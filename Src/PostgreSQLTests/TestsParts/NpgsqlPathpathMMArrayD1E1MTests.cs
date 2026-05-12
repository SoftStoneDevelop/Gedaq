

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
    internal partial interface INpgsqlPathMArraypathMMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD1 : INpgsqlPathMArraypathMMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD1E1M[] _testData = new NpgsqlPathpathMMArrayD1E1M[]
        {
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10981942581212656d, y: 0.44218640325229663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174774749671123d, y: 0.2250600099740826d), new NpgsqlTypes.NpgsqlPoint(x: 0.24010791597505088d, y: 0.5813821442324414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.608690156835687d, y: 0.5928286454815814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499679769992041d, y: 0.33761839693057494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5119021335758427d, y: 0.6044694705102626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8101119732780394d, y: 0.7109744101153604d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415861061384652d, y: 0.7692402411161263d), new NpgsqlTypes.NpgsqlPoint(x: 0.17338812455524577d, y: 0.20884140742760393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12424444343715957d, y: 0.7269051550707462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340602824639094d, y: 0.6513146027188534d), new NpgsqlTypes.NpgsqlPoint(x: 0.47731920603311995d, y: 0.5773781079223685d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7243268131580425d, y: 0.44240501638846097d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737257959069377d, y: 0.8168929299863663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2022962619321388d, y: 0.9281126308243353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29900156676771217d, y: 0.5520180776770969d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891818452663652d, y: 0.4463878107525564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5479292629614371d, y: 0.2961426944789223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4932616836145185d, y: 0.036043376102420255d), new NpgsqlTypes.NpgsqlPoint(x: 0.11741212964839087d, y: 0.14902836328883728d), new NpgsqlTypes.NpgsqlPoint(x: 0.6346918361161459d, y: 0.6121043371595811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7596185851890552d, y: 0.7076435022444719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008956520140976d, y: 0.5064220120960065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730029864409199d, y: 0.33305183418685813d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22604357367244132d, y: 0.14337358824299662d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463965993256603d, y: 0.8327812421227025d), new NpgsqlTypes.NpgsqlPoint(x: 0.457426718381416d, y: 0.8164449077882959d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4467983709626223d, y: 0.9845259191631867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988776276675966d, y: 0.010809676608427798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478045887182521d, y: 0.22547929802209643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44854603764765044d, y: 0.9242428488416163d), new NpgsqlTypes.NpgsqlPoint(x: 0.2708083334982011d, y: 0.9878066654807026d), new NpgsqlTypes.NpgsqlPoint(x: 0.183568489863289d, y: 0.4594708567340484d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1819084886598311d, y: 0.21752468389119972d), new NpgsqlTypes.NpgsqlPoint(x: 0.3629253975075447d, y: 0.09319101401249774d), new NpgsqlTypes.NpgsqlPoint(x: 0.03950302433884689d, y: 0.44512361125760314d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8822283693208582d, y: 0.618146032255998d), new NpgsqlTypes.NpgsqlPoint(x: 0.5739825994889381d, y: 0.6375416847156361d), new NpgsqlTypes.NpgsqlPoint(x: 0.0001913817945552454d, y: 0.7754061349485984d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4395373285328862d, y: 0.3212252617150917d), new NpgsqlTypes.NpgsqlPoint(x: 0.12674462876710835d, y: 0.40568849425694775d), new NpgsqlTypes.NpgsqlPoint(x: 0.4362268411898812d, y: 0.12859976233574277d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02341239018536645d, y: 0.65464245777277d), new NpgsqlTypes.NpgsqlPoint(x: 0.3728902553569746d, y: 0.6297272178180269d), new NpgsqlTypes.NpgsqlPoint(x: 0.12263396191927789d, y: 0.8377109728353229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.793961620962382d, y: 0.36309151733400225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205587179908654d, y: 0.4746182781446461d), new NpgsqlTypes.NpgsqlPoint(x: 0.14651923020678015d, y: 0.8170353608113192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3269318892543007d, y: 0.37566134967409903d), new NpgsqlTypes.NpgsqlPoint(x: 0.1406556798201103d, y: 0.37904144893862146d), new NpgsqlTypes.NpgsqlPoint(x: 0.19808908507777534d, y: 0.5813041603628202d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6658433414806871d, y: 0.560461355554762d), new NpgsqlTypes.NpgsqlPoint(x: 0.05408783247862026d, y: 0.3746787008104492d), new NpgsqlTypes.NpgsqlPoint(x: 0.939723922577904d, y: 0.6831560486604186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.68192484273227d, y: 0.06400944141146903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293105262055223d, y: 0.44394356955455405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769214402510729d, y: 0.3466245213417668d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6586147485394823d, y: 0.09759749935843154d), new NpgsqlTypes.NpgsqlPoint(x: 0.2847289048910019d, y: 0.0960882030023128d), new NpgsqlTypes.NpgsqlPoint(x: 0.28307970579975317d, y: 0.8130611183173992d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49095740652412256d, y: 0.9970422363547481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294569418595195d, y: 0.18723751227709784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5562212087555393d, y: 0.9140245912013324d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20410237730203462d, y: 0.778362028936518d), new NpgsqlTypes.NpgsqlPoint(x: 0.06584771793280908d, y: 0.1484222717096968d), new NpgsqlTypes.NpgsqlPoint(x: 0.02358153622611192d, y: 0.5851140755226213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28544597070920597d, y: 0.5875774705716841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5228714739341074d, y: 0.5022600987189623d), new NpgsqlTypes.NpgsqlPoint(x: 0.16659406642689212d, y: 0.753348657214584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8261301231412479d, y: 0.2125127492817559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887499074876382d, y: 0.6877655528454915d), new NpgsqlTypes.NpgsqlPoint(x: 0.11808891819679157d, y: 0.6832721693152964d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6707415660805832d, y: 0.7551778336345545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155036589622624d, y: 0.6955621662782266d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082298135896884d, y: 0.8189659570589776d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14408164811066793d, y: 0.5399878311735338d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606734084675833d, y: 0.4957936380414205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356218793271986d, y: 0.2890994957908929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8905517461634257d, y: 0.4346424498843924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400085311180123d, y: 0.10341235430420903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9537352451946887d, y: 0.030936519877654445d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9388321230747956d, y: 0.13963322438648595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275037271196704d, y: 0.3531780071167825d), new NpgsqlTypes.NpgsqlPoint(x: 0.30319439244133306d, y: 0.7772810907199992d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46106159032108684d, y: 0.803817863806376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298659158454483d, y: 0.6648454330211624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763903296575407d, y: 0.4584617472122141d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.92445103540993d, y: 0.4781652838677003d), new NpgsqlTypes.NpgsqlPoint(x: 0.34027177153908894d, y: 0.3287511436346323d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982723331515336d, y: 0.897959128832589d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5690162163049934d, y: 0.5732085890668981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631241538427966d, y: 0.6375015151346114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444016876141108d, y: 0.31823912575322166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2815579987118625d, y: 0.15200671042283986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5874031148484758d, y: 0.4221061475254444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095036281175978d, y: 0.10409507132342088d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7276688883404644d, y: 0.5040294557961289d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078976856657817d, y: 0.7857976478012928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666570462371479d, y: 0.21531454749182832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6170569678632521d, y: 0.7624129795559008d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014615249471288d, y: 0.097087439755563d), new NpgsqlTypes.NpgsqlPoint(x: 0.09459012500946684d, y: 0.6297238983122346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02020418465744822d, y: 0.5983479904291116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5811216216595276d, y: 0.14731824162205742d), new NpgsqlTypes.NpgsqlPoint(x: 0.027237875176137294d, y: 0.9439460168937961d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13642707605345816d, y: 0.8895344501065657d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277711679771745d, y: 0.3842247624081546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530699039774827d, y: 0.10142333937512049d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4109055192945247d, y: 0.7767200062061254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9983342647087943d, y: 0.973825449003662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8873982727404625d, y: 0.3306498222829636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8298989365205732d, y: 0.44106222952948415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538577598530259d, y: 0.5220410642899327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142539172726153d, y: 0.7801868008745522d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8834831325452072d, y: 0.6434976006106522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4740318449056061d, y: 0.49829633328198564d), new NpgsqlTypes.NpgsqlPoint(x: 0.19461969230201126d, y: 0.8370998976064166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8651648608849422d, y: 0.5703363811778939d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457320632272854d, y: 0.8370010111868789d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377318749071069d, y: 0.25421796595437784d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.911549619070053d, y: 0.8235516144360115d), new NpgsqlTypes.NpgsqlPoint(x: 0.7091365447959209d, y: 0.8449380611071913d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301230533258671d, y: 0.3060913562407087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1425796843931434d, y: 0.3554603935031513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5389461443082544d, y: 0.38209083036284663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131489611024495d, y: 0.9633478155041817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7461715166167386d, y: 0.4810883015787154d), new NpgsqlTypes.NpgsqlPoint(x: 0.706904110878806d, y: 0.5911164085178887d), new NpgsqlTypes.NpgsqlPoint(x: 0.2153191974343699d, y: 0.040610284871041236d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2443681950281149d, y: 0.5333460931864844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9125811693739582d, y: 0.6086921208284027d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339021313379971d, y: 0.16327672972921636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5438470258212165d, y: 0.2127876727745759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7705562552902537d, y: 0.12273032705268605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624611959711536d, y: 0.5462914901783196d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13029249583503721d, y: 0.7597189299965308d), new NpgsqlTypes.NpgsqlPoint(x: 0.20037080470501478d, y: 0.33949325758831195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321728886251131d, y: 0.34112511252661615d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3431630265535174d, y: 0.9955252378873249d), new NpgsqlTypes.NpgsqlPoint(x: 0.2282630719359039d, y: 0.010758757969457688d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517749780932158d, y: 0.05464634481365016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9120649922458451d, y: 0.7447788828573121d), new NpgsqlTypes.NpgsqlPoint(x: 0.11112254849708436d, y: 0.6921126909528659d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443115901526723d, y: 0.21001053196748964d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6575011468090728d, y: 0.6654544061893645d), new NpgsqlTypes.NpgsqlPoint(x: 0.39575866696896667d, y: 0.23614813839565485d), new NpgsqlTypes.NpgsqlPoint(x: 0.36007385870805875d, y: 0.14771072691679143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38128550049359466d, y: 0.6317651539099615d), new NpgsqlTypes.NpgsqlPoint(x: 0.057353485895221046d, y: 0.7349800475282767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9072720336552254d, y: 0.1629564163197934d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5882485772252029d, y: 0.11366030687182904d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167126010137475d, y: 0.6494689785831366d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231439552646027d, y: 0.3737525122220311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6603572326475767d, y: 0.9209664555383423d), new NpgsqlTypes.NpgsqlPoint(x: 0.1263350874241278d, y: 0.017645934601046798d), new NpgsqlTypes.NpgsqlPoint(x: 0.46182664727539735d, y: 0.6358456832639439d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6940135210198242d, y: 0.22741424898508145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997315246550845d, y: 0.7089094456242484d), new NpgsqlTypes.NpgsqlPoint(x: 0.4304562785356457d, y: 0.7456850082102819d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32622037028484685d, y: 0.5160250061008413d), new NpgsqlTypes.NpgsqlPoint(x: 0.000985617315451548d, y: 0.6878939798138177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5071363853096285d, y: 0.3162419865887779d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07536563582766964d, y: 0.18363941784058424d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460012354918428d, y: 0.9350639520246881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464219862435366d, y: 0.4418602938195153d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4092074901353904d, y: 0.7792451097667091d), new NpgsqlTypes.NpgsqlPoint(x: 0.042081685688772574d, y: 0.24441319129809935d), new NpgsqlTypes.NpgsqlPoint(x: 0.005760586088602859d, y: 0.6535547014061562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08096725606848354d, y: 0.8110931255829142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341784563994538d, y: 0.42665170776881634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708972158310792d, y: 0.03759017073022641d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7660631764970881d, y: 0.8907011380344226d), new NpgsqlTypes.NpgsqlPoint(x: 0.33678890268516526d, y: 0.6378647794259857d), new NpgsqlTypes.NpgsqlPoint(x: 0.887931619383014d, y: 0.24563781675682927d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.62128340996338d, y: 0.45545921878255036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008547932132892d, y: 0.9466102291338208d), new NpgsqlTypes.NpgsqlPoint(x: 0.13830395402429918d, y: 0.5459728362471188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03929591436675317d, y: 0.521370865868259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155083479718585d, y: 0.4045974562737429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068449027555892d, y: 0.8574275037601158d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7067230203775098d, y: 0.767978673152301d), new NpgsqlTypes.NpgsqlPoint(x: 0.386832519250511d, y: 0.19175872374113379d), new NpgsqlTypes.NpgsqlPoint(x: 0.008397394987126328d, y: 0.9214517063084002d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2392017728434611d, y: 0.6138500356122752d), new NpgsqlTypes.NpgsqlPoint(x: 0.19485717059581797d, y: 0.9182839387923455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170372822837151d, y: 0.4527784708982412d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413523323740523d, y: 0.5289995127970707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628312167107915d, y: 0.05787316590258429d), new NpgsqlTypes.NpgsqlPoint(x: 0.1536907036863394d, y: 0.583925666298311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7187665524555426d, y: 0.5780449087482712d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694431065822824d, y: 0.5414549779505778d), new NpgsqlTypes.NpgsqlPoint(x: 0.22210173039588454d, y: 0.8260221720777736d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.640005974804315d, y: 0.4768635333258845d), new NpgsqlTypes.NpgsqlPoint(x: 0.04496932054790104d, y: 0.956224901301788d), new NpgsqlTypes.NpgsqlPoint(x: 0.3995117635926946d, y: 0.4708995882983503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4054279177580713d, y: 0.7021430899812625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049649646812026d, y: 0.6719012573170765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554146607194767d, y: 0.0684463359926577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6258870096338991d, y: 0.1850097986166337d), new NpgsqlTypes.NpgsqlPoint(x: 0.09177881170842572d, y: 0.43155264635388335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786880846119263d, y: 0.29969283824428894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21858229635679483d, y: 0.7354087296921361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141210911561382d, y: 0.08562141412711621d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479916876043103d, y: 0.9836412454877641d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5081376374563491d, y: 0.3929694620798121d), new NpgsqlTypes.NpgsqlPoint(x: 0.6696878077450004d, y: 0.8870974329876058d), new NpgsqlTypes.NpgsqlPoint(x: 0.23807963596186332d, y: 0.03389000529144437d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4602514071094923d, y: 0.671830118980717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065394856575061d, y: 0.831402326095098d), new NpgsqlTypes.NpgsqlPoint(x: 0.24574576279058302d, y: 0.9657871944184507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1883586688879343d, y: 0.3546150931651294d), new NpgsqlTypes.NpgsqlPoint(x: 0.044887678082972116d, y: 0.7556653568022542d), new NpgsqlTypes.NpgsqlPoint(x: 0.1305850719731223d, y: 0.5721152257570006d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08694951439729748d, y: 0.2472814615488802d), new NpgsqlTypes.NpgsqlPoint(x: 0.15913089204164066d, y: 0.6177359302787709d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941643063274032d, y: 0.7850605770411956d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7792685030427138d, y: 0.4143170447003103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892806996939507d, y: 0.7644345170765384d), new NpgsqlTypes.NpgsqlPoint(x: 0.3913957764335264d, y: 0.07252731955562708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020361210959780718d, y: 0.8649878415068859d), new NpgsqlTypes.NpgsqlPoint(x: 0.12655158343582984d, y: 0.4441033793380177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3297083732611813d, y: 0.36160261772926017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7267256350599117d, y: 0.9032160116505512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898442166592208d, y: 0.48044079657489946d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719633346110306d, y: 0.5645233320014242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04396656755706685d, y: 0.7377857130963434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540339885802945d, y: 0.2444304726778349d), new NpgsqlTypes.NpgsqlPoint(x: 0.1412600325174831d, y: 0.37271415806142794d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21613149022615163d, y: 0.7390729658825462d), new NpgsqlTypes.NpgsqlPoint(x: 0.09482616446759007d, y: 0.4020083120999428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822280043640209d, y: 0.4263804059764408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7662159619909139d, y: 0.2571871705876816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3480250971643366d, y: 0.7193004476884922d), new NpgsqlTypes.NpgsqlPoint(x: 0.16624783657197206d, y: 0.5304635559219699d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9413715681540263d, y: 0.7553637342732284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013469212897841d, y: 0.8011747526395948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429172373994502d, y: 0.35920839946097316d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7666495203114668d, y: 0.09708418677826425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9328794484847596d, y: 0.37551202664927086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9422611257346284d, y: 0.7701378556493641d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27850669129642946d, y: 0.6931190233732899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084171875418081d, y: 0.8563188333804092d), new NpgsqlTypes.NpgsqlPoint(x: 0.1501482702273631d, y: 0.27390668891286496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9969070245801005d, y: 0.7727300575414443d), new NpgsqlTypes.NpgsqlPoint(x: 0.13059655517125845d, y: 0.8396684980731873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608279331337257d, y: 0.6686686750284205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2549720596220474d, y: 0.7141331324656567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287556643840117d, y: 0.3983070256311817d), new NpgsqlTypes.NpgsqlPoint(x: 0.04022075664593616d, y: 0.647484525110529d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8184070419774608d, y: 0.6769030025471328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7951144090700571d, y: 0.5350168293333244d), new NpgsqlTypes.NpgsqlPoint(x: 0.24972364934556635d, y: 0.4996081313614328d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6130504332522388d, y: 0.0384350262222114d), new NpgsqlTypes.NpgsqlPoint(x: 0.34885287100240514d, y: 0.6710707671465249d), new NpgsqlTypes.NpgsqlPoint(x: 0.09925471184200207d, y: 0.560761567055176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6204062670798379d, y: 0.5023384299697801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986795210769426d, y: 0.6148368293681712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545189137417923d, y: 0.19768798124409426d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05468675465266082d, y: 0.4770615162341878d), new NpgsqlTypes.NpgsqlPoint(x: 0.11782089100540705d, y: 0.952445584158399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6501502541443139d, y: 0.14865048213826249d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7120861202541383d, y: 0.218087573157005d), new NpgsqlTypes.NpgsqlPoint(x: 0.24577580246530872d, y: 0.27309674538681195d), new NpgsqlTypes.NpgsqlPoint(x: 0.2970656593613711d, y: 0.7104864434936078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5493375556307352d, y: 0.8616677143525647d), new NpgsqlTypes.NpgsqlPoint(x: 0.40731373960069883d, y: 0.29787408878811117d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773090472267018d, y: 0.7931623438997543d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7727565907039583d, y: 0.7514846702738693d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692808318091908d, y: 0.919512233748926d), new NpgsqlTypes.NpgsqlPoint(x: 0.1540752587676486d, y: 0.8299700209434085d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5695689231405779d, y: 0.186351250545309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7644702770708971d, y: 0.8210666026355375d), new NpgsqlTypes.NpgsqlPoint(x: 0.07531988394049949d, y: 0.908168443816222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6612790363927897d, y: 0.9647191371581564d), new NpgsqlTypes.NpgsqlPoint(x: 0.45072272386906487d, y: 0.21712466414834242d), new NpgsqlTypes.NpgsqlPoint(x: 0.797893459595725d, y: 0.9453560764095289d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9219963106612297d, y: 0.739625739621623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561032156582841d, y: 0.889475453496898d), new NpgsqlTypes.NpgsqlPoint(x: 0.2893062296652479d, y: 0.126991885733019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550281872711964d, y: 0.5471590753648126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179434098360839d, y: 0.3866897666382977d), new NpgsqlTypes.NpgsqlPoint(x: 0.21469643753040035d, y: 0.9755638099269611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8645834235921795d, y: 0.9011585450546097d), new NpgsqlTypes.NpgsqlPoint(x: 0.577318609105747d, y: 0.7600426985454544d), new NpgsqlTypes.NpgsqlPoint(x: 0.03445533396880629d, y: 0.8617081714933466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8542755846540703d, y: 0.7074880036577956d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016427375375049902d, y: 0.09750968705087859d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326560964091705d, y: 0.8231742485237088d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9774471576524134d, y: 0.676967854735454d), new NpgsqlTypes.NpgsqlPoint(x: 0.29097392180443815d, y: 0.2780356757005885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437648602101666d, y: 0.7006216573686576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30634610071621826d, y: 0.13044292997369d), new NpgsqlTypes.NpgsqlPoint(x: 0.33549413428360353d, y: 0.7574433067710065d), new NpgsqlTypes.NpgsqlPoint(x: 0.735814703431751d, y: 0.6194889928744393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2924279014193736d, y: 0.8824640913867925d), new NpgsqlTypes.NpgsqlPoint(x: 0.36207302231637406d, y: 0.2079082881935015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353948803781855d, y: 0.12408922021089586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4464384637833374d, y: 0.42934036925132446d), new NpgsqlTypes.NpgsqlPoint(x: 0.03838926981288848d, y: 0.47556615195931984d), new NpgsqlTypes.NpgsqlPoint(x: 0.4926498303232859d, y: 0.18683896429473024d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47785597983657124d, y: 0.5433524014423808d), new NpgsqlTypes.NpgsqlPoint(x: 0.3996166932165619d, y: 0.6079160245471048d), new NpgsqlTypes.NpgsqlPoint(x: 0.16970850561241746d, y: 0.558057034472271d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5326236265674734d, y: 0.773367971204867d), new NpgsqlTypes.NpgsqlPoint(x: 0.34993645449871735d, y: 0.9737727091121199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217937748187509d, y: 0.867689607761047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10461315347877953d, y: 0.7321971980551903d), new NpgsqlTypes.NpgsqlPoint(x: 0.20723412042947698d, y: 0.7911970058835454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397756494466689d, y: 0.5883349523906278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7753568555645284d, y: 0.3942616231314511d), new NpgsqlTypes.NpgsqlPoint(x: 0.4777146147493584d, y: 0.2187190297577144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771007452458709d, y: 0.8443318569540011d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2552553677408116d, y: 0.24797094919098728d), new NpgsqlTypes.NpgsqlPoint(x: 0.23507673343086344d, y: 0.8902329155104782d), new NpgsqlTypes.NpgsqlPoint(x: 0.986798369757784d, y: 0.3103031968729203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9511840222108612d, y: 0.5857382705462227d), new NpgsqlTypes.NpgsqlPoint(x: 0.2013188629076813d, y: 0.7419275906566629d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563542067542167d, y: 0.40479445414292037d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9037314493864521d, y: 0.7193474415756806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2595660522335106d, y: 0.37647597731654703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880081739609727d, y: 0.04364477109559306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016066412369052152d, y: 0.7191201340728344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922821583420552d, y: 0.7879869312202117d), new NpgsqlTypes.NpgsqlPoint(x: 0.617418438602506d, y: 0.8461000301708993d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2816644546050614d, y: 0.44638891371297296d), new NpgsqlTypes.NpgsqlPoint(x: 0.019791609142278954d, y: 0.19708465592580993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5419850128088378d, y: 0.9632822371141454d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6281334411411957d, y: 0.6948972416428589d), new NpgsqlTypes.NpgsqlPoint(x: 0.22069924279565067d, y: 0.4891891760110054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6652859491563786d, y: 0.7206839774460919d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23027740961819d, y: 0.34579207461260364d), new NpgsqlTypes.NpgsqlPoint(x: 0.3110503796401196d, y: 0.6500939879308016d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848256980203232d, y: 0.2305325607500779d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11859914682941497d, y: 0.5385804813088964d), new NpgsqlTypes.NpgsqlPoint(x: 0.46607272412086553d, y: 0.16532001783352435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869775978190049d, y: 0.3204596246440007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475433466115857d, y: 0.8718138339988509d), new NpgsqlTypes.NpgsqlPoint(x: 0.07834646181090255d, y: 0.6163597046787322d), new NpgsqlTypes.NpgsqlPoint(x: 0.20878386298870788d, y: 0.33478080046845216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.836682652018325d, y: 0.0007459610619415802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6197819179880663d, y: 0.8421271181591946d), new NpgsqlTypes.NpgsqlPoint(x: 0.14576862696848658d, y: 0.7815819724920654d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1273134048059642d, y: 0.3025466291647748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672340704579885d, y: 0.6661507222336873d), new NpgsqlTypes.NpgsqlPoint(x: 0.34126242033173926d, y: 0.36968386088968985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.238717480634003d, y: 0.5036254922840907d), new NpgsqlTypes.NpgsqlPoint(x: 0.10624022817546142d, y: 0.8257971031981186d), new NpgsqlTypes.NpgsqlPoint(x: 0.20483633688101188d, y: 0.7753920285382583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0464103476765928d, y: 0.36379512786422286d), new NpgsqlTypes.NpgsqlPoint(x: 0.35351069741531027d, y: 0.15106162018302915d), new NpgsqlTypes.NpgsqlPoint(x: 0.19129008306475725d, y: 0.9437760766046238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5889886767928935d, y: 0.10002072462411893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8596539713878174d, y: 0.8381830402642182d), new NpgsqlTypes.NpgsqlPoint(x: 0.16415262758655536d, y: 0.7779336589190534d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4997389680549267d, y: 0.2298712458548865d), new NpgsqlTypes.NpgsqlPoint(x: 0.2473343684934567d, y: 0.8261288789791034d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948992605131283d, y: 0.424227060450297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41266312068829125d, y: 0.8308675488707462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923178281857978d, y: 0.9658098785290875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036031278475616d, y: 0.29342836836257946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9124744619932429d, y: 0.39509659809832376d), new NpgsqlTypes.NpgsqlPoint(x: 0.17060076957520176d, y: 0.22085816721968765d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680420355952374d, y: 0.34803706095059284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12564337046259832d, y: 0.22329505734606625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6810972126420549d, y: 0.47622257371320287d), new NpgsqlTypes.NpgsqlPoint(x: 0.15578877706012717d, y: 0.4127323414135443d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2767234807891945d, y: 0.8547798949296826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337726613837217d, y: 0.13818139806560337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521015080021232d, y: 0.3815365493146575d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5578220425384824d, y: 0.963600832907503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036894434336949d, y: 0.4308388538194142d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936649527023758d, y: 0.7089385551517334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7578765749617241d, y: 0.8554514933012742d), new NpgsqlTypes.NpgsqlPoint(x: 0.2511099188112855d, y: 0.32202527401855274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460289452008676d, y: 0.3946183375932667d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9480291168238623d, y: 0.14145458515322795d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872036881613002d, y: 0.5152884238822664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9416862374373421d, y: 0.49981353128700023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6763736642119291d, y: 0.7253627269052834d), new NpgsqlTypes.NpgsqlPoint(x: 0.36528733666924795d, y: 0.1363359441173707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711714959847032d, y: 0.2265677684866252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10393774049374638d, y: 0.9088205600590541d), new NpgsqlTypes.NpgsqlPoint(x: 0.593922210327387d, y: 0.2864445847183934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6798822086087388d, y: 0.10826552597648154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25249202154551287d, y: 0.1005582118135041d), new NpgsqlTypes.NpgsqlPoint(x: 0.3175282664540944d, y: 0.45441353114615224d), new NpgsqlTypes.NpgsqlPoint(x: 0.32714870125873907d, y: 0.8550774789677315d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4919869031965184d, y: 0.7192488455785452d), new NpgsqlTypes.NpgsqlPoint(x: 0.018829521347491274d, y: 0.8228572166222361d), new NpgsqlTypes.NpgsqlPoint(x: 0.16064225521469033d, y: 0.13194082585511036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19787550927230357d, y: 0.15296608065137574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764063981867545d, y: 0.6398115974913162d), new NpgsqlTypes.NpgsqlPoint(x: 0.1514441800282973d, y: 0.41447273473645097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8025594342355744d, y: 0.15434721416455743d), new NpgsqlTypes.NpgsqlPoint(x: 0.001623277893249564d, y: 0.3748610548063501d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827302202244053d, y: 0.7236572755862891d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30811145504085924d, y: 0.5518979163790043d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227715336912441d, y: 0.4892858079243111d), new NpgsqlTypes.NpgsqlPoint(x: 0.4024638867609601d, y: 0.9914722477808523d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21167031679986648d, y: 0.4291110736192403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095170831787036d, y: 0.7428781059853321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381308062842354d, y: 0.43595010033952597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22643057029793945d, y: 0.9007488948346082d), new NpgsqlTypes.NpgsqlPoint(x: 0.927048850715321d, y: 0.4850988546907815d), new NpgsqlTypes.NpgsqlPoint(x: 0.521459158971126d, y: 0.08432224996672077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4501214088421459d, y: 0.21420345890765347d), new NpgsqlTypes.NpgsqlPoint(x: 0.30595513156765186d, y: 0.17922256692308292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813593441246895d, y: 0.14674514810401906d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28474218091197656d, y: 0.18150867155556816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3108315233072587d, y: 0.7833677325970411d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360789124497354d, y: 0.5021047836489303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10935559808554407d, y: 0.6466194532992617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971114640976869d, y: 0.9061933504572657d), new NpgsqlTypes.NpgsqlPoint(x: 0.398325637016701d, y: 0.2516273971161016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19707083170752382d, y: 0.8322983503961879d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909393121549159d, y: 0.07400546377127182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413058121075648d, y: 0.9127154147291479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47656588751231277d, y: 0.561492630370518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200114751829163d, y: 0.30574496150243113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872545425772278d, y: 0.17617789273164575d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7750345189373403d, y: 0.5185505942499798d), new NpgsqlTypes.NpgsqlPoint(x: 0.71234462673826d, y: 0.7282902023853355d), new NpgsqlTypes.NpgsqlPoint(x: 0.48255675125868047d, y: 0.9178105636439156d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12044481283871611d, y: 0.5975086489533329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199620500051505d, y: 0.046109526432008496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089687487994168d, y: 0.7153245790158915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3257847902329223d, y: 0.7793402334783776d), new NpgsqlTypes.NpgsqlPoint(x: 0.14279428102842429d, y: 0.3075023168664628d), new NpgsqlTypes.NpgsqlPoint(x: 0.49852168262716523d, y: 0.29799604736056684d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3699004834564834d, y: 0.7793566549924252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699717528692406d, y: 0.06778438379269158d), new NpgsqlTypes.NpgsqlPoint(x: 0.2255828913443927d, y: 0.9966029647830359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34398811721164246d, y: 0.5558189672891244d), new NpgsqlTypes.NpgsqlPoint(x: 0.1540693788545281d, y: 0.6057415188240236d), new NpgsqlTypes.NpgsqlPoint(x: 0.019878692051042646d, y: 0.7943296423265769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942779498979778d, y: 0.31312850336275355d), new NpgsqlTypes.NpgsqlPoint(x: 0.003461251120114306d, y: 0.08172858906309366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854864512440177d, y: 0.8132339530774646d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8754237617632754d, y: 0.3324796761350254d), new NpgsqlTypes.NpgsqlPoint(x: 0.14379158273382564d, y: 0.7371782407470836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3689724597561004d, y: 0.7415284857809123d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32264187168499725d, y: 0.29895580159549695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8686379049920878d, y: 0.04511511323364903d), new NpgsqlTypes.NpgsqlPoint(x: 0.21681193050923664d, y: 0.23357508302604058d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9567939375044964d, y: 0.9927963873035732d), new NpgsqlTypes.NpgsqlPoint(x: 0.19186485263626318d, y: 0.6250639972352825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137440968704395d, y: 0.3345626461138619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5164120706308895d, y: 0.746097603438482d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806308177785717d, y: 0.11399068522115807d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999279779492431d, y: 0.23168343971306493d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18839399889717512d, y: 0.0853353550076581d), new NpgsqlTypes.NpgsqlPoint(x: 0.48960491985387866d, y: 0.1319380520830672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5678626595326353d, y: 0.3832098311176415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16128618455583832d, y: 0.6570231280172926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7746494337236041d, y: 0.1584480730233453d), new NpgsqlTypes.NpgsqlPoint(x: 0.3787093677235738d, y: 0.9460227104114125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5406457276596228d, y: 0.3253875417941461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960492406737774d, y: 0.4926667680283332d), new NpgsqlTypes.NpgsqlPoint(x: 0.19865059898426618d, y: 0.4169457974426761d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15481853969748283d, y: 0.27146330736359636d), new NpgsqlTypes.NpgsqlPoint(x: 0.29353417703927254d, y: 0.4619084329587456d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256026963448586d, y: 0.6586219469407452d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36307633660590666d, y: 0.1459954983740438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930923057466332d, y: 0.3428184910207981d), new NpgsqlTypes.NpgsqlPoint(x: 0.23385291769815064d, y: 0.396053802848374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7048484305791776d, y: 0.7911394773869788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219355042606646d, y: 0.6347050490032528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701333767345508d, y: 0.17056664404535626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25249213236716717d, y: 0.16043723139964283d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744055926617675d, y: 0.3453233780003522d), new NpgsqlTypes.NpgsqlPoint(x: 0.767808615853502d, y: 0.24488784243335204d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37722545906069993d, y: 0.4227583197417043d), new NpgsqlTypes.NpgsqlPoint(x: 0.31966616065400955d, y: 0.9187633487099875d), new NpgsqlTypes.NpgsqlPoint(x: 0.983207018952341d, y: 0.397970252765382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5121968737853672d, y: 0.9682695890364096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170496416635174d, y: 0.6662816793905504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859838537923677d, y: 0.5625814897214246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8202090373831161d, y: 0.6948327637435506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702986185867668d, y: 0.6981231124312643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873207327869405d, y: 0.6592043206301939d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2261067750474316d, y: 0.2922277233681958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605159181940553d, y: 0.6152076161022603d), new NpgsqlTypes.NpgsqlPoint(x: 0.1683511174653507d, y: 0.8087767170266794d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8540046949623662d, y: 0.5856057947018475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654105197985972d, y: 0.02528178288284788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7435984121581898d, y: 0.746830551691262d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7154047382500278d, y: 0.8844009167741315d), new NpgsqlTypes.NpgsqlPoint(x: 0.026490843268455633d, y: 0.6583828326779777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5525122236557066d, y: 0.1717365704631676d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20256895922391405d, y: 0.7683452701833245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648456436377224d, y: 0.18521840037099535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641607048038184d, y: 0.5745320820574163d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.82661806437226d, y: 0.3360475199250752d), new NpgsqlTypes.NpgsqlPoint(x: 0.4958651172260483d, y: 0.6178374420289235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180106157297837d, y: 0.7685436235609068d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6941486855441339d, y: 0.9405376090174865d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932097685378959d, y: 0.05054100100889125d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709264462497001d, y: 0.8861603825257657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26556137034335014d, y: 0.5316945422257089d), new NpgsqlTypes.NpgsqlPoint(x: 0.19028319447417164d, y: 0.6936139069429079d), new NpgsqlTypes.NpgsqlPoint(x: 0.11456427787237589d, y: 0.055305151126492924d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.513655077572983d, y: 0.4900334243073653d), new NpgsqlTypes.NpgsqlPoint(x: 0.003373420433948504d, y: 0.062164417248831816d), new NpgsqlTypes.NpgsqlPoint(x: 0.617195583130688d, y: 0.5831728543736887d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058865924201909836d, y: 0.32122379218415287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9858932868213781d, y: 0.5477948250866972d), new NpgsqlTypes.NpgsqlPoint(x: 0.15652328400154492d, y: 0.5908614413743105d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.654850964641723d, y: 0.6465923005933546d), new NpgsqlTypes.NpgsqlPoint(x: 0.76337041559629d, y: 0.9113535538900904d), new NpgsqlTypes.NpgsqlPoint(x: 0.08493349611628975d, y: 0.7019493713416294d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.482890961608865d, y: 0.3887108134992274d), new NpgsqlTypes.NpgsqlPoint(x: 0.434480513041832d, y: 0.8342254099555849d), new NpgsqlTypes.NpgsqlPoint(x: 0.3157337438299431d, y: 0.8006026880514419d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8032187295285269d, y: 0.6869106909027793d), new NpgsqlTypes.NpgsqlPoint(x: 0.36340915291060616d, y: 0.5794996368914979d), new NpgsqlTypes.NpgsqlPoint(x: 0.14286523090508885d, y: 0.2655477162022628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19031125742041077d, y: 0.3264826683495159d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302080299001537d, y: 0.9395560322457762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349814667902528d, y: 0.689197868437859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3878212566768374d, y: 0.37909272421402984d), new NpgsqlTypes.NpgsqlPoint(x: 0.41162192801688235d, y: 0.14528691982039266d), new NpgsqlTypes.NpgsqlPoint(x: 0.670337412357431d, y: 0.6902131449705139d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10069077513462621d, y: 0.6623320607167708d), new NpgsqlTypes.NpgsqlPoint(x: 0.35330303175727196d, y: 0.46019501156119014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557583865368093d, y: 0.5308613106826064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8446305027034894d, y: 0.4929431451848906d), new NpgsqlTypes.NpgsqlPoint(x: 0.05114347118405882d, y: 0.8300901096668091d), new NpgsqlTypes.NpgsqlPoint(x: 0.39741387897457325d, y: 0.4551607262471844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6763701159330399d, y: 0.4524832599311982d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818519508088734d, y: 0.772288770619622d), new NpgsqlTypes.NpgsqlPoint(x: 0.24186895017446286d, y: 0.28420823675967544d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24716507244448582d, y: 0.879167261506295d), new NpgsqlTypes.NpgsqlPoint(x: 0.0199566258860695d, y: 0.9952849598123268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231848155124889d, y: 0.6676164663062056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24085186174184814d, y: 0.6080803687896293d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992314570281088d, y: 0.3013877723451861d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988163639149472d, y: 0.4000785402151451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6425933100626813d, y: 0.5295849704540999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342687055104951d, y: 0.16611635786207946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4790874822599659d, y: 0.34152684941691647d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8358275091684793d, y: 0.6243351865847151d), new NpgsqlTypes.NpgsqlPoint(x: 0.990255947427355d, y: 0.8705014321018559d), new NpgsqlTypes.NpgsqlPoint(x: 0.09172455416962755d, y: 0.7842625292764022d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8772373187382023d, y: 0.34064114991754824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938183231124662d, y: 0.4276062689412399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606491078159441d, y: 0.8970515762482102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5919288780907658d, y: 0.21038522450647068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331472509789325d, y: 0.6451498428077304d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177275165036939d, y: 0.5638136545005451d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22268263433700553d, y: 0.38646917814586756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852177153214111d, y: 0.1383021198171025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021062755095248d, y: 0.7440763734545232d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7900279867943419d, y: 0.7669684073494308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204769518810159d, y: 0.3077735313552541d), new NpgsqlTypes.NpgsqlPoint(x: 0.22913109083189032d, y: 0.9470808473421803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43141619651584695d, y: 0.3317404338466894d), new NpgsqlTypes.NpgsqlPoint(x: 0.601047080181369d, y: 0.9701159767891471d), new NpgsqlTypes.NpgsqlPoint(x: 0.11150859608742925d, y: 0.45010990961486586d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44121068254472884d, y: 0.9328321535160065d), new NpgsqlTypes.NpgsqlPoint(x: 0.39150419087137545d, y: 0.3376018292316928d), new NpgsqlTypes.NpgsqlPoint(x: 0.7297763432603505d, y: 0.2265541022009505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39486265731218406d, y: 0.5041588687295032d), new NpgsqlTypes.NpgsqlPoint(x: 0.11410647544405117d, y: 0.9160556944299483d), new NpgsqlTypes.NpgsqlPoint(x: 0.627995220765146d, y: 0.4239357384730106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004730445597233901d, y: 0.723823928250557d), new NpgsqlTypes.NpgsqlPoint(x: 0.024840795901927892d, y: 0.8219645885118362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8478707458393117d, y: 0.1695290342212329d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4981184856064196d, y: 0.8720116074730666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4232381763844769d, y: 0.669378164541913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339202451815091d, y: 0.7475442944698921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3626142376325967d, y: 0.24283278115785123d), new NpgsqlTypes.NpgsqlPoint(x: 0.1749351859557663d, y: 0.04471080875343192d), new NpgsqlTypes.NpgsqlPoint(x: 0.1853968099519362d, y: 0.7833377274719672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6394142553564233d, y: 0.895873530723462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367008263606156d, y: 0.623915355833134d), new NpgsqlTypes.NpgsqlPoint(x: 0.919271617857463d, y: 0.8779902897729714d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3706578486204356d, y: 0.3475849649324434d), new NpgsqlTypes.NpgsqlPoint(x: 0.31905397300650307d, y: 0.7508013784241656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202356480338827d, y: 0.8345761320940948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8313212714728733d, y: 0.9974687255939024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2447536637760357d, y: 0.4431295345281707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995425607834961d, y: 0.49805929286464046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36998924487277585d, y: 0.8967496094794103d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399381530199429d, y: 0.9225672043522354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706344465447556d, y: 0.5316577477984378d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4158060911564496d, y: 0.6821274685802492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7233832432142383d, y: 0.7099701391796138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6867594160814181d, y: 0.9322008363239045d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6742572284785148d, y: 0.25467486173897813d), new NpgsqlTypes.NpgsqlPoint(x: 0.13300302080293824d, y: 0.5327282687711179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760649434537125d, y: 0.2447783142838934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6310788597708307d, y: 0.4311717530369161d), new NpgsqlTypes.NpgsqlPoint(x: 0.28511093355833905d, y: 0.0791463321236261d), new NpgsqlTypes.NpgsqlPoint(x: 0.05371349728470942d, y: 0.5690196366301611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3786409449238456d, y: 0.24820068922679106d), new NpgsqlTypes.NpgsqlPoint(x: 0.06687533938487933d, y: 0.14660303807325892d), new NpgsqlTypes.NpgsqlPoint(x: 0.05240367917982147d, y: 0.6116130004397132d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23801172926962055d, y: 0.3047053969142439d), new NpgsqlTypes.NpgsqlPoint(x: 0.3313102198451314d, y: 0.04300258823484859d), new NpgsqlTypes.NpgsqlPoint(x: 0.05122082329250188d, y: 0.16646455611177602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05579951207234424d, y: 0.28234440994033605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869414642934738d, y: 0.459784317524624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339909075529769d, y: 0.415713854660961d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54878285422933d, y: 0.4083837113686518d), new NpgsqlTypes.NpgsqlPoint(x: 0.988669967144508d, y: 0.8852451071889805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318979433458208d, y: 0.11354516989187269d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9229747182033513d, y: 0.7529141182449642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916915001704472d, y: 0.9629309486599648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461252348313939d, y: 0.9313999146669234d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7539088543901578d, y: 0.7771059668303327d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016591716392001d, y: 0.283936716920254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531704696574709d, y: 0.13492624090563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12910304165792152d, y: 0.24709999563600793d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600205082040368d, y: 0.16970846779226811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168739141542015d, y: 0.3741270761317286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5198344929993057d, y: 0.39638782108849946d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633314447130481d, y: 0.023181619464873404d), new NpgsqlTypes.NpgsqlPoint(x: 0.4800331053096738d, y: 0.13994049000526498d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6831729361484464d, y: 0.13134702424396738d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486151367750058d, y: 0.4983765825594938d), new NpgsqlTypes.NpgsqlPoint(x: 0.056536270060481675d, y: 0.922898169791016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26900588827785643d, y: 0.2783201498218473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421669324939664d, y: 0.5776827372707644d), new NpgsqlTypes.NpgsqlPoint(x: 0.78072411365096d, y: 0.015457788261458716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022658184211230226d, y: 0.28994163968628495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573640491009793d, y: 0.13444463352278557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9866531398842651d, y: 0.4397179287876365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5252269086373517d, y: 0.9340377632825828d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692040778864364d, y: 0.7878707272318791d), new NpgsqlTypes.NpgsqlPoint(x: 0.28550111414777635d, y: 0.09420483721942419d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13998929776620495d, y: 0.08286168781629111d), new NpgsqlTypes.NpgsqlPoint(x: 0.39979100072062934d, y: 0.8348481812515941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711144524229867d, y: 0.40469176000948404d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3020972089376973d, y: 0.1820390611263264d), new NpgsqlTypes.NpgsqlPoint(x: 0.0222251690898998d, y: 0.23733532118256218d), new NpgsqlTypes.NpgsqlPoint(x: 0.2811547687296174d, y: 0.17770743286461266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01333391072019019d, y: 0.12778405981892682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758701823745387d, y: 0.39355221522595674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635084165571618d, y: 0.9626664895903251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.641805822698629d, y: 0.2876301642140666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153776523456533d, y: 0.30566183242152833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8311074542584417d, y: 0.22226107218308155d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48278518184426644d, y: 0.510136863535634d), new NpgsqlTypes.NpgsqlPoint(x: 0.33873097540483144d, y: 0.4610272270063366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7666278768538208d, y: 0.49090744726590907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30656219134285545d, y: 0.7629772910037749d), new NpgsqlTypes.NpgsqlPoint(x: 0.0762440187897575d, y: 0.366956065246686d), new NpgsqlTypes.NpgsqlPoint(x: 0.18387379304595852d, y: 0.4364856934904049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20444491336925608d, y: 0.4678449643052758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8365471116212334d, y: 0.26942372000757764d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204508594772026d, y: 0.20243008438584298d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43784565648533913d, y: 0.6611815438474922d), new NpgsqlTypes.NpgsqlPoint(x: 0.2487031304039875d, y: 0.6141794273702444d), new NpgsqlTypes.NpgsqlPoint(x: 0.536632037796466d, y: 0.4687390623095232d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3554039010070029d, y: 0.42648253041525175d), new NpgsqlTypes.NpgsqlPoint(x: 0.031818027027298856d, y: 0.5125993359280193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8300871610220338d, y: 0.49861419730499823d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23328448806269764d, y: 0.2814800399667372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219532716627963d, y: 0.4130327277819892d), new NpgsqlTypes.NpgsqlPoint(x: 0.30805551119868635d, y: 0.3387291085713615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8822549340392457d, y: 0.14334051237405754d), new NpgsqlTypes.NpgsqlPoint(x: 0.659383507603253d, y: 0.7203004179131423d), new NpgsqlTypes.NpgsqlPoint(x: 0.0658384769511624d, y: 0.8176321848233213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49262072069806373d, y: 0.5134261861935747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512039467408703d, y: 0.14992662282166946d), new NpgsqlTypes.NpgsqlPoint(x: 0.18967933228700673d, y: 0.18030682301947654d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.91348817988092d, y: 0.7902904506840718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6652687811056608d, y: 0.7045747971424281d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730734361171608d, y: 0.850147022881656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8220597773204918d, y: 0.16958977051418644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565565253211345d, y: 0.4477974951827607d), new NpgsqlTypes.NpgsqlPoint(x: 0.17211742156376553d, y: 0.7380088970334218d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12481298937417773d, y: 0.16590995775728545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741308416522704d, y: 0.28555139379648287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429088891053657d, y: 0.1569805114161511d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5912703795187896d, y: 0.18314488434356402d), new NpgsqlTypes.NpgsqlPoint(x: 0.2154448337839957d, y: 0.5699837350480071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785356966166834d, y: 0.376546778200918d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33169328834793543d, y: 0.3415224497561773d), new NpgsqlTypes.NpgsqlPoint(x: 0.025689520911905683d, y: 0.5672274358151203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998158731700058d, y: 0.9341165143750597d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3077578118893526d, y: 0.563589154349982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201399600706993d, y: 0.01588262245443195d), new NpgsqlTypes.NpgsqlPoint(x: 0.883486203885124d, y: 0.82602704507405d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32367277708372877d, y: 0.654968630276306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315769886965536d, y: 0.6619710901302065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159270396100934d, y: 0.3293687794630763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06100685220236812d, y: 0.768566808360444d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223646337513983d, y: 0.6622159569760314d), new NpgsqlTypes.NpgsqlPoint(x: 0.06517630697836663d, y: 0.3519738282246687d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43336551187672023d, y: 0.5836049836663642d), new NpgsqlTypes.NpgsqlPoint(x: 0.637454677218128d, y: 0.06167613421311502d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775251098872548d, y: 0.087571577010788d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8765153948436246d, y: 0.3051047734202431d), new NpgsqlTypes.NpgsqlPoint(x: 0.19882944307077732d, y: 0.7828361691003106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806831747726063d, y: 0.8332987207926091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7409007170826005d, y: 0.813446624695649d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129899607765069d, y: 0.815086555913051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5372494299134226d, y: 0.38814813822979d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9609017691333118d, y: 0.8045690429053513d), new NpgsqlTypes.NpgsqlPoint(x: 0.13551197909982526d, y: 0.30077993560031147d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434636565060475d, y: 0.5324143163299138d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9846353371282055d, y: 0.8734726375712853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7355262123039223d, y: 0.6809714493643032d), new NpgsqlTypes.NpgsqlPoint(x: 0.1374601627215536d, y: 0.1778001352777766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4104393658050347d, y: 0.7152112428526191d), new NpgsqlTypes.NpgsqlPoint(x: 0.2042559804447449d, y: 0.5707025320179359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227159864840953d, y: 0.7894678785881507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012028415559211192d, y: 0.03757166254168476d), new NpgsqlTypes.NpgsqlPoint(x: 0.28084967946227246d, y: 0.17719018612519455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417212497306748d, y: 0.19588708095127094d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7223355134847146d, y: 0.7523214211294986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9109204124538178d, y: 0.5313000460209211d), new NpgsqlTypes.NpgsqlPoint(x: 0.8873943769791723d, y: 0.976611274803961d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8807695732867352d, y: 0.4664102078134186d), new NpgsqlTypes.NpgsqlPoint(x: 0.33627829425961775d, y: 0.5430689100609172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013408533123868d, y: 0.655101659095136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20993756821211673d, y: 0.07640738362966581d), new NpgsqlTypes.NpgsqlPoint(x: 0.7125080073374513d, y: 0.9750103228393882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492467969351159d, y: 0.5370574787190393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3680735807829566d, y: 0.9347198062268153d), new NpgsqlTypes.NpgsqlPoint(x: 0.07085117655325468d, y: 0.7025627360413127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076474722417034d, y: 0.3247378113159861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21467425559424247d, y: 0.07585536708834217d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542373496671889d, y: 0.4680370616305114d), new NpgsqlTypes.NpgsqlPoint(x: 0.10678006393979522d, y: 0.9126011834708212d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8540281003916751d, y: 0.8408975955839375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4850008407222721d, y: 0.08085885816716654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121279243312679d, y: 0.1891196317085584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007851948882917625d, y: 0.5688297900694889d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739505893759847d, y: 0.04574504166887616d), new NpgsqlTypes.NpgsqlPoint(x: 0.11572756398836725d, y: 0.8761313368417892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3743444314295493d, y: 0.5255365886308895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769921550687022d, y: 0.06481770370070905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8146574385079598d, y: 0.9151687006271095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3456211750160515d, y: 0.9199203718191392d), new NpgsqlTypes.NpgsqlPoint(x: 0.13794532386376623d, y: 0.059328434377370565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060052196564065d, y: 0.3176711444533755d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7864455988192698d, y: 0.5466027353796089d), new NpgsqlTypes.NpgsqlPoint(x: 0.7292894811969172d, y: 0.9226951487513821d), new NpgsqlTypes.NpgsqlPoint(x: 0.635667466295149d, y: 0.5631128107787807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22415382045790122d, y: 0.48266070353024626d), new NpgsqlTypes.NpgsqlPoint(x: 0.22489924592449606d, y: 0.7045945079925134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388824784911932d, y: 0.42740234321311865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7686298856218499d, y: 0.8878421489601016d), new NpgsqlTypes.NpgsqlPoint(x: 0.01286649281464003d, y: 0.3903640393295421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289290366561162d, y: 0.6411316225213586d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12230827602266092d, y: 0.8677027067908191d), new NpgsqlTypes.NpgsqlPoint(x: 0.15884445312686313d, y: 0.8701136955634927d), new NpgsqlTypes.NpgsqlPoint(x: 0.1451699824654057d, y: 0.5229027399125671d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8153653763994334d, y: 0.46680614687857624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170748063743213d, y: 0.844946067131043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466293763246645d, y: 0.08332324881884812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019275779704151508d, y: 0.4067803747504737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5820289534532148d, y: 0.07173837150632922d), new NpgsqlTypes.NpgsqlPoint(x: 0.1321130604179852d, y: 0.06651856608818585d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10267588227550106d, y: 0.6992018686292915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365200254867838d, y: 0.06696553709788688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363476747787514d, y: 0.6247322177788693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.054706812414162975d, y: 0.17150399629165902d), new NpgsqlTypes.NpgsqlPoint(x: 0.3155748515544119d, y: 0.12858028388504128d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841671159607596d, y: 0.1302053301088988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8187920828004269d, y: 0.9038877090980844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846906118097993d, y: 0.19308676772592726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807798693244774d, y: 0.9903782558147238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.910018684798675d, y: 0.017362579900282782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508631999664423d, y: 0.8410676405528152d), new NpgsqlTypes.NpgsqlPoint(x: 0.7632421130704071d, y: 0.2665604219430213d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.514262692144724d, y: 0.5355338853999122d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528383059395496d, y: 0.2354902699856971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601187538719721d, y: 0.9002078015488932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18135644866600864d, y: 0.862252191845633d), new NpgsqlTypes.NpgsqlPoint(x: 0.044885199697691225d, y: 0.7888736223594606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9648976591875617d, y: 0.6325043179776701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4652102239968514d, y: 0.1342705366520045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4539889524155555d, y: 0.5773105058022111d), new NpgsqlTypes.NpgsqlPoint(x: 0.673501348904658d, y: 0.5978698942891771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4029495171185866d, y: 0.8689915359821979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886514327110846d, y: 0.34707940449317076d), new NpgsqlTypes.NpgsqlPoint(x: 0.031029760493003877d, y: 0.7887580668685324d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2564823393266944d, y: 0.55994809498116d), new NpgsqlTypes.NpgsqlPoint(x: 0.6749317530345248d, y: 0.41776780476954356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431993779593274d, y: 0.9800805654899467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7870005479715889d, y: 0.4128812836059138d), new NpgsqlTypes.NpgsqlPoint(x: 0.995643016506323d, y: 0.9443611196165944d), new NpgsqlTypes.NpgsqlPoint(x: 0.003957647675262077d, y: 0.11171031076179139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838682309381225d, y: 0.8702947941394337d), new NpgsqlTypes.NpgsqlPoint(x: 0.1851876549005932d, y: 0.8960148534581874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573965444850187d, y: 0.30847688304416476d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6086105321285125d, y: 0.6158729061256473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9083497527757491d, y: 0.24438806559796433d), new NpgsqlTypes.NpgsqlPoint(x: 0.17294556211586776d, y: 0.5509213871687452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104373608163817d, y: 0.13473039906773854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8843931660075728d, y: 0.43447251030450207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948228319673115d, y: 0.14867122610366212d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7180305358105077d, y: 0.07633813200081752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674796151270465d, y: 0.8505498039308649d), new NpgsqlTypes.NpgsqlPoint(x: 0.062186695441373785d, y: 0.6227928025609994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9736793025341067d, y: 0.3110473363820436d), new NpgsqlTypes.NpgsqlPoint(x: 0.05586229290538414d, y: 0.683844954262924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4917994119925114d, y: 0.11612933899854616d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3486952200867659d, y: 0.7506852270011135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549803532478394d, y: 0.6376819885789881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075097392379206d, y: 0.779916772624511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6541255373813385d, y: 0.6016786332144192d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302950530969138d, y: 0.9208069174130058d), new NpgsqlTypes.NpgsqlPoint(x: 0.05302425434458291d, y: 0.3069507478084461d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311156354666128d, y: 0.33837845495517727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6633075641822177d, y: 0.7749891226327512d), new NpgsqlTypes.NpgsqlPoint(x: 0.4099548767283562d, y: 0.7705571635161306d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7327355682133992d, y: 0.2716274878647379d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207381969268654d, y: 0.9431717235462599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248684730124799d, y: 0.6881082559852703d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7490181372860686d, y: 0.13914609961646962d), new NpgsqlTypes.NpgsqlPoint(x: 0.568349395643143d, y: 0.7279131662199518d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363823120923568d, y: 0.4775290231753013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8023791816478211d, y: 0.7962039184078155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8309390828172347d, y: 0.9337097355298296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789755869603526d, y: 0.3559486800856265d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32828177216463483d, y: 0.7413446795951354d), new NpgsqlTypes.NpgsqlPoint(x: 0.2076437710577308d, y: 0.6960822731429209d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573118721991386d, y: 0.2126558595214333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45814636547472065d, y: 0.9215675055177415d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913162383532305d, y: 0.33102796179015936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4653724807286008d, y: 0.8636069599600947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22017494190250553d, y: 0.12845798946438824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236409530515518d, y: 0.027606434244159317d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273107687563241d, y: 0.32120308056880076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7782429529300932d, y: 0.14326483400392642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945623340444139d, y: 0.5542320931964672d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418588671115238d, y: 0.9301531127696769d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7792685030427138d, y: 0.4143170447003103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892806996939507d, y: 0.7644345170765384d), new NpgsqlTypes.NpgsqlPoint(x: 0.3913957764335264d, y: 0.07252731955562708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020361210959780718d, y: 0.8649878415068859d), new NpgsqlTypes.NpgsqlPoint(x: 0.12655158343582984d, y: 0.4441033793380177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3297083732611813d, y: 0.36160261772926017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7267256350599117d, y: 0.9032160116505512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898442166592208d, y: 0.48044079657489946d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719633346110306d, y: 0.5645233320014242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04396656755706685d, y: 0.7377857130963434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540339885802945d, y: 0.2444304726778349d), new NpgsqlTypes.NpgsqlPoint(x: 0.1412600325174831d, y: 0.37271415806142794d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 23;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 142, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 104, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 142, query1, 13, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 35, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 122, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 110, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 24);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
FROM public.binary_npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI), typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

