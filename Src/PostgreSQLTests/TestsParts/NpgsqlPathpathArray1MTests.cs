

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02163238391289879d, y: 0.385883100476367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711875704771543d, y: 0.9626350037306428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5125210061392986d, y: 0.5731825045424505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1618693903180588d, y: 0.9453586816149109d), new NpgsqlTypes.NpgsqlPoint(x: 0.09103553487889193d, y: 0.3759881843059273d), new NpgsqlTypes.NpgsqlPoint(x: 0.48534801161528984d, y: 0.20264161239805423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9004997095478603d, y: 0.18260224735757336d), new NpgsqlTypes.NpgsqlPoint(x: 0.2975189750057742d, y: 0.9203132283313555d), new NpgsqlTypes.NpgsqlPoint(x: 0.24817074595165334d, y: 0.40766892403565436d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43050385128514d, y: 0.4891654108592417d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969650217749463d, y: 0.27463458097059623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2550785186788075d, y: 0.6520725899605496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8264044321544135d, y: 0.33279646363323934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747139550919666d, y: 0.34987718059535755d), new NpgsqlTypes.NpgsqlPoint(x: 0.17446043226078645d, y: 0.7254310443987837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6416781499261008d, y: 0.049179836450474856d), new NpgsqlTypes.NpgsqlPoint(x: 0.2050381976865574d, y: 0.49956727664340317d), new NpgsqlTypes.NpgsqlPoint(x: 0.29596674169773163d, y: 0.05737969859047831d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27607841882015294d, y: 0.6038321361835262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9008562439035679d, y: 0.5038135828585956d), new NpgsqlTypes.NpgsqlPoint(x: 0.02716037629186674d, y: 0.008035574696199976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5337532512145343d, y: 0.5923407592620186d), new NpgsqlTypes.NpgsqlPoint(x: 0.30719560297857984d, y: 0.19468134805213855d), new NpgsqlTypes.NpgsqlPoint(x: 0.24318395840723173d, y: 0.44264554828756886d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0158110976708824d, y: 0.542296480683562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663128209800058d, y: 0.38295170866047035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7393741515613304d, y: 0.2907219463621291d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6046945431250139d, y: 0.5042617330163152d), new NpgsqlTypes.NpgsqlPoint(x: 0.27441347758541135d, y: 0.7216163987998125d), new NpgsqlTypes.NpgsqlPoint(x: 0.21685534593029598d, y: 0.2154947836125708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.397587012322567d, y: 0.1138694346055249d), new NpgsqlTypes.NpgsqlPoint(x: 0.7438938857111905d, y: 0.47249975666122646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826068447679435d, y: 0.6441771681886672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8616546424963799d, y: 0.9579239509890833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617622340090471d, y: 0.6591112443782124d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457757134133974d, y: 0.5828646523369899d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29453809259325914d, y: 0.6295473614957479d), new NpgsqlTypes.NpgsqlPoint(x: 0.12437218579474385d, y: 0.7378878118866501d), new NpgsqlTypes.NpgsqlPoint(x: 0.726691502391927d, y: 0.27327601712032845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08561717361411947d, y: 0.4115519544545293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6711047124700728d, y: 0.7488090952988296d), new NpgsqlTypes.NpgsqlPoint(x: 0.13617052895752757d, y: 0.20324746504659774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7909338581572012d, y: 0.5985820521745963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305030084834868d, y: 0.18490240611154019d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859041830425525d, y: 0.5330016187585981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7255348712300063d, y: 0.3816933071800277d), new NpgsqlTypes.NpgsqlPoint(x: 0.20973629760194834d, y: 0.016365628042061875d), new NpgsqlTypes.NpgsqlPoint(x: 0.24494704654468713d, y: 0.6508292438272703d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3486526954925713d, y: 0.11532264805164472d), new NpgsqlTypes.NpgsqlPoint(x: 0.06699463859538224d, y: 0.9226244231747212d), new NpgsqlTypes.NpgsqlPoint(x: 0.9812930629801861d, y: 0.12705888464059956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3890805870773949d, y: 0.40087705785934036d), new NpgsqlTypes.NpgsqlPoint(x: 0.37823641687705867d, y: 0.916519459026069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513109546333657d, y: 0.672283632318022d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20743938457568845d, y: 0.2558480800175338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439455579326391d, y: 0.8199548479664803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786491858884703d, y: 0.7561536132245298d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5555611178127249d, y: 0.8725204572933261d), new NpgsqlTypes.NpgsqlPoint(x: 0.14019837155405024d, y: 0.3843369694995832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756311440762463d, y: 0.2839561746584808d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11235023542798905d, y: 0.7719074132941398d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173500826258665d, y: 0.9401229476750368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364496979337855d, y: 0.6047744503784811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7300728379424041d, y: 0.4743012288334857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913414734175308d, y: 0.9576142393243762d), new NpgsqlTypes.NpgsqlPoint(x: 0.20003414437341527d, y: 0.9627830986724412d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088857395925178d, y: 0.2527010916903931d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804489139507497d, y: 0.6457804483935683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652574903142695d, y: 0.56918207802813d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.881102084604237d, y: 0.21307150374366457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835972281017307d, y: 0.6117174913702379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142583593037722d, y: 0.9007909600728334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156579939065995d, y: 0.08647736832384845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3571900806632651d, y: 0.20247544532148187d), new NpgsqlTypes.NpgsqlPoint(x: 0.17048243580241618d, y: 0.4678431437344194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2469063465886847d, y: 0.7339407648281321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961952825070922d, y: 0.18548830037194264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569916263855327d, y: 0.7359799352304834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746122467041908d, y: 0.8196403864351137d), new NpgsqlTypes.NpgsqlPoint(x: 0.015675660380724432d, y: 0.22259284916254374d), new NpgsqlTypes.NpgsqlPoint(x: 0.040511987244955305d, y: 0.5366118448284469d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5779740773624705d, y: 0.43390805695621903d), new NpgsqlTypes.NpgsqlPoint(x: 0.741249045373555d, y: 0.849115395681866d), new NpgsqlTypes.NpgsqlPoint(x: 0.022787795199760486d, y: 0.8904186636765635d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5381709019167883d, y: 0.11993121169861842d), new NpgsqlTypes.NpgsqlPoint(x: 0.1812966354315717d, y: 0.6673245547332327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486101342989835d, y: 0.7088684036184718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9404787056112301d, y: 0.7545814082703312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656005611941556d, y: 0.9543446368024446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853520671375992d, y: 0.9391904431420272d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40663455977222196d, y: 0.7544534979474999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362630532619883d, y: 0.555610496116423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8697618377595969d, y: 0.5439265965368142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3806368100293507d, y: 0.9182745848838226d), new NpgsqlTypes.NpgsqlPoint(x: 0.4903319404405728d, y: 0.40033772558616665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295444882471993d, y: 0.09629448651252392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05134850248278222d, y: 0.5465214311656901d), new NpgsqlTypes.NpgsqlPoint(x: 0.729368369124573d, y: 0.6144289564479314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343323957418816d, y: 0.956817345250788d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5840638814985261d, y: 0.3952776523495103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7092772723316255d, y: 0.6274278275396991d), new NpgsqlTypes.NpgsqlPoint(x: 0.14961562417997254d, y: 0.6356506072977683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6270082886605405d, y: 0.30513020346825825d), new NpgsqlTypes.NpgsqlPoint(x: 0.16387557039319567d, y: 0.0030207772366881436d), new NpgsqlTypes.NpgsqlPoint(x: 0.3172847101747196d, y: 0.5812928578247414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54545787467685d, y: 0.6311772771542812d), new NpgsqlTypes.NpgsqlPoint(x: 0.39258622782722397d, y: 0.15198868791807596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640166955168376d, y: 0.6791097555141393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10897499946273881d, y: 0.2902357986733033d), new NpgsqlTypes.NpgsqlPoint(x: 0.013519334235799096d, y: 0.36267575259466533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726609915657907d, y: 0.8098307423741388d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.912216394387947d, y: 0.14435165404471972d), new NpgsqlTypes.NpgsqlPoint(x: 0.15501086534530606d, y: 0.5702200890755712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503410802822197d, y: 0.3360715940721982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3190950921330612d, y: 0.043571828138881386d), new NpgsqlTypes.NpgsqlPoint(x: 0.837303560467746d, y: 0.1045735483226572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3832062666871944d, y: 0.12933018700245746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8471330778766372d, y: 0.36717875736560923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08744890604656075d, y: 0.8364049861523297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735008058558573d, y: 0.1673398219109038d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26462203708462384d, y: 0.857364204921824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8705009110222487d, y: 0.1447785226748627d), new NpgsqlTypes.NpgsqlPoint(x: 0.48625353127129456d, y: 0.6722863987040965d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010748946219642064d, y: 0.5825237583410869d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827495389402252d, y: 0.5266123910434053d), new NpgsqlTypes.NpgsqlPoint(x: 0.25345928211269986d, y: 0.8270818342603956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.677234938109705d, y: 0.23976561799778895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595889665396911d, y: 0.0330876034830786d), new NpgsqlTypes.NpgsqlPoint(x: 0.9906115035124038d, y: 0.4636880574393176d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9968749584093254d, y: 0.5269186189858678d), new NpgsqlTypes.NpgsqlPoint(x: 0.367088984078058d, y: 0.9347437995593447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388463578997881d, y: 0.673323524088568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019227849141177145d, y: 0.1596838119190167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6336681038322896d, y: 0.9935640681447537d), new NpgsqlTypes.NpgsqlPoint(x: 0.43077665870005466d, y: 0.2523609632893219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3287907007081523d, y: 0.14835093224821383d), new NpgsqlTypes.NpgsqlPoint(x: 0.0029929457252878544d, y: 0.16993924055756437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704051049728985d, y: 0.7466885520924503d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7333152592909821d, y: 0.7754451847523205d), new NpgsqlTypes.NpgsqlPoint(x: 0.003908395574107715d, y: 0.7970461934273658d), new NpgsqlTypes.NpgsqlPoint(x: 0.4114778490858967d, y: 0.7911049609141988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9517063207103992d, y: 0.5830557621671618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8734745321251798d, y: 0.4013150024949498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107364523194366d, y: 0.12961579473572182d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20430795521969558d, y: 0.5392630230403854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8248628357360597d, y: 0.540013568258506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544907373206043d, y: 0.8712320722675749d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21368363369232013d, y: 0.017767706701983688d), new NpgsqlTypes.NpgsqlPoint(x: 0.43226306122540736d, y: 0.6865670137386122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805297608865593d, y: 0.21403479106319356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2976260246177137d, y: 0.25522552014319666d), new NpgsqlTypes.NpgsqlPoint(x: 0.06073550099884939d, y: 0.7752013106705259d), new NpgsqlTypes.NpgsqlPoint(x: 0.42311787982617466d, y: 0.01106115407154784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8319118962555959d, y: 0.7752294517999957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1772747700763152d, y: 0.4850088314705363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500589891757588d, y: 0.07616988558697879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3073470731450264d, y: 0.7600809920222893d), new NpgsqlTypes.NpgsqlPoint(x: 0.4337591234974828d, y: 0.6462026920037252d), new NpgsqlTypes.NpgsqlPoint(x: 0.614515102688985d, y: 0.4415040399180048d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12637579639580887d, y: 0.6630208375981929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3668160960455604d, y: 0.10149112359305279d), new NpgsqlTypes.NpgsqlPoint(x: 0.25393234068562986d, y: 0.3780269036094468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5792458262446505d, y: 0.056389268821076866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134911685960876d, y: 0.6196458540413948d), new NpgsqlTypes.NpgsqlPoint(x: 0.30502984575679126d, y: 0.8263598211155424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11315766591961307d, y: 0.4971085120180143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357650186673848d, y: 0.20029460155360024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704268596123571d, y: 0.25027146416621937d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4067608674448412d, y: 0.16582484754397875d), new NpgsqlTypes.NpgsqlPoint(x: 0.10698620899939493d, y: 0.9945000469605809d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345037245298058d, y: 0.7852466108271675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5660191350854868d, y: 0.8495374198995985d), new NpgsqlTypes.NpgsqlPoint(x: 0.44660793167751267d, y: 0.1445309393805494d), new NpgsqlTypes.NpgsqlPoint(x: 0.31318768251352513d, y: 0.15927155798996717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5244428343346429d, y: 0.393451450755956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3337184592659366d, y: 0.19861894288060733d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876258615736861d, y: 0.15130587039125964d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44150382631190976d, y: 0.8882401744213347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165327191165655d, y: 0.9014356596610769d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109228933903247d, y: 0.5242131255329838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9842236838783912d, y: 0.43240718690961344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341461552573557d, y: 0.09071051210509529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167689016497778d, y: 0.6446633060117541d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0635385364748472d, y: 0.21630618094490794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117752372655897d, y: 0.2627212474035945d), new NpgsqlTypes.NpgsqlPoint(x: 0.22333136448941882d, y: 0.8798236848204789d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5325951770827354d, y: 0.8177458530736796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954891653840799d, y: 0.07875291212583735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9688326138730831d, y: 0.13122353348374627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0026758643157487327d, y: 0.6661418367224524d), new NpgsqlTypes.NpgsqlPoint(x: 0.33635840125409255d, y: 0.6099906316402103d), new NpgsqlTypes.NpgsqlPoint(x: 0.10564454547453517d, y: 0.2851348192616536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4886165666007444d, y: 0.9808462160938421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524879235104483d, y: 0.9914551416863209d), new NpgsqlTypes.NpgsqlPoint(x: 0.16336958537177948d, y: 0.036778243331372584d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09506616711001947d, y: 0.9032538723258411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865483298413349d, y: 0.7873714753302996d), new NpgsqlTypes.NpgsqlPoint(x: 0.672446004866361d, y: 0.7583968677369285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6342631101281042d, y: 0.04298016574566543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539340848308283d, y: 0.04134938309712621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616487995568163d, y: 0.6543619691345356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783287801138763d, y: 0.024927776373438904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6767922666543068d, y: 0.8441898516887698d), new NpgsqlTypes.NpgsqlPoint(x: 0.38544373675009413d, y: 0.7462309099033712d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44266976248344714d, y: 0.6081946037061623d), new NpgsqlTypes.NpgsqlPoint(x: 0.40203009183782623d, y: 0.1316511219832488d), new NpgsqlTypes.NpgsqlPoint(x: 0.09320849261206099d, y: 0.5442687268984696d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611870105690281d, y: 0.8062222176440961d), new NpgsqlTypes.NpgsqlPoint(x: 0.4917233560993185d, y: 0.44727123743944597d), new NpgsqlTypes.NpgsqlPoint(x: 0.20511605732074834d, y: 0.7078613201428627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.695123639581157d, y: 0.38560085229245133d), new NpgsqlTypes.NpgsqlPoint(x: 0.951908020603928d, y: 0.6974480396026207d), new NpgsqlTypes.NpgsqlPoint(x: 0.9822567302024088d, y: 0.7564609202667025d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46125116504438124d, y: 0.7705831811921302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351350581559403d, y: 0.5778514348382054d), new NpgsqlTypes.NpgsqlPoint(x: 0.35140044943773796d, y: 0.5862882068498756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3653443538711858d, y: 0.08696009946408811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594166347054098d, y: 0.4909946048868895d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006045859674908005d, y: 0.03879043587127262d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8745151078027963d, y: 0.6399274967031994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7457588626154884d, y: 0.3714455954638163d), new NpgsqlTypes.NpgsqlPoint(x: 0.49159233311729145d, y: 0.08166850239490742d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37440021463761086d, y: 0.19499085240972336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850886817109632d, y: 0.7757070927926664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595761726402698d, y: 0.2901799619135548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7881990227117537d, y: 0.39683833429934723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137835142044103d, y: 0.4133961645789007d), new NpgsqlTypes.NpgsqlPoint(x: 0.1357931634326499d, y: 0.9684261559140475d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002820273491105252d, y: 0.03380894674414092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144844947478001d, y: 0.6644751654448192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080408792801073d, y: 0.9915033416613399d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37409498907040895d, y: 0.481943796184064d), new NpgsqlTypes.NpgsqlPoint(x: 0.83822928297718d, y: 0.11669278140832096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658562583796221d, y: 0.9579987118491092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982788422123462d, y: 0.40223186259758237d), new NpgsqlTypes.NpgsqlPoint(x: 0.10441897703036906d, y: 0.24247821423944582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352446670590417d, y: 0.9727425593507328d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3633777001277422d, y: 0.978201675134203d), new NpgsqlTypes.NpgsqlPoint(x: 0.9283948111413571d, y: 0.8543269658940176d), new NpgsqlTypes.NpgsqlPoint(x: 0.532055234796675d, y: 0.9760559731666117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6735399436222569d, y: 0.04551862102711912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999134824567089d, y: 0.7165081249778248d), new NpgsqlTypes.NpgsqlPoint(x: 0.18339235177265334d, y: 0.4986170091320292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9017275491967763d, y: 0.4390905567949053d), new NpgsqlTypes.NpgsqlPoint(x: 0.015390166281625262d, y: 0.7784716333096873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776799765981931d, y: 0.7658981750502836d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2926159954184827d, y: 0.43830858152617314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579536262037826d, y: 0.43687280263721395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454046547765626d, y: 0.07508419047258186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8102332306361887d, y: 0.5851183344055881d), new NpgsqlTypes.NpgsqlPoint(x: 0.04903576158866774d, y: 0.9923054010066285d), new NpgsqlTypes.NpgsqlPoint(x: 0.32353490407767227d, y: 0.3146373810734763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8754793199068134d, y: 0.2622211088231774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6658899049438992d, y: 0.6692497203639184d), new NpgsqlTypes.NpgsqlPoint(x: 0.34415789501030425d, y: 0.9000091859694148d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1149192845693936d, y: 0.7780276025387791d), new NpgsqlTypes.NpgsqlPoint(x: 0.23471861498730417d, y: 0.2853062765496943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7879158145893261d, y: 0.7702923808434534d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3521188108956277d, y: 0.5401580922389358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8797680188814233d, y: 0.25904323812886065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4710475260302903d, y: 0.22661217891440277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5480423482012395d, y: 0.9691269552292573d), new NpgsqlTypes.NpgsqlPoint(x: 0.1395418490599427d, y: 0.217985147443301d), new NpgsqlTypes.NpgsqlPoint(x: 0.43597847577594795d, y: 0.29853676148570385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47670958124688456d, y: 0.041890950592072485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477866371550865d, y: 0.6910271776054197d), new NpgsqlTypes.NpgsqlPoint(x: 0.931252454831455d, y: 0.21909092658305573d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.99122891953281d, y: 0.00886726956795536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391819815373624d, y: 0.5497922493856642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590146009525623d, y: 0.6919693305196674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1736607039044169d, y: 0.7870029647334956d), new NpgsqlTypes.NpgsqlPoint(x: 0.533617130429634d, y: 0.07887929506159941d), new NpgsqlTypes.NpgsqlPoint(x: 0.06877259609058461d, y: 0.6404981440110192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.503092633395232d, y: 0.1789888561365237d), new NpgsqlTypes.NpgsqlPoint(x: 0.30257896291617714d, y: 0.7900903655460819d), new NpgsqlTypes.NpgsqlPoint(x: 0.4787982892534176d, y: 0.9555482477031773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8978286612650194d, y: 0.6811150724611132d), new NpgsqlTypes.NpgsqlPoint(x: 0.30741146775374906d, y: 0.5769867799711481d), new NpgsqlTypes.NpgsqlPoint(x: 0.5273866340657922d, y: 0.8237323330212106d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5778947109877635d, y: 0.29427703437101227d), new NpgsqlTypes.NpgsqlPoint(x: 0.21471763644635578d, y: 0.8951026482607853d), new NpgsqlTypes.NpgsqlPoint(x: 0.08802380589083303d, y: 0.26134833203788077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4969083900705584d, y: 0.01771475327626071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006915331648218d, y: 0.1450787170939043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6034811987776559d, y: 0.8603341370116205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747477426218331d, y: 0.21725532851345386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777013144848397d, y: 0.23728317172139612d), new NpgsqlTypes.NpgsqlPoint(x: 0.08661302538405324d, y: 0.08424370758042576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28122368850590784d, y: 0.7434238024929413d), new NpgsqlTypes.NpgsqlPoint(x: 0.0634249045664671d, y: 0.7996347758100603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5005507258862028d, y: 0.3596638375150423d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19570092768595493d, y: 0.9766139184069794d), new NpgsqlTypes.NpgsqlPoint(x: 0.847997462899939d, y: 0.38390706165309174d), new NpgsqlTypes.NpgsqlPoint(x: 0.49549476049646013d, y: 0.5392376725216447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15980071943104945d, y: 0.12445382418387518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674910531223187d, y: 0.6042447588649517d), new NpgsqlTypes.NpgsqlPoint(x: 0.865033959627685d, y: 0.27700028042069724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04003153413027638d, y: 0.7483388710474413d), new NpgsqlTypes.NpgsqlPoint(x: 0.47332698106916493d, y: 0.6275985199012344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634550320511973d, y: 0.24313273178776296d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15357741783010614d, y: 0.12353353800675038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7540640594034271d, y: 0.01610738233847786d), new NpgsqlTypes.NpgsqlPoint(x: 0.2691003542415761d, y: 0.11943468742923913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.845230821583277d, y: 0.06231553134424295d), new NpgsqlTypes.NpgsqlPoint(x: 0.12658587578957092d, y: 0.6775946979586729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9715194402297305d, y: 0.9317519425190638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395672907600322d, y: 0.045122199141162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241294362331666d, y: 0.6678186078289952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816170708386605d, y: 0.35303707044739996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8980768975991575d, y: 0.20886580096481178d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680072378626359d, y: 0.7789641041563932d), new NpgsqlTypes.NpgsqlPoint(x: 0.021620977234804717d, y: 0.6393874464125718d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40446521357400167d, y: 0.1260577926160844d), new NpgsqlTypes.NpgsqlPoint(x: 0.2251568872222498d, y: 0.3000806906747202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274685764639155d, y: 0.0694387752281973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6794816325860351d, y: 0.34680201937827393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454749251446075d, y: 0.8523870776514444d), new NpgsqlTypes.NpgsqlPoint(x: 0.13868680803852618d, y: 0.8187438175263636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7285270266912958d, y: 0.6658296096356321d), new NpgsqlTypes.NpgsqlPoint(x: 0.05055058259210021d, y: 0.7734013366190732d), new NpgsqlTypes.NpgsqlPoint(x: 0.24151662732166645d, y: 0.24613561642002812d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11248319254115635d, y: 0.502326561854812d), new NpgsqlTypes.NpgsqlPoint(x: 0.4433490776636313d, y: 0.11641856384452876d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675633934316747d, y: 0.8842921933124119d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38900737109689576d, y: 0.4162068672749766d), new NpgsqlTypes.NpgsqlPoint(x: 0.753856337332492d, y: 0.9476634786282656d), new NpgsqlTypes.NpgsqlPoint(x: 0.792054846178904d, y: 0.519864399611565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20644792536792078d, y: 0.616915262898532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548514248745045d, y: 0.2953621651414339d), new NpgsqlTypes.NpgsqlPoint(x: 0.43206472663233453d, y: 0.33355357804482566d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47685854453837695d, y: 0.466518235891175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487341723713914d, y: 0.050667584168593516d), new NpgsqlTypes.NpgsqlPoint(x: 0.22125432499560926d, y: 0.9348956596704461d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5715737284400227d, y: 0.7970033333583689d), new NpgsqlTypes.NpgsqlPoint(x: 0.3631797725267377d, y: 0.7271145443765873d), new NpgsqlTypes.NpgsqlPoint(x: 0.2608246439257865d, y: 0.6649822392086483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05609783598307938d, y: 0.8169913109098829d), new NpgsqlTypes.NpgsqlPoint(x: 0.698280228936847d, y: 0.6886278504728165d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691163660334495d, y: 0.4581335685075354d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6149063038451751d, y: 0.4502335849122111d), new NpgsqlTypes.NpgsqlPoint(x: 0.11035035986936992d, y: 0.6435824878893412d), new NpgsqlTypes.NpgsqlPoint(x: 0.40782243205902324d, y: 0.8026521994066904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3572952151616203d, y: 0.20761769717839407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227169726180884d, y: 0.6231325975293509d), new NpgsqlTypes.NpgsqlPoint(x: 0.18462313635511152d, y: 0.12043790796192533d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7948681961486757d, y: 0.34695139887074733d), new NpgsqlTypes.NpgsqlPoint(x: 0.11314529188378863d, y: 0.6403666766383684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187366809514848d, y: 0.6062678171924848d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6832274051102797d, y: 0.987667066908675d), new NpgsqlTypes.NpgsqlPoint(x: 0.87502451918832d, y: 0.6919816188139742d), new NpgsqlTypes.NpgsqlPoint(x: 0.30587400057923086d, y: 0.3950911238193654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.808876461518307d, y: 0.7694434165702965d), new NpgsqlTypes.NpgsqlPoint(x: 0.042200879986545425d, y: 0.08038923703351064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799294560024458d, y: 0.7792903963916712d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4852287720527123d, y: 0.9941016864003217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9251357278422855d, y: 0.2686751711976475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717647084039824d, y: 0.27531085510847775d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9718662564536387d, y: 0.30954132648125143d), new NpgsqlTypes.NpgsqlPoint(x: 0.21026266952029538d, y: 0.462768880302625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135330914341619d, y: 0.8499384798362544d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5960898928873732d, y: 0.18648115886628802d), new NpgsqlTypes.NpgsqlPoint(x: 0.32287931790692614d, y: 0.6238835238668642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198022341725332d, y: 0.5926556264144603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31638277551150207d, y: 0.9702230224292044d), new NpgsqlTypes.NpgsqlPoint(x: 0.20984593554185516d, y: 0.46570374540141335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4288069422952804d, y: 0.9684897815403133d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49582325522448256d, y: 0.13607005114794402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7337329988513465d, y: 0.15941435083320088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7971106619943724d, y: 0.4684144105095408d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8912431097718096d, y: 0.6383062731209064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5743649641512746d, y: 0.2547908043979118d), new NpgsqlTypes.NpgsqlPoint(x: 0.13648618790379552d, y: 0.7897561651497074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6508561310253324d, y: 0.43878316336281376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827783268638371d, y: 0.942884362695824d), new NpgsqlTypes.NpgsqlPoint(x: 0.193264515296806d, y: 0.4263783367530255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169696360279888d, y: 0.24943312496398962d), new NpgsqlTypes.NpgsqlPoint(x: 0.15371418856606767d, y: 0.6837982877180148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551933589596147d, y: 0.14785867818234855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059603051763236436d, y: 0.812143090874937d), new NpgsqlTypes.NpgsqlPoint(x: 0.08238236203303995d, y: 0.7612504689551808d), new NpgsqlTypes.NpgsqlPoint(x: 0.727760902055686d, y: 0.9106097652265438d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806628129249842d, y: 0.9028345720213495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569754891225651d, y: 0.8689580126598532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385481444726631d, y: 0.5045788584601921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7585298500272971d, y: 0.4449397088549001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598155575712494d, y: 0.411333762696913d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059388186876456d, y: 0.06355308326699571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6309086522094647d, y: 0.7068500125389977d), new NpgsqlTypes.NpgsqlPoint(x: 0.22916576590896043d, y: 0.1809559346757066d), new NpgsqlTypes.NpgsqlPoint(x: 0.28199788171895224d, y: 0.24237167386493708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21893085058685313d, y: 0.915796928406651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149711943933337d, y: 0.6095159621461336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994814547164291d, y: 0.14842333198445046d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3788535542490242d, y: 0.4937523019266721d), new NpgsqlTypes.NpgsqlPoint(x: 0.2593640131412218d, y: 0.44955142118258684d), new NpgsqlTypes.NpgsqlPoint(x: 0.36914595217413915d, y: 0.9642443532103022d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21424030026887164d, y: 0.8509284182376786d), new NpgsqlTypes.NpgsqlPoint(x: 0.45756010360549404d, y: 0.7704646000668627d), new NpgsqlTypes.NpgsqlPoint(x: 0.4137145428833343d, y: 0.857946367440316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1645453677884915d, y: 0.9156888936039025d), new NpgsqlTypes.NpgsqlPoint(x: 0.11729635065623245d, y: 0.7004417762414611d), new NpgsqlTypes.NpgsqlPoint(x: 0.8534385316780848d, y: 0.46860992891816566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4117201930919052d, y: 0.8251808854410463d), new NpgsqlTypes.NpgsqlPoint(x: 0.2629615415416402d, y: 0.3685099353428053d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434815073838856d, y: 0.1892802813939145d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6378098003635175d, y: 0.16445037754300806d), new NpgsqlTypes.NpgsqlPoint(x: 0.985021407055251d, y: 0.30130989514145146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4644892427087818d, y: 0.12730351471576928d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051014120233282d, y: 0.8822914558602001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486124674772765d, y: 0.3171503458971716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826697933122204d, y: 0.5958043326146671d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2389392027051649d, y: 0.2446708204495851d), new NpgsqlTypes.NpgsqlPoint(x: 0.8106906566189583d, y: 0.2546612724619295d), new NpgsqlTypes.NpgsqlPoint(x: 0.19881360533152181d, y: 0.6872265022152475d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15753663751547675d, y: 0.8653081763253261d), new NpgsqlTypes.NpgsqlPoint(x: 0.19605196600269914d, y: 0.30124358600847023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8893391630411448d, y: 0.9699345445800589d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46121332830690853d, y: 0.45764766536257595d), new NpgsqlTypes.NpgsqlPoint(x: 0.14516778189651547d, y: 0.8346457549979482d), new NpgsqlTypes.NpgsqlPoint(x: 0.13134680032609025d, y: 0.42255666409943027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05100244647417518d, y: 0.19252272705160844d), new NpgsqlTypes.NpgsqlPoint(x: 0.12711354561429278d, y: 0.1731307427698474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861134484156725d, y: 0.9889744235296039d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8528184113006623d, y: 0.5874978241240723d), new NpgsqlTypes.NpgsqlPoint(x: 0.47369183603745524d, y: 0.8642962212113099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8190403405361418d, y: 0.8467678388169511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41836397847671913d, y: 0.7175230015441424d), new NpgsqlTypes.NpgsqlPoint(x: 0.8937673578937899d, y: 0.6189273437497818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645559829393107d, y: 0.48476249252588255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.930293136356861d, y: 0.5434049859772637d), new NpgsqlTypes.NpgsqlPoint(x: 0.902557679385108d, y: 0.8548438683673656d), new NpgsqlTypes.NpgsqlPoint(x: 0.2642989436976442d, y: 0.010493597456694204d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.795521177571869d, y: 0.49704832602228544d), new NpgsqlTypes.NpgsqlPoint(x: 0.352249496571417d, y: 0.7323152314409603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372440391368492d, y: 0.36060601550591564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04053454620553054d, y: 0.18781606029705744d), new NpgsqlTypes.NpgsqlPoint(x: 0.16677181675839858d, y: 0.3757628047523873d), new NpgsqlTypes.NpgsqlPoint(x: 0.005676680209632412d, y: 0.8523818121700771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6492982514833107d, y: 0.5255377109042766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207390289117828d, y: 0.7738390051413542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017602872918902d, y: 0.4654233217873829d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35773895956963275d, y: 0.7845064043565375d), new NpgsqlTypes.NpgsqlPoint(x: 0.749803550998914d, y: 0.44820289336071006d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528092924004598d, y: 0.58893378783824d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9999018076375458d, y: 0.5564216033519646d), new NpgsqlTypes.NpgsqlPoint(x: 0.197160190014125d, y: 0.6753618472378635d), new NpgsqlTypes.NpgsqlPoint(x: 0.6586816629925658d, y: 0.03691588010005553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32056369545708696d, y: 0.48572432162908186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495262093040394d, y: 0.5384721969647885d), new NpgsqlTypes.NpgsqlPoint(x: 0.035586974637752955d, y: 0.5856408338435919d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5290694376813873d, y: 0.6721343303755029d), new NpgsqlTypes.NpgsqlPoint(x: 0.29444626229875015d, y: 0.26484613324610384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881053352965213d, y: 0.5253585771129158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3473958485664884d, y: 0.9346313061546054d), new NpgsqlTypes.NpgsqlPoint(x: 0.562947130659051d, y: 0.07901602772924021d), new NpgsqlTypes.NpgsqlPoint(x: 0.043602753089420965d, y: 0.6558653873805925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6290813197118731d, y: 0.30197341141708967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378697034099263d, y: 0.5524934957830105d), new NpgsqlTypes.NpgsqlPoint(x: 0.15725378854993166d, y: 0.4049889137116397d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5784351460254086d, y: 0.658621211271305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342994091853231d, y: 0.019774609627527306d), new NpgsqlTypes.NpgsqlPoint(x: 0.69537691767748d, y: 0.1939539619704027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8062686401380562d, y: 0.8577872921450714d), new NpgsqlTypes.NpgsqlPoint(x: 0.26861984112960824d, y: 0.8795617965872827d), new NpgsqlTypes.NpgsqlPoint(x: 0.24047579414212095d, y: 0.5969514935807887d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9659765189067774d, y: 0.050742706313496866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341140064128847d, y: 0.0031351734553669575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632525944358531d, y: 0.5142829094003752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3242749347682006d, y: 0.6409139489452547d), new NpgsqlTypes.NpgsqlPoint(x: 0.08119217740858309d, y: 0.0031230466699401216d), new NpgsqlTypes.NpgsqlPoint(x: 0.10951752248106039d, y: 0.399461636052154d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41303697226628777d, y: 0.3817604677762758d), new NpgsqlTypes.NpgsqlPoint(x: 0.13566965454703273d, y: 0.37032622652001457d), new NpgsqlTypes.NpgsqlPoint(x: 0.29664758466712404d, y: 0.9814855475806377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45294133947710324d, y: 0.17426736896550798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370108808516943d, y: 0.29427294471039867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289705241223023d, y: 0.25640237145346567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46284945938470223d, y: 0.6091264768510093d), new NpgsqlTypes.NpgsqlPoint(x: 0.47170876242501103d, y: 0.8807445208007053d), new NpgsqlTypes.NpgsqlPoint(x: 0.604032565237692d, y: 0.02321961888376889d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2793392640217145d, y: 0.3001596948769968d), new NpgsqlTypes.NpgsqlPoint(x: 0.598008963928469d, y: 0.5234233743217417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871275006715643d, y: 0.49587407336147094d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4779728164893734d, y: 0.920486384326362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503853271113625d, y: 0.07178244093194142d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985548552484846d, y: 0.5009217028277637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2604413508996576d, y: 0.3146763322461057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859480612878089d, y: 0.6643213930073484d), new NpgsqlTypes.NpgsqlPoint(x: 0.20054775530402824d, y: 0.10596000662374361d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.307210612840899d, y: 0.6077026173356492d), new NpgsqlTypes.NpgsqlPoint(x: 0.381111878528004d, y: 0.3759851838946512d), new NpgsqlTypes.NpgsqlPoint(x: 0.0671273782915186d, y: 0.43991071837409434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19531822388068365d, y: 0.5222714082446968d), new NpgsqlTypes.NpgsqlPoint(x: 0.823979541400171d, y: 0.8353022243451844d), new NpgsqlTypes.NpgsqlPoint(x: 0.700876820776515d, y: 0.929684474360277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9422597012151633d, y: 0.9244945011831732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742371469965724d, y: 0.3378766060651929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173437194135342d, y: 0.0742414558164356d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40809544193210445d, y: 0.6217584832934376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690246458011185d, y: 0.0962889146596182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015334041410241d, y: 0.3332899121716222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5057294684494027d, y: 0.43402724099765555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8413966349199457d, y: 0.7093389298188153d), new NpgsqlTypes.NpgsqlPoint(x: 0.031211639615528863d, y: 0.007735902379683357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9264673755745048d, y: 0.4592407177433038d), new NpgsqlTypes.NpgsqlPoint(x: 0.788904371344982d, y: 0.13061199044607652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280526606133358d, y: 0.8163723163249897d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6211600229981287d, y: 0.3396233354823347d), new NpgsqlTypes.NpgsqlPoint(x: 0.16288970719860596d, y: 0.09119347588320437d), new NpgsqlTypes.NpgsqlPoint(x: 0.15113433391351072d, y: 0.20946887836565553d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4466674364822334d, y: 0.80030222917468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8742734794368046d, y: 0.6100526477002718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433978633254968d, y: 0.5413008965390425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08408157552370676d, y: 0.6336829999161615d), new NpgsqlTypes.NpgsqlPoint(x: 0.38174889900668196d, y: 0.33133131311182573d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660452251173394d, y: 0.08477604431713626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7113576005904656d, y: 0.12165366124650456d), new NpgsqlTypes.NpgsqlPoint(x: 0.3251767951664718d, y: 0.8213214744262836d), new NpgsqlTypes.NpgsqlPoint(x: 0.22203425669073973d, y: 0.08442797162985649d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3462209965399703d, y: 0.6633205971205558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4575422762728245d, y: 0.3190996980802523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813649063896597d, y: 0.6338966579609004d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8382052922401715d, y: 0.6450644274382369d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774430853759435d, y: 0.4410549935982926d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176480439137487d, y: 0.6141964335922799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4972162160987704d, y: 0.16674270773642685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996271986248393d, y: 0.08036224998864638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929162519275814d, y: 0.1399654082261057d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5261684071437955d, y: 0.3120215091488413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076671475079525d, y: 0.5037575111278888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553310902429335d, y: 0.999399305317378d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07515246162056011d, y: 0.33686794049675295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530972575495797d, y: 0.04699130794184192d), new NpgsqlTypes.NpgsqlPoint(x: 0.3649697108478036d, y: 0.6573890124872991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9834047841018663d, y: 0.8390480183459558d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877478859078173d, y: 0.7051785364946036d), new NpgsqlTypes.NpgsqlPoint(x: 0.11271527202179088d, y: 0.8108369633575031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18474349920779654d, y: 0.837534954706971d), new NpgsqlTypes.NpgsqlPoint(x: 0.23270430637084139d, y: 0.2367002200535938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390455321349438d, y: 0.7008590585499911d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9052323370008819d, y: 0.47748662543146003d), new NpgsqlTypes.NpgsqlPoint(x: 0.35119496883438295d, y: 0.4054278196719412d), new NpgsqlTypes.NpgsqlPoint(x: 0.3574747197722532d, y: 0.040669140463787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9030406717917457d, y: 0.08802232063266491d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071235632011139d, y: 0.7502442006889862d), new NpgsqlTypes.NpgsqlPoint(x: 0.28733884363257156d, y: 0.5879356650954446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39133054259213274d, y: 0.9004712864280648d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418617905369223d, y: 0.8517430587017942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699880665491206d, y: 0.0739445779390896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5505393455522493d, y: 0.033773103174812635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940179795301601d, y: 0.47681190316605104d), new NpgsqlTypes.NpgsqlPoint(x: 0.26528180815604874d, y: 0.8118216421355113d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7719222122642136d, y: 0.918155733074704d), new NpgsqlTypes.NpgsqlPoint(x: 0.008296235650253059d, y: 0.9651177744643095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852582106424191d, y: 0.9046751309068735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39259323147680814d, y: 0.8791567572267566d), new NpgsqlTypes.NpgsqlPoint(x: 0.13374866214703063d, y: 0.10267623351954935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743323377385824d, y: 0.7919903811128425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.270708682708402d, y: 0.20153312736279572d), new NpgsqlTypes.NpgsqlPoint(x: 0.18083933328503643d, y: 0.47963208646756117d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020397933875017094d, y: 0.216571771708569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7342644314763122d, y: 0.9860049665072556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614022371378148d, y: 0.420737689726149d), new NpgsqlTypes.NpgsqlPoint(x: 0.42000794308630784d, y: 0.5109823850199381d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5519940488540999d, y: 0.7963764062751757d), new NpgsqlTypes.NpgsqlPoint(x: 0.599997198096799d, y: 0.8857856350276545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888300202284065d, y: 0.8049435263874926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12050285052250997d, y: 0.8516410117727109d), new NpgsqlTypes.NpgsqlPoint(x: 0.29143540607462015d, y: 0.0890611430085052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232163464386748d, y: 0.22271231061588204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3751141509552339d, y: 0.3767910591705561d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781977139045173d, y: 0.1691204763530023d), new NpgsqlTypes.NpgsqlPoint(x: 0.13495569175746935d, y: 0.16857414794103298d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9578986578940214d, y: 0.5907068251996205d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077236415820183d, y: 0.49241447800839877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481755307792203d, y: 0.08686350693795741d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4740056788939082d, y: 0.1210890299576679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4130917634215554d, y: 0.7282323460011119d), new NpgsqlTypes.NpgsqlPoint(x: 0.61757631420545d, y: 0.9915625541474845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2014207786802925d, y: 0.7825236000638398d), new NpgsqlTypes.NpgsqlPoint(x: 0.011017737466104127d, y: 0.3675844454338085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139174103571818d, y: 0.5830915290471494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4111242604341868d, y: 0.7261901872693993d), new NpgsqlTypes.NpgsqlPoint(x: 0.43999868644723306d, y: 0.7207573579032766d), new NpgsqlTypes.NpgsqlPoint(x: 0.005826150708118205d, y: 0.4357008283007562d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9551475079402832d, y: 0.18986092209527616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7347613780289965d, y: 0.3389583186034162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9222628477495183d, y: 0.4446438473209954d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9304274629082002d, y: 0.915638479317798d), new NpgsqlTypes.NpgsqlPoint(x: 0.49496268104480323d, y: 0.01784179144096576d), new NpgsqlTypes.NpgsqlPoint(x: 0.17412823735578187d, y: 0.6032046036926472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1182413246517745d, y: 0.4700814825121623d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253427021069276d, y: 0.31413496527533735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409386804342962d, y: 0.8494857975603564d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3879291667645616d, y: 0.7006116959635862d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506999484708286d, y: 0.3065835346583775d), new NpgsqlTypes.NpgsqlPoint(x: 0.1981112026015157d, y: 0.30547804195105066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5818141802521213d, y: 0.8587026232270271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217446016957713d, y: 0.7407554743246157d), new NpgsqlTypes.NpgsqlPoint(x: 0.41191145301977816d, y: 0.47979490465220787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15220919519682852d, y: 0.0686814314662767d), new NpgsqlTypes.NpgsqlPoint(x: 0.36153061029435885d, y: 0.828868235496502d), new NpgsqlTypes.NpgsqlPoint(x: 0.2281384079002411d, y: 0.9319812522076096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691429639017777d, y: 0.8610167523424425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911307972348944d, y: 0.7234409485865456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757604278342324d, y: 0.055372895236663666d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38249358309613135d, y: 0.9254227145269743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259865275424528d, y: 0.7096321241938153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9842417029730666d, y: 0.39380640827346525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5980627378920288d, y: 0.0562330153424947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146773896677326d, y: 0.8931912647379142d), new NpgsqlTypes.NpgsqlPoint(x: 0.043504318360536476d, y: 0.388536060146654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9893475629810261d, y: 0.7332278320671306d), new NpgsqlTypes.NpgsqlPoint(x: 0.17714066286161056d, y: 0.878362171611088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211203324024685d, y: 0.1089287976400205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7580399336969733d, y: 0.22916503494942686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030609081328955012d, y: 0.4154747499570971d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791402707783132d, y: 0.8687066635588632d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20380566347990137d, y: 0.3108668463749592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190935036047286d, y: 0.07568898614627873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971894795403188d, y: 0.21675663320835092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21596032335906212d, y: 0.2306192038898558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757081737900341d, y: 0.9971813562934188d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962429034755434d, y: 0.9868219195516731d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5107364526481979d, y: 0.6196349341246385d), new NpgsqlTypes.NpgsqlPoint(x: 0.0682879383850784d, y: 0.504786804677207d), new NpgsqlTypes.NpgsqlPoint(x: 0.366180399955379d, y: 0.27456387993324893d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8031455700420684d, y: 0.7070768741666358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152725278388054d, y: 0.9250694986743446d), new NpgsqlTypes.NpgsqlPoint(x: 0.46696255783094887d, y: 0.7939725147032678d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.923927987197295d, y: 0.10827061059051946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968866525791869d, y: 0.4476384357756761d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238699191119181d, y: 0.6007030274627816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24680517417813452d, y: 0.561071053275538d), new NpgsqlTypes.NpgsqlPoint(x: 0.20570680332388103d, y: 0.06714537085504968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723014879854664d, y: 0.2451347237367808d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10236677238647007d, y: 0.14985202986066026d), new NpgsqlTypes.NpgsqlPoint(x: 0.17475306107656607d, y: 0.13652336887794625d), new NpgsqlTypes.NpgsqlPoint(x: 0.2801619926808121d, y: 0.7357421437553002d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9972020223339142d, y: 0.6683348975447274d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390059254752857d, y: 0.6300372839412905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940014701540755d, y: 0.6959928044803926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.867270597939664d, y: 0.030728483784751015d), new NpgsqlTypes.NpgsqlPoint(x: 0.1945654794505315d, y: 0.22473813853360203d), new NpgsqlTypes.NpgsqlPoint(x: 0.36567712968583865d, y: 0.27759369141068146d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5990544204286479d, y: 0.4274567265453847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308569748559636d, y: 0.9816492115864003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8666767071670327d, y: 0.7475940391373322d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23705092349094614d, y: 0.5874376185819467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9671979113688707d, y: 0.15071800091205123d), new NpgsqlTypes.NpgsqlPoint(x: 0.36625237407576616d, y: 0.9491629832618543d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1433317547856835d, y: 0.8293904217209553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5124766971480579d, y: 0.6175211852307072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217446711462238d, y: 0.5241809322334229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11009296413074277d, y: 0.1168341666036854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514060218985078d, y: 0.4936760910197302d), new NpgsqlTypes.NpgsqlPoint(x: 0.598110640070831d, y: 0.30206651792214556d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.001839049157153605d, y: 0.5481388501957092d), new NpgsqlTypes.NpgsqlPoint(x: 0.08283235260168476d, y: 0.10299020278218896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184877721720256d, y: 0.17529437846122142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27319955415088204d, y: 0.052080555007202545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920939646255334d, y: 0.834664124897372d), new NpgsqlTypes.NpgsqlPoint(x: 0.33144495707903054d, y: 0.6717405532558519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27244307159300674d, y: 0.5193032111630249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908034660968206d, y: 0.58441858255174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986688860593198d, y: 0.009903510553332606d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15805475314734752d, y: 0.7335565756026611d), new NpgsqlTypes.NpgsqlPoint(x: 0.40047696116177145d, y: 0.5211967404957426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656454952258655d, y: 0.047692142401526416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47432635295781134d, y: 0.7995827005894917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5743949424235453d, y: 0.47471757036413975d), new NpgsqlTypes.NpgsqlPoint(x: 0.32743477415650535d, y: 0.8812416274976422d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15399547839539662d, y: 0.5812869695776507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5854013065473698d, y: 0.5253010165028918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316009919792675d, y: 0.6143010509409709d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4208914917125264d, y: 0.07501944818475836d), new NpgsqlTypes.NpgsqlPoint(x: 0.44680451336756377d, y: 0.4006112263229895d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864427236636098d, y: 0.30006392643822544d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5459800034337757d, y: 0.475785133154338d), new NpgsqlTypes.NpgsqlPoint(x: 0.3896720685762277d, y: 0.08784264881370418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079333560783212d, y: 0.38701289671357997d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15942510877150107d, y: 0.2506044520682795d), new NpgsqlTypes.NpgsqlPoint(x: 0.22597236254073605d, y: 0.4460014362195198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198201339925548d, y: 0.9546468256366724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33060318908583475d, y: 0.8199406210556994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581617259505056d, y: 0.13806472893447896d), new NpgsqlTypes.NpgsqlPoint(x: 0.44808485740472426d, y: 0.8814083342224739d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5351650176540704d, y: 0.5920062242099542d), new NpgsqlTypes.NpgsqlPoint(x: 0.08716371801564637d, y: 0.914308347566979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875114926890847d, y: 0.8558375862069457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28876213710403975d, y: 0.9446100313657894d), new NpgsqlTypes.NpgsqlPoint(x: 0.371077100693222d, y: 0.2661902311029184d), new NpgsqlTypes.NpgsqlPoint(x: 0.12586804618064995d, y: 0.5981615665741733d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3844531958377332d, y: 0.8986052848494568d), new NpgsqlTypes.NpgsqlPoint(x: 0.4884919760456574d, y: 0.9845173679396592d), new NpgsqlTypes.NpgsqlPoint(x: 0.16130720373871998d, y: 0.21183688192642514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8146111487404899d, y: 0.40680357677856227d), new NpgsqlTypes.NpgsqlPoint(x: 0.19794030743549096d, y: 0.9081529324065982d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198394038908569d, y: 0.0423556893559317d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8561785789128586d, y: 0.018945301601152598d), new NpgsqlTypes.NpgsqlPoint(x: 0.055127388495165075d, y: 0.9268023035559404d), new NpgsqlTypes.NpgsqlPoint(x: 0.31132391174561336d, y: 0.11159456881227137d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6885473886074881d, y: 0.39051972879983343d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605679713574004d, y: 0.6789512313886029d), new NpgsqlTypes.NpgsqlPoint(x: 0.27768116798970255d, y: 0.6092342256455502d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7224107155892134d, y: 0.050095892785881335d), new NpgsqlTypes.NpgsqlPoint(x: 0.022440645543682303d, y: 0.6576027123479287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7947144566466883d, y: 0.536799670971932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6303693011323585d, y: 0.6717793710417301d), new NpgsqlTypes.NpgsqlPoint(x: 0.982337597060229d, y: 0.435460256637884d), new NpgsqlTypes.NpgsqlPoint(x: 0.08434365709060498d, y: 0.7368541152458836d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2834450827794698d, y: 0.32979564401595673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988477171849137d, y: 0.9132724912384793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4902809403373417d, y: 0.7165359856650666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03460445414968394d, y: 0.20339086672529905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6338310644935479d, y: 0.31626480187018036d), new NpgsqlTypes.NpgsqlPoint(x: 0.08014050746394197d, y: 0.2551835599901151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8103108901187096d, y: 0.7724617161268618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5743108306705356d, y: 0.6098762579448977d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389038866826024d, y: 0.33876918603586026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34664489062208603d, y: 0.4003765213483269d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928113081885034d, y: 0.9770436713989952d), new NpgsqlTypes.NpgsqlPoint(x: 0.1057615640963514d, y: 0.0032836217444095483d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.566635846311486d, y: 0.1957038652160492d), new NpgsqlTypes.NpgsqlPoint(x: 0.42450726643517944d, y: 0.6843276707849957d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446703847364133d, y: 0.06598791296159745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.144664048502529d, y: 0.44863209123078596d), new NpgsqlTypes.NpgsqlPoint(x: 0.06895632232465143d, y: 0.4331972507058375d), new NpgsqlTypes.NpgsqlPoint(x: 0.35255287818633374d, y: 0.9440806931559834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8260138699453933d, y: 0.7095715886257613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283587718530275d, y: 0.44361144739895864d), new NpgsqlTypes.NpgsqlPoint(x: 0.012125555974318636d, y: 0.16587398660048724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48479513398483154d, y: 0.1558041728406231d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305961819365494d, y: 0.1674301199290018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701269076887895d, y: 0.12332671641467574d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4273605193411729d, y: 0.615076348525587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652108447947919d, y: 0.28239768643675833d), new NpgsqlTypes.NpgsqlPoint(x: 0.697172514259188d, y: 0.31437618891622554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18491779076576687d, y: 0.8342785435103565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061178818724313d, y: 0.7551085087952384d), new NpgsqlTypes.NpgsqlPoint(x: 0.16955596618216973d, y: 0.2882337447008134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4217002757779963d, y: 0.7799944916411994d), new NpgsqlTypes.NpgsqlPoint(x: 0.542594002839774d, y: 0.9063672941212296d), new NpgsqlTypes.NpgsqlPoint(x: 0.049385164167428774d, y: 0.7956499018257245d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5795862867645771d, y: 0.6687727125638254d), new NpgsqlTypes.NpgsqlPoint(x: 0.41447992065138783d, y: 0.2838909007130581d), new NpgsqlTypes.NpgsqlPoint(x: 0.733518892374345d, y: 0.7353931977612073d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3873324133650743d, y: 0.5275019255546993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777986623887015d, y: 0.2152199689129144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3521132998424703d, y: 0.5239321339424781d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4138544654206229d, y: 0.1802692734143745d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137730035745042d, y: 0.06364043864705304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724481042131705d, y: 0.017146761346934936d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12682235362636074d, y: 0.6931815087876801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9727618418571139d, y: 0.8207659488773275d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948612390577604d, y: 0.21607304382648362d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16827290193166822d, y: 0.5410150734925655d), new NpgsqlTypes.NpgsqlPoint(x: 0.17198172603399764d, y: 0.5622303606157072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3769058490307876d, y: 0.001783070179255719d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26708592916109364d, y: 0.9544879338203758d), new NpgsqlTypes.NpgsqlPoint(x: 0.20556352830871427d, y: 0.3193774698551253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6150951419439615d, y: 0.8469752307753408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6328943375086564d, y: 0.5809674906434644d), new NpgsqlTypes.NpgsqlPoint(x: 0.719906078815491d, y: 0.820022033351173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9233051691003885d, y: 0.3641648464658733d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05562888186211046d, y: 0.46032870960943995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8546627425621152d, y: 0.7352915158017781d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765805642831609d, y: 0.03183159331103269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.608254735187644d, y: 0.5031941621468287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6524309622245134d, y: 0.3201663318755399d), new NpgsqlTypes.NpgsqlPoint(x: 0.791601924986851d, y: 0.8579450113183409d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4705373900581151d, y: 0.17998413292624782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7602704083961673d, y: 0.5895271788414972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6174647815417142d, y: 0.4483559099265626d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11542092019089178d, y: 0.008078042493538606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771594781024058d, y: 0.021072827753102152d), new NpgsqlTypes.NpgsqlPoint(x: 0.20980173817689352d, y: 0.8543598158370063d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.881102084604237d, y: 0.21307150374366457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835972281017307d, y: 0.6117174913702379d), new NpgsqlTypes.NpgsqlPoint(x: 0.6142583593037722d, y: 0.9007909600728334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156579939065995d, y: 0.08647736832384845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3571900806632651d, y: 0.20247544532148187d), new NpgsqlTypes.NpgsqlPoint(x: 0.17048243580241618d, y: 0.4678431437344194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2469063465886847d, y: 0.7339407648281321d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961952825070922d, y: 0.18548830037194264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569916263855327d, y: 0.7359799352304834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746122467041908d, y: 0.8196403864351137d), new NpgsqlTypes.NpgsqlPoint(x: 0.015675660380724432d, y: 0.22259284916254374d), new NpgsqlTypes.NpgsqlPoint(x: 0.040511987244955305d, y: 0.5366118448284469d)),
}));
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.912216394387947d, y: 0.14435165404471972d), new NpgsqlTypes.NpgsqlPoint(x: 0.15501086534530606d, y: 0.5702200890755712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503410802822197d, y: 0.3360715940721982d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3190950921330612d, y: 0.043571828138881386d), new NpgsqlTypes.NpgsqlPoint(x: 0.837303560467746d, y: 0.1045735483226572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3832062666871944d, y: 0.12933018700245746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8471330778766372d, y: 0.36717875736560923d), new NpgsqlTypes.NpgsqlPoint(x: 0.08744890604656075d, y: 0.8364049861523297d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735008058558573d, y: 0.1673398219109038d)),
}));
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12637579639580887d, y: 0.6630208375981929d), new NpgsqlTypes.NpgsqlPoint(x: 0.3668160960455604d, y: 0.10149112359305279d), new NpgsqlTypes.NpgsqlPoint(x: 0.25393234068562986d, y: 0.3780269036094468d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5792458262446505d, y: 0.056389268821076866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4134911685960876d, y: 0.6196458540413948d), new NpgsqlTypes.NpgsqlPoint(x: 0.30502984575679126d, y: 0.8263598211155424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11315766591961307d, y: 0.4971085120180143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357650186673848d, y: 0.20029460155360024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704268596123571d, y: 0.25027146416621937d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44150382631190976d, y: 0.8882401744213347d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165327191165655d, y: 0.9014356596610769d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109228933903247d, y: 0.5242131255329838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9842236838783912d, y: 0.43240718690961344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341461552573557d, y: 0.09071051210509529d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167689016497778d, y: 0.6446633060117541d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0635385364748472d, y: 0.21630618094490794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117752372655897d, y: 0.2627212474035945d), new NpgsqlTypes.NpgsqlPoint(x: 0.22333136448941882d, y: 0.8798236848204789d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002820273491105252d, y: 0.03380894674414092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144844947478001d, y: 0.6644751654448192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080408792801073d, y: 0.9915033416613399d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37409498907040895d, y: 0.481943796184064d), new NpgsqlTypes.NpgsqlPoint(x: 0.83822928297718d, y: 0.11669278140832096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658562583796221d, y: 0.9579987118491092d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982788422123462d, y: 0.40223186259758237d), new NpgsqlTypes.NpgsqlPoint(x: 0.10441897703036906d, y: 0.24247821423944582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352446670590417d, y: 0.9727425593507328d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 75, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 160, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 124, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 97, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 13, query1, 167, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 13, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 152, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 84, 152))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 13);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[30],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[31],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[32],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

