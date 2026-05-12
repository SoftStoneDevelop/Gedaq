

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890336638874876d, y: 0.4619186041542839d), new NpgsqlTypes.NpgsqlPoint(x: 0.3208628052249243d, y: 0.583506031691092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317965344572412d, y: 0.12166827510402833d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.451651273481675d, y: 0.39078902874348065d), new NpgsqlTypes.NpgsqlPoint(x: 0.702739912951661d, y: 0.8724880019358086d), new NpgsqlTypes.NpgsqlPoint(x: 0.09001384518265498d, y: 0.3208847375224603d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1567921151533923d, y: 0.9012007264751596d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810942765174692d, y: 0.28351759292565615d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672843730708062d, y: 0.20358173604835794d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5630816896737348d, y: 0.8933975067960952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120124866926615d, y: 0.27861666045889777d), new NpgsqlTypes.NpgsqlPoint(x: 0.797861346769694d, y: 0.15394629346577615d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9284070875775944d, y: 0.6827027172949331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936989755335465d, y: 0.35735010785469745d), new NpgsqlTypes.NpgsqlPoint(x: 0.40862984958242055d, y: 0.4594668374058015d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8663138934990035d, y: 0.7697191486344258d), new NpgsqlTypes.NpgsqlPoint(x: 0.03700867255941809d, y: 0.17007500520456909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760836641469418d, y: 0.8269767455253931d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08488551148706769d, y: 0.861562844049745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374852839541119d, y: 0.4567142468102189d), new NpgsqlTypes.NpgsqlPoint(x: 0.13956060557484673d, y: 0.34484993052605717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3866598131996043d, y: 0.262227088160949d), new NpgsqlTypes.NpgsqlPoint(x: 0.9539743240311931d, y: 0.40496142748380015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3045231877471526d, y: 0.643480579562789d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36989302338505337d, y: 0.5835231635548251d), new NpgsqlTypes.NpgsqlPoint(x: 0.23121068575847992d, y: 0.8070125935851364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015050854379585d, y: 0.6240231840602797d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46856753405802565d, y: 0.9022582988686897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840904986888733d, y: 0.4079391781930862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6730249300710023d, y: 0.4665357714114108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5249066995190214d, y: 0.2455313057171804d), new NpgsqlTypes.NpgsqlPoint(x: 0.4988251810090717d, y: 0.5704478622355625d), new NpgsqlTypes.NpgsqlPoint(x: 0.12795413201370465d, y: 0.9361034750862222d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3278356547115172d, y: 0.2412187889911538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898325507213358d, y: 0.5621062851553681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7682956505499197d, y: 0.8856200953485481d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6877878504093916d, y: 0.5249666785747747d), new NpgsqlTypes.NpgsqlPoint(x: 0.4651240932366686d, y: 0.9143683049647195d), new NpgsqlTypes.NpgsqlPoint(x: 0.291391688453859d, y: 0.6668426051712412d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3648354345179118d, y: 0.44898340632872036d), new NpgsqlTypes.NpgsqlPoint(x: 0.12226723902930381d, y: 0.24973127113825178d), new NpgsqlTypes.NpgsqlPoint(x: 0.3315662816560224d, y: 0.8907024847262196d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37035045792649124d, y: 0.8498918285529476d), new NpgsqlTypes.NpgsqlPoint(x: 0.19620512176227023d, y: 0.2557377379005824d), new NpgsqlTypes.NpgsqlPoint(x: 0.039549737696643716d, y: 0.34709159616806096d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023414889735691058d, y: 0.17988991136498245d), new NpgsqlTypes.NpgsqlPoint(x: 0.35576468283186646d, y: 0.35993313750478173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9808310890861687d, y: 0.0684594378675123d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8381660864350448d, y: 0.213288361384237d), new NpgsqlTypes.NpgsqlPoint(x: 0.360857633250089d, y: 0.752848505809055d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768246248779317d, y: 0.9040302670089054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38959380385843356d, y: 0.640230616093332d), new NpgsqlTypes.NpgsqlPoint(x: 0.4922314717814149d, y: 0.35977493600232546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875650420934918d, y: 0.021903676704618014d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6393320942039893d, y: 0.2509008782197425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031007148142537d, y: 0.9910507692359982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305200728710326d, y: 0.45523376721961994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.074288236805931d, y: 0.24030835740271772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098479326186656d, y: 0.02714923898106225d), new NpgsqlTypes.NpgsqlPoint(x: 0.22496306575052594d, y: 0.8189406485891083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47377677232727733d, y: 0.8235325368248566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9867933144730311d, y: 0.18978613511540265d), new NpgsqlTypes.NpgsqlPoint(x: 0.12505763596142105d, y: 0.949672803374599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5711342077761198d, y: 0.7937869457076203d), new NpgsqlTypes.NpgsqlPoint(x: 0.48541494314028544d, y: 0.7605581709576124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585389604431817d, y: 0.9590052679464922d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7849449460567701d, y: 0.30960579712929004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859177487429632d, y: 0.6221416117650641d), new NpgsqlTypes.NpgsqlPoint(x: 0.337852558207152d, y: 0.7182017099635108d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02741111173431754d, y: 0.1855550136776769d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191081012941487d, y: 0.978585074041609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238583116148544d, y: 0.02312119402114099d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6625220797254373d, y: 0.33226676081659723d), new NpgsqlTypes.NpgsqlPoint(x: 0.25808642367346246d, y: 0.24934516691410968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200769375370184d, y: 0.5041840992956191d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9453846187093423d, y: 0.9894592090515485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531289824555587d, y: 0.5248704934750947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8386437204492014d, y: 0.36054281837156477d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6899171439050232d, y: 0.34591335114240873d), new NpgsqlTypes.NpgsqlPoint(x: 0.40031861908792754d, y: 0.8732304096380236d), new NpgsqlTypes.NpgsqlPoint(x: 0.19448946293215152d, y: 0.37243432722122505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9663406306512652d, y: 0.26199359983756276d), new NpgsqlTypes.NpgsqlPoint(x: 0.33422331633536106d, y: 0.17173949840185831d), new NpgsqlTypes.NpgsqlPoint(x: 0.031001617635830647d, y: 0.7855148786769875d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13814359859845182d, y: 0.6870318547270062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290783696490277d, y: 0.49874820035335277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697489891527079d, y: 0.5620088612435623d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12262434394157684d, y: 0.33971902079082517d), new NpgsqlTypes.NpgsqlPoint(x: 0.945975567338638d, y: 0.3358786160231044d), new NpgsqlTypes.NpgsqlPoint(x: 0.7360832760579187d, y: 0.6668321893193818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44869638629050557d, y: 0.7521113130797248d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645088050339649d, y: 0.3063746004739656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7036003872353701d, y: 0.9349512317559848d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.017855900186619755d, y: 0.41454504136673287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5453385901814549d, y: 0.6050495034372267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454543166969124d, y: 0.8624281785421025d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20216589887330916d, y: 0.23800036241610445d), new NpgsqlTypes.NpgsqlPoint(x: 0.22625120944893307d, y: 0.9208273822337096d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477039506140307d, y: 0.7982517446621419d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058795343626848795d, y: 0.42530039320327695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7829218961105142d, y: 0.43156212949586203d), new NpgsqlTypes.NpgsqlPoint(x: 0.017698836097705062d, y: 0.38898998324798884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7001816468891123d, y: 0.5522677496715737d), new NpgsqlTypes.NpgsqlPoint(x: 0.5712526695183436d, y: 0.0003356578679422073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781076634725597d, y: 7.445295547159336E-05d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17002271180996165d, y: 0.5918017476982319d), new NpgsqlTypes.NpgsqlPoint(x: 0.05347596877008043d, y: 0.8213747545330996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148496003842463d, y: 0.5825941715033639d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3741738817188247d, y: 0.6711636098870141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325009670542619d, y: 0.563907511007779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455863603342386d, y: 0.03236180072102579d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2686389661694235d, y: 0.5819023169737321d), new NpgsqlTypes.NpgsqlPoint(x: 0.26491650906834596d, y: 0.13821355693140902d), new NpgsqlTypes.NpgsqlPoint(x: 0.3169877280166976d, y: 0.5325537206546517d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.403634617104935d, y: 0.014390685527496005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072500931536566d, y: 0.9637037657555406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959224859913666d, y: 0.26025429387144483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7180105481714912d, y: 0.36861637269007796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617178677058368d, y: 0.42433663097773777d), new NpgsqlTypes.NpgsqlPoint(x: 0.019870853801329358d, y: 0.6226308785176219d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5998481029062579d, y: 0.025256524799110336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880515324155022d, y: 0.532029048836171d), new NpgsqlTypes.NpgsqlPoint(x: 0.23986396207914484d, y: 0.2895332811980883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8423674133532495d, y: 0.04511736673157474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322430347791489d, y: 0.41328488670238894d), new NpgsqlTypes.NpgsqlPoint(x: 0.27903942943204496d, y: 0.30094459838919163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07613973032274768d, y: 0.8519130303884482d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355143000971944d, y: 0.542603688626563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211569631987075d, y: 0.6667916632894698d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34404935945167003d, y: 0.3135968867794606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3957541882192802d, y: 0.894838881706069d), new NpgsqlTypes.NpgsqlPoint(x: 0.440054905931647d, y: 0.9803137042432434d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9263682985876039d, y: 0.6243909486664249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6669640372053957d, y: 0.5206810132461807d), new NpgsqlTypes.NpgsqlPoint(x: 0.32357436464928924d, y: 0.025393650746744822d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5485706852520371d, y: 0.7913251987310241d), new NpgsqlTypes.NpgsqlPoint(x: 0.564748294977683d, y: 0.2644376102073749d), new NpgsqlTypes.NpgsqlPoint(x: 0.805147621817803d, y: 0.6283062889362638d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8055027237608223d, y: 0.775225139320069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6944001503045466d, y: 0.6421657029409337d), new NpgsqlTypes.NpgsqlPoint(x: 0.14749250338677444d, y: 0.024807723575665852d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3431816133485719d, y: 0.5960210697041549d), new NpgsqlTypes.NpgsqlPoint(x: 0.25677844765571567d, y: 0.46059338219565127d), new NpgsqlTypes.NpgsqlPoint(x: 0.30435619968727656d, y: 0.773224632699287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30944615762396044d, y: 0.4769778471565187d), new NpgsqlTypes.NpgsqlPoint(x: 0.14527022641930853d, y: 0.2406244077437143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2682367674848579d, y: 0.41304524157972067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8454529534141857d, y: 0.17054820571353024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144047951852545d, y: 0.5913021376442718d), new NpgsqlTypes.NpgsqlPoint(x: 0.0903785919096044d, y: 0.2981858170128385d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9311823495344014d, y: 0.8372249594322393d), new NpgsqlTypes.NpgsqlPoint(x: 0.27100023426804465d, y: 0.8127195065007498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093262183132942d, y: 0.05236703458296177d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6148604119172557d, y: 0.7703469881024636d), new NpgsqlTypes.NpgsqlPoint(x: 0.4413202323270362d, y: 0.03918970623507756d), new NpgsqlTypes.NpgsqlPoint(x: 0.47123490852907324d, y: 0.26454213971195606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23165812299557476d, y: 0.05415398217788747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473709039505537d, y: 0.0844006681575209d), new NpgsqlTypes.NpgsqlPoint(x: 0.11664170259451279d, y: 0.49922278103438744d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12701458088963768d, y: 0.10383568967366918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8963759947108283d, y: 0.36111953065716673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621139072299761d, y: 0.8627944941025172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43457657009589234d, y: 0.5485302176417086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759589597680876d, y: 0.5526465765095081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918564636059302d, y: 0.06359680297745163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47441607804069197d, y: 0.3316989401314234d), new NpgsqlTypes.NpgsqlPoint(x: 0.32198496203635396d, y: 0.1418025635758634d), new NpgsqlTypes.NpgsqlPoint(x: 0.10874602046637527d, y: 0.4957654929309899d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08345346101629192d, y: 0.6877490041353681d), new NpgsqlTypes.NpgsqlPoint(x: 0.4267564839458927d, y: 0.13104911749572723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495152250504113d, y: 0.875706517309103d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45715704501897725d, y: 0.9686234310601738d), new NpgsqlTypes.NpgsqlPoint(x: 0.26483310285273054d, y: 0.36632873919541087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726781486234711d, y: 0.6223318441245638d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3012405421274904d, y: 0.17224547708832272d), new NpgsqlTypes.NpgsqlPoint(x: 0.59605394443196d, y: 0.7083019702062624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421162877516433d, y: 0.6173336066987632d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6561359243218192d, y: 0.7531818293359612d), new NpgsqlTypes.NpgsqlPoint(x: 0.12933081858240347d, y: 0.7847127284786624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3979690984582517d, y: 0.11995746321876732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1722044151971257d, y: 0.8050253836316852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8035347094856432d, y: 0.8771956806883999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8295471339435975d, y: 0.8896791972409333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6207716992889142d, y: 0.36908734180322356d), new NpgsqlTypes.NpgsqlPoint(x: 0.0969065469983944d, y: 0.34879568224836477d), new NpgsqlTypes.NpgsqlPoint(x: 0.1456455813378893d, y: 0.05109093781368923d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3896702119652504d, y: 0.8592127441138065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922434073305235d, y: 0.00038643170277707917d), new NpgsqlTypes.NpgsqlPoint(x: 0.33642735116679945d, y: 0.7732330347745215d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783495415246562d, y: 0.5670318956466888d), new NpgsqlTypes.NpgsqlPoint(x: 0.16116820234630502d, y: 0.6586282861567905d), new NpgsqlTypes.NpgsqlPoint(x: 0.1957736389284529d, y: 0.7295992587782736d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9702968175023062d, y: 0.7553109116551489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320466936341724d, y: 0.960750414809582d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524397298359172d, y: 0.8224036961296577d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9512095633627332d, y: 0.8183825053763629d), new NpgsqlTypes.NpgsqlPoint(x: 0.1311959226037004d, y: 0.24844987007238173d), new NpgsqlTypes.NpgsqlPoint(x: 0.16555610811064125d, y: 0.05961388035609727d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9748049868618317d, y: 0.27629965747666907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147838931986085d, y: 0.9935276638973559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433434633650014d, y: 0.39433135907161265d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2880523527619886d, y: 0.8551199774621716d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054362772930432d, y: 0.9822548675108335d), new NpgsqlTypes.NpgsqlPoint(x: 0.25786348194010356d, y: 0.5467417299561075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5541243783726062d, y: 0.4737565883055602d), new NpgsqlTypes.NpgsqlPoint(x: 0.06622782170845731d, y: 0.8213460949047013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5915664849024994d, y: 0.5481149514638229d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618129019901722d, y: 0.8485547359273793d), new NpgsqlTypes.NpgsqlPoint(x: 0.2999079050726494d, y: 0.884063442257187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069758947880569d, y: 0.4675355885107826d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.547961332721741d, y: 0.47441712060577124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335836719605082d, y: 0.7679777291715558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8586449585671588d, y: 0.5131375468527104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2452256992453059d, y: 0.10233165519215459d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315334571538206d, y: 0.30270839704206876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743364421617028d, y: 0.30809631361885403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5744507786862909d, y: 0.8315472224609435d), new NpgsqlTypes.NpgsqlPoint(x: 0.42971008052666093d, y: 0.10837609273012883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079151638362061d, y: 0.7309470259395383d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21481984411852528d, y: 0.25343496116170017d), new NpgsqlTypes.NpgsqlPoint(x: 0.30355508623497673d, y: 0.45033253123056494d), new NpgsqlTypes.NpgsqlPoint(x: 0.2622397806976643d, y: 0.7361774134262279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1415825357714825d, y: 0.6235239516655599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861388605702899d, y: 0.8896194832606457d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165262271100494d, y: 0.5237680999010041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6886239425723323d, y: 0.1849417429163409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147544901432733d, y: 0.21669021355760776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855264161428326d, y: 0.9714109326268372d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2114425687871927d, y: 0.338383857453717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071339194411527d, y: 0.782404060670782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154435666358856d, y: 0.44621405851087004d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39339817330546323d, y: 0.7135730079921053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219044673486745d, y: 0.2137372780358262d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363937490464459d, y: 0.48309471852258423d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29907575914503026d, y: 0.922689724075808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8925922248417929d, y: 0.7245931732612821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178954702711506d, y: 0.37464236072897494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5993126319361562d, y: 0.6112820457490528d), new NpgsqlTypes.NpgsqlPoint(x: 0.4339511549386653d, y: 0.5243445938331468d), new NpgsqlTypes.NpgsqlPoint(x: 0.849048008532452d, y: 0.45214584371566013d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7642175053031155d, y: 0.7808138666473552d), new NpgsqlTypes.NpgsqlPoint(x: 0.601246259930844d, y: 0.3974858535098842d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570024615954476d, y: 0.15070441858668637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4729584842281448d, y: 0.3928457817933816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7571078736322062d, y: 0.9493921498836607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569503879637055d, y: 0.1659182038466861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9565050514261617d, y: 0.270937070162097d), new NpgsqlTypes.NpgsqlPoint(x: 0.32781522355492687d, y: 0.5534669935876431d), new NpgsqlTypes.NpgsqlPoint(x: 0.01572566398323305d, y: 0.8490651987661652d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07902797307427056d, y: 0.4527800894459886d), new NpgsqlTypes.NpgsqlPoint(x: 0.0741521732416871d, y: 0.5971024187717436d), new NpgsqlTypes.NpgsqlPoint(x: 0.008682174782209673d, y: 0.3408102510412182d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6858058129472467d, y: 0.03138553044853154d), new NpgsqlTypes.NpgsqlPoint(x: 0.15594963626220903d, y: 0.9952175807592348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980270982544023d, y: 0.18688122315812083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38261324562630905d, y: 0.5769938605003365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3046321870722333d, y: 0.32639306756276154d), new NpgsqlTypes.NpgsqlPoint(x: 0.47409226680066896d, y: 0.2739105305061297d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5506349783756498d, y: 0.9390101813521838d), new NpgsqlTypes.NpgsqlPoint(x: 0.9141217755054294d, y: 0.36305575287380765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583184966655561d, y: 0.7627895044755038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2769993929044138d, y: 0.04860732355513364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623509551017778d, y: 0.5757031403808012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6398086290278183d, y: 0.4117886012637172d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5242378182192964d, y: 0.9864815018708182d), new NpgsqlTypes.NpgsqlPoint(x: 0.48893329627943183d, y: 0.36989472841060544d), new NpgsqlTypes.NpgsqlPoint(x: 0.2512638566433728d, y: 0.010029635644659973d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3386173167996227d, y: 0.6222047682260936d), new NpgsqlTypes.NpgsqlPoint(x: 0.008011783494249025d, y: 0.7032154293125734d), new NpgsqlTypes.NpgsqlPoint(x: 0.23325542507282393d, y: 0.5479826892532764d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14846808027558545d, y: 0.4931752509059072d), new NpgsqlTypes.NpgsqlPoint(x: 0.39269090332524426d, y: 0.4351474885188683d), new NpgsqlTypes.NpgsqlPoint(x: 0.754192159469973d, y: 0.6989126197340989d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13240593066282758d, y: 0.019752328568729438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3364598824853534d, y: 0.7801025303373379d), new NpgsqlTypes.NpgsqlPoint(x: 0.26445828807021354d, y: 0.6795534755316288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4017605430890461d, y: 0.16695877971269002d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414726283618119d, y: 0.1897618905256382d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400177055959964d, y: 0.9655864003438863d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9094291032536299d, y: 0.6255823536574793d), new NpgsqlTypes.NpgsqlPoint(x: 0.05796460803752579d, y: 0.2217472871944719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6999938308160679d, y: 0.26967369172885247d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8129149875884332d, y: 0.9641487292549086d), new NpgsqlTypes.NpgsqlPoint(x: 0.28860524778055985d, y: 0.2275930148378813d), new NpgsqlTypes.NpgsqlPoint(x: 0.2762352628019453d, y: 0.42668998509864065d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10498566031637324d, y: 0.09033022882815767d), new NpgsqlTypes.NpgsqlPoint(x: 0.19910753379182355d, y: 0.74658412096258d), new NpgsqlTypes.NpgsqlPoint(x: 0.22215649570083185d, y: 0.37296511738157434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6909868379899192d, y: 0.6271304511118942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754935193067816d, y: 0.40329649907198184d), new NpgsqlTypes.NpgsqlPoint(x: 0.21581615936575205d, y: 0.9957396536428657d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47848928430540394d, y: 0.4403922317521576d), new NpgsqlTypes.NpgsqlPoint(x: 0.10462679374866779d, y: 0.7567460302754975d), new NpgsqlTypes.NpgsqlPoint(x: 0.5720492949308109d, y: 0.9987980043806862d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7014035963926145d, y: 0.8950812857782596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826358596685338d, y: 0.8117435917262107d), new NpgsqlTypes.NpgsqlPoint(x: 0.10116882321887544d, y: 0.44381981074841403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545117944902896d, y: 0.960149363740279d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051156048480747d, y: 0.3907339505764711d), new NpgsqlTypes.NpgsqlPoint(x: 0.462674730885255d, y: 0.23314978661708075d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7096949590416717d, y: 0.8435129143035756d), new NpgsqlTypes.NpgsqlPoint(x: 0.29873978018615166d, y: 0.9873405125497052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580042074640578d, y: 0.20168940711188854d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1422783363043112d, y: 0.32937466669603066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410422863974318d, y: 0.07660022188692073d), new NpgsqlTypes.NpgsqlPoint(x: 0.25303314953463973d, y: 0.48647922012266176d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19118543522612863d, y: 0.15665298549141415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8425383353803592d, y: 0.9597299438652871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975650120202576d, y: 0.4327718533967234d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6196078093478582d, y: 0.6895939878497201d), new NpgsqlTypes.NpgsqlPoint(x: 0.6918928417250281d, y: 0.9786956723786752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315850596648498d, y: 0.3907690043223311d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7427960016029216d, y: 0.424955860655033d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748480661512646d, y: 0.5364894214051759d), new NpgsqlTypes.NpgsqlPoint(x: 0.11433593662058716d, y: 0.3688512666852538d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9297530326048897d, y: 0.00611831138645802d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209034476515384d, y: 0.036279557690365616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2754409356313069d, y: 0.23365527603198022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013219254874196618d, y: 0.46143318466741645d), new NpgsqlTypes.NpgsqlPoint(x: 0.08306089140734729d, y: 0.9374389481380011d), new NpgsqlTypes.NpgsqlPoint(x: 0.09971247777967152d, y: 0.5228218784402152d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8585036329445139d, y: 0.799843815790865d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158857727830646d, y: 0.570873349975927d), new NpgsqlTypes.NpgsqlPoint(x: 0.15436116937870825d, y: 0.7284416845298598d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5072615918016615d, y: 0.37891096636865795d), new NpgsqlTypes.NpgsqlPoint(x: 0.11021029784164149d, y: 0.56154938631803d), new NpgsqlTypes.NpgsqlPoint(x: 0.1684224745143883d, y: 0.5424871682984647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6276484079126889d, y: 0.47225932168511886d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663877111592093d, y: 0.6792683351141947d), new NpgsqlTypes.NpgsqlPoint(x: 0.1405923825167653d, y: 0.8847173191670207d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2719586847546358d, y: 0.4492789271426214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8963498274197257d, y: 0.1775914178118133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877168604003085d, y: 0.9588018303419518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843778040992917d, y: 0.18527135794934424d), new NpgsqlTypes.NpgsqlPoint(x: 0.01880252048536135d, y: 0.20173073609242342d), new NpgsqlTypes.NpgsqlPoint(x: 0.63746296643335d, y: 0.16680254086030333d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5281025720305081d, y: 0.7791755127772962d), new NpgsqlTypes.NpgsqlPoint(x: 0.8895856089826194d, y: 0.7401072854379149d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579417975644833d, y: 0.37735075487898107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07902132170366338d, y: 0.0864654049921395d), new NpgsqlTypes.NpgsqlPoint(x: 0.034087657210001954d, y: 0.8853970675003735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8210399600276349d, y: 0.6389813341979539d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6885479578362312d, y: 0.15898336816637448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3222758749253519d, y: 0.0853463418087651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3729069875837274d, y: 0.9535012134295721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8830704178913209d, y: 0.06101795474691618d), new NpgsqlTypes.NpgsqlPoint(x: 0.660015301972076d, y: 0.43295267074006794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788031496266496d, y: 0.49218306308372217d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21643807978939078d, y: 0.4541423335717586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690853289412424d, y: 0.20635096931453156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147888247877079d, y: 0.24311110572947725d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793794304703178d, y: 0.6513614505490185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138131749548783d, y: 0.3764332583380311d), new NpgsqlTypes.NpgsqlPoint(x: 0.19939353557059503d, y: 0.4643672231820545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01232141675145948d, y: 0.8863989705343736d), new NpgsqlTypes.NpgsqlPoint(x: 0.047118970273949845d, y: 0.23439319233132816d), new NpgsqlTypes.NpgsqlPoint(x: 0.02223572542457819d, y: 0.8357002364641758d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04870369135787522d, y: 0.6730232039577313d), new NpgsqlTypes.NpgsqlPoint(x: 0.21363174984379096d, y: 0.6779895882918473d), new NpgsqlTypes.NpgsqlPoint(x: 0.0402160289507314d, y: 0.9350594269756044d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.83582706309155d, y: 0.2988665520144159d), new NpgsqlTypes.NpgsqlPoint(x: 0.44743565820039877d, y: 0.35698256578853993d), new NpgsqlTypes.NpgsqlPoint(x: 0.28531697812090406d, y: 0.21060208167967742d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16274091325622697d, y: 0.49645401665273614d), new NpgsqlTypes.NpgsqlPoint(x: 0.13943072824838054d, y: 0.6465489515596488d), new NpgsqlTypes.NpgsqlPoint(x: 0.44472002137745725d, y: 0.3435104154100612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8709000309027002d, y: 0.2287239593330651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612907425943207d, y: 0.5238612746127144d), new NpgsqlTypes.NpgsqlPoint(x: 0.603661468180086d, y: 0.8078392557303959d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9615125577248763d, y: 0.783573506943563d), new NpgsqlTypes.NpgsqlPoint(x: 0.6575403656863773d, y: 0.15096023629112676d), new NpgsqlTypes.NpgsqlPoint(x: 0.846709627420783d, y: 0.42896655650094984d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05769365009892691d, y: 0.4754591912819349d), new NpgsqlTypes.NpgsqlPoint(x: 0.17637369784012324d, y: 0.788698342980396d), new NpgsqlTypes.NpgsqlPoint(x: 0.3468069743419454d, y: 0.8118952747600666d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04549285157203897d, y: 0.025855243030533215d), new NpgsqlTypes.NpgsqlPoint(x: 0.5085845081613349d, y: 0.16087014891221962d), new NpgsqlTypes.NpgsqlPoint(x: 0.004379288288439365d, y: 0.029435810680261243d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8396613835136485d, y: 0.4930419609330956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517083267477632d, y: 0.6189546453348533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808192971895667d, y: 0.36865287424249815d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20674456443539957d, y: 0.28643858125177835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484929330798392d, y: 0.8937136552437891d), new NpgsqlTypes.NpgsqlPoint(x: 0.12716963394899516d, y: 0.6411421337953468d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6673562860248349d, y: 0.6558302087828715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006433446520367d, y: 0.8928525512651869d), new NpgsqlTypes.NpgsqlPoint(x: 0.696625333804431d, y: 0.37071286019971805d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7039943630680265d, y: 0.6741327043904473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136811440696883d, y: 0.2549843177649397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6238799186272791d, y: 0.6058635988824519d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4058326829297394d, y: 0.875200013581006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143517453855824d, y: 0.9631585696906206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184358398466511d, y: 0.10745541953728788d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4693231812981331d, y: 0.2658133014417261d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018891223532990775d, y: 0.43916072045023713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5271646306467987d, y: 0.3932585390754333d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20743578230421567d, y: 0.48835153753638794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671658967640894d, y: 0.7507714831395559d), new NpgsqlTypes.NpgsqlPoint(x: 0.09519382494737838d, y: 0.9105631685580049d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7064003386694617d, y: 0.4054688102622288d), new NpgsqlTypes.NpgsqlPoint(x: 0.05096196679896137d, y: 0.15045333694634877d), new NpgsqlTypes.NpgsqlPoint(x: 0.09992590639018539d, y: 0.13041842178664975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4575776900191135d, y: 0.007277969083379743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454834604892128d, y: 0.2453566329916257d), new NpgsqlTypes.NpgsqlPoint(x: 0.2068053254857296d, y: 0.8690952805824887d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24204225596552975d, y: 0.7708703632692305d), new NpgsqlTypes.NpgsqlPoint(x: 0.936454535648724d, y: 0.1908340470972465d), new NpgsqlTypes.NpgsqlPoint(x: 0.0797348554717866d, y: 0.11451470440154188d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9195983432651347d, y: 0.8146938157480993d), new NpgsqlTypes.NpgsqlPoint(x: 0.33469676581885677d, y: 0.36680930208721985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068949776478984d, y: 0.1063792270222671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6921197943860661d, y: 0.6289489040888969d), new NpgsqlTypes.NpgsqlPoint(x: 0.13673009665925584d, y: 0.9196881549232233d), new NpgsqlTypes.NpgsqlPoint(x: 0.41342974706947244d, y: 0.9241356250721414d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5985205808930603d, y: 0.2139398885529582d), new NpgsqlTypes.NpgsqlPoint(x: 0.26502569410442023d, y: 0.6262902473736329d), new NpgsqlTypes.NpgsqlPoint(x: 0.16880891621094396d, y: 0.672741180600321d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8962425745336164d, y: 0.5120227473387556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572350008637622d, y: 0.4570061681955533d), new NpgsqlTypes.NpgsqlPoint(x: 0.27518415519953754d, y: 0.26161502491323496d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3644710053960767d, y: 0.11100988394628031d), new NpgsqlTypes.NpgsqlPoint(x: 0.57494451737803d, y: 0.3363244842306069d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896332113146482d, y: 0.23635662503912325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2360316968412396d, y: 0.10734744070785751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280394234037483d, y: 0.6239123101794611d), new NpgsqlTypes.NpgsqlPoint(x: 0.22665518615336266d, y: 0.9228815220456862d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22921024609094653d, y: 0.5764318313724349d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158191185206128d, y: 0.8486603920496125d), new NpgsqlTypes.NpgsqlPoint(x: 0.017365927438707907d, y: 0.5134105033069194d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1908825419265735d, y: 0.4572808683200663d), new NpgsqlTypes.NpgsqlPoint(x: 0.37548680616687835d, y: 0.667663737428041d), new NpgsqlTypes.NpgsqlPoint(x: 0.19885621252353824d, y: 0.5971985972198645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8526004400952907d, y: 0.9459813095977517d), new NpgsqlTypes.NpgsqlPoint(x: 0.971121830327498d, y: 0.9450715236108205d), new NpgsqlTypes.NpgsqlPoint(x: 0.11372487190909153d, y: 0.07427389439209131d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2893717876886105d, y: 0.6445064316949333d), new NpgsqlTypes.NpgsqlPoint(x: 0.24137060999677173d, y: 0.47318072552012513d), new NpgsqlTypes.NpgsqlPoint(x: 0.41246699964652667d, y: 0.5568186646561147d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21746452674058014d, y: 0.2651620116575407d), new NpgsqlTypes.NpgsqlPoint(x: 0.128873712538359d, y: 0.5762193473138232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428381313967361d, y: 0.3211745755453278d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31806117556844304d, y: 0.11380190416677216d), new NpgsqlTypes.NpgsqlPoint(x: 0.3996149829882667d, y: 0.863673641743732d), new NpgsqlTypes.NpgsqlPoint(x: 0.951416926433338d, y: 0.1855204158002698d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6528058977753093d, y: 0.834849888882937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368502961313832d, y: 0.5577926719319148d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229542644643516d, y: 0.4930093512906417d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06131800705102419d, y: 0.01516295052997807d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185898913601061d, y: 0.12431403713864952d), new NpgsqlTypes.NpgsqlPoint(x: 0.24974263849209644d, y: 0.06653014099192789d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8803653503995618d, y: 0.6198126185268961d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512634808506973d, y: 0.6651050489162045d), new NpgsqlTypes.NpgsqlPoint(x: 0.7914896211099688d, y: 0.29465758849256174d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1432640028484805d, y: 0.5207202967730913d), new NpgsqlTypes.NpgsqlPoint(x: 0.02425860054650275d, y: 0.6165436698616706d), new NpgsqlTypes.NpgsqlPoint(x: 0.05371437535760826d, y: 0.3087404196539748d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2923676965098412d, y: 0.2120164597274513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609259830998882d, y: 0.9820656027539899d), new NpgsqlTypes.NpgsqlPoint(x: 0.18143894763564683d, y: 0.11356266079966482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9312966065694961d, y: 0.8145070479553195d), new NpgsqlTypes.NpgsqlPoint(x: 0.1663951629655881d, y: 0.44488235196057435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192049807931595d, y: 0.33032055759892587d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1031129857799592d, y: 0.5416764559235602d), new NpgsqlTypes.NpgsqlPoint(x: 0.7272796975515833d, y: 0.35417667693902577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971903909025217d, y: 0.22475201273919665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559223167344199d, y: 0.5653887643701272d), new NpgsqlTypes.NpgsqlPoint(x: 0.14624660662568922d, y: 0.22072084228173006d), new NpgsqlTypes.NpgsqlPoint(x: 0.4813985998980904d, y: 0.10183582655989631d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7643980153311342d, y: 0.8504844441752792d), new NpgsqlTypes.NpgsqlPoint(x: 0.0028273095531182735d, y: 0.1347629265833209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8427368150785867d, y: 0.5462148953663488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.051676865773194636d, y: 0.1711981229499029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339688297237365d, y: 0.27129502493454616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3972775783312228d, y: 0.5606234227954221d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30177354086863517d, y: 0.053654451231291755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324862549472152d, y: 0.8931901719791812d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133588536264222d, y: 0.7899022574236678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.045994948491307586d, y: 0.531949260174707d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425018049456946d, y: 0.552400008971222d), new NpgsqlTypes.NpgsqlPoint(x: 0.09859805782709563d, y: 0.35518633442163927d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24785481206186266d, y: 0.3469247969356992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2514577054849033d, y: 0.8386751653448796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652163515581995d, y: 0.6935768144517004d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8420174258506644d, y: 0.6494207795632909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6188268275370159d, y: 0.1444126377226096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3840296160705231d, y: 0.6202909683030208d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0600995633657293d, y: 0.09994296407720915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4273067262350321d, y: 0.6398007651380444d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936128147619038d, y: 0.9138737460477768d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8001542277925795d, y: 0.8738262655305025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4199359832220566d, y: 0.7553428725492692d), new NpgsqlTypes.NpgsqlPoint(x: 0.26023745690647293d, y: 0.7079095376100616d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40009677797959387d, y: 0.6098135901832951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9513488240453709d, y: 0.9627243692257634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506193849537089d, y: 0.4542558069255479d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8905219690321866d, y: 0.2585933771781239d), new NpgsqlTypes.NpgsqlPoint(x: 0.583063656350597d, y: 0.35970425191394007d), new NpgsqlTypes.NpgsqlPoint(x: 0.43649211989814063d, y: 0.8992064001082838d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8149793193574694d, y: 0.5412906628795624d), new NpgsqlTypes.NpgsqlPoint(x: 0.17635311623101058d, y: 0.98892923720951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9358943464315914d, y: 0.9557895663483664d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09086959110202031d, y: 0.34738234641835486d), new NpgsqlTypes.NpgsqlPoint(x: 0.652374717632979d, y: 0.07255779387103456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6711027766636931d, y: 0.8567537457996649d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6155105951746914d, y: 0.3617486053951895d), new NpgsqlTypes.NpgsqlPoint(x: 0.08649616006320882d, y: 0.4093242970264144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207866107377987d, y: 0.2722434636573111d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7694344183426336d, y: 0.5397175664550795d), new NpgsqlTypes.NpgsqlPoint(x: 0.686014517293873d, y: 0.5635893609166466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194150259801446d, y: 0.5772176342334823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6403303640223172d, y: 0.19505115403094986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651339878828558d, y: 0.14040403834539084d), new NpgsqlTypes.NpgsqlPoint(x: 0.16075154369165545d, y: 0.40166790622150017d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21517525853295116d, y: 0.27350145629357103d), new NpgsqlTypes.NpgsqlPoint(x: 0.816918907578402d, y: 0.12606981693302333d), new NpgsqlTypes.NpgsqlPoint(x: 0.360809399757574d, y: 0.5027968220674383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9317013260144457d, y: 0.39669358147342293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184998830633665d, y: 0.5313988702610049d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246325057869843d, y: 0.4451322309745306d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4831024691680681d, y: 0.2617932666020789d), new NpgsqlTypes.NpgsqlPoint(x: 0.10112455158729006d, y: 0.6475701268643905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849162597361613d, y: 0.26991008472599676d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20154453250862525d, y: 0.9204667277930549d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533160519214713d, y: 0.6607136841442057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192343054388558d, y: 0.47097177995006756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33958977157899883d, y: 0.212843290584374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277922566108919d, y: 0.2272654952700972d), new NpgsqlTypes.NpgsqlPoint(x: 0.1823738459527804d, y: 0.625191188171245d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4264275822676121d, y: 0.6026643897911191d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267523731728775d, y: 0.8676730027494088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481132603503711d, y: 0.9766816289496814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7173453017147019d, y: 0.881367701185782d), new NpgsqlTypes.NpgsqlPoint(x: 0.39114283876901523d, y: 0.5905090732539606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068334302003036d, y: 0.678875227839958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9232810571875543d, y: 0.7695954867952788d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770202341981106d, y: 0.12081036520265886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5242097514503846d, y: 0.4964846611730056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05483212963053408d, y: 0.6959283702189392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7857438298630556d, y: 0.3803958137755096d), new NpgsqlTypes.NpgsqlPoint(x: 0.46514137589302174d, y: 0.7280632690243564d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11325700485188495d, y: 0.10312834914505675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572923413101599d, y: 0.9495838786438594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549234937327348d, y: 0.011107548088199137d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4261949614709136d, y: 0.25349958814527984d), new NpgsqlTypes.NpgsqlPoint(x: 0.33620341635790685d, y: 0.893041804791724d), new NpgsqlTypes.NpgsqlPoint(x: 0.36421973593908497d, y: 0.9753094983602223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41987853801445196d, y: 0.15525899447555802d), new NpgsqlTypes.NpgsqlPoint(x: 0.22804443560440613d, y: 0.8140010134484195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4906857937451867d, y: 0.59700160333223d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9230807635642246d, y: 0.2439511463834656d), new NpgsqlTypes.NpgsqlPoint(x: 0.12802074089835636d, y: 0.1945957606439177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187536036831895d, y: 0.18513569360300597d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6398664456265977d, y: 0.9215761741404856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265699453658191d, y: 0.4005285965582893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449162499061671d, y: 0.5069738473453539d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6239921508230053d, y: 0.9312952455557755d), new NpgsqlTypes.NpgsqlPoint(x: 0.796434356656539d, y: 0.98408223038648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051093816215524d, y: 0.7489585003817143d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46452272402242445d, y: 0.34407148878536276d), new NpgsqlTypes.NpgsqlPoint(x: 0.507016934276484d, y: 0.3471891671947469d), new NpgsqlTypes.NpgsqlPoint(x: 0.22194366641710972d, y: 0.3167318534931971d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6858905393797744d, y: 0.35953174171875835d), new NpgsqlTypes.NpgsqlPoint(x: 0.15786634735070282d, y: 0.23301898690707246d), new NpgsqlTypes.NpgsqlPoint(x: 0.018967383204632204d, y: 0.7461922403389416d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6167651246194559d, y: 0.6166473518987072d), new NpgsqlTypes.NpgsqlPoint(x: 0.972365477059375d, y: 0.8897153374415021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7532809749224089d, y: 0.7171741221423023d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6205675090311763d, y: 0.692249222993685d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167930147373659d, y: 0.020771244337440598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773724340233219d, y: 0.16721870474698763d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9929101865495735d, y: 0.2453775647953118d), new NpgsqlTypes.NpgsqlPoint(x: 0.3977351856390505d, y: 0.26896383385634537d), new NpgsqlTypes.NpgsqlPoint(x: 0.3929319879440005d, y: 0.8354945709011434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7879961340199352d, y: 0.6236288408659074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534080079523372d, y: 0.1049130535356656d), new NpgsqlTypes.NpgsqlPoint(x: 0.733112774203029d, y: 0.7179521462323704d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0780969156555289d, y: 0.790938687269214d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641987084160955d, y: 0.04848513661019671d), new NpgsqlTypes.NpgsqlPoint(x: 0.19464746363813423d, y: 0.6700357271982194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34129930624877847d, y: 0.010153721593834764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6199251360015441d, y: 0.9839105487806358d), new NpgsqlTypes.NpgsqlPoint(x: 0.07426719708908436d, y: 0.7965712585913907d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33296399762964757d, y: 0.009968160775167378d), new NpgsqlTypes.NpgsqlPoint(x: 0.007202934442368414d, y: 0.6247575496878462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899402270866513d, y: 0.9354775152990044d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6093090085560515d, y: 0.5145645403851935d), new NpgsqlTypes.NpgsqlPoint(x: 0.19389775149689092d, y: 0.07493752781379215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554060867384616d, y: 0.6999095359384007d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18155045541813053d, y: 0.4908742165684935d), new NpgsqlTypes.NpgsqlPoint(x: 0.2350278707495317d, y: 0.050195738365119036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5867084675471276d, y: 0.7100568515975548d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48614550027606074d, y: 0.5538855357252822d), new NpgsqlTypes.NpgsqlPoint(x: 0.021494290898095625d, y: 0.26998874270053763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5270951553448198d, y: 0.7051826409378473d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3050618120025047d, y: 0.3307325343098002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2357085256165533d, y: 0.006665099867965374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169774167675724d, y: 0.4128511015932076d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6241860694448501d, y: 0.39395777419738776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925875058305479d, y: 0.21206219224312617d), new NpgsqlTypes.NpgsqlPoint(x: 0.57349592065585d, y: 0.8846393385192451d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.035823563009172776d, y: 0.17771488294990856d), new NpgsqlTypes.NpgsqlPoint(x: 0.2996982056716666d, y: 0.6792494305872828d), new NpgsqlTypes.NpgsqlPoint(x: 0.05955097349831806d, y: 0.3541429962084077d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17886234148757552d, y: 0.7778576369462924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191683185291822d, y: 0.023972721675910802d), new NpgsqlTypes.NpgsqlPoint(x: 0.23379034648632635d, y: 0.9142650820368403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6453220106392781d, y: 0.2573218118755438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989190816190109d, y: 0.5171309771636015d), new NpgsqlTypes.NpgsqlPoint(x: 0.27823908642615125d, y: 0.40316709367996106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6326858326832873d, y: 0.884099824735433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428183854905693d, y: 0.5860224151309484d), new NpgsqlTypes.NpgsqlPoint(x: 0.1388853123226339d, y: 0.7029976278313477d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38182003422757704d, y: 0.43928647127970766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7928102483731455d, y: 0.06670932171235888d), new NpgsqlTypes.NpgsqlPoint(x: 0.21603863182966132d, y: 0.7163966026823052d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.787543994851464d, y: 0.011715506687810961d), new NpgsqlTypes.NpgsqlPoint(x: 0.058124202898206856d, y: 0.711814736882897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392602188982284d, y: 0.051978330305210596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022480477166999302d, y: 0.5187567007397867d), new NpgsqlTypes.NpgsqlPoint(x: 0.977370153735897d, y: 0.9144320792794303d), new NpgsqlTypes.NpgsqlPoint(x: 0.26829452035032153d, y: 0.36986185611541966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5906592102600114d, y: 0.9176754087427109d), new NpgsqlTypes.NpgsqlPoint(x: 0.2444395590471432d, y: 0.10971208803248911d), new NpgsqlTypes.NpgsqlPoint(x: 0.30158291754296995d, y: 0.34747179069940726d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2997279173866586d, y: 0.7809753202818791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520858829736437d, y: 0.5875308583855453d), new NpgsqlTypes.NpgsqlPoint(x: 0.4562183996781799d, y: 0.4799036649748749d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5322565916707924d, y: 0.5191965537022792d), new NpgsqlTypes.NpgsqlPoint(x: 0.4028579735454124d, y: 0.6734643894226074d), new NpgsqlTypes.NpgsqlPoint(x: 0.04448003132748102d, y: 0.7567344250782795d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2414484360569903d, y: 0.6176339600528125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227668073951575d, y: 0.34155716208978615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458224610680466d, y: 0.19756989061537722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20575974150588716d, y: 0.6701362198575376d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572211600898917d, y: 0.030969738785137202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760740901243615d, y: 0.06917992023693764d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23516553660632555d, y: 0.025879512395067916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732431384365467d, y: 0.5950653435491178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6318181732188309d, y: 0.27361614055922157d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.580283978887309d, y: 0.5477857710856041d), new NpgsqlTypes.NpgsqlPoint(x: 0.12377557858026933d, y: 0.17161653329140236d), new NpgsqlTypes.NpgsqlPoint(x: 0.18525656036017812d, y: 0.3512816376051122d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6210036190542377d, y: 0.12529420467077423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7857556613678874d, y: 0.8719974303120567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547063056544974d, y: 0.37240692972974365d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8764439355265263d, y: 0.6595930052184423d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919732443302187d, y: 0.9417011287107877d), new NpgsqlTypes.NpgsqlPoint(x: 0.42289612819731404d, y: 0.3568271986249393d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014167417123417292d, y: 0.19843529292463336d), new NpgsqlTypes.NpgsqlPoint(x: 0.24080103118798502d, y: 0.5544045522206849d), new NpgsqlTypes.NpgsqlPoint(x: 0.25273868941135835d, y: 0.39339627962551205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6169526825908436d, y: 0.16098591379125538d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512425447040375d, y: 0.19968206922701814d), new NpgsqlTypes.NpgsqlPoint(x: 0.2972874595737971d, y: 0.9913949043388139d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038103869407252966d, y: 0.3721802570055541d), new NpgsqlTypes.NpgsqlPoint(x: 0.37818996644908265d, y: 0.6768546872633258d), new NpgsqlTypes.NpgsqlPoint(x: 0.689609289226829d, y: 0.16892067990893522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10496477166258156d, y: 0.8319547941271126d), new NpgsqlTypes.NpgsqlPoint(x: 0.024364505139013226d, y: 0.648831748859785d), new NpgsqlTypes.NpgsqlPoint(x: 0.34600477980432187d, y: 0.6849000441050518d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16592692399784081d, y: 0.07418891085322166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404720734765411d, y: 0.21478436012378777d), new NpgsqlTypes.NpgsqlPoint(x: 0.4906909709035744d, y: 0.21769847579077062d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405048642329367d, y: 0.5552553091482288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6357866035183793d, y: 0.8000815915373378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734921685084994d, y: 0.11856497957609191d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5046353851850947d, y: 0.6736301910466647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7595306874302599d, y: 0.39248912150803783d), new NpgsqlTypes.NpgsqlPoint(x: 0.2763867644654383d, y: 0.5985140164080175d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4981659811780157d, y: 0.6840822131293459d), new NpgsqlTypes.NpgsqlPoint(x: 0.3573778231818515d, y: 0.6886858131618255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905621372568318d, y: 0.6179807604926271d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6011181874116802d, y: 0.21222482932431064d), new NpgsqlTypes.NpgsqlPoint(x: 0.27397136482262185d, y: 0.42444714612163503d), new NpgsqlTypes.NpgsqlPoint(x: 0.01567850095224277d, y: 0.058304643986688d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4334169694280269d, y: 0.2635417571878357d), new NpgsqlTypes.NpgsqlPoint(x: 0.05730064214600228d, y: 0.8818132092888548d), new NpgsqlTypes.NpgsqlPoint(x: 0.001505216657613495d, y: 0.6889293381676309d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00427728870045041d, y: 0.09120661563444254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379982662001055d, y: 0.18761390726839233d), new NpgsqlTypes.NpgsqlPoint(x: 0.33148841018258157d, y: 0.5921628831983977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033590553506039234d, y: 0.021554523463078845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2634016067420005d, y: 0.7834432326797421d), new NpgsqlTypes.NpgsqlPoint(x: 0.765331903707027d, y: 0.2590697305747818d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8606600018386861d, y: 0.8058668503541214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7501964609298197d, y: 0.6615856924170085d), new NpgsqlTypes.NpgsqlPoint(x: 0.23529301867719743d, y: 0.013098378243322606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805379285258591d, y: 0.9996419569630257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587961382311579d, y: 0.11168825188854492d), new NpgsqlTypes.NpgsqlPoint(x: 0.18386547574963452d, y: 0.4306152683212602d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6794432713209082d, y: 0.0328672498543523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105176276805774d, y: 0.5298750070037805d), new NpgsqlTypes.NpgsqlPoint(x: 0.252603300780715d, y: 0.7374740961382563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49774169590479556d, y: 0.0469780226024098d), new NpgsqlTypes.NpgsqlPoint(x: 0.349238709258168d, y: 0.3873129861500908d), new NpgsqlTypes.NpgsqlPoint(x: 0.46244460919132846d, y: 0.7664922949519754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5024719718333419d, y: 0.9455671984216659d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077780500652045d, y: 0.02730503426930031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055400637434274d, y: 0.9140518829937533d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4880303642618935d, y: 0.29046229842544724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446455886088863d, y: 0.9215737751680015d), new NpgsqlTypes.NpgsqlPoint(x: 0.23129106518693376d, y: 0.12035023104560305d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5722846386133045d, y: 0.7597722023319569d), new NpgsqlTypes.NpgsqlPoint(x: 0.3583288355957923d, y: 0.4940234159936855d), new NpgsqlTypes.NpgsqlPoint(x: 0.98999536227566d, y: 0.9095680368749082d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9630237279018209d, y: 0.5918476357811927d), new NpgsqlTypes.NpgsqlPoint(x: 0.1028629266527179d, y: 0.788786575616673d), new NpgsqlTypes.NpgsqlPoint(x: 0.23738794686229936d, y: 0.9091330281275919d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9021764135468404d, y: 0.30149915825057916d), new NpgsqlTypes.NpgsqlPoint(x: 0.24947175986469639d, y: 0.4770283645380491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373568137462821d, y: 0.5724082878587756d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05196179360291531d, y: 0.9236615185446071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4708206214181566d, y: 0.6466581633933592d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891539658973041d, y: 0.7725388970066279d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9192537732699697d, y: 0.6246817362196696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4825341373158203d, y: 0.8280864424309741d), new NpgsqlTypes.NpgsqlPoint(x: 0.44649161277644456d, y: 0.1165137718058229d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4307655284481249d, y: 0.8482117538228872d), new NpgsqlTypes.NpgsqlPoint(x: 0.17145089744226671d, y: 0.9871729346191273d), new NpgsqlTypes.NpgsqlPoint(x: 0.48315406381534953d, y: 0.5971999581026546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020211653349785252d, y: 0.45920586996362633d), new NpgsqlTypes.NpgsqlPoint(x: 0.2074690244790105d, y: 0.5547205136781371d), new NpgsqlTypes.NpgsqlPoint(x: 0.08213642652410225d, y: 0.7828101358619454d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30753301629746055d, y: 0.9007655156210884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049141891127042d, y: 0.9235082685911837d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590409148249647d, y: 0.9764317388715169d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.714637707532941d, y: 0.1978981268897262d), new NpgsqlTypes.NpgsqlPoint(x: 0.08154599762762837d, y: 0.9137132253546858d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265709838033854d, y: 0.48704151160480613d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31444109934183917d, y: 0.21737798084787163d), new NpgsqlTypes.NpgsqlPoint(x: 0.20440292452926856d, y: 0.3048928534066373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4306745212183247d, y: 0.5131734684242764d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6057277293173672d, y: 0.9467250982001313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9084861339896735d, y: 0.4540994987589553d), new NpgsqlTypes.NpgsqlPoint(x: 0.29020592950489166d, y: 0.46080530180919166d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.553625583862357d, y: 0.17909933806671452d), new NpgsqlTypes.NpgsqlPoint(x: 0.308251794073214d, y: 0.16984310109093947d), new NpgsqlTypes.NpgsqlPoint(x: 0.02596816168021654d, y: 0.02997030508792564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5211194154428882d, y: 0.4284714505220957d), new NpgsqlTypes.NpgsqlPoint(x: 0.554165184276595d, y: 0.1045155153598617d), new NpgsqlTypes.NpgsqlPoint(x: 0.01188122255561419d, y: 0.16049729892506126d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8865784366856265d, y: 0.6022203607415296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163458430424091d, y: 0.25993969589480326d), new NpgsqlTypes.NpgsqlPoint(x: 0.14879425206922947d, y: 0.7159314259548543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6867196971903929d, y: 0.8076094334101356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9010610781844616d, y: 0.7605732426531118d), new NpgsqlTypes.NpgsqlPoint(x: 0.23327651224127888d, y: 0.922148798220791d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9367563457947258d, y: 0.2858862953706728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396822177692417d, y: 0.1592524333605384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7902347035997488d, y: 0.8789604907283047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1849944188314342d, y: 0.5507733512811172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312889820086285d, y: 0.6018908838430707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227991871250505d, y: 0.26909983255651326d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4241157187634409d, y: 0.08246396294019864d), new NpgsqlTypes.NpgsqlPoint(x: 0.3073409032604356d, y: 0.06925456693787457d), new NpgsqlTypes.NpgsqlPoint(x: 0.396308118557274d, y: 0.2076594813375574d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49086001413789027d, y: 0.08883777879498311d), new NpgsqlTypes.NpgsqlPoint(x: 0.27862961338116066d, y: 0.21804741105589875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4242708267616565d, y: 0.3982986446465222d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2942541461316265d, y: 0.1843534493681923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6892702423637949d, y: 0.5733986702450029d), new NpgsqlTypes.NpgsqlPoint(x: 0.34569001374624975d, y: 0.8857237841838878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5500271734646204d, y: 0.28275993055439474d), new NpgsqlTypes.NpgsqlPoint(x: 0.037520376032489366d, y: 0.3950876235684839d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798925468756186d, y: 0.32765316368140374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33135088909745525d, y: 0.39142800113700393d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403926046384319d, y: 0.9781971657941638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342590878002235d, y: 0.5177895580595703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04379660771856353d, y: 0.35077900032993015d), new NpgsqlTypes.NpgsqlPoint(x: 0.2290784995565469d, y: 0.9070762253716298d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766917479317724d, y: 0.43979617522156733d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42226350373252286d, y: 0.629728798072713d), new NpgsqlTypes.NpgsqlPoint(x: 0.22225637979476165d, y: 0.8984745636226085d), new NpgsqlTypes.NpgsqlPoint(x: 0.15901784194587776d, y: 0.9577649506124252d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5655185968998533d, y: 0.3069220236302005d), new NpgsqlTypes.NpgsqlPoint(x: 0.17393559678556647d, y: 0.18270122601755734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2795370652285708d, y: 0.5639199089930487d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02977563525047d, y: 0.4796031905149032d), new NpgsqlTypes.NpgsqlPoint(x: 0.43001049893123855d, y: 0.07249594331342557d), new NpgsqlTypes.NpgsqlPoint(x: 0.21110639513231888d, y: 0.19010788727515326d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23027767130663668d, y: 0.45364105060918913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164333526101549d, y: 0.785635267338085d), new NpgsqlTypes.NpgsqlPoint(x: 0.40172207611335d, y: 0.12515229016288432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21221157012686143d, y: 0.06469787669924287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157252813493403d, y: 0.5131370410161046d), new NpgsqlTypes.NpgsqlPoint(x: 0.36613400758973336d, y: 0.16712631367653386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8171917589200829d, y: 0.7700004474128181d), new NpgsqlTypes.NpgsqlPoint(x: 0.07400083114279876d, y: 0.4067189224641017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176775521121296d, y: 0.4667144768782492d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23492863485402027d, y: 0.10293898369453647d), new NpgsqlTypes.NpgsqlPoint(x: 0.22991734554916188d, y: 0.9053214542025221d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487261403885002d, y: 0.43277918819098005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12131177031511442d, y: 0.231696771233457d), new NpgsqlTypes.NpgsqlPoint(x: 0.968097586590159d, y: 0.40781700194233617d), new NpgsqlTypes.NpgsqlPoint(x: 0.517052049711405d, y: 0.976586740129819d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746883141384989d, y: 0.2574234525018372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604379028995232d, y: 0.25820650230972075d), new NpgsqlTypes.NpgsqlPoint(x: 0.18115912334174433d, y: 0.5018628016449906d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.611737838574302d, y: 0.6986325940875184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4572996003113652d, y: 0.5779827416939849d), new NpgsqlTypes.NpgsqlPoint(x: 0.20806670251417458d, y: 0.7233994507812352d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769193512525165d, y: 0.4310509665263428d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846636298988553d, y: 0.5465198915741788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299997424026015d, y: 0.2360535138034734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16188725758371947d, y: 0.8872374037006734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833747203721799d, y: 0.6829805360294691d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421064721474028d, y: 0.07315006229660193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32339460060197d, y: 0.5979336230083994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3878378217481828d, y: 0.5348953889274373d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282717802821395d, y: 0.5033528518383398d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8952929250629422d, y: 0.4667298173859483d), new NpgsqlTypes.NpgsqlPoint(x: 0.04820119605868134d, y: 0.9513650152690234d), new NpgsqlTypes.NpgsqlPoint(x: 0.0459804024532271d, y: 0.2886327227555524d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8411220919908715d, y: 0.9012277691858462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378156197161523d, y: 0.10469687096772862d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622627520687946d, y: 0.4758792548572356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6882759934767935d, y: 0.3582088783157442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218731562040751d, y: 0.7719237761492064d), new NpgsqlTypes.NpgsqlPoint(x: 0.173621580852513d, y: 0.4381599379041413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17410391991900942d, y: 0.6770975864988482d), new NpgsqlTypes.NpgsqlPoint(x: 0.991577103389409d, y: 0.6490722883175176d), new NpgsqlTypes.NpgsqlPoint(x: 0.46802315195690736d, y: 0.6753959703350202d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9123003776216463d, y: 0.6719049843845986d), new NpgsqlTypes.NpgsqlPoint(x: 0.29761037293541226d, y: 0.13035904687318323d), new NpgsqlTypes.NpgsqlPoint(x: 0.3425895764011684d, y: 0.9487456057333508d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 108;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 147, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 119, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 136, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 152, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 39))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 104, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[8], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[9], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[10], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[11], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[12], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[13], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[14], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[15], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

