

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8174633339363169d, y: 0.3952022987024215d), new NpgsqlTypes.NpgsqlPoint(x: 0.7403737681223679d, y: 0.8587213737321037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710665232970827d, y: 0.9574091134893671d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4598598458987426d, y: 0.33542839120360946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118569349177358d, y: 0.17346766464764307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286418995988107d, y: 0.4340496893249691d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13244280382512907d, y: 0.756534213967204d), new NpgsqlTypes.NpgsqlPoint(x: 0.851370240976605d, y: 0.6163380681813688d), new NpgsqlTypes.NpgsqlPoint(x: 0.029177571829270388d, y: 0.344695339917483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01851148551534465d, y: 0.8444203304537301d), new NpgsqlTypes.NpgsqlPoint(x: 0.2868036364122616d, y: 0.4411928514564116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005940930751008d, y: 0.41509715125183744d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5417779942551001d, y: 0.6610060625688408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929422925076715d, y: 0.474824282918313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391414704621114d, y: 0.9853117677585187d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47219770372267d, y: 0.8822170821969483d), new NpgsqlTypes.NpgsqlPoint(x: 0.253726046509112d, y: 0.7064723127973849d), new NpgsqlTypes.NpgsqlPoint(x: 0.43074246348633904d, y: 0.7765341897498268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016701924178988414d, y: 0.062490937218331544d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901597459976111d, y: 0.357682940053373d), new NpgsqlTypes.NpgsqlPoint(x: 0.12629716089963883d, y: 0.15291132121419804d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5802877807691049d, y: 0.3712703485915557d), new NpgsqlTypes.NpgsqlPoint(x: 0.036524463338418744d, y: 0.1436170853672578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9831011120911453d, y: 0.1034514112344821d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5190465699001083d, y: 0.6299468184828293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6870034551302158d, y: 0.027063746614412354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014869068414364d, y: 0.2305523043015375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37158831008051696d, y: 0.18018358059839057d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624726185098849d, y: 0.9496531085995321d), new NpgsqlTypes.NpgsqlPoint(x: 0.8795654801480949d, y: 0.9416405891449741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21004181230249308d, y: 0.29129357173142667d), new NpgsqlTypes.NpgsqlPoint(x: 0.32424674757818905d, y: 0.6546946949480243d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183281783616325d, y: 0.7614308121582566d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6390009609838754d, y: 0.5091202739683363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059922315536521d, y: 0.5341967116711841d), new NpgsqlTypes.NpgsqlPoint(x: 0.0051264672210525886d, y: 0.7618113335304265d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.574068616551518d, y: 0.9830200224094694d), new NpgsqlTypes.NpgsqlPoint(x: 0.44410612397688454d, y: 0.11232547311832564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7946289471058978d, y: 0.35664303522401364d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08452888434452177d, y: 0.601861284466306d), new NpgsqlTypes.NpgsqlPoint(x: 0.265078576488157d, y: 0.24787047405413032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615305066227991d, y: 0.743885048484653d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1151529995337578d, y: 0.002122352518649784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7628877141388593d, y: 0.7129529971474924d), new NpgsqlTypes.NpgsqlPoint(x: 0.29397818697279066d, y: 0.6477040189145097d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8432922342324618d, y: 0.19450310490775424d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407373445154066d, y: 0.8883268561539606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638991115745336d, y: 0.5536086421374236d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.913430563304007d, y: 0.4889509719762136d), new NpgsqlTypes.NpgsqlPoint(x: 0.30028669325570867d, y: 0.18661812731889216d), new NpgsqlTypes.NpgsqlPoint(x: 0.06701306656818617d, y: 0.6260065669060779d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5342200531054758d, y: 0.4691248471921021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108129248453971d, y: 0.3878656325344849d), new NpgsqlTypes.NpgsqlPoint(x: 0.48132499130757367d, y: 0.10861529738883702d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.836019115417037d, y: 0.5160546554050288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798218237562972d, y: 0.42741462773537564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3082802155454163d, y: 0.31694179927553545d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.988896502459001d, y: 0.5632528002077171d), new NpgsqlTypes.NpgsqlPoint(x: 0.98259028401616d, y: 0.6741358393652075d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060031491767441d, y: 0.5494479900977965d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29836668006677347d, y: 0.05093928629761968d), new NpgsqlTypes.NpgsqlPoint(x: 0.4139393783429737d, y: 0.0511383456586012d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039218501509215d, y: 0.8746810952678896d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7091103175265049d, y: 0.4991735267884597d), new NpgsqlTypes.NpgsqlPoint(x: 0.12100626683361215d, y: 0.37006589762465447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152037406401796d, y: 0.23622547615684975d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18224048193632492d, y: 0.8970991469928794d), new NpgsqlTypes.NpgsqlPoint(x: 0.07697983877410453d, y: 0.6076114435717869d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917598258905061d, y: 0.5577898374434471d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21989681274670125d, y: 0.13487914604955764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5466596624225526d, y: 0.43784782995008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469665917832107d, y: 0.5117675083067025d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4665471976594825d, y: 0.9098417405237247d), new NpgsqlTypes.NpgsqlPoint(x: 0.40050037813646766d, y: 0.02347946054356498d), new NpgsqlTypes.NpgsqlPoint(x: 0.43371820970408226d, y: 0.8841049429674981d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5340660355067157d, y: 0.3601339133554724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2938264841090388d, y: 0.2723235858414019d), new NpgsqlTypes.NpgsqlPoint(x: 0.6933728924380267d, y: 0.16846524581671996d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10310909281332226d, y: 0.44271879505182254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662812929322318d, y: 0.31151149353778895d), new NpgsqlTypes.NpgsqlPoint(x: 0.21880456494054035d, y: 0.9714356610081201d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7149947447081919d, y: 0.1928938779029541d), new NpgsqlTypes.NpgsqlPoint(x: 0.2998753610264432d, y: 0.33006396290890727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460522392945758d, y: 0.35774680313612794d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31947818853077337d, y: 0.23137191510160193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5923092383844103d, y: 0.7294634020315339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369859613312571d, y: 0.0012232275441140805d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716128668279693d, y: 0.568360029902032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9622664617184745d, y: 0.2435474199525547d), new NpgsqlTypes.NpgsqlPoint(x: 0.535555548955128d, y: 0.1949004564046729d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4247440146875495d, y: 0.222898234337371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357380911288554d, y: 0.0653911454825562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9312829864805288d, y: 0.7384627452527178d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2590257350410946d, y: 0.6472426461601138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8943265372882754d, y: 0.9882985146056964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8318256336746991d, y: 0.9073092253552179d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.897303075183728d, y: 0.04997532271265093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4949608252783577d, y: 0.31404557294330016d), new NpgsqlTypes.NpgsqlPoint(x: 0.6243017746453406d, y: 0.05041412146757063d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006250398888799857d, y: 0.9903384263988754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062033623207195d, y: 0.9994417830119101d), new NpgsqlTypes.NpgsqlPoint(x: 0.07602070339972422d, y: 0.6067265851190881d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7630371697695345d, y: 0.533137719980087d), new NpgsqlTypes.NpgsqlPoint(x: 0.37642719798624336d, y: 0.014241141621051834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198489720830878d, y: 0.12239198019345898d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6471562790644592d, y: 0.5673105441053418d), new NpgsqlTypes.NpgsqlPoint(x: 0.04874129685724515d, y: 0.5422163739600594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397740894764911d, y: 0.3320401870532035d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4256549270864566d, y: 0.062110748329858856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815472482460906d, y: 0.07629879241805282d), new NpgsqlTypes.NpgsqlPoint(x: 0.03132139649289012d, y: 0.8012158963001096d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.872062227490128d, y: 0.3789004558717931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592032826436549d, y: 0.3897010012007197d), new NpgsqlTypes.NpgsqlPoint(x: 0.836784733032785d, y: 0.3175756816178419d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42446856189877247d, y: 0.2154075026017651d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747830238226167d, y: 0.8976660299543816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608751379917551d, y: 0.35754603944938446d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21440599591951537d, y: 0.008182814590981247d), new NpgsqlTypes.NpgsqlPoint(x: 0.4228351972539992d, y: 0.9632728565788355d), new NpgsqlTypes.NpgsqlPoint(x: 0.3591058441815267d, y: 0.9846433990961785d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.000991779374696189d, y: 0.19679517585900763d), new NpgsqlTypes.NpgsqlPoint(x: 0.32440085762001303d, y: 0.5411434103488497d), new NpgsqlTypes.NpgsqlPoint(x: 0.36207100826967775d, y: 0.5086961223321174d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.688942924743503d, y: 0.07085010756164689d), new NpgsqlTypes.NpgsqlPoint(x: 0.537356331176841d, y: 0.48876550344452596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775383870357973d, y: 0.659195841013983d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5530693888502413d, y: 0.20239282179500395d), new NpgsqlTypes.NpgsqlPoint(x: 0.10122432261606928d, y: 0.22858626991637943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141241659486616d, y: 0.5763935481672254d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02771395495134188d, y: 0.3856756260368577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103254641569051d, y: 0.3244227841200935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756091479990185d, y: 0.5412834029890022d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7877051162105452d, y: 0.8520300230665085d), new NpgsqlTypes.NpgsqlPoint(x: 0.4067197605750563d, y: 0.21454310514792707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6147852006626323d, y: 0.9412936352650987d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9124568086665443d, y: 0.6919379320872987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7928494227375096d, y: 0.5594851479454702d), new NpgsqlTypes.NpgsqlPoint(x: 0.05784766881404335d, y: 0.20241975182068983d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44273876473670215d, y: 0.5375886263661759d), new NpgsqlTypes.NpgsqlPoint(x: 0.14146521752381802d, y: 0.15918002721930768d), new NpgsqlTypes.NpgsqlPoint(x: 0.1896607840052521d, y: 0.7217196822652152d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6243169097275758d, y: 0.030309604905655818d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166646198479342d, y: 0.682416825121592d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969918281921927d, y: 0.04683578184746484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6200306823672248d, y: 0.9795083594946433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6100800954028368d, y: 0.9891343505521099d), new NpgsqlTypes.NpgsqlPoint(x: 0.19340340134731027d, y: 0.35629470155825926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9979477750202718d, y: 0.3544082666455538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8270882186372955d, y: 0.4035740871890616d), new NpgsqlTypes.NpgsqlPoint(x: 0.782141779989163d, y: 0.730839304373475d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48065318366442056d, y: 0.6593329056291609d), new NpgsqlTypes.NpgsqlPoint(x: 0.22460401636645566d, y: 0.5330552284654629d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571395573947354d, y: 0.7959769554152353d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37550734554272347d, y: 0.3113023656015895d), new NpgsqlTypes.NpgsqlPoint(x: 0.7162919802325852d, y: 0.6337515149781489d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277472813127907d, y: 0.5273127412813919d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35112921945982456d, y: 0.2072345885959369d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581756074980794d, y: 0.3775094406022038d), new NpgsqlTypes.NpgsqlPoint(x: 0.1540743720492701d, y: 0.6983958646568211d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008810926526429341d, y: 0.3448745953999476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745850233718474d, y: 0.6475963591064857d), new NpgsqlTypes.NpgsqlPoint(x: 0.021393248235286877d, y: 0.6366065182626237d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9779588788035638d, y: 0.08725100096600047d), new NpgsqlTypes.NpgsqlPoint(x: 0.11211739437596646d, y: 0.9691548973550465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718963183366866d, y: 0.4026384010125893d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7193791343138481d, y: 0.3571731966872457d), new NpgsqlTypes.NpgsqlPoint(x: 0.26422880640883595d, y: 0.2689123426237081d), new NpgsqlTypes.NpgsqlPoint(x: 0.4804762626360797d, y: 0.6773195176551859d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3066141449825689d, y: 0.8275528756323962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115323453413707d, y: 0.20926507353061496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214584358536442d, y: 0.1418036987815341d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6788839025879568d, y: 0.6075338720597162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779369942059745d, y: 0.7517766042704426d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350592951264806d, y: 0.9240314728352248d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.731672652797097d, y: 0.3435978004592848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108025190720925d, y: 0.4705368423595764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5259742399560452d, y: 0.5720451873226491d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6874768633601459d, y: 0.34757625544404724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169953679844266d, y: 0.3125124167641099d), new NpgsqlTypes.NpgsqlPoint(x: 0.047978411560523404d, y: 0.6541065466635736d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6232955824060479d, y: 0.648267434045896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7252756249002864d, y: 0.34718747641242187d), new NpgsqlTypes.NpgsqlPoint(x: 0.3586921256526294d, y: 0.8282932288297227d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37839571187512644d, y: 0.40384574143353924d), new NpgsqlTypes.NpgsqlPoint(x: 0.06371639669874074d, y: 0.08555017746904514d), new NpgsqlTypes.NpgsqlPoint(x: 0.058029883523319614d, y: 0.032386965930567446d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6487710036455554d, y: 0.9752693015651718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543216058191555d, y: 0.9840377652031626d), new NpgsqlTypes.NpgsqlPoint(x: 0.18460102855405547d, y: 0.9927764719658407d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.045875440101329046d, y: 0.9056319958626527d), new NpgsqlTypes.NpgsqlPoint(x: 0.4862757719555144d, y: 0.553417968407335d), new NpgsqlTypes.NpgsqlPoint(x: 0.23292369930997248d, y: 0.6146520416339339d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248636588595703d, y: 0.7884293829022639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090711378685821d, y: 0.7891992024231693d), new NpgsqlTypes.NpgsqlPoint(x: 0.06521914127637285d, y: 0.7689588830895489d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7956055870793247d, y: 0.8488799157019473d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761995468070555d, y: 0.7943889929363563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096415650582455d, y: 0.14291247111100236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6420814600601933d, y: 0.05952682850360458d), new NpgsqlTypes.NpgsqlPoint(x: 0.3547632868681244d, y: 0.2667566520333927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626316080905331d, y: 0.3030493041568474d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38272421417771496d, y: 0.4852192419816471d), new NpgsqlTypes.NpgsqlPoint(x: 0.40870752128033616d, y: 0.029000047197596523d), new NpgsqlTypes.NpgsqlPoint(x: 0.24381282843014118d, y: 0.9985870689644404d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8856035391408562d, y: 0.40347616206565673d), new NpgsqlTypes.NpgsqlPoint(x: 0.012105750465617016d, y: 0.042057159142482425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998299334826661d, y: 0.3052466878533867d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3826249591169858d, y: 0.7288881107846072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120867226478699d, y: 0.19027773160250894d), new NpgsqlTypes.NpgsqlPoint(x: 0.11833259076881353d, y: 0.4087214908225806d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12265376646727189d, y: 0.5134008380304164d), new NpgsqlTypes.NpgsqlPoint(x: 0.756115963169934d, y: 0.6030759948303318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888676026460669d, y: 0.10386958971824256d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.646035085754436d, y: 0.8675282950656902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038089246708457d, y: 0.9445806810801963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002399029691352d, y: 0.6839086458619806d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32672534362734196d, y: 0.7854490620761618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408741862956178d, y: 0.48761379166066476d), new NpgsqlTypes.NpgsqlPoint(x: 0.12610458679920056d, y: 0.2966437648016711d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5344462994210663d, y: 0.955614991539576d), new NpgsqlTypes.NpgsqlPoint(x: 0.2038381519570579d, y: 0.029002719403709687d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680338817243547d, y: 0.2205189714841408d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39744505404353103d, y: 0.5568395863074175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427283938674465d, y: 0.7022459099882814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667893206695256d, y: 0.46864151766911954d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7950781526185217d, y: 0.9551096598893342d), new NpgsqlTypes.NpgsqlPoint(x: 0.11212467572619322d, y: 0.6192638038729548d), new NpgsqlTypes.NpgsqlPoint(x: 0.16880478525725995d, y: 0.9715795350988763d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7885216550837103d, y: 0.692717695429919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916470556458913d, y: 0.7875291133759846d), new NpgsqlTypes.NpgsqlPoint(x: 0.22618183779854162d, y: 0.9890277492465986d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5899590985866949d, y: 0.6868324516654482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002605042081871d, y: 0.5838502710206936d), new NpgsqlTypes.NpgsqlPoint(x: 0.08358833349551675d, y: 0.9155721871634699d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1856807739265004d, y: 0.47412319319880625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101221001042772d, y: 0.5460352038259086d), new NpgsqlTypes.NpgsqlPoint(x: 0.850223419921743d, y: 0.4707871426129846d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6457598184781214d, y: 0.049865923403310974d), new NpgsqlTypes.NpgsqlPoint(x: 0.30328989010988183d, y: 0.3836573276615185d), new NpgsqlTypes.NpgsqlPoint(x: 0.19552087231896942d, y: 0.7701911862955614d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03715122701785112d, y: 0.3896936796518975d), new NpgsqlTypes.NpgsqlPoint(x: 0.2733041081085824d, y: 0.6690779548313625d), new NpgsqlTypes.NpgsqlPoint(x: 0.648035165581718d, y: 0.5492677603312728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07124596274788009d, y: 0.9550216293993075d), new NpgsqlTypes.NpgsqlPoint(x: 0.92641657562042d, y: 0.3134500687019036d), new NpgsqlTypes.NpgsqlPoint(x: 0.276548316796726d, y: 0.003143250447427026d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7221923766910849d, y: 0.019053309723904954d), new NpgsqlTypes.NpgsqlPoint(x: 0.22051920162469552d, y: 0.1899623921933007d), new NpgsqlTypes.NpgsqlPoint(x: 0.050096095228205684d, y: 0.5939045536637128d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5958074805757394d, y: 0.49637606660862155d), new NpgsqlTypes.NpgsqlPoint(x: 0.02861425854735533d, y: 0.5877040964638832d), new NpgsqlTypes.NpgsqlPoint(x: 0.35860154553236967d, y: 0.6802736794841903d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0051642919544351296d, y: 0.5663396867230172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6980550456386857d, y: 0.23007418423367298d), new NpgsqlTypes.NpgsqlPoint(x: 0.25464696854312496d, y: 0.30675124329841896d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2516497620228201d, y: 0.9882106209512815d), new NpgsqlTypes.NpgsqlPoint(x: 0.688749259768136d, y: 0.303173968991746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487682878586038d, y: 0.19462821330141422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20034095386765294d, y: 0.2063703958449351d), new NpgsqlTypes.NpgsqlPoint(x: 0.27423551729899964d, y: 0.6071995875931772d), new NpgsqlTypes.NpgsqlPoint(x: 0.24072788506428122d, y: 0.19494634420989576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9166539317624823d, y: 0.30637543489114216d), new NpgsqlTypes.NpgsqlPoint(x: 0.534922844483094d, y: 0.45712449428923874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9192351267934897d, y: 0.02082094936923795d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7076904649464254d, y: 0.5680655435811628d), new NpgsqlTypes.NpgsqlPoint(x: 0.14573202952672082d, y: 0.5742414345254719d), new NpgsqlTypes.NpgsqlPoint(x: 0.05665574526912287d, y: 0.5927923919569812d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9026345563612292d, y: 0.29888906044146313d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374538025612327d, y: 0.8392505752275716d), new NpgsqlTypes.NpgsqlPoint(x: 0.2632003646185048d, y: 0.49463236008651046d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6300658898685405d, y: 0.30335737840471466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695990378908852d, y: 0.5360270392676529d), new NpgsqlTypes.NpgsqlPoint(x: 0.20241502971717895d, y: 0.34054102488702365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5190384425709654d, y: 0.9165620129387879d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243199363746632d, y: 0.30240532192461533d), new NpgsqlTypes.NpgsqlPoint(x: 0.30581127721329515d, y: 0.45526392933926807d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9576455074177703d, y: 0.6647626207090038d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014797788291224d, y: 0.26229605298517433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8439314971592737d, y: 0.03729162750498416d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17943367060189597d, y: 0.17285141760626843d), new NpgsqlTypes.NpgsqlPoint(x: 0.012338478348323578d, y: 0.07609004825800847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328077196915516d, y: 0.45421479020397926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8999698086314852d, y: 0.7710329126797204d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154624676918436d, y: 0.4907950382103554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381117246275982d, y: 0.25453041513064156d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21584432884718996d, y: 0.46409403928491955d), new NpgsqlTypes.NpgsqlPoint(x: 0.28092916359907727d, y: 0.27789366683479233d), new NpgsqlTypes.NpgsqlPoint(x: 0.511728107694688d, y: 0.28850400261934284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07490990011698007d, y: 0.9379176777671954d), new NpgsqlTypes.NpgsqlPoint(x: 0.19408090576329884d, y: 0.6286845546278453d), new NpgsqlTypes.NpgsqlPoint(x: 0.31670391657768415d, y: 0.38199501638361133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8086925437781103d, y: 0.5921317036405115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274830900894208d, y: 0.0031912794796702393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073155114595818d, y: 0.6602329233261323d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48579531282218047d, y: 0.6676119524514526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719897734543097d, y: 0.8684673780840363d), new NpgsqlTypes.NpgsqlPoint(x: 0.24605476564512052d, y: 0.3615573408723014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7399008374852075d, y: 0.7620989316379214d), new NpgsqlTypes.NpgsqlPoint(x: 0.0663743863473274d, y: 0.39484939235909366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668040158383107d, y: 0.17015330439173093d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9696217546276685d, y: 0.7527748862237197d), new NpgsqlTypes.NpgsqlPoint(x: 0.856875598103221d, y: 0.6926334143529254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514859577983873d, y: 0.34545285855771024d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23576335651322644d, y: 0.8089551747266441d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907269102170857d, y: 0.13101223730749922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526371419109098d, y: 0.7548657653839788d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04175102717331047d, y: 0.6168772091585947d), new NpgsqlTypes.NpgsqlPoint(x: 0.21231796488696664d, y: 0.39111164473740245d), new NpgsqlTypes.NpgsqlPoint(x: 0.6726503912303285d, y: 0.88175496230663d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40988474882229986d, y: 0.43930797662716636d), new NpgsqlTypes.NpgsqlPoint(x: 0.45775506854710846d, y: 0.9470253288625532d), new NpgsqlTypes.NpgsqlPoint(x: 0.918796091555787d, y: 0.23239771727185632d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1131916616367239d, y: 0.19078559544574036d), new NpgsqlTypes.NpgsqlPoint(x: 0.00036812869944258253d, y: 0.5888056596019388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808463268623858d, y: 0.3987806208135444d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7515398908854127d, y: 0.5079813171969139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453637895293438d, y: 0.9095505841942022d), new NpgsqlTypes.NpgsqlPoint(x: 0.26607019706069546d, y: 0.48996185205062925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9564748058121185d, y: 0.32995314579395085d), new NpgsqlTypes.NpgsqlPoint(x: 0.783586494218083d, y: 0.9375218595566734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321718764391677d, y: 0.5894950660879956d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8230378184341182d, y: 0.08236100087414078d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157388352084316d, y: 0.8626359489245939d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986812750489529d, y: 0.38968933485122714d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05344463647934705d, y: 0.6298324822949893d), new NpgsqlTypes.NpgsqlPoint(x: 0.048129668214256016d, y: 0.7891150776006329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768004890516468d, y: 0.37576918730864417d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17416672920501897d, y: 0.1771659916285847d), new NpgsqlTypes.NpgsqlPoint(x: 0.34007842060333127d, y: 0.0555623578674217d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910311060625535d, y: 0.8707751101756795d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7938716837335317d, y: 0.48715474223685473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600453250821684d, y: 0.09426188465364727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7525837431567951d, y: 0.5731892460001308d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7867140091992028d, y: 0.7735789818315154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712081067557996d, y: 0.4047083521739506d), new NpgsqlTypes.NpgsqlPoint(x: 0.949860780553427d, y: 0.2771548481939119d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14456380997672313d, y: 0.19816814698077723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9683421353943661d, y: 0.2500023866948772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7366761510690271d, y: 0.984057238566058d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7503632965733791d, y: 0.5030052183285266d), new NpgsqlTypes.NpgsqlPoint(x: 0.13947075310272106d, y: 0.43931637462425255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4874341416591019d, y: 0.2998928342172348d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5487154906042063d, y: 0.9702439626891133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7965697198260896d, y: 0.9309348769035574d), new NpgsqlTypes.NpgsqlPoint(x: 0.43937829376046167d, y: 0.38812330135548323d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6188018545666637d, y: 0.22634244458845876d), new NpgsqlTypes.NpgsqlPoint(x: 0.14656755356503504d, y: 0.6668012161187652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686136804699036d, y: 0.5573297896663294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8305988036717922d, y: 0.033813622119054365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5750542292377276d, y: 0.5608670248797206d), new NpgsqlTypes.NpgsqlPoint(x: 0.18707669311310504d, y: 0.2639154797423011d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3220159905387635d, y: 0.7273583599138975d), new NpgsqlTypes.NpgsqlPoint(x: 0.4939380981879967d, y: 0.6395495640136485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791761198765992d, y: 0.3263475045539628d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5009277623254493d, y: 0.10211609086076989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067034419265202d, y: 0.7559680214554441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9385830196671782d, y: 0.6230715559591529d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07162065867616307d, y: 0.9275559233443835d), new NpgsqlTypes.NpgsqlPoint(x: 0.04437833824564963d, y: 0.9887862036484083d), new NpgsqlTypes.NpgsqlPoint(x: 0.13491572617359238d, y: 0.03846108363704148d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14581984984304286d, y: 0.27269294792545173d), new NpgsqlTypes.NpgsqlPoint(x: 0.18407127682953994d, y: 0.16685922502380013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525575259485334d, y: 0.11022977153803948d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0388935435509431d, y: 0.11957727511969041d), new NpgsqlTypes.NpgsqlPoint(x: 0.03392396884105664d, y: 0.8143410859466105d), new NpgsqlTypes.NpgsqlPoint(x: 0.46084344130063226d, y: 0.7764112955676881d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8235098879832354d, y: 0.06613790085881421d), new NpgsqlTypes.NpgsqlPoint(x: 0.08265804536061727d, y: 0.9590721843212633d), new NpgsqlTypes.NpgsqlPoint(x: 0.37684326129769197d, y: 0.5250676996139036d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.987132706824358d, y: 0.8581718262562097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215671701864778d, y: 0.7108414232111425d), new NpgsqlTypes.NpgsqlPoint(x: 0.2929779412761241d, y: 0.4059937788325553d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6997424802127096d, y: 0.6369166607880324d), new NpgsqlTypes.NpgsqlPoint(x: 0.81159183635856d, y: 0.5338620943654586d), new NpgsqlTypes.NpgsqlPoint(x: 0.759683896852448d, y: 0.8505584142117922d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8575390178270833d, y: 0.17714802837568322d), new NpgsqlTypes.NpgsqlPoint(x: 0.992365643324519d, y: 0.041596758642707066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9165316326215587d, y: 0.6151653220844152d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2859571777884935d, y: 0.1012949686939908d), new NpgsqlTypes.NpgsqlPoint(x: 0.25978622159346665d, y: 0.1259470711601618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974038734886226d, y: 0.95510798428364d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38451655375669735d, y: 0.8972445834076984d), new NpgsqlTypes.NpgsqlPoint(x: 0.3262363448501622d, y: 0.5056956466046654d), new NpgsqlTypes.NpgsqlPoint(x: 0.39282068251877034d, y: 0.21744254016466147d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.044566997256423435d, y: 0.5017676769786604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6332864345203728d, y: 0.5045158576384681d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792668497668518d, y: 0.9253140509604976d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5253333916068953d, y: 0.11661280163012155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652030733865062d, y: 0.1334689498863767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5943009430827066d, y: 0.32640849845737474d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10173500554787962d, y: 0.608372121050793d), new NpgsqlTypes.NpgsqlPoint(x: 0.30942328042164646d, y: 0.6807467333650337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708518790273918d, y: 0.8850747362552044d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3428383493367203d, y: 0.052393398539478886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583585096848481d, y: 0.8685997231579532d), new NpgsqlTypes.NpgsqlPoint(x: 0.11250735536808332d, y: 0.12421124089019986d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4523064658103585d, y: 0.04266497937567715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340933511835099d, y: 0.2739248147801352d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465465597586871d, y: 0.1425648809634792d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8795521337790012d, y: 0.4199083998938494d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772779230130824d, y: 0.6738382070851207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223674120976965d, y: 0.03930083024321396d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11962550809838668d, y: 0.37464759049624297d), new NpgsqlTypes.NpgsqlPoint(x: 0.47425647764346546d, y: 0.10966869144946312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4621440995243178d, y: 0.5715621504497037d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9241754926905024d, y: 0.1751615832598986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894444440316439d, y: 0.07920696049778797d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622575580019815d, y: 0.9593119508874655d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7076318870842407d, y: 0.09152698217670474d), new NpgsqlTypes.NpgsqlPoint(x: 0.19515314237511883d, y: 0.00542783311566597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9793865128720843d, y: 0.6552687103297218d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7832159344869838d, y: 0.32264065826617194d), new NpgsqlTypes.NpgsqlPoint(x: 0.09901101157136138d, y: 0.5815672216546086d), new NpgsqlTypes.NpgsqlPoint(x: 0.0884701644394601d, y: 0.17762584624124078d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.532408846619255d, y: 0.053621351834095d), new NpgsqlTypes.NpgsqlPoint(x: 0.11257088685880678d, y: 0.8794353658492201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7454724588968357d, y: 0.6569754813094111d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5642760391097589d, y: 0.4980487170912422d), new NpgsqlTypes.NpgsqlPoint(x: 0.020876442384672345d, y: 0.23894966015793717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331012399627415d, y: 0.3731913101301987d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08049446742976607d, y: 0.015822292517928438d), new NpgsqlTypes.NpgsqlPoint(x: 0.35972895920526804d, y: 0.4769390809114421d), new NpgsqlTypes.NpgsqlPoint(x: 0.1996544844789817d, y: 0.1941257544320686d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24282087004064945d, y: 0.936461578811766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6545952929297648d, y: 0.3409574500301723d), new NpgsqlTypes.NpgsqlPoint(x: 0.13830660277785167d, y: 0.8313362386141255d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4103651732866811d, y: 0.8273135234894292d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014625703424805403d, y: 0.6420780303807202d), new NpgsqlTypes.NpgsqlPoint(x: 0.18792277123850498d, y: 0.5607241664796011d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09989945572643477d, y: 0.9499377303503138d), new NpgsqlTypes.NpgsqlPoint(x: 0.12185388938827413d, y: 0.5324302776878119d), new NpgsqlTypes.NpgsqlPoint(x: 0.5710894785975551d, y: 0.4520340063251892d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9869416934510977d, y: 0.06973130617584267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5357713158710223d, y: 0.9193545231025324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5658805359086493d, y: 0.7634941953092503d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3270152240726837d, y: 0.39893567446293476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6733341807928275d, y: 0.4844807608118792d), new NpgsqlTypes.NpgsqlPoint(x: 0.07134962168629322d, y: 0.2203086339923337d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11206316959234552d, y: 0.4621458809844421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344686331365204d, y: 0.4352021807634623d), new NpgsqlTypes.NpgsqlPoint(x: 0.3718872962566153d, y: 0.3408543819959309d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8082829447430527d, y: 0.9727058258239472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8739801014720003d, y: 0.6939200241597443d), new NpgsqlTypes.NpgsqlPoint(x: 0.20133783232999936d, y: 0.02850676036386468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2915377953793282d, y: 0.836659669013159d), new NpgsqlTypes.NpgsqlPoint(x: 0.013836855370583212d, y: 0.9162780062749394d), new NpgsqlTypes.NpgsqlPoint(x: 0.917068336197152d, y: 0.7262077366987245d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5977197286029662d, y: 0.4622564429231486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738034165308731d, y: 0.6231783351474071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030063399930645d, y: 0.8144917808168521d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8867807616781447d, y: 0.8742809464669855d), new NpgsqlTypes.NpgsqlPoint(x: 0.846932576478237d, y: 0.4843359594723269d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499705950962806d, y: 0.6248955560640157d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8187190022399516d, y: 0.9982834989818848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4461859853575426d, y: 0.23350772633117634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7982539602827667d, y: 0.1549015646589521d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14576947527013018d, y: 0.7359249393432395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6400830593618897d, y: 0.2793662656300919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290288666194029d, y: 0.5042766405929764d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393649949649903d, y: 0.4299969715508478d), new NpgsqlTypes.NpgsqlPoint(x: 0.2786059782189997d, y: 0.7254170462421009d), new NpgsqlTypes.NpgsqlPoint(x: 0.33034374102568287d, y: 0.39776008785486483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8685470587648195d, y: 0.20092743283650738d), new NpgsqlTypes.NpgsqlPoint(x: 0.34313242232943875d, y: 0.21791037140148206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356901050711389d, y: 0.721605043287155d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02524784701892857d, y: 0.9046021240877614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018658144722763d, y: 0.47078942297644233d), new NpgsqlTypes.NpgsqlPoint(x: 0.16670098701167746d, y: 0.6656544264545406d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3868519917704497d, y: 0.646526434191963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885187454164577d, y: 0.8220304411587455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9648053629607192d, y: 0.025691665331320723d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19397710813267532d, y: 0.9309253933371691d), new NpgsqlTypes.NpgsqlPoint(x: 0.114818741510332d, y: 0.129669287175051d), new NpgsqlTypes.NpgsqlPoint(x: 0.6057278520521847d, y: 0.9548089616620724d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21969223181179875d, y: 0.3041491618190747d), new NpgsqlTypes.NpgsqlPoint(x: 0.1872855034611688d, y: 0.7398791345817379d), new NpgsqlTypes.NpgsqlPoint(x: 0.3729486868168762d, y: 0.9147630352606847d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.295317240290228d, y: 0.37479321046978875d), new NpgsqlTypes.NpgsqlPoint(x: 0.48785943852240166d, y: 0.276023807062445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275625912601321d, y: 0.939717068838872d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7156988144691268d, y: 0.19783847241343433d), new NpgsqlTypes.NpgsqlPoint(x: 0.24265805803512508d, y: 0.4309542002539667d), new NpgsqlTypes.NpgsqlPoint(x: 0.06364069405901451d, y: 0.4167912781956963d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4261736314221849d, y: 0.48880131786295244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5359699615734023d, y: 0.19319148919509654d), new NpgsqlTypes.NpgsqlPoint(x: 0.4710363938879861d, y: 0.4491617797288403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9805908702908027d, y: 0.2689777843033314d), new NpgsqlTypes.NpgsqlPoint(x: 0.44070000252673713d, y: 0.04087749263363927d), new NpgsqlTypes.NpgsqlPoint(x: 0.42715126247594337d, y: 0.43644314398031614d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.547294379547148d, y: 0.8140508128471043d), new NpgsqlTypes.NpgsqlPoint(x: 0.7293059656492735d, y: 0.5873688072662931d), new NpgsqlTypes.NpgsqlPoint(x: 0.14640191798011493d, y: 0.6432298837299213d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9622644734250764d, y: 0.5717221482864775d), new NpgsqlTypes.NpgsqlPoint(x: 0.4664593004406722d, y: 0.40132107534225203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2511023670325838d, y: 0.5907353149706743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39452086135478925d, y: 0.2518933898536653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070115781173032d, y: 0.43468590139425023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875949193709319d, y: 0.617070630518635d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4453369805655789d, y: 0.9532169707970873d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831880826792534d, y: 0.8692291787850652d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423531474056478d, y: 0.5693093146822046d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44547259649602156d, y: 0.3904967633832688d), new NpgsqlTypes.NpgsqlPoint(x: 0.542313356094558d, y: 0.5222422981763863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522501888229689d, y: 0.7268922300366892d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4660026766920883d, y: 0.35697481317475677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561216056980788d, y: 0.19176266353953764d), new NpgsqlTypes.NpgsqlPoint(x: 0.1761650165347608d, y: 0.06743198236889303d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6393343706292501d, y: 0.7757892892673931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397153381710559d, y: 0.034544402565198085d), new NpgsqlTypes.NpgsqlPoint(x: 0.496225151284581d, y: 0.0728921859479521d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4994021285044451d, y: 0.40186032769388247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9255895212416985d, y: 0.5371728781575402d), new NpgsqlTypes.NpgsqlPoint(x: 0.09239281141628053d, y: 0.7797854798832059d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2694811115876399d, y: 0.6440986572047687d), new NpgsqlTypes.NpgsqlPoint(x: 0.12240660161553207d, y: 0.08472166385806634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810422486884444d, y: 0.22660277528392625d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2894648131820827d, y: 0.5069834955052004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8399474914653589d, y: 0.6040515248965016d), new NpgsqlTypes.NpgsqlPoint(x: 0.020775066426052646d, y: 0.9386486007248032d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21455514215399807d, y: 0.36095912782279616d), new NpgsqlTypes.NpgsqlPoint(x: 0.36612257408723115d, y: 0.5970205853755285d), new NpgsqlTypes.NpgsqlPoint(x: 0.280619597313302d, y: 0.9370858558386774d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5481321731951658d, y: 0.42908916754064363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431500897246957d, y: 0.26142312976670834d), new NpgsqlTypes.NpgsqlPoint(x: 0.10400698663305308d, y: 0.7782609987740625d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4247941537824743d, y: 0.6442048899411926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8658277186951331d, y: 0.46499321763363144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708150478036655d, y: 0.6884655398838438d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.784973181652432d, y: 0.09515340249749182d), new NpgsqlTypes.NpgsqlPoint(x: 0.804164567598773d, y: 0.7808769249305536d), new NpgsqlTypes.NpgsqlPoint(x: 0.674240076621224d, y: 0.9319688018044556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31437218088162433d, y: 0.5431309600755999d), new NpgsqlTypes.NpgsqlPoint(x: 0.28382530819125706d, y: 0.5528532020870641d), new NpgsqlTypes.NpgsqlPoint(x: 0.35780840566181993d, y: 0.023773680275682607d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716645444550307d, y: 0.006817985637699309d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820200086772423d, y: 0.22818543346411513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301037704572486d, y: 0.6816845571580081d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5990412966110925d, y: 0.2176962698310675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774131280164834d, y: 0.47777397072808225d), new NpgsqlTypes.NpgsqlPoint(x: 0.6073692191622896d, y: 0.003545309045450251d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21137623947912887d, y: 0.7288522905844993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059294946898613d, y: 0.20669901571929883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491102640373922d, y: 0.9019813619097728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.733853184947981d, y: 0.30271839924879773d), new NpgsqlTypes.NpgsqlPoint(x: 0.24206259946552644d, y: 0.03498989501247107d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532464076564578d, y: 0.6207173743126241d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7220135796659081d, y: 0.7229475615755434d), new NpgsqlTypes.NpgsqlPoint(x: 0.2619897031835593d, y: 0.3246324046694995d), new NpgsqlTypes.NpgsqlPoint(x: 0.293634260266586d, y: 0.9554573168960283d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12031570527024793d, y: 0.5109905479054806d), new NpgsqlTypes.NpgsqlPoint(x: 0.9522641356900317d, y: 0.395353296343387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1882914187172029d, y: 0.013513006847243214d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.059860199346929654d, y: 0.3457948253738523d), new NpgsqlTypes.NpgsqlPoint(x: 0.15985945832962756d, y: 0.2820405490564758d), new NpgsqlTypes.NpgsqlPoint(x: 0.04999167073076782d, y: 0.03136017691638271d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3089633714675869d, y: 0.1910306555708312d), new NpgsqlTypes.NpgsqlPoint(x: 0.1207116552526536d, y: 0.5622703569961663d), new NpgsqlTypes.NpgsqlPoint(x: 0.44506347333010277d, y: 0.8401182986234909d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3687972686597134d, y: 0.7154981519724957d), new NpgsqlTypes.NpgsqlPoint(x: 0.0015764849925204993d, y: 0.03788525134468301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705411918258098d, y: 0.40173789292740514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6019567879740583d, y: 0.1024953084577499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981581482299865d, y: 0.844347406270792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711463053532174d, y: 0.11677784049335438d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16357394261870595d, y: 0.1373302233880963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288703353309447d, y: 0.9405152029477385d), new NpgsqlTypes.NpgsqlPoint(x: 0.38224408953089106d, y: 0.5882720957104756d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9126337004627612d, y: 0.4844754388832465d), new NpgsqlTypes.NpgsqlPoint(x: 0.252213378404859d, y: 0.9976601102561096d), new NpgsqlTypes.NpgsqlPoint(x: 0.963236444671694d, y: 0.8967249433413784d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2636667676361135d, y: 0.007126402373622831d), new NpgsqlTypes.NpgsqlPoint(x: 0.42824151505776165d, y: 0.6937400057201933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430152689665357d, y: 0.7845438103697066d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4274636861020499d, y: 0.4172232926559736d), new NpgsqlTypes.NpgsqlPoint(x: 0.22928125543749223d, y: 0.7667056192703974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8111764719495893d, y: 0.937767221335177d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3686777822441274d, y: 0.04624294765482173d), new NpgsqlTypes.NpgsqlPoint(x: 0.23126389176619444d, y: 0.6414386320097981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704941235028493d, y: 0.4293568658468706d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4187078969596275d, y: 0.7776467865832781d), new NpgsqlTypes.NpgsqlPoint(x: 0.37472255135192156d, y: 0.14326372367434803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695931972266808d, y: 0.282703886044373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8003142575044823d, y: 0.27599987174199947d), new NpgsqlTypes.NpgsqlPoint(x: 0.34352828348348463d, y: 0.5307657496575406d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963874601319769d, y: 0.08603176407586677d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35935368075303076d, y: 0.38053394590480627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9826509845492184d, y: 0.781299671455626d), new NpgsqlTypes.NpgsqlPoint(x: 0.28749678355540764d, y: 0.8428547309947672d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.570545151257581d, y: 0.5907640514973638d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254528529725542d, y: 0.7131486900823892d), new NpgsqlTypes.NpgsqlPoint(x: 0.3418747804226704d, y: 0.01848126955004048d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10593440106825325d, y: 0.5849390038018548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554904044297231d, y: 0.11662789669484508d), new NpgsqlTypes.NpgsqlPoint(x: 0.19664165150860935d, y: 0.6899319139151497d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9122618202633495d, y: 0.3287047783041246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507215233555118d, y: 0.6691249101900263d), new NpgsqlTypes.NpgsqlPoint(x: 0.963813179347025d, y: 0.9420716329793618d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06932840831322518d, y: 0.5471443939497522d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216607206046517d, y: 0.23835754162281564d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693584922730703d, y: 0.20717458405413136d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8930032909520644d, y: 0.1254845951615995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514950344983128d, y: 0.9872393140176647d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558913338732439d, y: 0.4739321229331849d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9346826796653884d, y: 0.8495944866501354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191425323683911d, y: 0.6844937899462114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603580709672994d, y: 0.8032668267754859d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6251946209171612d, y: 0.11457424322979304d), new NpgsqlTypes.NpgsqlPoint(x: 0.30848122925466515d, y: 0.9927597452933893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209112304422327d, y: 0.07506300852288483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02893669282049549d, y: 0.6440004268442442d), new NpgsqlTypes.NpgsqlPoint(x: 0.14578140775546167d, y: 0.607223329733164d), new NpgsqlTypes.NpgsqlPoint(x: 0.38952154209061773d, y: 0.6045476810052963d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22429363045084727d, y: 0.40252157089262164d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823702661669478d, y: 0.8521565694261363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916161427432616d, y: 0.7739020791247797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44863078754151264d, y: 0.5700196590771612d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054468024720167d, y: 0.2876708993722853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443133934104635d, y: 0.6176730796650571d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5733940559265079d, y: 0.9528999797620528d), new NpgsqlTypes.NpgsqlPoint(x: 0.0995305945212801d, y: 0.9012116271266295d), new NpgsqlTypes.NpgsqlPoint(x: 0.10665225678807655d, y: 0.8855494893460496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31690049248452656d, y: 0.37999201035728947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677048690417217d, y: 0.3408483027302911d), new NpgsqlTypes.NpgsqlPoint(x: 0.2362870280192979d, y: 0.9763826603066122d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9381833718765437d, y: 0.13276398036273573d), new NpgsqlTypes.NpgsqlPoint(x: 0.40484081476944056d, y: 0.5178545110408054d), new NpgsqlTypes.NpgsqlPoint(x: 0.35409708981847565d, y: 0.3849658977437799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22428063045923263d, y: 0.07422734096503891d), new NpgsqlTypes.NpgsqlPoint(x: 0.3246909869242327d, y: 0.24496899749918954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7696751209784575d, y: 0.3231749120195254d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.527697517359071d, y: 0.8093609399628071d), new NpgsqlTypes.NpgsqlPoint(x: 0.671611403292283d, y: 0.2569113401921346d), new NpgsqlTypes.NpgsqlPoint(x: 0.03478112270679967d, y: 0.3251068328287503d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08054901526756242d, y: 0.03746028344591201d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125594850225797d, y: 0.15889112733060717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629558773547665d, y: 0.5419611726909787d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02132240597009938d, y: 0.24095486245447373d), new NpgsqlTypes.NpgsqlPoint(x: 0.22682512591962423d, y: 0.6231757766543611d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180385587652158d, y: 0.4384885361066565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32779626576359344d, y: 0.8429530385124862d), new NpgsqlTypes.NpgsqlPoint(x: 0.1810931861819295d, y: 0.7591773945307679d), new NpgsqlTypes.NpgsqlPoint(x: 0.27042041188068044d, y: 0.9820816653252462d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7263113474113561d, y: 0.616887866410644d), new NpgsqlTypes.NpgsqlPoint(x: 0.18993047416147002d, y: 0.7061070061798932d), new NpgsqlTypes.NpgsqlPoint(x: 0.29861342134618074d, y: 0.697166878051469d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06299762094327566d, y: 0.7034222036792176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4205683962985183d, y: 0.7464059826375329d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310587037786626d, y: 0.21066457466355315d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9625927411063334d, y: 0.3441058177314853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508874937125858d, y: 0.13737908203041993d), new NpgsqlTypes.NpgsqlPoint(x: 0.1671901827242216d, y: 0.6043762284345229d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3310039860947709d, y: 0.8972153055003625d), new NpgsqlTypes.NpgsqlPoint(x: 0.06409863877041344d, y: 0.6277322006364174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486698193299728d, y: 0.7509548728082297d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7308668119698587d, y: 0.040336044163837736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956448996556622d, y: 0.06465191357110411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196968061633545d, y: 0.4096480082007946d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.653054227003293d, y: 0.5243212849518619d), new NpgsqlTypes.NpgsqlPoint(x: 0.11084003592220482d, y: 0.38775060270516437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585880129913593d, y: 0.1177137253029027d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21365419231044225d, y: 0.4599153720556376d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456847491884405d, y: 0.04483963870379726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629740527481656d, y: 0.3956950390718227d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37047108765332126d, y: 0.10657158515467835d), new NpgsqlTypes.NpgsqlPoint(x: 0.9099994932049266d, y: 0.08153512674609609d), new NpgsqlTypes.NpgsqlPoint(x: 0.78567168262404d, y: 0.07544413996169808d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26443156591322625d, y: 0.2454534781558657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674437290075515d, y: 0.5983278108736969d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296436871434988d, y: 0.6852419508119515d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2238622042380749d, y: 0.17651879058102338d), new NpgsqlTypes.NpgsqlPoint(x: 0.11538645551327786d, y: 0.12599885511922393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075999993272442d, y: 0.6424252916245161d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8979186116208032d, y: 0.8740688838458006d), new NpgsqlTypes.NpgsqlPoint(x: 0.1571310908275082d, y: 0.12064591161874605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775749003617027d, y: 0.6995469383040248d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7132664382288255d, y: 0.09313709964592909d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257706367018572d, y: 0.5981215294147495d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738872455944719d, y: 0.3495720040457322d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15882008365495082d, y: 0.8499306361405021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9854972127810951d, y: 0.71125947198128d), new NpgsqlTypes.NpgsqlPoint(x: 0.40175898267565224d, y: 0.724223794179027d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6556622977489075d, y: 0.3889585983104308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364105609718914d, y: 0.3102859318767802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516574343093682d, y: 0.39900600833058697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24068952917778152d, y: 0.2597003149344552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9453664654857231d, y: 0.24529480390134917d), new NpgsqlTypes.NpgsqlPoint(x: 0.47971068618211943d, y: 0.46503406784137047d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790423319317779d, y: 0.3672693327664026d), new NpgsqlTypes.NpgsqlPoint(x: 0.08539279908241748d, y: 0.7984179004698735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3262846767491926d, y: 0.007381857234988631d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870236447200164d, y: 0.0015207606050612332d), new NpgsqlTypes.NpgsqlPoint(x: 0.06460419945787654d, y: 0.2704721202173923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20131500222571053d, y: 0.22134744076877133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33343589235836335d, y: 0.7785348335479993d), new NpgsqlTypes.NpgsqlPoint(x: 0.08622650919805175d, y: 0.9630539674950538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179755205270283d, y: 0.7814722508799095d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.695741550721381d, y: 0.7744678786727569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971807890214909d, y: 0.45272939223186937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860257012808956d, y: 0.2074584613954349d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9507901762476709d, y: 0.09186954442585482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2340820836219336d, y: 0.743171251240996d), new NpgsqlTypes.NpgsqlPoint(x: 0.38367427678175836d, y: 0.43918656192248784d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 115, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 28, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatch(connection, 142, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

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
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

