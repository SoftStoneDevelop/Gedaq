

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD2
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD2 : INpgsqlPolygonMArraypolygonMMArrayD2
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD2E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD2E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7690681320205108d, y: 0.9799231089281788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792658763972382d, y: 0.4269967329595421d), new NpgsqlTypes.NpgsqlPoint(x: 0.08445996813316525d, y: 0.1116953880706879d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5370337079105533d, y: 0.24492650513382286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737191746288902d, y: 0.39657435676615893d), new NpgsqlTypes.NpgsqlPoint(x: 0.11008244191376215d, y: 0.18884264416489627d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3530304153262265d, y: 0.41080663914119453d), new NpgsqlTypes.NpgsqlPoint(x: 0.028186319764889722d, y: 0.6894128600427883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752263780932959d, y: 0.3751271103244699d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24313473060501467d, y: 0.8774848058056466d), new NpgsqlTypes.NpgsqlPoint(x: 0.4217827490205345d, y: 0.8652347577698671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389759521059412d, y: 0.28258916692875147d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8216585715219987d, y: 0.2170482929955453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6054396194441749d, y: 0.18634873081833114d), new NpgsqlTypes.NpgsqlPoint(x: 0.31591966625029955d, y: 0.21146012826668403d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.699871269035569d, y: 0.7133808621726877d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381598049258985d, y: 0.014637719780704939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9510253562099954d, y: 0.07050432938334106d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7372759984979345d, y: 0.7440805725731428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809913724920746d, y: 0.027017330576651233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542652490065312d, y: 0.08548018176857597d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047689518194058755d, y: 0.13418294207642023d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137398719816309d, y: 0.025477901336382835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046445845037408d, y: 0.11067010427784174d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.71055299060317d, y: 0.6842989763219026d), new NpgsqlTypes.NpgsqlPoint(x: 0.17087074955245563d, y: 0.32201768611722004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984524504601062d, y: 0.7743675991097896d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48284459611237307d, y: 0.20105635760515617d), new NpgsqlTypes.NpgsqlPoint(x: 0.652857869352957d, y: 0.7907839474397743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794547019611477d, y: 0.3058171303535345d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013558481986688964d, y: 0.804372423152894d), new NpgsqlTypes.NpgsqlPoint(x: 0.18217293103201015d, y: 0.7018330209504828d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716486239739088d, y: 0.6709847682455032d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.525652114558615d, y: 0.33131192703683565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282018417910648d, y: 0.6718995829952278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735055717908537d, y: 0.37688171457101627d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2644982517372102d, y: 0.5403173893863605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3696148692734552d, y: 0.24327044745247894d), new NpgsqlTypes.NpgsqlPoint(x: 0.07967081861944225d, y: 0.5308545707657153d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10932504173162938d, y: 0.5283467727942458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829584449168155d, y: 0.19738293507203652d), new NpgsqlTypes.NpgsqlPoint(x: 0.11014526586031204d, y: 0.2969347161729259d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726935408555961d, y: 0.11993703367148278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9192138776567754d, y: 0.8153300605089118d), new NpgsqlTypes.NpgsqlPoint(x: 0.023654065796921753d, y: 0.37617874291403397d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7332622351608158d, y: 0.38503589698454077d), new NpgsqlTypes.NpgsqlPoint(x: 0.6288389625674735d, y: 0.5361546580357127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375412431334462d, y: 0.7071449624681856d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5525711604106192d, y: 0.5832429810966993d), new NpgsqlTypes.NpgsqlPoint(x: 0.17261440819370422d, y: 0.17004303360723194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477079695117452d, y: 0.07591571802205821d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08320010439794134d, y: 0.2514660631837491d), new NpgsqlTypes.NpgsqlPoint(x: 0.057575460237763054d, y: 0.1683470623820471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595002768610996d, y: 0.7725946933035253d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4198611749768296d, y: 0.9395368500243712d), new NpgsqlTypes.NpgsqlPoint(x: 0.0696998908772094d, y: 0.8059150392274371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768410200974808d, y: 0.42178221104563396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45125063366681384d, y: 0.05738388163108987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627623248669976d, y: 0.2617211305076941d), new NpgsqlTypes.NpgsqlPoint(x: 0.49553385252054705d, y: 0.26346617324268284d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25203197201908634d, y: 0.36712755698967103d), new NpgsqlTypes.NpgsqlPoint(x: 0.15729070137805357d, y: 0.9160175351447568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838078124712887d, y: 0.01904398021197251d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9033453955364258d, y: 0.4129304679163608d), new NpgsqlTypes.NpgsqlPoint(x: 0.5558078759949238d, y: 0.7139600032157516d), new NpgsqlTypes.NpgsqlPoint(x: 0.914613129199596d, y: 0.719924220874449d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.532714275703767d, y: 0.5022200033574877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5884532864306369d, y: 0.04136861529119018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501209687558984d, y: 0.3689179158741981d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47938687883304376d, y: 0.41154071599792785d), new NpgsqlTypes.NpgsqlPoint(x: 0.014700336945686177d, y: 0.3698101096791565d), new NpgsqlTypes.NpgsqlPoint(x: 0.03191772074035504d, y: 0.09718863396657917d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6999331131474342d, y: 0.17503367634238576d), new NpgsqlTypes.NpgsqlPoint(x: 0.02630566795219924d, y: 0.8106447604388527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6671007942843395d, y: 0.2381542012506248d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19812157261237573d, y: 0.43909019290440354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5042575680928676d, y: 0.6354626239710361d), new NpgsqlTypes.NpgsqlPoint(x: 0.75978026851653d, y: 0.21888137815038922d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8868706814437389d, y: 0.1382126757857577d), new NpgsqlTypes.NpgsqlPoint(x: 0.13883469803025383d, y: 0.2739003449554286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3185143972015094d, y: 0.41972715870035493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10455385023566943d, y: 0.8545695522066111d), new NpgsqlTypes.NpgsqlPoint(x: 0.36538858410681685d, y: 0.16212381894118033d), new NpgsqlTypes.NpgsqlPoint(x: 0.22883614799069996d, y: 0.7175065078901369d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6035679961087749d, y: 0.5116112075045034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5634067207572663d, y: 0.953749020942683d), new NpgsqlTypes.NpgsqlPoint(x: 0.863027996439798d, y: 0.13030455853375d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735986586223508d, y: 0.2436556219004622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337782683457501d, y: 0.5768555647169844d), new NpgsqlTypes.NpgsqlPoint(x: 0.4869708184260422d, y: 0.8315488093597119d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13304942125819108d, y: 0.681985570724969d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370429304131231d, y: 0.15953090720599705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966236234506911d, y: 0.5808690453087669d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8781204475403209d, y: 0.2268901520299741d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319488361935951d, y: 0.17349359685632992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051588776809099d, y: 0.014817235344774637d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.90507227041418d, y: 0.30181107944754704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481860860913722d, y: 0.8434151026251807d), new NpgsqlTypes.NpgsqlPoint(x: 0.27855922741782013d, y: 0.5346382560339633d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1287022960759442d, y: 0.29797203675499384d), new NpgsqlTypes.NpgsqlPoint(x: 0.27036595065958047d, y: 0.8484617115251533d), new NpgsqlTypes.NpgsqlPoint(x: 0.05061414762796079d, y: 0.8636419389434209d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2801777911549167d, y: 0.20052806154473135d), new NpgsqlTypes.NpgsqlPoint(x: 0.05111383122307289d, y: 0.17334749591257237d), new NpgsqlTypes.NpgsqlPoint(x: 0.37633017568657445d, y: 0.907980190466123d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.948441269566424d, y: 0.6960940121930365d), new NpgsqlTypes.NpgsqlPoint(x: 0.022309405314111408d, y: 0.31070979969294876d), new NpgsqlTypes.NpgsqlPoint(x: 0.929250783589515d, y: 0.7959007707173568d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003391420137643486d, y: 0.8674634616759792d), new NpgsqlTypes.NpgsqlPoint(x: 0.8534765099373175d, y: 0.9309465429335857d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807517761076991d, y: 0.3536744239120344d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.276155162591881d, y: 0.9154459920176121d), new NpgsqlTypes.NpgsqlPoint(x: 0.570404055288645d, y: 0.9786832535515531d), new NpgsqlTypes.NpgsqlPoint(x: 0.4891350933024907d, y: 0.9801423432394588d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.431887445910333d, y: 0.8626192249014685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115358834616125d, y: 0.6841328153523732d), new NpgsqlTypes.NpgsqlPoint(x: 0.01713679930473866d, y: 0.32897763406236646d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34505894143055704d, y: 0.04781236400323319d), new NpgsqlTypes.NpgsqlPoint(x: 0.41381200190734857d, y: 0.3344972062033973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6915870980215831d, y: 0.7668706543045968d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8199618343946539d, y: 0.8652506711665409d), new NpgsqlTypes.NpgsqlPoint(x: 0.09012119094039239d, y: 0.23222690993208794d), new NpgsqlTypes.NpgsqlPoint(x: 0.43798651657131316d, y: 0.3321877508111122d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5078047128690009d, y: 0.9301756363662453d), new NpgsqlTypes.NpgsqlPoint(x: 0.2075059336303543d, y: 0.5218644671165207d), new NpgsqlTypes.NpgsqlPoint(x: 0.745648038064688d, y: 0.20486438546529873d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7806841160604927d, y: 0.8903378769888297d), new NpgsqlTypes.NpgsqlPoint(x: 0.00953949844270352d, y: 0.06531639363227715d), new NpgsqlTypes.NpgsqlPoint(x: 0.03058654055130494d, y: 0.37387138029315026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5635111090514586d, y: 0.0744039584102254d), new NpgsqlTypes.NpgsqlPoint(x: 0.06752563593597649d, y: 0.011092607081236716d), new NpgsqlTypes.NpgsqlPoint(x: 0.24420706447676988d, y: 0.7033908560543743d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03013138377065183d, y: 0.5446950624334203d), new NpgsqlTypes.NpgsqlPoint(x: 0.45309529932487624d, y: 0.22157894983492155d), new NpgsqlTypes.NpgsqlPoint(x: 0.18358157158487742d, y: 0.7846741029564661d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9869200112129077d, y: 0.69963641722461d), new NpgsqlTypes.NpgsqlPoint(x: 0.6824419738508474d, y: 0.26363180058821567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406058924677067d, y: 0.9999929157767679d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9440321561225133d, y: 0.4566908802485312d), new NpgsqlTypes.NpgsqlPoint(x: 0.10713617829845257d, y: 0.8146486485726592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910503603290832d, y: 0.44034691537613435d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3520672022880619d, y: 0.33842791665107597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975940016541125d, y: 0.8134583243874984d), new NpgsqlTypes.NpgsqlPoint(x: 0.996012820875257d, y: 0.6370463169939716d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8803277502859723d, y: 0.7492139654401442d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792527768364093d, y: 0.7316027875586004d), new NpgsqlTypes.NpgsqlPoint(x: 0.09199550780198673d, y: 0.7709691923468347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.052074211754053024d, y: 0.8428480594946486d), new NpgsqlTypes.NpgsqlPoint(x: 0.6659603531654991d, y: 0.19679564901530655d), new NpgsqlTypes.NpgsqlPoint(x: 0.33486304376066256d, y: 0.4209766946639635d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6262141135746506d, y: 0.5711430499445088d), new NpgsqlTypes.NpgsqlPoint(x: 0.09240543579283966d, y: 0.9958889687008415d), new NpgsqlTypes.NpgsqlPoint(x: 0.15412883864160642d, y: 0.6781474960487142d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8288886616629116d, y: 0.5971033647896444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5377155910943756d, y: 0.849442797355929d), new NpgsqlTypes.NpgsqlPoint(x: 0.14585838129945117d, y: 0.3357950353568828d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6590707435495258d, y: 0.37142159206318415d), new NpgsqlTypes.NpgsqlPoint(x: 0.671517938125253d, y: 0.7570241544069735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952090231110734d, y: 0.23334804484300153d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3870718195494478d, y: 0.6030698580643609d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942039901312913d, y: 0.5843920006322563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662805686031048d, y: 0.7185638007720134d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22661115012358424d, y: 0.5093560417515235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429770565560815d, y: 0.4070132841009809d), new NpgsqlTypes.NpgsqlPoint(x: 0.275846250981332d, y: 0.027342454761068558d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9850260911139767d, y: 0.6925963990097196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9912503844672669d, y: 0.628688557664359d), new NpgsqlTypes.NpgsqlPoint(x: 0.08458999121893562d, y: 0.13742148252511655d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48716062970675733d, y: 0.05103634389954137d), new NpgsqlTypes.NpgsqlPoint(x: 0.981725314280832d, y: 0.8187239351039551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865819972123626d, y: 0.705901168280638d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989182263419877d, y: 0.4399583129074244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4164571808021098d, y: 0.9263006026877145d), new NpgsqlTypes.NpgsqlPoint(x: 0.682715116089062d, y: 0.3824901569829824d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6406377340200291d, y: 0.6451349151022522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4272452042278211d, y: 0.16499770231725153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987858307112032d, y: 0.9573632402609004d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34048661860246765d, y: 0.714501995426439d), new NpgsqlTypes.NpgsqlPoint(x: 0.36438442419747663d, y: 0.03556271364678787d), new NpgsqlTypes.NpgsqlPoint(x: 0.08001089391384764d, y: 0.6363528603549903d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.610176416471138d, y: 0.11656173948909354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852321717077923d, y: 0.480839857559791d), new NpgsqlTypes.NpgsqlPoint(x: 0.06986509933840357d, y: 0.28957677053549347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5360765525197876d, y: 0.9251388847875595d), new NpgsqlTypes.NpgsqlPoint(x: 0.1346259364379897d, y: 0.05882144831167091d), new NpgsqlTypes.NpgsqlPoint(x: 0.24953500980949828d, y: 0.604753821573344d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05425525014621102d, y: 0.2495311811295312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000975154335883d, y: 0.10390040163907377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147625136322117d, y: 0.40305831972570916d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772102138508546d, y: 0.6349075203663765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981225326456757d, y: 0.3191756551566406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8712464990891883d, y: 0.10539009357698204d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36272586497799264d, y: 0.5972226038227773d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936274157881492d, y: 0.3138355564505131d), new NpgsqlTypes.NpgsqlPoint(x: 0.24571125373911384d, y: 0.7927962622900775d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5606053066872916d, y: 0.36955151176270595d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722963204230017d, y: 0.6787776628651737d), new NpgsqlTypes.NpgsqlPoint(x: 0.08269063741194282d, y: 0.3968212532455345d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07964924319676248d, y: 0.7387110776650041d), new NpgsqlTypes.NpgsqlPoint(x: 0.07261344274430526d, y: 0.6617830160005088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032180261285713d, y: 0.6818791561578615d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.583760177259788d, y: 0.7568791865925057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051661912388407d, y: 0.8636467943995687d), new NpgsqlTypes.NpgsqlPoint(x: 0.48638307343180254d, y: 0.26125777519865534d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7781743786588193d, y: 0.8709405595546968d), new NpgsqlTypes.NpgsqlPoint(x: 0.12162687567127661d, y: 0.8534478282140832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4595747538117415d, y: 0.3808641329053025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7113827190550316d, y: 0.9984456734416304d), new NpgsqlTypes.NpgsqlPoint(x: 0.729017188048724d, y: 0.486124806538202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836511191638654d, y: 0.7467467814481575d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08998070119151858d, y: 0.8062411433641261d), new NpgsqlTypes.NpgsqlPoint(x: 0.1910452147595404d, y: 0.7567538122589746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082203308178408d, y: 0.3368235144253303d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11891655976623372d, y: 0.8120132337350026d), new NpgsqlTypes.NpgsqlPoint(x: 0.5697925970040294d, y: 0.9523793197897954d), new NpgsqlTypes.NpgsqlPoint(x: 0.35504718273562164d, y: 0.3077182219200586d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4236970574542227d, y: 0.07593136657114263d), new NpgsqlTypes.NpgsqlPoint(x: 0.08922749645447992d, y: 0.8292038021474327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976293663346214d, y: 0.4730465857096532d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3657843130327849d, y: 0.5821631766641785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918692490735785d, y: 0.592728775572795d), new NpgsqlTypes.NpgsqlPoint(x: 0.17747359428741583d, y: 0.17256739195402493d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.169008173997244d, y: 0.6738469222857572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636927700230744d, y: 0.00837319859814023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996973483576974d, y: 0.9065633656866731d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10716344238521258d, y: 0.5100300854804118d), new NpgsqlTypes.NpgsqlPoint(x: 0.02736939852875675d, y: 0.8850191093324502d), new NpgsqlTypes.NpgsqlPoint(x: 0.3874022817282543d, y: 0.326015621065726d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05276821714573798d, y: 0.03205351176247706d), new NpgsqlTypes.NpgsqlPoint(x: 0.37932884351979035d, y: 0.0032471003302945167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111053433938607d, y: 0.6986348951598083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4814955909493174d, y: 0.2134252029958743d), new NpgsqlTypes.NpgsqlPoint(x: 0.38389963402491156d, y: 0.8256498751330684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406159032088469d, y: 0.09179725951142781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18684425188253306d, y: 0.9057691154581361d), new NpgsqlTypes.NpgsqlPoint(x: 0.3190364992529342d, y: 0.4460336369014736d), new NpgsqlTypes.NpgsqlPoint(x: 0.633760331294756d, y: 0.6789289345125348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06649184417370646d, y: 0.11617977207648089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3597564305340255d, y: 0.31848457427225074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984536814860444d, y: 0.08018550701789562d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7088426232348247d, y: 0.9445483165888279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9963258123162743d, y: 0.6169921966126304d), new NpgsqlTypes.NpgsqlPoint(x: 0.21475964491174315d, y: 0.533381026350616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19260083206694856d, y: 0.3171492631845466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6150129922663726d, y: 0.38702749678495874d), new NpgsqlTypes.NpgsqlPoint(x: 0.4425520444607698d, y: 0.8721913926185644d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6569526439674204d, y: 0.07839781387633549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9399514720988275d, y: 0.7752635421036239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832126257956505d, y: 0.7485304524280221d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9457377666571648d, y: 0.9740419373832381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832745289757222d, y: 0.6297035543064695d), new NpgsqlTypes.NpgsqlPoint(x: 0.21030447428292787d, y: 0.7403292630187935d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.278289743664756d, y: 0.3195848119153104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4744228873941385d, y: 0.9166337432494684d), new NpgsqlTypes.NpgsqlPoint(x: 0.32213580076807935d, y: 0.5693570657990695d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6075305622248327d, y: 0.750342092651209d), new NpgsqlTypes.NpgsqlPoint(x: 0.10300872327945909d, y: 0.10697350531618532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161126964562608d, y: 0.24212630828923343d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5623792068045337d, y: 0.6276913116891829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4683720009761676d, y: 0.9987711584895396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473668880827353d, y: 0.7103713436783444d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41003316068492246d, y: 0.2265931057987718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389864757476941d, y: 0.5500131418960841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134620096688766d, y: 0.9076949587313434d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8553690471444502d, y: 0.5777724206630738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103414327237481d, y: 0.2776717100089804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7036553651328171d, y: 0.48451433043206493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6732465545321974d, y: 0.42072804036652034d), new NpgsqlTypes.NpgsqlPoint(x: 0.2486046762378613d, y: 0.9918156324973156d), new NpgsqlTypes.NpgsqlPoint(x: 0.5918471088566728d, y: 0.010518492223595355d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3156858994362952d, y: 0.4151040073420891d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707642839185659d, y: 0.439470975135823d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616035849266793d, y: 0.5323847340065483d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5814471727904952d, y: 0.936834328796761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566317171533498d, y: 0.7265027718532658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5427607954272171d, y: 0.008905738141415709d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3013624098372073d, y: 0.7635593852272128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214217615529018d, y: 0.4768993141474682d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495556339220014d, y: 0.6352432692999338d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07959723123341222d, y: 0.4829078806175431d), new NpgsqlTypes.NpgsqlPoint(x: 0.23469924500076333d, y: 0.0068008565683403965d), new NpgsqlTypes.NpgsqlPoint(x: 0.4364987719472607d, y: 0.8335779369267685d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1690550664398982d, y: 0.6382951301272105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631172397897783d, y: 0.3953180256242743d), new NpgsqlTypes.NpgsqlPoint(x: 0.40029264926287433d, y: 0.9844425800175368d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.619809399560266d, y: 0.9867880544278163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024309102111027d, y: 0.8430126620451915d), new NpgsqlTypes.NpgsqlPoint(x: 0.40062843592489583d, y: 0.20595307195224655d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024858613413143327d, y: 0.5194629264559856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9361761153717114d, y: 0.8056994575665245d), new NpgsqlTypes.NpgsqlPoint(x: 0.00947498100962696d, y: 0.9357728960994589d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6870359211434761d, y: 0.5177336038594524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195992448293916d, y: 0.6496432323419844d), new NpgsqlTypes.NpgsqlPoint(x: 0.3678403190240792d, y: 0.2624607592044724d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018529154924421865d, y: 0.6998791608478663d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883796422958541d, y: 0.8137434611356962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4555078731853286d, y: 0.22020763706030133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31283255963968004d, y: 0.005066843524425768d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869778574866684d, y: 0.061961746970706555d), new NpgsqlTypes.NpgsqlPoint(x: 0.38027403872555543d, y: 0.4253674431657086d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2620322245611636d, y: 0.6353027028574062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758289210845744d, y: 0.5136190546751938d), new NpgsqlTypes.NpgsqlPoint(x: 0.08741893170257875d, y: 0.9772830246102248d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5573387143582236d, y: 0.09320010731917072d), new NpgsqlTypes.NpgsqlPoint(x: 0.17613145301262256d, y: 0.30022358920884085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8931762221723262d, y: 0.7937171421977561d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7588108675588787d, y: 0.3713519419633333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885271597935561d, y: 0.5271504728184233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105963860998474d, y: 0.6647840764062353d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9258363395823551d, y: 0.6331456675538278d), new NpgsqlTypes.NpgsqlPoint(x: 0.43652096614257574d, y: 0.31241223128367324d), new NpgsqlTypes.NpgsqlPoint(x: 0.04096457559688271d, y: 0.8669947079622848d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11390313985185851d, y: 0.5315639713304081d), new NpgsqlTypes.NpgsqlPoint(x: 0.07748579002540812d, y: 0.4641552403213166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660203980532104d, y: 0.9325045438288267d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3491142674679836d, y: 0.20406601180695805d), new NpgsqlTypes.NpgsqlPoint(x: 0.39575593978069945d, y: 0.6209907356071925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750084024511797d, y: 0.02550804061674139d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020099717420608232d, y: 0.5653039838152775d), new NpgsqlTypes.NpgsqlPoint(x: 0.03255455579015021d, y: 0.2156471919258247d), new NpgsqlTypes.NpgsqlPoint(x: 0.24517586092463495d, y: 0.5751216613592577d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2781092936909142d, y: 0.780635503971356d), new NpgsqlTypes.NpgsqlPoint(x: 0.18559155250386783d, y: 0.17948165540640681d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327188377468582d, y: 0.0757674025576962d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7930088902806991d, y: 0.8678489130277286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818255982467523d, y: 0.91273397614448d), new NpgsqlTypes.NpgsqlPoint(x: 0.4534891926036142d, y: 0.2583640530655217d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08857039056472993d, y: 0.5506894874418495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9397639453106812d, y: 0.9915720610403479d), new NpgsqlTypes.NpgsqlPoint(x: 0.551939225303967d, y: 0.022054383937402222d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9851923067018271d, y: 0.5408979930896927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9720501804659445d, y: 0.0921700473203898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3457101789596465d, y: 0.1153680903244575d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13760408895107634d, y: 0.6716817772595866d), new NpgsqlTypes.NpgsqlPoint(x: 0.316628596087172d, y: 0.23172508288388227d), new NpgsqlTypes.NpgsqlPoint(x: 0.24728390242005815d, y: 0.3238685388271303d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5665890175116091d, y: 0.31894501310938317d), new NpgsqlTypes.NpgsqlPoint(x: 0.2662604184689702d, y: 0.17739871988627232d), new NpgsqlTypes.NpgsqlPoint(x: 0.380152812763346d, y: 0.7690622196748323d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6566872657067302d, y: 0.7383665399252755d), new NpgsqlTypes.NpgsqlPoint(x: 0.10033555689681672d, y: 0.8363223957264254d), new NpgsqlTypes.NpgsqlPoint(x: 0.31313696518333867d, y: 0.13532076183385566d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3355500643300292d, y: 0.12569940440089045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018143045331807d, y: 0.5407183481600888d), new NpgsqlTypes.NpgsqlPoint(x: 0.004098463968418287d, y: 0.15668213497333416d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2835709767475624d, y: 0.9812154215174566d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727858330810949d, y: 0.7342140865151904d), new NpgsqlTypes.NpgsqlPoint(x: 0.25706695348311703d, y: 0.18771577087949365d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09453211307348364d, y: 0.005800674614674706d), new NpgsqlTypes.NpgsqlPoint(x: 0.44322055828896323d, y: 0.43102388025789984d), new NpgsqlTypes.NpgsqlPoint(x: 0.3260858927172865d, y: 0.11650094832525748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6471558089636766d, y: 0.8215722364336485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583906488360905d, y: 0.10398917734842528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7767166156276776d, y: 0.8879922816151542d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4765100259097429d, y: 0.3612201545215462d), new NpgsqlTypes.NpgsqlPoint(x: 0.47600896838784834d, y: 0.6042021731006405d), new NpgsqlTypes.NpgsqlPoint(x: 0.700497322156799d, y: 0.58716275407776d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19960250571881077d, y: 0.5265942025265415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9692835422969712d, y: 0.4185582015716832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7289196254857265d, y: 0.2703241483455524d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6984856818998625d, y: 0.7772219117146248d), new NpgsqlTypes.NpgsqlPoint(x: 0.20140560352937087d, y: 0.7040999485513636d), new NpgsqlTypes.NpgsqlPoint(x: 0.49794493629888525d, y: 0.8702489863115422d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7940326990766614d, y: 0.8312843665858525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554038802908945d, y: 0.5822780323935055d), new NpgsqlTypes.NpgsqlPoint(x: 0.004451231102049813d, y: 0.47630717848610427d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25982814747927474d, y: 0.06948132313307309d), new NpgsqlTypes.NpgsqlPoint(x: 0.09760903838740731d, y: 0.1785430662977292d), new NpgsqlTypes.NpgsqlPoint(x: 0.04711398512077658d, y: 0.8466646233940193d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6763622446971662d, y: 0.8572118581917603d), new NpgsqlTypes.NpgsqlPoint(x: 0.89125010747855d, y: 0.789026371421364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376512684479896d, y: 0.42324425324958703d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07319678003360564d, y: 0.403192710009165d), new NpgsqlTypes.NpgsqlPoint(x: 0.10326154409333621d, y: 0.005243692328837368d), new NpgsqlTypes.NpgsqlPoint(x: 0.11010233859909846d, y: 0.3111308268243237d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3111524310279994d, y: 0.8421458048464084d), new NpgsqlTypes.NpgsqlPoint(x: 0.45664161619144616d, y: 0.15203016530033697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050281822544993d, y: 0.868820307555004d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09724060604582618d, y: 0.2533954933034579d), new NpgsqlTypes.NpgsqlPoint(x: 0.387120534685506d, y: 0.12305046363646632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868746052228734d, y: 0.01501662150286398d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33917045523793066d, y: 0.23152464814229035d), new NpgsqlTypes.NpgsqlPoint(x: 0.8879694552723486d, y: 0.41010943284051904d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318497494810126d, y: 0.7560782662585789d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6912235527216435d, y: 0.4385105097570384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633171377816629d, y: 0.0377404530461537d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105310897214095d, y: 0.6961836554349887d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.598530094959912d, y: 0.6796916145054357d), new NpgsqlTypes.NpgsqlPoint(x: 0.4784623481197574d, y: 0.4122549550689235d), new NpgsqlTypes.NpgsqlPoint(x: 0.535670027152069d, y: 0.4999220583154974d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48810882844466363d, y: 0.2009813545648479d), new NpgsqlTypes.NpgsqlPoint(x: 0.43944900220766603d, y: 0.7218256847258574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062657744727475d, y: 0.42778395685984905d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6893260952729081d, y: 0.20980072518501203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538953817365038d, y: 0.6690868461113815d), new NpgsqlTypes.NpgsqlPoint(x: 0.22928416960204467d, y: 0.6523228561016009d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15977452477938947d, y: 0.695130562506301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171534673014302d, y: 0.7344760906199753d), new NpgsqlTypes.NpgsqlPoint(x: 0.21394172684677282d, y: 0.00990918087727477d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27273386467983274d, y: 0.717191498619504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294445293126413d, y: 0.11031307335560614d), new NpgsqlTypes.NpgsqlPoint(x: 0.46771031952812714d, y: 0.8490322619191327d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6355841910804743d, y: 0.26011941312423725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784477210379413d, y: 0.7471460913168219d), new NpgsqlTypes.NpgsqlPoint(x: 0.25272326979561865d, y: 0.45952260772312026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33883565581376796d, y: 0.5584342247098223d), new NpgsqlTypes.NpgsqlPoint(x: 0.15799820298847944d, y: 0.6377754876326784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937424520238257d, y: 0.8786378391972457d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6524424404703839d, y: 0.1290546981871188d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592303357134775d, y: 0.6906367505203683d), new NpgsqlTypes.NpgsqlPoint(x: 0.20562714010195904d, y: 0.5767123047614102d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34257334458293387d, y: 0.9400624175212647d), new NpgsqlTypes.NpgsqlPoint(x: 0.027182912222131206d, y: 0.08165257621497501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467294045161744d, y: 0.4631703236227439d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8205958434199715d, y: 0.9573869859763668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529417599142762d, y: 0.31741569773796274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515635980984847d, y: 0.06183767747955915d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8689453905085067d, y: 0.4324861397384765d), new NpgsqlTypes.NpgsqlPoint(x: 0.40201214123476636d, y: 0.23606007378404892d), new NpgsqlTypes.NpgsqlPoint(x: 0.07022085965981573d, y: 0.6758306214558315d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6960526518266664d, y: 0.49409564112086213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711169745565432d, y: 0.07369896673284315d), new NpgsqlTypes.NpgsqlPoint(x: 0.35309143951094457d, y: 0.2211396647714201d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.076936281598184d, y: 0.7517049107371909d), new NpgsqlTypes.NpgsqlPoint(x: 0.869092334482044d, y: 0.2153057989712307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890881103032716d, y: 0.058354162129755305d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008037708800634369d, y: 0.25290087187032395d), new NpgsqlTypes.NpgsqlPoint(x: 0.007985493535425214d, y: 0.6481234245287026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393351086950119d, y: 0.9756287077181882d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.931496228723767d, y: 0.5194106226745598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362915107415437d, y: 0.3173810089522262d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186706096867353d, y: 0.7768145003994165d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6989234721209225d, y: 0.5831128292038137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3232432723362202d, y: 0.5816870014085258d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580475907822975d, y: 0.06404078145671133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3905635315337096d, y: 0.864996763906617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642829526518253d, y: 0.1869319747511664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7228263212986819d, y: 0.6261305206248938d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8763947404221222d, y: 0.31045610468903173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258680194702362d, y: 0.7223739303911975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249350569521549d, y: 0.37961566080142806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8105336657221822d, y: 0.18780603559703435d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016638298266337115d, y: 0.923473687190195d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080334631600444d, y: 0.9640750935121313d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2371371514961521d, y: 0.2864693245306177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169397099881613d, y: 0.07786385109822525d), new NpgsqlTypes.NpgsqlPoint(x: 0.20241068472129442d, y: 0.8057107813340443d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5225148280131222d, y: 0.05793727836114426d), new NpgsqlTypes.NpgsqlPoint(x: 0.76199095689344d, y: 0.30122091863467626d), new NpgsqlTypes.NpgsqlPoint(x: 0.981787792936568d, y: 0.14546941722395546d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40414872659754764d, y: 0.5769156720576522d), new NpgsqlTypes.NpgsqlPoint(x: 0.029418568293507752d, y: 0.6222900993077457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655453070507766d, y: 0.13664092279074957d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4183952111317495d, y: 0.305982547475921d), new NpgsqlTypes.NpgsqlPoint(x: 0.027983550315330508d, y: 0.59549734653669d), new NpgsqlTypes.NpgsqlPoint(x: 0.14255963640809555d, y: 0.6674313261109188d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30102276358547797d, y: 0.8462145222084794d), new NpgsqlTypes.NpgsqlPoint(x: 0.41505231273608656d, y: 0.3664399772395335d), new NpgsqlTypes.NpgsqlPoint(x: 0.037014491256945115d, y: 0.8993937735807143d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5640221363296568d, y: 0.6148545904018206d), new NpgsqlTypes.NpgsqlPoint(x: 0.056741702573943065d, y: 0.23881746151888006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838894105176686d, y: 0.3852699981446388d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.987268255541669d, y: 0.07738270793884294d), new NpgsqlTypes.NpgsqlPoint(x: 0.809457200670042d, y: 0.7045361490820048d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273320671266075d, y: 0.7916219642976404d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9352921768354587d, y: 0.19674598858035652d), new NpgsqlTypes.NpgsqlPoint(x: 0.13773576600184412d, y: 0.10197633053157074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261549189259961d, y: 0.013662366151312999d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21846542614711018d, y: 0.30899574922271933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167246999609683d, y: 0.09277014736934808d), new NpgsqlTypes.NpgsqlPoint(x: 0.27788193396596217d, y: 0.3921958346350659d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9444172154423655d, y: 0.7971946520968378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293968551811599d, y: 0.07456345733553893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4556999400616908d, y: 0.953020059062479d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3086044389671626d, y: 0.7140595413635769d), new NpgsqlTypes.NpgsqlPoint(x: 0.21663402868984039d, y: 0.9155085854919384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790223305337307d, y: 0.23440406864651642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7458481326148487d, y: 0.24121231939818766d), new NpgsqlTypes.NpgsqlPoint(x: 0.341213718110817d, y: 0.9829021407211675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536979891518506d, y: 0.951523013123064d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9896346477526506d, y: 0.3804138345668977d), new NpgsqlTypes.NpgsqlPoint(x: 0.95414065453511d, y: 0.7779869445262703d), new NpgsqlTypes.NpgsqlPoint(x: 0.622912429520928d, y: 0.8377972788121631d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15985131886906012d, y: 0.8282982579402837d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128098450784667d, y: 0.7044647113054654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5450354483736229d, y: 0.32733370397995865d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1981924429866857d, y: 0.5817990107232593d), new NpgsqlTypes.NpgsqlPoint(x: 0.69542635129234d, y: 0.27971759935756557d), new NpgsqlTypes.NpgsqlPoint(x: 0.874494735401817d, y: 0.7422258228248495d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8969566676214594d, y: 0.08103681292342624d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888505792747352d, y: 0.5702971562522536d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343823715278387d, y: 0.047743597512870606d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48227882412771994d, y: 0.6505641782832695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236322573352716d, y: 0.07348349389452735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633382942070654d, y: 0.5935763442490668d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6316568672458613d, y: 0.23311396540816376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165329343970466d, y: 0.09794505093524097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582774506085117d, y: 0.836787806065939d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18162755161451827d, y: 0.496764085680391d), new NpgsqlTypes.NpgsqlPoint(x: 0.09824826645053086d, y: 0.574440096571293d), new NpgsqlTypes.NpgsqlPoint(x: 0.870036559048432d, y: 0.07101843097814375d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9856225599962964d, y: 0.8208192938647577d), new NpgsqlTypes.NpgsqlPoint(x: 0.019691297915779504d, y: 0.9763623406095786d), new NpgsqlTypes.NpgsqlPoint(x: 0.03177159562444798d, y: 0.734480836740422d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6390487625181362d, y: 0.8003565033384761d), new NpgsqlTypes.NpgsqlPoint(x: 0.4511678849785461d, y: 0.10406548895134338d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605261566225585d, y: 0.9229700143377428d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9378206072907812d, y: 0.832759486489354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872026586445373d, y: 0.5532480039091294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540582882426246d, y: 0.10098467846232406d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9934497625080205d, y: 0.3603384828007343d), new NpgsqlTypes.NpgsqlPoint(x: 0.27203523235686755d, y: 0.24990808681264753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3032048497745863d, y: 0.42476816116177063d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1498267225487595d, y: 0.7610616745091014d), new NpgsqlTypes.NpgsqlPoint(x: 0.781473470436451d, y: 0.6940208030698127d), new NpgsqlTypes.NpgsqlPoint(x: 0.4118092974896701d, y: 0.5390010313927321d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6828918553186372d, y: 0.9690685772415304d), new NpgsqlTypes.NpgsqlPoint(x: 0.47834896148500583d, y: 0.3012547885271404d), new NpgsqlTypes.NpgsqlPoint(x: 0.8556991795242563d, y: 0.04869713905400386d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.756071127375088d, y: 0.016050687252098017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7841536017801637d, y: 0.20537323375355854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5649371744242546d, y: 0.7482111028958227d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11764667253011629d, y: 0.8009075173265995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9767379732367241d, y: 0.4656558874596981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913619303310873d, y: 0.03446456315353408d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35782437662484246d, y: 0.0558445745940076d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732745200853885d, y: 0.5617715561943069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397303238705008d, y: 0.03789427314398852d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7234840217008068d, y: 0.20348273769459757d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649156458133469d, y: 0.8816529787778155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4492420533097613d, y: 0.7593137446042452d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5922470726363719d, y: 0.8219841663578125d), new NpgsqlTypes.NpgsqlPoint(x: 0.15499249473507104d, y: 0.176632753347716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951690963969897d, y: 0.08123676557818793d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801263137781603d, y: 0.46001763881778135d), new NpgsqlTypes.NpgsqlPoint(x: 0.3624459180353907d, y: 0.6792913775277158d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373026582110218d, y: 0.9361837147203929d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9282133090329516d, y: 0.8337178127228271d), new NpgsqlTypes.NpgsqlPoint(x: 0.29733823910875656d, y: 0.582186988373615d), new NpgsqlTypes.NpgsqlPoint(x: 0.06255278553654708d, y: 0.1978060049577096d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3021119606768805d, y: 0.5358379287446127d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129095331406855d, y: 0.4672678027488636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253470366658665d, y: 0.4800606434766086d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1935167324426832d, y: 0.7158235955699266d), new NpgsqlTypes.NpgsqlPoint(x: 0.1920412014856704d, y: 0.9045436935150826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740118972920812d, y: 0.8214613654401405d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32446314731871995d, y: 0.21601841876874384d), new NpgsqlTypes.NpgsqlPoint(x: 0.018258977177409763d, y: 0.09350653361207084d), new NpgsqlTypes.NpgsqlPoint(x: 0.0677980455965328d, y: 0.03482301030764701d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6232710105571266d, y: 0.12277928905907987d), new NpgsqlTypes.NpgsqlPoint(x: 0.20136011579414204d, y: 0.22429038912993238d), new NpgsqlTypes.NpgsqlPoint(x: 0.23152836128824783d, y: 0.629965716629416d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08282628584536278d, y: 0.7307172923313967d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919873660752617d, y: 0.8824450652486804d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737206601678795d, y: 0.48248647402028566d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34186543537920144d, y: 0.98710095257421d), new NpgsqlTypes.NpgsqlPoint(x: 0.06434726843022798d, y: 0.3427744262840393d), new NpgsqlTypes.NpgsqlPoint(x: 0.19410566463195267d, y: 0.5106462062475969d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9129933789070013d, y: 0.8074984574720271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252304219799087d, y: 0.15865061611833164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004302015394269d, y: 0.5388679862575108d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12573812160870834d, y: 0.5581330791559556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3514833984613669d, y: 0.5319761735301414d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336703819758359d, y: 0.4256148511263246d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6171291369914677d, y: 0.4159009283216334d), new NpgsqlTypes.NpgsqlPoint(x: 0.905051389860653d, y: 0.18994082146622326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216450526771881d, y: 0.03849045016346453d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6111134419156159d, y: 0.5392103498727646d), new NpgsqlTypes.NpgsqlPoint(x: 0.0905488578175685d, y: 0.06168586703125978d), new NpgsqlTypes.NpgsqlPoint(x: 0.139769713364162d, y: 0.5059467585119675d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8265524336143686d, y: 0.44890766917995817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652742873808679d, y: 0.8977009407214075d), new NpgsqlTypes.NpgsqlPoint(x: 0.753317868473617d, y: 0.8255808907705546d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1564581453708911d, y: 0.4204721578574877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493044438328166d, y: 0.31601785494773615d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536861376365779d, y: 0.8065960405204904d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8335657253070814d, y: 0.5747718606773717d), new NpgsqlTypes.NpgsqlPoint(x: 0.22634513515600674d, y: 0.7950920819664798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469977660420659d, y: 0.43310490095248133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7052632535071746d, y: 0.3197345930253014d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774027941759525d, y: 0.05947691411066103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727759827431637d, y: 0.6508665139319317d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5718702763062943d, y: 0.635141017488088d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536924106284837d, y: 0.887007295765557d), new NpgsqlTypes.NpgsqlPoint(x: 0.2744989420837681d, y: 0.41136394388950337d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4031138846369222d, y: 0.04973118462233461d), new NpgsqlTypes.NpgsqlPoint(x: 0.18587351783414308d, y: 0.7532712819545678d), new NpgsqlTypes.NpgsqlPoint(x: 0.4510579386363831d, y: 0.008960359205442359d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9261824133637769d, y: 0.43009208952133327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8111576610675141d, y: 0.579854142283738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556036320539599d, y: 0.029267155482099794d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7021954644913678d, y: 0.8799997768753303d), new NpgsqlTypes.NpgsqlPoint(x: 0.1154474406763194d, y: 0.8371070102647605d), new NpgsqlTypes.NpgsqlPoint(x: 0.42280355126059976d, y: 0.775055230558093d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6388226971112464d, y: 0.8625431131050914d), new NpgsqlTypes.NpgsqlPoint(x: 0.059176314049995016d, y: 0.3716909893535689d), new NpgsqlTypes.NpgsqlPoint(x: 0.11929903964455402d, y: 0.2853011461238417d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8626038856730662d, y: 0.8769104888029482d), new NpgsqlTypes.NpgsqlPoint(x: 0.42842076074859425d, y: 0.5378402631780953d), new NpgsqlTypes.NpgsqlPoint(x: 0.931838992936779d, y: 0.12581244147921467d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6535236044690024d, y: 0.796348222666892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852936556755132d, y: 0.8733610251898943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793125685741598d, y: 0.9332664183802059d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2601114675806613d, y: 0.5521216935318622d), new NpgsqlTypes.NpgsqlPoint(x: 0.3316920997307614d, y: 0.6525308079852647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356014856742907d, y: 0.9264741403832181d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5561919449878165d, y: 0.024162007818604003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8773619289470085d, y: 0.12097965703710722d), new NpgsqlTypes.NpgsqlPoint(x: 0.44117122952519805d, y: 0.1799893500917833d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01037350222076483d, y: 0.1448338456928876d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273190276157697d, y: 0.8152325720022192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091077898273527d, y: 0.0019733414800062743d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5933835837913034d, y: 0.6936432736075514d), new NpgsqlTypes.NpgsqlPoint(x: 0.40388669533491084d, y: 0.5202524063458427d), new NpgsqlTypes.NpgsqlPoint(x: 0.06510104816012463d, y: 0.024581579874212833d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0494402911070454d, y: 0.8163791322144017d), new NpgsqlTypes.NpgsqlPoint(x: 0.1642399788658213d, y: 0.44781922219888415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563715301716241d, y: 0.03481151060542953d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5943481350579746d, y: 0.16786315227812465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741263329278603d, y: 0.35200302203978107d), new NpgsqlTypes.NpgsqlPoint(x: 0.08015124282284458d, y: 0.9359031836511137d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6512269903331624d, y: 0.5083325611403455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5064333507437302d, y: 0.40259184536574777d), new NpgsqlTypes.NpgsqlPoint(x: 0.2973970374772186d, y: 0.29940872668597296d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9644223203255315d, y: 0.6046193480945812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781857293143722d, y: 0.9481886304339988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768676204966121d, y: 0.5919395579572696d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 9.477187797712894E-05d, y: 0.6672537360987089d), new NpgsqlTypes.NpgsqlPoint(x: 0.09197161322862957d, y: 0.429917261406351d), new NpgsqlTypes.NpgsqlPoint(x: 0.10746170745749595d, y: 0.9689470388055301d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870308066307445d, y: 0.40549998150389144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437696620642742d, y: 0.23845413130149984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368326339820854d, y: 0.27097066859317176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6668243956488484d, y: 0.7671885395749695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675495507581292d, y: 0.6746568267938376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544133903390172d, y: 0.7123221673374698d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5936536859846165d, y: 0.14211889702025526d), new NpgsqlTypes.NpgsqlPoint(x: 0.963076396176219d, y: 0.23342058280567402d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222712165581083d, y: 0.3733820671326471d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38813494946451266d, y: 0.5475639081269021d), new NpgsqlTypes.NpgsqlPoint(x: 0.009756547081015032d, y: 0.907718773457487d), new NpgsqlTypes.NpgsqlPoint(x: 0.03837185456484982d, y: 0.935000592918838d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6165722818998105d, y: 0.32253469708364757d), new NpgsqlTypes.NpgsqlPoint(x: 0.5814193881372323d, y: 0.05812070403275715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5787075943808937d, y: 0.5902587411567475d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2713110790900555d, y: 0.5330931755766937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639402654277871d, y: 0.15066394143951767d), new NpgsqlTypes.NpgsqlPoint(x: 0.19034080408076526d, y: 0.267228837688515d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2815409672197192d, y: 0.989572140484992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499657439838947d, y: 0.5354362514859593d), new NpgsqlTypes.NpgsqlPoint(x: 0.12224396217910038d, y: 0.4303860743163803d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0015200855824439863d, y: 0.6241186542782023d), new NpgsqlTypes.NpgsqlPoint(x: 0.07125912375670274d, y: 0.7068175331772046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8954440319484336d, y: 0.6267167993100207d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8035091053750715d, y: 0.5895285531194183d), new NpgsqlTypes.NpgsqlPoint(x: 0.17845237199401132d, y: 0.5227567294284816d), new NpgsqlTypes.NpgsqlPoint(x: 0.43086110476711426d, y: 0.9314079716406763d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48544672721166426d, y: 0.750624918848565d), new NpgsqlTypes.NpgsqlPoint(x: 0.268310282383887d, y: 0.6705186174155111d), new NpgsqlTypes.NpgsqlPoint(x: 0.09069607685609693d, y: 0.741513087805715d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023056792827687023d, y: 0.04547078628835599d), new NpgsqlTypes.NpgsqlPoint(x: 0.3884601838696703d, y: 0.3311378599695326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673135540824382d, y: 0.09462671338543904d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8418818359048076d, y: 0.38311226604371773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9954779176697914d, y: 0.46082446335167004d), new NpgsqlTypes.NpgsqlPoint(x: 0.06680218342831123d, y: 0.18133062787659815d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3984419424394011d, y: 0.004096263451717763d), new NpgsqlTypes.NpgsqlPoint(x: 0.09122368547180204d, y: 0.6525425611608524d), new NpgsqlTypes.NpgsqlPoint(x: 0.41523010709360186d, y: 0.6544612707385619d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6648389645859515d, y: 0.1917741062829269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613957800696616d, y: 0.1512694904719355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260560512173748d, y: 0.1751486224277029d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43823806852361924d, y: 0.24169727396744745d), new NpgsqlTypes.NpgsqlPoint(x: 0.05165769569816159d, y: 0.04144450642689379d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583015930031024d, y: 0.4144924756905791d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7611891434166814d, y: 0.4157351587487258d), new NpgsqlTypes.NpgsqlPoint(x: 0.23061560943162718d, y: 0.9697481100505468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397545343030411d, y: 0.8559279562703115d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0995521294627778d, y: 0.3096522512022547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705658897136651d, y: 0.2361061182692782d), new NpgsqlTypes.NpgsqlPoint(x: 0.01115152927175378d, y: 0.6687337704446239d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.111709839143312d, y: 0.5474398012703846d), new NpgsqlTypes.NpgsqlPoint(x: 0.1433163361277111d, y: 0.15638155117903563d), new NpgsqlTypes.NpgsqlPoint(x: 0.32494176356768845d, y: 0.9950813923657733d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013077470485874598d, y: 0.05310265785182999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390514304091564d, y: 0.1454899346209556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613863843207013d, y: 0.4031082108800771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.53516040071048d, y: 0.5505012413748488d), new NpgsqlTypes.NpgsqlPoint(x: 0.750153504746872d, y: 0.07972616030728708d), new NpgsqlTypes.NpgsqlPoint(x: 0.15453670462987257d, y: 0.5429985395431869d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42388072806642085d, y: 0.25328335917709466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035941620154718d, y: 0.40327629627278694d), new NpgsqlTypes.NpgsqlPoint(x: 0.673437378272211d, y: 0.46894665885646847d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9885208884212543d, y: 0.6519778476298953d), new NpgsqlTypes.NpgsqlPoint(x: 0.571920456734257d, y: 0.8757436021944097d), new NpgsqlTypes.NpgsqlPoint(x: 0.20217979666503771d, y: 0.37132782620189353d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5814416879252285d, y: 0.8878987193558334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562297828485859d, y: 0.30848963898614634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2844790536145081d, y: 0.6928259429557917d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5551873653330119d, y: 0.009864055354489865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448029035537681d, y: 0.643071455381789d), new NpgsqlTypes.NpgsqlPoint(x: 0.1275969969215791d, y: 0.6643341643512282d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7352875305029531d, y: 0.8570739820114136d), new NpgsqlTypes.NpgsqlPoint(x: 0.03973921215053289d, y: 0.911071266492915d), new NpgsqlTypes.NpgsqlPoint(x: 0.0899980886819679d, y: 0.8852271608697339d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6830189240710052d, y: 0.04870136553051441d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738444813463204d, y: 0.2744683283488455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530124330529186d, y: 0.45976384609744414d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7178190712258856d, y: 0.775390336991409d), new NpgsqlTypes.NpgsqlPoint(x: 0.49879459944730054d, y: 0.517372026413252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096760959967926d, y: 0.6728534626606908d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.034819851745360175d, y: 0.7815311124514748d), new NpgsqlTypes.NpgsqlPoint(x: 0.39022660940116716d, y: 0.5589617981822592d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722497240601579d, y: 0.22520796960023537d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803569270781652d, y: 0.59910426939962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6199191857110935d, y: 0.322881545099056d), new NpgsqlTypes.NpgsqlPoint(x: 0.022378583239323402d, y: 0.4904617865480889d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3179419381166614d, y: 0.49260297057834446d), new NpgsqlTypes.NpgsqlPoint(x: 0.05373273617102314d, y: 0.3241720208035245d), new NpgsqlTypes.NpgsqlPoint(x: 0.12527891391426693d, y: 0.9088386393458942d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1580613618981137d, y: 0.14838289667408844d), new NpgsqlTypes.NpgsqlPoint(x: 0.778146772540847d, y: 0.8411970167386066d), new NpgsqlTypes.NpgsqlPoint(x: 0.06780619702155954d, y: 0.9061925905140071d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3497065828814222d, y: 0.27418421194775444d), new NpgsqlTypes.NpgsqlPoint(x: 0.12069552440402365d, y: 0.5011976352529139d), new NpgsqlTypes.NpgsqlPoint(x: 0.028901030923348503d, y: 0.3517889165905491d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022299294461933128d, y: 0.975188177132923d), new NpgsqlTypes.NpgsqlPoint(x: 0.4267795354665317d, y: 0.906143077231713d), new NpgsqlTypes.NpgsqlPoint(x: 0.891304313078366d, y: 0.9725468716232832d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4791824135294712d, y: 0.463835477406607d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068034824838462d, y: 0.8679715814185691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8399835963880572d, y: 0.33555881427274437d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9931263701629872d, y: 0.8801664647783777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7242032782562692d, y: 0.15311226717467707d), new NpgsqlTypes.NpgsqlPoint(x: 0.007992090048898892d, y: 0.377115752412266d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6787151863378023d, y: 0.06980837428704945d), new NpgsqlTypes.NpgsqlPoint(x: 0.08078743311816716d, y: 0.14472314679685228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788718806735533d, y: 0.9045770564943098d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5503427083737453d, y: 0.21316823770375237d), new NpgsqlTypes.NpgsqlPoint(x: 0.9517064424817603d, y: 0.5918718791691873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507419941003157d, y: 0.47922398713709347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8423114510780167d, y: 0.7418580821508085d), new NpgsqlTypes.NpgsqlPoint(x: 0.001620362644267348d, y: 0.9639290980385516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8591210177480666d, y: 0.6450202683598375d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9029814951830776d, y: 0.07682498898004253d), new NpgsqlTypes.NpgsqlPoint(x: 0.38172571288129775d, y: 0.2369628038222652d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635192605449244d, y: 0.10545857074110343d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9583095630905095d, y: 0.11243908514899514d), new NpgsqlTypes.NpgsqlPoint(x: 0.34005396801469956d, y: 0.7386337596255287d), new NpgsqlTypes.NpgsqlPoint(x: 0.15092583241191937d, y: 0.8349898821264242d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12574857857633492d, y: 0.3960978773034628d), new NpgsqlTypes.NpgsqlPoint(x: 0.2732306751757615d, y: 0.3014727575629004d), new NpgsqlTypes.NpgsqlPoint(x: 0.30007130151148764d, y: 0.7843704150418914d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1132092849884958d, y: 0.8590597712283567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7214824941608357d, y: 0.5494142356710425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9345491997851142d, y: 0.08727975414783096d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5986334776720855d, y: 0.7197378164555912d), new NpgsqlTypes.NpgsqlPoint(x: 0.47623199387449566d, y: 0.19792745127131484d), new NpgsqlTypes.NpgsqlPoint(x: 0.16047368189460842d, y: 0.2823941608103572d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8017394150248038d, y: 0.45080620123106463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006723835237224d, y: 0.6906037536603371d), new NpgsqlTypes.NpgsqlPoint(x: 0.10570573114645299d, y: 0.2299380814860169d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9759796172452302d, y: 0.2617194158638346d), new NpgsqlTypes.NpgsqlPoint(x: 0.17797294734143065d, y: 0.888335306096274d), new NpgsqlTypes.NpgsqlPoint(x: 0.46264144184166967d, y: 0.8195787881723758d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26417211087692605d, y: 0.9882281022043632d), new NpgsqlTypes.NpgsqlPoint(x: 0.3223295274081377d, y: 0.3872443725316128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859794538214668d, y: 0.8211124134450544d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9351288775123812d, y: 0.544658469891287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7729623971333474d, y: 0.7877350137192609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617268574721653d, y: 0.9481657780812642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7737617447219356d, y: 0.7890470676628254d), new NpgsqlTypes.NpgsqlPoint(x: 0.41305727577614926d, y: 0.14335999297046553d), new NpgsqlTypes.NpgsqlPoint(x: 0.34378407422053936d, y: 0.061298539199517554d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4243529818411277d, y: 0.17717428693172488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299003918024699d, y: 0.14054928191298988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697065025866132d, y: 0.6100077011557736d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9450993475297041d, y: 0.8487289634049107d), new NpgsqlTypes.NpgsqlPoint(x: 0.12584060714817824d, y: 0.5627269978788718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554513084782358d, y: 0.7697096223649285d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.579423360922157d, y: 0.4605624856532061d), new NpgsqlTypes.NpgsqlPoint(x: 0.42250527214550126d, y: 0.21486842577355547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032641744803752d, y: 0.7192280885808188d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40006679627990205d, y: 0.8231801834074112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853744380413704d, y: 0.5699308176938085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3049120079648189d, y: 0.6350102812983636d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2621416409883728d, y: 0.7230222935647874d), new NpgsqlTypes.NpgsqlPoint(x: 0.007553238695954589d, y: 0.9144941561742921d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027642618635237d, y: 0.8581463850866401d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3043544328529073d, y: 0.31331989769063096d), new NpgsqlTypes.NpgsqlPoint(x: 0.867614859238763d, y: 0.875428707092748d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794208776162658d, y: 0.5420340871275473d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05574667534588651d, y: 0.1896766135262452d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548369890398446d, y: 0.5594682107125359d), new NpgsqlTypes.NpgsqlPoint(x: 0.10029159926239006d, y: 0.8646779756891462d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40256735317531345d, y: 0.2745083417344222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6250626337750995d, y: 0.9183126004739399d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608067471507319d, y: 0.07567075631220066d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8095659476076087d, y: 0.23856904723886563d), new NpgsqlTypes.NpgsqlPoint(x: 0.03522763384709093d, y: 0.23794268352740688d), new NpgsqlTypes.NpgsqlPoint(x: 0.38326529587788116d, y: 0.12767028758294674d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7457512558184894d, y: 0.4711246780919379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7257981779162546d, y: 0.3447227211090945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886590712786019d, y: 0.9718301802478505d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6153232399214597d, y: 0.6734949751730872d), new NpgsqlTypes.NpgsqlPoint(x: 0.22524780268463584d, y: 0.34605312952876743d), new NpgsqlTypes.NpgsqlPoint(x: 0.017966444582825036d, y: 0.6579939146998157d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9111209360227552d, y: 0.1941900198609522d), new NpgsqlTypes.NpgsqlPoint(x: 0.580496038659586d, y: 0.22043648612767386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938128348576054d, y: 0.8345636864817979d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7337085471855056d, y: 0.045820827318601376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5643678675075731d, y: 0.37015948712305224d), new NpgsqlTypes.NpgsqlPoint(x: 0.822980700711801d, y: 0.8235551405346582d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9107810926312067d, y: 0.6121652319349281d), new NpgsqlTypes.NpgsqlPoint(x: 0.35144743759664987d, y: 0.40623377708692443d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009167708335644509d, y: 0.6639812953830697d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9075872765600842d, y: 0.3327239655681573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208309551583954d, y: 0.655747595825786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5088658146923081d, y: 0.3775611191451891d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07043646641848833d, y: 0.09450791967837813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8108494106775039d, y: 0.14182966103145067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954303783337562d, y: 0.541968598681781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7603265873659021d, y: 0.1742219723799645d), new NpgsqlTypes.NpgsqlPoint(x: 0.12000760266073607d, y: 0.08403301519344264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584763907401768d, y: 0.45618131596449374d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540012367722961d, y: 0.778228300578467d), new NpgsqlTypes.NpgsqlPoint(x: 0.05310449446246579d, y: 0.11391510769033886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760321669096001d, y: 0.28352067023382665d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8132204030526634d, y: 0.47049594917305726d), new NpgsqlTypes.NpgsqlPoint(x: 0.23864714445689938d, y: 0.2653954562855707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406370598721391d, y: 0.20745601006252234d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9226888099329161d, y: 0.5732780395935873d), new NpgsqlTypes.NpgsqlPoint(x: 0.3773955649496682d, y: 0.18729807865820003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521685864599977d, y: 0.8686831039163704d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5105045009894037d, y: 0.7491241454993042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531384865722498d, y: 0.5718581826040016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485111701280901d, y: 0.079832466868902d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2155244606777773d, y: 0.4825819218582281d), new NpgsqlTypes.NpgsqlPoint(x: 0.2437465493792158d, y: 0.21412221569316736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208238727933361d, y: 0.04871907149383414d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4705874318448672d, y: 0.03396270221247588d), new NpgsqlTypes.NpgsqlPoint(x: 0.11716694387881166d, y: 0.7066471494139752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640091884788005d, y: 0.6335349544699427d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6387911806592793d, y: 0.8801812088400824d), new NpgsqlTypes.NpgsqlPoint(x: 0.16916608214509754d, y: 0.19645930261528088d), new NpgsqlTypes.NpgsqlPoint(x: 0.03490753269400548d, y: 0.337811213680283d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3151183086109386d, y: 0.05732962593671043d), new NpgsqlTypes.NpgsqlPoint(x: 0.005508702037743118d, y: 0.662846786917409d), new NpgsqlTypes.NpgsqlPoint(x: 0.847772022240269d, y: 0.6878382109953378d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5515611659359355d, y: 0.09966811332324588d), new NpgsqlTypes.NpgsqlPoint(x: 0.3132324616134602d, y: 0.4401675384509678d), new NpgsqlTypes.NpgsqlPoint(x: 0.7044615953036943d, y: 0.8037748896133413d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9365968367331783d, y: 0.33835330033197497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443067546304427d, y: 0.09868386959986641d), new NpgsqlTypes.NpgsqlPoint(x: 0.06668816081616114d, y: 0.42342483665340624d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3428281723239984d, y: 0.20563966102322206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5228050963681754d, y: 0.851227005892719d), new NpgsqlTypes.NpgsqlPoint(x: 0.20370376978891513d, y: 0.9834119441782104d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6577971365098372d, y: 0.6860046515516051d), new NpgsqlTypes.NpgsqlPoint(x: 0.6430061773591987d, y: 0.9637879956033452d), new NpgsqlTypes.NpgsqlPoint(x: 0.1459107678018321d, y: 0.18545737998160539d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13103367936319954d, y: 0.3567476839656827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584786066233128d, y: 0.8081647249015425d), new NpgsqlTypes.NpgsqlPoint(x: 0.469685353067713d, y: 0.9984415807954847d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1298696358044309d, y: 0.3061025289603838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705464105401756d, y: 0.9696571282425805d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800049688406306d, y: 0.09950672656608206d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6842873679039071d, y: 0.06144078076087878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114025181235329d, y: 0.19846899006033236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4153001182789361d, y: 0.6309128435495661d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7842870938513471d, y: 0.8751597402639646d), new NpgsqlTypes.NpgsqlPoint(x: 0.19256802416347385d, y: 0.8116298364937278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6799160477575329d, y: 0.13658873662787396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13942299699012173d, y: 0.29887260755603795d), new NpgsqlTypes.NpgsqlPoint(x: 0.19332000406103245d, y: 0.5436901650368426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045614636685148d, y: 0.3237098748436915d)), }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD2E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8115825311442869d, y: 0.6134368214604694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110815115549086d, y: 0.1053436572710359d), new NpgsqlTypes.NpgsqlPoint(x: 0.40362872490881907d, y: 0.4563015398201846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9322452609204858d, y: 0.7764817525850023d), new NpgsqlTypes.NpgsqlPoint(x: 0.44251013656766125d, y: 0.017479684318124855d), new NpgsqlTypes.NpgsqlPoint(x: 0.9915070924891145d, y: 0.2229975308985026d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49581867043693995d, y: 0.9695960772292694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731522478134586d, y: 0.5201910068169807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247308829496427d, y: 0.2783728284560001d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7168403316766266d, y: 0.3376280253248376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433394642988295d, y: 0.9436119324801239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258071804650196d, y: 0.14330195028148385d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.768977696432364d, y: 0.9453580869807413d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570531106583097d, y: 0.3913840248886422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9446056860948818d, y: 0.7272136748621967d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4625757341614608d, y: 0.7992631240526235d), new NpgsqlTypes.NpgsqlPoint(x: 0.36163298174667735d, y: 0.3221758179280242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076489792608191d, y: 0.7345357258546125d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6590164589931732d, y: 0.6816706708420065d), new NpgsqlTypes.NpgsqlPoint(x: 0.13195392165891817d, y: 0.21905185183033526d), new NpgsqlTypes.NpgsqlPoint(x: 0.2556006899813328d, y: 0.4299609695123934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8721267557723121d, y: 0.1506571699416166d), new NpgsqlTypes.NpgsqlPoint(x: 0.3737973860827819d, y: 0.3695995509299813d), new NpgsqlTypes.NpgsqlPoint(x: 0.07532304495217601d, y: 0.08432679847869873d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8773246400168052d, y: 0.5838991859994596d), new NpgsqlTypes.NpgsqlPoint(x: 0.3713555525631711d, y: 0.372526532463324d), new NpgsqlTypes.NpgsqlPoint(x: 0.06102356136056675d, y: 0.6371682369815396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2715286241749635d, y: 0.5421525689029842d), new NpgsqlTypes.NpgsqlPoint(x: 0.41353120944525257d, y: 0.9369876291426943d), new NpgsqlTypes.NpgsqlPoint(x: 0.06123575912753321d, y: 0.19774537004970028d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6624401410660864d, y: 0.46453036160350036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4095629855610903d, y: 0.21773884592946324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845635635285653d, y: 0.9570535298056532d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36966373730334323d, y: 0.19039297090646823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5736404329596253d, y: 0.6997702861517584d), new NpgsqlTypes.NpgsqlPoint(x: 0.4887089623051124d, y: 0.5440167635788877d)), }, },
},
            new NpgsqlPolygonpolygonMMArrayD2E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7955411988154623d, y: 0.3825291507741071d), new NpgsqlTypes.NpgsqlPoint(x: 0.15160854457423345d, y: 0.8214142767568049d), new NpgsqlTypes.NpgsqlPoint(x: 0.21355022452130334d, y: 0.9060202182967273d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5735620850022496d, y: 0.8456101415722196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515742127246238d, y: 0.2793123951435674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213810450301422d, y: 0.5311307273893164d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9154696156276673d, y: 0.9038583153362819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8943253343884114d, y: 0.7682246265648303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196958640655956d, y: 0.6835848275451072d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9012648394180608d, y: 0.2343204323964817d), new NpgsqlTypes.NpgsqlPoint(x: 0.617947955786448d, y: 0.2714358835464554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931084177956617d, y: 0.020781923348831888d)), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)), 
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
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd2e1mi_id
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
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                methodParametrName: "npgsqlpolygonpolygonmmarrayd2e1mi_id", 
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
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05276821714573798d, y: 0.03205351176247706d), new NpgsqlTypes.NpgsqlPoint(x: 0.37932884351979035d, y: 0.0032471003302945167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111053433938607d, y: 0.6986348951598083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4814955909493174d, y: 0.2134252029958743d), new NpgsqlTypes.NpgsqlPoint(x: 0.38389963402491156d, y: 0.8256498751330684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406159032088469d, y: 0.09179725951142781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18684425188253306d, y: 0.9057691154581361d), new NpgsqlTypes.NpgsqlPoint(x: 0.3190364992529342d, y: 0.4460336369014736d), new NpgsqlTypes.NpgsqlPoint(x: 0.633760331294756d, y: 0.6789289345125348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06649184417370646d, y: 0.11617977207648089d), new NpgsqlTypes.NpgsqlPoint(x: 0.3597564305340255d, y: 0.31848457427225074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984536814860444d, y: 0.08018550701789562d)), }, }));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,] { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11390313985185851d, y: 0.5315639713304081d), new NpgsqlTypes.NpgsqlPoint(x: 0.07748579002540812d, y: 0.4641552403213166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2660203980532104d, y: 0.9325045438288267d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3491142674679836d, y: 0.20406601180695805d), new NpgsqlTypes.NpgsqlPoint(x: 0.39575593978069945d, y: 0.6209907356071925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750084024511797d, y: 0.02550804061674139d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020099717420608232d, y: 0.5653039838152775d), new NpgsqlTypes.NpgsqlPoint(x: 0.03255455579015021d, y: 0.2156471919258247d), new NpgsqlTypes.NpgsqlPoint(x: 0.24517586092463495d, y: 0.5751216613592577d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2781092936909142d, y: 0.780635503971356d), new NpgsqlTypes.NpgsqlPoint(x: 0.18559155250386783d, y: 0.17948165540640681d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327188377468582d, y: 0.0757674025576962d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD2E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 68, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 8, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 111, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 79, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 131, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD2E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 4, 4))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 75, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd2e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
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
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI), typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD2E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD2))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

