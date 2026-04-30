

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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6185225791375966d, y: 0.6826236526915227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6044498994779229d, y: 0.3632817681440782d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047116867738897d, y: 0.6600769634415687d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32386344849237225d, y: 0.8771592028138858d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213901677963793d, y: 0.7445824998331053d), new NpgsqlTypes.NpgsqlPoint(x: 0.3495539003667648d, y: 0.10340794273413034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5807452873977837d, y: 0.8968195265515505d), new NpgsqlTypes.NpgsqlPoint(x: 0.511025935271707d, y: 0.23604948536521364d), new NpgsqlTypes.NpgsqlPoint(x: 0.368422746241611d, y: 0.7354019032248252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12771938157966234d, y: 0.47718634431944595d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632849947762768d, y: 0.14179622736792563d), new NpgsqlTypes.NpgsqlPoint(x: 0.589872452043435d, y: 0.6130938541551598d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3815905788304641d, y: 0.9537350007323544d), new NpgsqlTypes.NpgsqlPoint(x: 0.4375612783301822d, y: 0.7165489013725627d), new NpgsqlTypes.NpgsqlPoint(x: 0.055729895027937126d, y: 0.9822765761693608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07986281053937616d, y: 0.5614031040895616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3391415553086359d, y: 0.4866116077399901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073300925303661d, y: 0.6016495393417073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6941032885416585d, y: 0.9475717183575796d), new NpgsqlTypes.NpgsqlPoint(x: 0.40547501633954874d, y: 0.2762514570454909d), new NpgsqlTypes.NpgsqlPoint(x: 0.11785094918591343d, y: 0.0791719570160172d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33194765607059995d, y: 0.4160808850765847d), new NpgsqlTypes.NpgsqlPoint(x: 0.04641987416933202d, y: 0.3411208003070888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350091538162183d, y: 0.677029251950237d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7741690276200928d, y: 0.8824721462678624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668098771257331d, y: 0.7192838358481206d), new NpgsqlTypes.NpgsqlPoint(x: 0.011730443882162045d, y: 0.9452377823904509d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7914174329037544d, y: 0.3581357383742102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466298229543251d, y: 0.5566619179779874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3155402994625368d, y: 0.9366831397850893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9352655280986589d, y: 0.8221932977959835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941458477361206d, y: 0.32499012523176984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850824603086108d, y: 0.6615486904438235d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7181208641718195d, y: 0.4187345785009591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540479421202112d, y: 0.34530895863199973d), new NpgsqlTypes.NpgsqlPoint(x: 0.052558349835347906d, y: 0.7543233153803319d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7921018881767362d, y: 0.1148275759930899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025859093994427d, y: 0.6276970870649549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206363046227436d, y: 0.1880418545961542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6308992868031459d, y: 0.3500029440415515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8284605761636592d, y: 0.36600872791954686d), new NpgsqlTypes.NpgsqlPoint(x: 0.12450870010208248d, y: 0.9819209913506556d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9822878015394327d, y: 0.6759806588657228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210232565761916d, y: 0.023690313020995224d), new NpgsqlTypes.NpgsqlPoint(x: 0.2505150872665327d, y: 0.494840317114176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5925950457633065d, y: 0.5007466127148347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9265407108562014d, y: 0.6898456797606628d), new NpgsqlTypes.NpgsqlPoint(x: 0.23584943640406175d, y: 0.8818455658066784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1814555947159091d, y: 0.13302369258771596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306387730490056d, y: 0.4106661885953137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500486716995723d, y: 0.06613813038704253d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024886631563954098d, y: 0.3380344503316072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525002284745698d, y: 0.3346395152245877d), new NpgsqlTypes.NpgsqlPoint(x: 0.06753448618791269d, y: 0.17763655816909862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6850523253872448d, y: 0.9880965775943469d), new NpgsqlTypes.NpgsqlPoint(x: 0.38718308511542154d, y: 0.5456706632794837d), new NpgsqlTypes.NpgsqlPoint(x: 0.04102911523603703d, y: 0.9714647453236852d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16406447097268562d, y: 0.4738381590035151d), new NpgsqlTypes.NpgsqlPoint(x: 0.735454974184688d, y: 0.10476088546866946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195679048847497d, y: 0.6198768719382272d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7523112992037045d, y: 0.4173453679954867d), new NpgsqlTypes.NpgsqlPoint(x: 0.10767583843853223d, y: 0.7284591498852101d), new NpgsqlTypes.NpgsqlPoint(x: 0.18953189383910507d, y: 0.25650634861829336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06273118377353004d, y: 0.3953330357507271d), new NpgsqlTypes.NpgsqlPoint(x: 0.827691043304956d, y: 0.3568252861277045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3994746508521204d, y: 0.8237323209233953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4632746144422243d, y: 0.8977006464634301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938643977347608d, y: 0.6947439859935748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191729527601841d, y: 0.15756221705471607d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.699817524711579d, y: 0.6859154857107863d), new NpgsqlTypes.NpgsqlPoint(x: 0.2554602001573185d, y: 0.14939656643479815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2265349027395005d, y: 0.37956784386676934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6935826329748042d, y: 0.32085366744735677d), new NpgsqlTypes.NpgsqlPoint(x: 0.30848420184415926d, y: 0.1778531900127993d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654724041373944d, y: 0.6613836980911012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34652513900939397d, y: 0.2548467895593073d), new NpgsqlTypes.NpgsqlPoint(x: 0.26070042422036843d, y: 0.17701269334755854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519693518618558d, y: 0.591484169888697d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09910680326077403d, y: 0.39250151487419804d), new NpgsqlTypes.NpgsqlPoint(x: 0.9445413400001582d, y: 0.7836756079524215d), new NpgsqlTypes.NpgsqlPoint(x: 0.41143621798365837d, y: 0.3937943927631077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32514043603579346d, y: 0.25292384173021276d), new NpgsqlTypes.NpgsqlPoint(x: 0.04850490648097594d, y: 0.5323534511610393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396937150178661d, y: 0.0685626616214835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5577172851714995d, y: 0.6817660894462817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726395800253886d, y: 0.7510019888305678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033630356755868d, y: 0.07905609043777861d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6815706067221802d, y: 0.03987074920613254d), new NpgsqlTypes.NpgsqlPoint(x: 0.2044813649224917d, y: 0.33170401114351444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8973059613288599d, y: 0.30533761834140727d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.642473787340571d, y: 0.5003246871306634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7285638835991205d, y: 0.7588237283023045d), new NpgsqlTypes.NpgsqlPoint(x: 0.06184329265491051d, y: 0.836224762942446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5527761403171041d, y: 0.9950200128752884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929289558038934d, y: 0.18333144914719124d), new NpgsqlTypes.NpgsqlPoint(x: 0.13279616794898463d, y: 0.5744272740819636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3337406566908633d, y: 0.826834045276696d), new NpgsqlTypes.NpgsqlPoint(x: 0.04499689819558994d, y: 0.16077588147268407d), new NpgsqlTypes.NpgsqlPoint(x: 0.04528679021164039d, y: 0.7086328428727078d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3483166931222731d, y: 0.975989773574821d), new NpgsqlTypes.NpgsqlPoint(x: 0.06206133412075687d, y: 0.21462659359753378d), new NpgsqlTypes.NpgsqlPoint(x: 0.14238988388515383d, y: 0.13652357463375087d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8402468925288457d, y: 0.7511931282663702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481960812480371d, y: 0.03642642856977907d), new NpgsqlTypes.NpgsqlPoint(x: 0.08386182617395688d, y: 0.6110912940043867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36420609138811544d, y: 0.3403887157970398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578928783798219d, y: 0.7937426137162856d), new NpgsqlTypes.NpgsqlPoint(x: 0.18488369203352806d, y: 0.9817547036930416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47167242791985575d, y: 0.9255252921508533d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681681320732819d, y: 0.7198668630554351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251156213856869d, y: 0.19606199157162085d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.905225218346696d, y: 0.9447034304196334d), new NpgsqlTypes.NpgsqlPoint(x: 0.08504950878900042d, y: 0.8131761293145039d), new NpgsqlTypes.NpgsqlPoint(x: 0.2865018719540614d, y: 0.1561172741048753d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10539943104971106d, y: 0.8277798280759231d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438408407492018d, y: 0.4039705866225993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219928438948619d, y: 0.333078595898628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9319639388318831d, y: 0.29902348501628206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443251898339066d, y: 0.7223531108181981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711707625700184d, y: 0.018563154344326982d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3744162217430984d, y: 0.440105739379984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243353217684036d, y: 0.7912239401247245d), new NpgsqlTypes.NpgsqlPoint(x: 0.09589152178034521d, y: 0.45384950279050584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03943189753046816d, y: 0.8764032470692469d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239185650356024d, y: 0.34749736748582194d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770307802058267d, y: 0.5055506738848787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6911025225528957d, y: 0.08019595051456485d), new NpgsqlTypes.NpgsqlPoint(x: 0.04186072797126961d, y: 0.47140678621756005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5033564111377793d, y: 0.9745090220078213d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4435429106340649d, y: 0.8736918395322523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204272577928048d, y: 0.8955904379714722d), new NpgsqlTypes.NpgsqlPoint(x: 0.7104148426266028d, y: 0.24861373980711787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5578377144069798d, y: 0.9097056402775345d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923987826888864d, y: 0.8764742714345142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8424375263367788d, y: 0.5016206869103488d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40978940926669616d, y: 0.05164583622905072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6784660816836179d, y: 0.1561743045318078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4511142159879663d, y: 0.9567270215527993d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7950001369313908d, y: 0.9356174089412312d), new NpgsqlTypes.NpgsqlPoint(x: 0.35707801398742833d, y: 0.9688564926670855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818679540225748d, y: 0.5209882338265149d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7614833135373387d, y: 0.46580365876102436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808848584609594d, y: 0.9766763421832111d), new NpgsqlTypes.NpgsqlPoint(x: 0.3353710433133297d, y: 0.09169359871003613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05857312969241213d, y: 0.7794044647435432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668269326762927d, y: 0.17704366191703091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971078695490332d, y: 0.02519635897849204d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5969761825520921d, y: 0.5919199498946816d), new NpgsqlTypes.NpgsqlPoint(x: 0.05992428288417129d, y: 0.8347568901039703d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771779108851684d, y: 0.0784651493573364d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42608279851807374d, y: 0.3613397980436507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683072633303687d, y: 0.43556335660590384d), new NpgsqlTypes.NpgsqlPoint(x: 0.143970807506692d, y: 0.8801252677719801d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010376864546905673d, y: 0.5866582777940474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032182140021923d, y: 0.7852146531538082d), new NpgsqlTypes.NpgsqlPoint(x: 0.903916572171818d, y: 0.14538739274699142d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17231492583861674d, y: 0.26434672761913236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759401020145835d, y: 0.17622795259491686d), new NpgsqlTypes.NpgsqlPoint(x: 0.152718965222557d, y: 0.019565993849521846d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5506072258057744d, y: 0.050337581272797305d), new NpgsqlTypes.NpgsqlPoint(x: 0.681481390196612d, y: 0.6783305888953538d), new NpgsqlTypes.NpgsqlPoint(x: 0.4208019188101306d, y: 0.13253676638739897d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46712644601945985d, y: 0.10114582862529442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166669755597272d, y: 0.31249288766698924d), new NpgsqlTypes.NpgsqlPoint(x: 0.014515567402166307d, y: 0.11628488692073236d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6321617359017612d, y: 0.8253587766305679d), new NpgsqlTypes.NpgsqlPoint(x: 0.44186360391180857d, y: 0.026743920481031025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7577037038543469d, y: 0.8298954683775113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5988599398256879d, y: 0.44034684094570786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543009663927819d, y: 0.1081659170676551d), new NpgsqlTypes.NpgsqlPoint(x: 0.16844689998554774d, y: 0.9038302775289343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8028593029120868d, y: 0.5433920794223657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209318937566669d, y: 0.5255636800317595d), new NpgsqlTypes.NpgsqlPoint(x: 0.0760357837191673d, y: 0.29467690497228605d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3335351088249665d, y: 0.18241136103397848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2696830663085902d, y: 0.18080309740863d), new NpgsqlTypes.NpgsqlPoint(x: 0.5154213819985992d, y: 0.39123923167144026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5294319579127735d, y: 0.520575566777239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3123897166547881d, y: 0.6516625911132704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327885306428719d, y: 0.45689515408234493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9886162812934041d, y: 0.3583072289179371d), new NpgsqlTypes.NpgsqlPoint(x: 0.05591015113400144d, y: 0.6994865670054938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674447456661455d, y: 0.7765728279976551d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4933537009036517d, y: 0.1654360223334077d), new NpgsqlTypes.NpgsqlPoint(x: 0.1615618805052973d, y: 0.17316614225604365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237596175226395d, y: 0.9923084220609596d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688773783347443d, y: 0.7914362138405447d), new NpgsqlTypes.NpgsqlPoint(x: 0.27212347828696637d, y: 0.3350610364682478d), new NpgsqlTypes.NpgsqlPoint(x: 0.02424265139476356d, y: 0.8137119229084868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7423049680287613d, y: 0.9322661706121739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661729688133298d, y: 0.8925335250308505d), new NpgsqlTypes.NpgsqlPoint(x: 0.174087009006603d, y: 0.3184715382970841d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13454745108284005d, y: 0.12175258581058479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524897321689369d, y: 0.5886337235606847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655425519990329d, y: 0.01632256538706567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07073607425653716d, y: 0.7048959030372698d), new NpgsqlTypes.NpgsqlPoint(x: 0.05095668942323339d, y: 0.3749954654441745d), new NpgsqlTypes.NpgsqlPoint(x: 0.31018715514736517d, y: 0.36755459359522724d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12592236568609472d, y: 0.9932510570165567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4596663939625807d, y: 0.1399610562100435d), new NpgsqlTypes.NpgsqlPoint(x: 0.41760094847368123d, y: 0.5158097804742869d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7698262925512751d, y: 0.009065255233328795d), new NpgsqlTypes.NpgsqlPoint(x: 0.06204270373112297d, y: 0.3257270794567533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761892180454562d, y: 0.15207796627948433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8276538077592368d, y: 0.846014077218432d), new NpgsqlTypes.NpgsqlPoint(x: 0.43400051505090564d, y: 0.8005392096038327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114590065689413d, y: 0.01794669232493551d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7604439427454278d, y: 0.9486468133848247d), new NpgsqlTypes.NpgsqlPoint(x: 0.572166169183847d, y: 0.8622770018570513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868886881124913d, y: 0.07703965550288272d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007805598593769503d, y: 0.16547552815103406d), new NpgsqlTypes.NpgsqlPoint(x: 0.28924872275062596d, y: 0.018783935773308946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5989414113884357d, y: 0.8152389099686698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5562036215773921d, y: 0.1761339445616904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3270837920181551d, y: 0.774151289101344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305474638409434d, y: 0.7834909491037508d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8219613443702682d, y: 0.016870177052274227d), new NpgsqlTypes.NpgsqlPoint(x: 0.795610236722931d, y: 0.25345710833559787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5092678905699906d, y: 0.09974399774820408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.307386755221599d, y: 0.23912030944367613d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288036049590936d, y: 0.36912553567697937d), new NpgsqlTypes.NpgsqlPoint(x: 0.3907216087770977d, y: 0.4284561369042519d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10286455915150272d, y: 0.593986072738661d), new NpgsqlTypes.NpgsqlPoint(x: 0.69589689704854d, y: 0.6049116592963051d), new NpgsqlTypes.NpgsqlPoint(x: 0.4784237273708464d, y: 0.9688980675931337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11207086812055644d, y: 0.9520939866021216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795578619544428d, y: 0.4060277372457721d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980667423917985d, y: 0.059313650319835376d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21732913138725207d, y: 0.14322758246937672d), new NpgsqlTypes.NpgsqlPoint(x: 0.30896670473793864d, y: 0.2656465583780233d), new NpgsqlTypes.NpgsqlPoint(x: 0.17929063313768756d, y: 0.42944975046027256d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01383548987328076d, y: 0.4196630532782103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345635734584753d, y: 0.17051650428193166d), new NpgsqlTypes.NpgsqlPoint(x: 0.13721689771201107d, y: 0.09227359086650622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6907966573960103d, y: 0.9813048334394132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7248981764175643d, y: 0.36837998244225134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777760209901307d, y: 0.9511035589995359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2612393658944473d, y: 0.16437283805165026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752148520027549d, y: 0.12183573195044939d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842309645828504d, y: 0.24082117038444417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46530615412654297d, y: 0.46205475357223025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4244133290738825d, y: 0.6041773532050051d), new NpgsqlTypes.NpgsqlPoint(x: 0.25820841605118505d, y: 0.7219303216292567d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8018445877306172d, y: 0.6160860336358658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824602037206018d, y: 0.9322407577558943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7012209682481793d, y: 0.2465962119967645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6212859728889162d, y: 0.48728248370087024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099572465263808d, y: 0.27561636180548554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218149796689882d, y: 0.8232502541428836d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5070350518117452d, y: 0.15886886242151943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106759112390113d, y: 0.8091572304468965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1481487110681372d, y: 0.8061717801377417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36785148513717536d, y: 0.8468099323814235d), new NpgsqlTypes.NpgsqlPoint(x: 0.008184479291920677d, y: 0.24742276827251175d), new NpgsqlTypes.NpgsqlPoint(x: 0.382216559875834d, y: 0.4761956561211297d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04374081588627676d, y: 0.2838151470711061d), new NpgsqlTypes.NpgsqlPoint(x: 0.1093282742367373d, y: 0.292474133840642d), new NpgsqlTypes.NpgsqlPoint(x: 0.44058929677996794d, y: 0.8668219537225911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7454305782188728d, y: 0.04407053067868605d), new NpgsqlTypes.NpgsqlPoint(x: 0.33298478940009457d, y: 0.28563448902275135d), new NpgsqlTypes.NpgsqlPoint(x: 0.3311104442003763d, y: 0.7144404254039223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6119874113844328d, y: 0.07213866545325798d), new NpgsqlTypes.NpgsqlPoint(x: 0.12125023833882753d, y: 0.20757405718408317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106228643048758d, y: 0.643232173549327d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6152233518017889d, y: 0.2575667119572451d), new NpgsqlTypes.NpgsqlPoint(x: 0.253455225305661d, y: 0.2970748418165421d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624043478769605d, y: 0.720296322349372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4219157140825799d, y: 0.32144132408403425d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095878266253967d, y: 0.06138301819093739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881217028435633d, y: 0.305023474019703d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9950117162325077d, y: 0.86305180990944d), new NpgsqlTypes.NpgsqlPoint(x: 0.19791142427275632d, y: 0.9220714188831179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859407177107323d, y: 0.29056898489469074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16867120745838726d, y: 0.12118176875103503d), new NpgsqlTypes.NpgsqlPoint(x: 0.49615684082009115d, y: 0.33597442321518534d), new NpgsqlTypes.NpgsqlPoint(x: 0.23681904524098862d, y: 0.3929043159253699d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9360214309308733d, y: 0.5334719266032858d), new NpgsqlTypes.NpgsqlPoint(x: 0.24284754052063617d, y: 0.43877304986288124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4349593974809822d, y: 0.5439855550478595d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4866919293598233d, y: 0.10088943848894283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6007276651772394d, y: 0.07220892977616522d), new NpgsqlTypes.NpgsqlPoint(x: 0.08962676618262166d, y: 0.0341121348103709d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27247933555807313d, y: 0.8048389972145926d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078573455833201d, y: 0.32541161290951104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567048662253059d, y: 0.22308388868678675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23175092947283904d, y: 0.3587082165640423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377949564239483d, y: 0.9262349342438506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451027600084407d, y: 0.7650976355124267d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4377700917548173d, y: 0.6515779084523634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390995491054536d, y: 0.38541342652474797d), new NpgsqlTypes.NpgsqlPoint(x: 0.33239545529734993d, y: 0.24022836490077992d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29061301695754016d, y: 0.3666925601731852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9131754012094011d, y: 0.05363410146027359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274452654953594d, y: 0.5439007801084018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5771953305225679d, y: 0.4498701226893793d), new NpgsqlTypes.NpgsqlPoint(x: 0.045741700198071555d, y: 0.2945234217493359d), new NpgsqlTypes.NpgsqlPoint(x: 0.39265665926393467d, y: 0.6078409051651467d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7464163042898257d, y: 0.9328496743197474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8606695834254356d, y: 0.7504013731401673d), new NpgsqlTypes.NpgsqlPoint(x: 0.14021282372401989d, y: 0.07323137205285668d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9963163043307843d, y: 0.14336410125718435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8985229992321152d, y: 0.7476742649335963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861142643783816d, y: 0.005702848455900411d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23547215824120726d, y: 0.9990655335821731d), new NpgsqlTypes.NpgsqlPoint(x: 0.33704212541691325d, y: 0.33564865984123327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164058594714296d, y: 0.5706731672450206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8707252521179687d, y: 0.8337330307092763d), new NpgsqlTypes.NpgsqlPoint(x: 0.06291154027330959d, y: 0.42247106053370675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970603034716728d, y: 0.09986322956866289d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6426812215832189d, y: 0.8000087632785076d), new NpgsqlTypes.NpgsqlPoint(x: 0.17831324795811476d, y: 0.06194783368925816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3695138939850019d, y: 0.5828221229631417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5909273206301331d, y: 0.14226883610830388d), new NpgsqlTypes.NpgsqlPoint(x: 0.40570608173309075d, y: 0.03438322736870858d), new NpgsqlTypes.NpgsqlPoint(x: 0.400642444678034d, y: 0.5802512907545381d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5957033474528255d, y: 0.522355321440532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930671524699968d, y: 0.2743365629704583d), new NpgsqlTypes.NpgsqlPoint(x: 0.720883856815137d, y: 0.5968402952234273d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926492104569334d, y: 0.7763329795354096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3784639972939394d, y: 0.8079764215176238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254062489738815d, y: 0.3381767304226537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20371295323060068d, y: 0.3905357367051021d), new NpgsqlTypes.NpgsqlPoint(x: 0.26316751952049144d, y: 0.8600587225428833d), new NpgsqlTypes.NpgsqlPoint(x: 0.550695149526363d, y: 0.1838764126842607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9908014607875596d, y: 0.7116515263014935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183486484323928d, y: 0.03833939500392247d), new NpgsqlTypes.NpgsqlPoint(x: 0.007985493669316335d, y: 0.9751223058743285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5360812066007897d, y: 0.8100947535459161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029382404937641d, y: 0.0516476282014634d), new NpgsqlTypes.NpgsqlPoint(x: 0.006101077997883508d, y: 0.0001227487046372433d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7127188813523634d, y: 0.16424024049805397d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401570637848985d, y: 0.10268205982181022d), new NpgsqlTypes.NpgsqlPoint(x: 0.33564708308744573d, y: 0.8156230642449049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04211721432578652d, y: 0.3357734148922028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164284236411765d, y: 0.41783606446548616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541239452192202d, y: 0.5799122354146572d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17798193448729493d, y: 0.5954394200972116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143684866167984d, y: 0.24630037351058165d), new NpgsqlTypes.NpgsqlPoint(x: 0.4601785822904402d, y: 0.969776905338191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00027163445986566614d, y: 0.18588285916500724d), new NpgsqlTypes.NpgsqlPoint(x: 0.607898203417744d, y: 0.806659935021139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266375943040275d, y: 0.5607855661490084d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3980087781301812d, y: 0.8301647480334804d), new NpgsqlTypes.NpgsqlPoint(x: 0.14065239913061234d, y: 0.3894768325334017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7688337242500538d, y: 0.02846180383749064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2729976625018635d, y: 0.6333001196211366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491344598096475d, y: 0.7327915067683712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198618381599534d, y: 0.6621182390106161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11136354089896128d, y: 0.4489136028637468d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941471321840719d, y: 0.454445482684519d), new NpgsqlTypes.NpgsqlPoint(x: 0.12997631595766757d, y: 0.04604334721933767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3567527929595753d, y: 0.8490491167326606d), new NpgsqlTypes.NpgsqlPoint(x: 0.42585697091727903d, y: 0.1943056854692986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7947419647684923d, y: 0.21480576482199398d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25732824013743794d, y: 0.7553782246726933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974980635785375d, y: 0.8627624267149694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556336527184176d, y: 0.03258806890077026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778598514153737d, y: 0.6427522861355742d), new NpgsqlTypes.NpgsqlPoint(x: 0.41993731986852023d, y: 0.29873557831447506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943556151462577d, y: 0.31938430656714356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7832678592229536d, y: 0.06519946384192155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404616887771964d, y: 0.9616539016759142d), new NpgsqlTypes.NpgsqlPoint(x: 0.36064621469535585d, y: 0.7461729425963093d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15667023090629095d, y: 0.29323507682778416d), new NpgsqlTypes.NpgsqlPoint(x: 0.36547674040063405d, y: 0.17916596949497354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916129377247537d, y: 0.7712192675796914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19930748238177665d, y: 0.15144451409843507d), new NpgsqlTypes.NpgsqlPoint(x: 0.2083136932086025d, y: 0.820494778489988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762767498469374d, y: 0.09362328930495123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46311396233194146d, y: 0.5195862663412276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092360229126327d, y: 0.06039681602692404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823573638314261d, y: 0.8436597749566793d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8538015821080621d, y: 0.7662320994348836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325162812903144d, y: 0.3513688465506293d), new NpgsqlTypes.NpgsqlPoint(x: 0.16407385337548075d, y: 0.11038121912280141d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8659457256097373d, y: 0.5642519902074756d), new NpgsqlTypes.NpgsqlPoint(x: 0.460720101070506d, y: 0.15801242241076185d), new NpgsqlTypes.NpgsqlPoint(x: 0.8314030833241074d, y: 0.14617896479418713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3257938172855006d, y: 0.34446552386760565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3586541928118442d, y: 0.1277390577171933d), new NpgsqlTypes.NpgsqlPoint(x: 0.23365236996819827d, y: 0.2987153607965277d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29145581566286705d, y: 0.45043366180964817d), new NpgsqlTypes.NpgsqlPoint(x: 0.17173214899180422d, y: 0.6198847900931291d), new NpgsqlTypes.NpgsqlPoint(x: 0.6292901727340705d, y: 0.1595423805418542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0647438693431428d, y: 0.08089084500852806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729090566692149d, y: 0.9863532891428518d), new NpgsqlTypes.NpgsqlPoint(x: 0.3272992475077927d, y: 0.7145701267150909d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38837325375259946d, y: 0.08255594348352346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579316902013552d, y: 0.011346739353434332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9950246497475829d, y: 0.798948561670666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8372520784757975d, y: 0.5031120735106386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360560863090148d, y: 0.22070448479743787d), new NpgsqlTypes.NpgsqlPoint(x: 0.14499933421768607d, y: 0.773704439849275d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26055447005657917d, y: 0.803306066564533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728225546679824d, y: 0.6930274751565304d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897117548309218d, y: 0.8215326746842139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31385587905486645d, y: 0.6352055011797024d), new NpgsqlTypes.NpgsqlPoint(x: 0.3779253741264538d, y: 0.4625189306582027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7041276384184157d, y: 0.8366164491393522d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.654975676761857d, y: 0.5809851252671016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863721941848025d, y: 0.2908716202504983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813128332529162d, y: 0.7024766689943333d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17511815956348908d, y: 0.559204531009966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4153413342356269d, y: 0.8926303227790637d), new NpgsqlTypes.NpgsqlPoint(x: 0.10025770682149215d, y: 0.8086267328560183d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2756485865483891d, y: 0.7696128957059547d), new NpgsqlTypes.NpgsqlPoint(x: 0.18716193265956005d, y: 0.4399861150674539d), new NpgsqlTypes.NpgsqlPoint(x: 0.19578824019186192d, y: 0.5829774248779146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9751933711608661d, y: 0.7646092813659764d), new NpgsqlTypes.NpgsqlPoint(x: 0.16243173024016533d, y: 0.20857126644975177d), new NpgsqlTypes.NpgsqlPoint(x: 0.08634809970778012d, y: 0.9903658033323796d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7220958324644474d, y: 0.47961250696655655d), new NpgsqlTypes.NpgsqlPoint(x: 0.38084775000346505d, y: 0.738285728991167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7696914289727207d, y: 0.14795576576939817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11217851786155686d, y: 0.41226111624085715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2257332362582819d, y: 0.8613959237695968d), new NpgsqlTypes.NpgsqlPoint(x: 0.044613602771398364d, y: 0.5308403626206089d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7496229356003099d, y: 0.8597918226058525d), new NpgsqlTypes.NpgsqlPoint(x: 0.23563170169669823d, y: 0.05097197201461079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027918583406946d, y: 0.7973645034378275d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14545327848296252d, y: 0.28123935630324115d), new NpgsqlTypes.NpgsqlPoint(x: 0.925637859122666d, y: 0.11524819795005214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201286480989759d, y: 0.6947896326963854d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42815007991456544d, y: 0.19731137090481576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2557785683798496d, y: 0.6202354629961538d), new NpgsqlTypes.NpgsqlPoint(x: 0.1870280161957354d, y: 0.8137802413137242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1857843068442383d, y: 0.8866381944969915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8400914008372361d, y: 0.6571589801052525d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924862291902996d, y: 0.6964872900283785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5236951235344969d, y: 0.12918042454019907d), new NpgsqlTypes.NpgsqlPoint(x: 0.1394571699184629d, y: 0.2851922427580006d), new NpgsqlTypes.NpgsqlPoint(x: 0.3886661564169709d, y: 0.14165746170923632d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6307641393370292d, y: 0.7792944460130443d), new NpgsqlTypes.NpgsqlPoint(x: 0.019956083109122114d, y: 0.9050659061980683d), new NpgsqlTypes.NpgsqlPoint(x: 0.777084104670357d, y: 0.8645247255205218d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30294432172759533d, y: 0.716006771993224d), new NpgsqlTypes.NpgsqlPoint(x: 0.1168329810041262d, y: 0.0409648071305857d), new NpgsqlTypes.NpgsqlPoint(x: 0.3624408254013135d, y: 0.36373018950146896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2603132078776549d, y: 0.8045810003735023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9914691712167094d, y: 0.1414420260671233d), new NpgsqlTypes.NpgsqlPoint(x: 0.573886759172131d, y: 0.6670056251967533d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03122225706216475d, y: 0.9941627769833509d), new NpgsqlTypes.NpgsqlPoint(x: 0.39393569090634906d, y: 0.7305802822135471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5898400641281988d, y: 0.31616896069532674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6740820832824657d, y: 0.45785238733202327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756949058072586d, y: 0.6804715823058207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473945935736984d, y: 0.3294942738732325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04130885502515036d, y: 0.30180983854649424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102961555208d, y: 0.6369733660325136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902041540629463d, y: 0.24376319678054026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5923759998228283d, y: 0.9517366171641465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651049205617261d, y: 0.5124697591000674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9307905212648567d, y: 0.688117830510879d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06353443461419706d, y: 0.38778006720422764d), new NpgsqlTypes.NpgsqlPoint(x: 0.47178492832031493d, y: 0.5907622828695418d), new NpgsqlTypes.NpgsqlPoint(x: 0.32687636771127104d, y: 0.34367357310982205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9465803183895328d, y: 0.7190714895496895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699099141473536d, y: 0.8399387470454853d), new NpgsqlTypes.NpgsqlPoint(x: 0.43201318466787075d, y: 0.0030931301184278226d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9198697811533305d, y: 0.2839886910332935d), new NpgsqlTypes.NpgsqlPoint(x: 0.49977669960402105d, y: 0.1145170040705924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5899011669974469d, y: 0.3869513742073444d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5285060129035234d, y: 0.3531468695664908d), new NpgsqlTypes.NpgsqlPoint(x: 0.15651828888719066d, y: 0.8750351051589956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460120154766299d, y: 0.4142393042633631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3767262052682513d, y: 0.8643077016960001d), new NpgsqlTypes.NpgsqlPoint(x: 0.34368641572217473d, y: 0.4161616591420859d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689703698585983d, y: 0.5194423964546991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.53069986624905d, y: 0.7195982697090735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546507433245364d, y: 0.47870576709753243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530677026340994d, y: 0.13822940836574749d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8210424655486795d, y: 0.47400265159946464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4919341201505082d, y: 0.3340477010434316d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236677885712152d, y: 0.45352378841368735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7946681200305068d, y: 0.22743083421287758d), new NpgsqlTypes.NpgsqlPoint(x: 0.183483867561132d, y: 0.6171034665656451d), new NpgsqlTypes.NpgsqlPoint(x: 0.14658586876867397d, y: 0.25794574357589684d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15252921681592824d, y: 0.498810483634036d), new NpgsqlTypes.NpgsqlPoint(x: 0.11370982009079289d, y: 0.10479689438106576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4412950090493083d, y: 0.6349324939357828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24601170595502952d, y: 0.016023468999028956d), new NpgsqlTypes.NpgsqlPoint(x: 0.25002856032258525d, y: 0.734277306518634d), new NpgsqlTypes.NpgsqlPoint(x: 0.11409827499706171d, y: 0.4843421904932521d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3492815576422842d, y: 0.31646848625153945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7174870436663949d, y: 0.629394526591497d), new NpgsqlTypes.NpgsqlPoint(x: 0.3799413363246411d, y: 0.9256472981525392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9576874082565362d, y: 0.08508474883226813d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221021043315256d, y: 0.9619324430549087d), new NpgsqlTypes.NpgsqlPoint(x: 0.2930607434064699d, y: 0.1619590127817282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5298439923709277d, y: 0.2568455088464594d), new NpgsqlTypes.NpgsqlPoint(x: 0.1564824559140604d, y: 0.680441888570013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472068152837583d, y: 0.151412438113393d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09180384927159335d, y: 0.9726682048023493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424853576802672d, y: 0.827026878917096d), new NpgsqlTypes.NpgsqlPoint(x: 0.627779366469614d, y: 0.39051549055404466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20799761683073048d, y: 0.39543007306588596d), new NpgsqlTypes.NpgsqlPoint(x: 0.03542868723172454d, y: 0.587776273122242d), new NpgsqlTypes.NpgsqlPoint(x: 0.587833423178156d, y: 0.9394264432779114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8666452536432169d, y: 0.14500751339476925d), new NpgsqlTypes.NpgsqlPoint(x: 0.07993492482678166d, y: 0.2838040990796412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472019970838503d, y: 0.6933929439919554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1525110764467379d, y: 0.06313330581253207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469941367352996d, y: 0.025793451352824293d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641813068446045d, y: 0.02615559481228391d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.364991766268286d, y: 0.32234849960085077d), new NpgsqlTypes.NpgsqlPoint(x: 0.24965589150572476d, y: 0.5500432585968004d), new NpgsqlTypes.NpgsqlPoint(x: 0.2155567448011767d, y: 0.6546390084907072d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5881905654680065d, y: 0.25074215551615653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376951329034405d, y: 0.23553509385316296d), new NpgsqlTypes.NpgsqlPoint(x: 0.963063617269012d, y: 0.3727567205180664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21499111424527428d, y: 0.7985335312944086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8377112452351736d, y: 0.5888529897840987d), new NpgsqlTypes.NpgsqlPoint(x: 0.13608862912417485d, y: 0.22404410835985d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5838606937275775d, y: 0.010391678561484596d), new NpgsqlTypes.NpgsqlPoint(x: 0.1709146830568944d, y: 0.8833999083742733d), new NpgsqlTypes.NpgsqlPoint(x: 0.8620291668178791d, y: 0.7049264672658772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5687707989571593d, y: 0.6234789692960769d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845144526523557d, y: 0.004594419088041701d), new NpgsqlTypes.NpgsqlPoint(x: 0.21174407041760535d, y: 0.5500912867986449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.626796089570626d, y: 0.06430263971083339d), new NpgsqlTypes.NpgsqlPoint(x: 0.155706826179847d, y: 0.034822730065078966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110439660074821d, y: 0.7507767526998356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27611318147638475d, y: 0.9833992776078223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1050761177537195d, y: 0.5278208161297882d), new NpgsqlTypes.NpgsqlPoint(x: 0.34327177469883463d, y: 0.9949400147354425d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5788835178998232d, y: 0.7505846055169899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570027952037842d, y: 0.9213169393562115d), new NpgsqlTypes.NpgsqlPoint(x: 0.45959435901882273d, y: 0.11621715402121735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9293693277302754d, y: 0.32067804016689583d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648542514758582d, y: 0.3567691268836406d), new NpgsqlTypes.NpgsqlPoint(x: 0.37078916613268d, y: 0.6355966242203315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38618591637236066d, y: 0.3963036889793077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661231819097289d, y: 0.6784266490022406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940031166335943d, y: 0.45085471786607023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14045952829303276d, y: 0.9061822982926069d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986182206809229d, y: 0.29022283629087975d), new NpgsqlTypes.NpgsqlPoint(x: 0.27726666118922294d, y: 0.9500628168695326d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8361994855836689d, y: 0.6475185341265777d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286422552678072d, y: 0.429902127625462d), new NpgsqlTypes.NpgsqlPoint(x: 0.881158258713731d, y: 0.31999433345458117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5337342151161363d, y: 0.40112138544943043d), new NpgsqlTypes.NpgsqlPoint(x: 0.53081452847808d, y: 0.4198874430516564d), new NpgsqlTypes.NpgsqlPoint(x: 0.48759769788540586d, y: 0.18944664818246704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7452660135121534d, y: 0.21692135915555544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742475757283667d, y: 0.6776990797536934d), new NpgsqlTypes.NpgsqlPoint(x: 0.41726902387834475d, y: 0.057956027284050804d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43227490943771396d, y: 0.6112055774106516d), new NpgsqlTypes.NpgsqlPoint(x: 0.20453744002651608d, y: 0.31929021319992523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7965211562933612d, y: 0.1865871119169168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.601770498012778d, y: 0.09331962161156138d), new NpgsqlTypes.NpgsqlPoint(x: 0.21755535393790337d, y: 0.6354661045662531d), new NpgsqlTypes.NpgsqlPoint(x: 0.3857826939874932d, y: 0.9483158952384284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13162185827407247d, y: 0.3709797467149648d), new NpgsqlTypes.NpgsqlPoint(x: 0.7207907115810462d, y: 0.5312474220361082d), new NpgsqlTypes.NpgsqlPoint(x: 0.19214297200592478d, y: 0.390178281532789d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7777421391697664d, y: 0.942748355210429d), new NpgsqlTypes.NpgsqlPoint(x: 0.201715802100481d, y: 0.3049221786782651d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259190528846528d, y: 0.8094449747840117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764700506799776d, y: 0.12013359191374662d), new NpgsqlTypes.NpgsqlPoint(x: 0.8999579639660275d, y: 0.11455995361158411d), new NpgsqlTypes.NpgsqlPoint(x: 0.1356187728760787d, y: 0.18340610244121924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43496284843025845d, y: 0.30342789439318096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9856414217700306d, y: 0.22583915985733227d), new NpgsqlTypes.NpgsqlPoint(x: 0.4002263209370893d, y: 0.6178675289230999d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3817384405261405d, y: 0.4934113549766309d), new NpgsqlTypes.NpgsqlPoint(x: 0.14532471933103874d, y: 0.3027646030393173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8791916456585246d, y: 0.40326175186518964d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49405942837303163d, y: 0.8438257048587441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5732575510356722d, y: 0.35462749021823015d), new NpgsqlTypes.NpgsqlPoint(x: 0.29625892361978756d, y: 0.1339824572901659d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4614512864316648d, y: 0.49788582582896235d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367886831463566d, y: 0.552321156801425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866728630434434d, y: 0.6514558015439385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9072585354554557d, y: 0.699041366699795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9784997498133957d, y: 0.6487539612150919d), new NpgsqlTypes.NpgsqlPoint(x: 0.971260615890213d, y: 0.4917966722082141d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12061008117279126d, y: 0.27654279198274023d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276132713366446d, y: 0.11612202491390367d), new NpgsqlTypes.NpgsqlPoint(x: 0.1656137236812637d, y: 0.2438651047150835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6593435066415971d, y: 0.45755602716322685d), new NpgsqlTypes.NpgsqlPoint(x: 0.091724060372399d, y: 0.20910764846346175d), new NpgsqlTypes.NpgsqlPoint(x: 0.11909414415588326d, y: 0.1288793104600886d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6200819578500146d, y: 0.9884315075394499d), new NpgsqlTypes.NpgsqlPoint(x: 0.48525950323921907d, y: 0.5231818986604706d), new NpgsqlTypes.NpgsqlPoint(x: 0.899739333689514d, y: 0.5761679435695607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18156657949971167d, y: 0.7468058653054499d), new NpgsqlTypes.NpgsqlPoint(x: 0.013933103142161563d, y: 0.30560079734541357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969388329403914d, y: 0.6277310867622693d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39272230659916907d, y: 0.5457023691747647d), new NpgsqlTypes.NpgsqlPoint(x: 0.04367809504960862d, y: 0.46141266174969553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567300943644798d, y: 0.886928084388063d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8255286037106832d, y: 0.865032964716221d), new NpgsqlTypes.NpgsqlPoint(x: 0.3860849884530093d, y: 0.9167027405371282d), new NpgsqlTypes.NpgsqlPoint(x: 0.23881010650421464d, y: 0.6285712418489497d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12227320159611066d, y: 0.6290820046534183d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259757235029793d, y: 0.5401343404116812d), new NpgsqlTypes.NpgsqlPoint(x: 0.21515432601280937d, y: 0.1057493086973984d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6836115881760119d, y: 0.632045436589575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267233102023988d, y: 0.027816971524413425d), new NpgsqlTypes.NpgsqlPoint(x: 0.13347473852463942d, y: 0.6745227014413822d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9247811860787468d, y: 0.686035949888892d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071082542699323d, y: 0.987714727727803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7947431039656887d, y: 0.4744457228514142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9015929799724687d, y: 0.865555738195824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617716482616877d, y: 0.3399815037286713d), new NpgsqlTypes.NpgsqlPoint(x: 0.514763203388792d, y: 0.9534329555542544d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5258611556732958d, y: 0.5189501601311467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697405537476068d, y: 0.35983992527550535d), new NpgsqlTypes.NpgsqlPoint(x: 0.2923110930850834d, y: 0.537063333644928d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47933767759935886d, y: 0.915585881059206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491151430132243d, y: 0.9705026376075859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264634190357305d, y: 0.7055675110703075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9852305009094768d, y: 0.6788804106297455d), new NpgsqlTypes.NpgsqlPoint(x: 0.29433246175210726d, y: 0.5921936436690085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8028268837095007d, y: 0.8930235076739117d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960099099188849d, y: 0.19049785870892522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6035112377377648d, y: 0.24267114130917045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8881486153440269d, y: 0.09518181372178136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026801609957213035d, y: 0.5973413967840275d), new NpgsqlTypes.NpgsqlPoint(x: 0.08327242125691858d, y: 0.5883051722317926d), new NpgsqlTypes.NpgsqlPoint(x: 0.1876587631387585d, y: 0.11589286130710308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9623792528682025d, y: 0.6484911763115985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873943721242806d, y: 0.8058393795697868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4308409002618202d, y: 0.9493655242715868d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6757515668774102d, y: 0.3502011408841885d), new NpgsqlTypes.NpgsqlPoint(x: 0.49805163406732156d, y: 0.6865163501916126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280035540481035d, y: 0.593624283600447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6088353840298654d, y: 0.13438590376475945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7613345657356648d, y: 0.94334044041432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844134965416052d, y: 0.9790683559121731d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5715647714449558d, y: 0.6911552626797396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634684753977337d, y: 0.21914400224566244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981781021343566d, y: 0.6033080720895551d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25327487755932865d, y: 0.5395697182270522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031387845919345d, y: 0.660550620354632d), new NpgsqlTypes.NpgsqlPoint(x: 0.16070384185861242d, y: 0.3609259879768718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9292038303412784d, y: 0.7633137475737447d), new NpgsqlTypes.NpgsqlPoint(x: 0.17563399923962286d, y: 0.326742687322228d), new NpgsqlTypes.NpgsqlPoint(x: 0.34888401172450256d, y: 0.06063061640328926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5529705215219367d, y: 0.777852274918421d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360904507393331d, y: 0.3997309970338334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9000646254402064d, y: 0.03728108719425438d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4358170984493617d, y: 0.7425448879150905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832238944868999d, y: 0.5276922955240549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464231438499986d, y: 0.6387931185549215d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.927490915929366d, y: 0.23067216567377002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534621215399406d, y: 0.8344687455780815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3050398193780266d, y: 0.3255555433989291d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14264136532172933d, y: 0.4841455040453795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676333823574133d, y: 0.6066610294068288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515596092878876d, y: 0.8982719822150765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8963799102774318d, y: 0.24631622359791838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813111963667034d, y: 0.43182442266273413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5938383538755764d, y: 0.2639514727896337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48661020343264594d, y: 0.6169267456630936d), new NpgsqlTypes.NpgsqlPoint(x: 0.7146215723976787d, y: 0.7304100077459618d), new NpgsqlTypes.NpgsqlPoint(x: 0.43041096366179354d, y: 0.9956316497772131d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901493529085222d, y: 0.9353883919294297d), new NpgsqlTypes.NpgsqlPoint(x: 0.7936972365521349d, y: 0.058786712963382226d), new NpgsqlTypes.NpgsqlPoint(x: 0.744282026758959d, y: 0.7474194777831734d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4692152336927048d, y: 0.8812766984589818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6365294402076759d, y: 0.2900698522396252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8956388557899759d, y: 0.0015402470608451013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7061694587112594d, y: 0.7326562837866828d), new NpgsqlTypes.NpgsqlPoint(x: 0.2934681476152232d, y: 0.19858342285041797d), new NpgsqlTypes.NpgsqlPoint(x: 0.811196883331368d, y: 0.5936561545882159d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4645067885806775d, y: 0.3551822671922319d), new NpgsqlTypes.NpgsqlPoint(x: 0.14435341328685902d, y: 0.5124769497377367d), new NpgsqlTypes.NpgsqlPoint(x: 0.13520285429578893d, y: 0.14978645743612273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7925751276038099d, y: 0.44260704337234047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507800584535764d, y: 0.9566227057651503d), new NpgsqlTypes.NpgsqlPoint(x: 0.716442962512726d, y: 0.8720331375220297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8583971918478399d, y: 0.3190624976740658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462040985827383d, y: 0.4878590588398588d), new NpgsqlTypes.NpgsqlPoint(x: 0.10935651683440617d, y: 0.5956339045345758d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3447757465546264d, y: 0.8005597481431259d), new NpgsqlTypes.NpgsqlPoint(x: 0.95966975298753d, y: 0.25925729720606017d), new NpgsqlTypes.NpgsqlPoint(x: 0.15961955363992175d, y: 0.9117567936768703d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21805892814067007d, y: 0.15098677327928833d), new NpgsqlTypes.NpgsqlPoint(x: 0.401088706505227d, y: 0.9752009347008226d), new NpgsqlTypes.NpgsqlPoint(x: 0.24587892870491734d, y: 0.24354975259578537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1789225940665371d, y: 0.5702542197004293d), new NpgsqlTypes.NpgsqlPoint(x: 0.12763920945006224d, y: 0.6188739165135456d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764402865912605d, y: 0.920195263108338d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40276068177499347d, y: 0.4298368345369806d), new NpgsqlTypes.NpgsqlPoint(x: 0.02872371687931441d, y: 0.11245676794389592d), new NpgsqlTypes.NpgsqlPoint(x: 0.30123331216349936d, y: 0.271467566182402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9564571430542266d, y: 0.35890637959221106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9446762100400958d, y: 0.19379930638007592d), new NpgsqlTypes.NpgsqlPoint(x: 0.14918981043391555d, y: 0.17006443080978184d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04043073999929869d, y: 0.6565444746598585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424941587081125d, y: 0.9386426013934853d), new NpgsqlTypes.NpgsqlPoint(x: 0.12166013017796573d, y: 0.0799808034228513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6708506890259539d, y: 0.8431738401334974d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876740181013933d, y: 0.7125112596357153d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478685553302007d, y: 0.4075822197768477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4323217115135167d, y: 0.06494729722475456d), new NpgsqlTypes.NpgsqlPoint(x: 0.18614471380552344d, y: 0.4487858285762394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3852857738924057d, y: 0.7338496382865217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.016314832250666544d, y: 0.6387639427124971d), new NpgsqlTypes.NpgsqlPoint(x: 0.26720285693426316d, y: 0.44713065240028804d), new NpgsqlTypes.NpgsqlPoint(x: 0.06800330962587497d, y: 0.7564970640869221d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6397682268989219d, y: 0.4900737590988965d), new NpgsqlTypes.NpgsqlPoint(x: 0.710491138289811d, y: 0.3734178657699495d), new NpgsqlTypes.NpgsqlPoint(x: 0.182170853365327d, y: 0.7925607182217601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6758100652632795d, y: 0.10128779407559585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7246724331810201d, y: 0.28350367096714035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859410974465435d, y: 0.09545172077571495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4691614802184092d, y: 0.9546040081901249d), new NpgsqlTypes.NpgsqlPoint(x: 0.69538441147602d, y: 0.326278518561965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1318719088418323d, y: 0.10269273176614413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6354487348735063d, y: 0.5268714134013487d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889930868397744d, y: 0.566170149621234d), new NpgsqlTypes.NpgsqlPoint(x: 0.0641015191427432d, y: 0.17787578343204857d)),
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7950001369313908d, y: 0.9356174089412312d), new NpgsqlTypes.NpgsqlPoint(x: 0.35707801398742833d, y: 0.9688564926670855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818679540225748d, y: 0.5209882338265149d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7614833135373387d, y: 0.46580365876102436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808848584609594d, y: 0.9766763421832111d), new NpgsqlTypes.NpgsqlPoint(x: 0.3353710433133297d, y: 0.09169359871003613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05857312969241213d, y: 0.7794044647435432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668269326762927d, y: 0.17704366191703091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8971078695490332d, y: 0.02519635897849204d)),
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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688773783347443d, y: 0.7914362138405447d), new NpgsqlTypes.NpgsqlPoint(x: 0.27212347828696637d, y: 0.3350610364682478d), new NpgsqlTypes.NpgsqlPoint(x: 0.02424265139476356d, y: 0.8137119229084868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7423049680287613d, y: 0.9322661706121739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661729688133298d, y: 0.8925335250308505d), new NpgsqlTypes.NpgsqlPoint(x: 0.174087009006603d, y: 0.3184715382970841d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13454745108284005d, y: 0.12175258581058479d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524897321689369d, y: 0.5886337235606847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655425519990329d, y: 0.01632256538706567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07073607425653716d, y: 0.7048959030372698d), new NpgsqlTypes.NpgsqlPoint(x: 0.05095668942323339d, y: 0.3749954654441745d), new NpgsqlTypes.NpgsqlPoint(x: 0.31018715514736517d, y: 0.36755459359522724d)),
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
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01383548987328076d, y: 0.4196630532782103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345635734584753d, y: 0.17051650428193166d), new NpgsqlTypes.NpgsqlPoint(x: 0.13721689771201107d, y: 0.09227359086650622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6907966573960103d, y: 0.9813048334394132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7248981764175643d, y: 0.36837998244225134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777760209901307d, y: 0.9511035589995359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2612393658944473d, y: 0.16437283805165026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6752148520027549d, y: 0.12183573195044939d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842309645828504d, y: 0.24082117038444417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46530615412654297d, y: 0.46205475357223025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4244133290738825d, y: 0.6041773532050051d), new NpgsqlTypes.NpgsqlPoint(x: 0.25820841605118505d, y: 0.7219303216292567d)),
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
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04374081588627676d, y: 0.2838151470711061d), new NpgsqlTypes.NpgsqlPoint(x: 0.1093282742367373d, y: 0.292474133840642d), new NpgsqlTypes.NpgsqlPoint(x: 0.44058929677996794d, y: 0.8668219537225911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7454305782188728d, y: 0.04407053067868605d), new NpgsqlTypes.NpgsqlPoint(x: 0.33298478940009457d, y: 0.28563448902275135d), new NpgsqlTypes.NpgsqlPoint(x: 0.3311104442003763d, y: 0.7144404254039223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6119874113844328d, y: 0.07213866545325798d), new NpgsqlTypes.NpgsqlPoint(x: 0.12125023833882753d, y: 0.20757405718408317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6106228643048758d, y: 0.643232173549327d)),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 22, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 99, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
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
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 6, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 33, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 96, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 5);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

