

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
    internal partial interface INpgsqlPolygonListpolygonListD1
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonListD1 : INpgsqlPolygonListpolygonListD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonListD1E2M[] _testData = new NpgsqlPolygonpolygonListD1E2M[]
        {
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6757471121585225d, y: 0.3239210728160723d), new NpgsqlTypes.NpgsqlPoint(x: 0.35962353095587196d, y: 0.353331807469183d), new NpgsqlTypes.NpgsqlPoint(x: 0.07976122014852616d, y: 0.8185040441594462d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9342689120512288d, y: 0.6913124183530781d), new NpgsqlTypes.NpgsqlPoint(x: 0.638194051743272d, y: 0.5633897676827062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795208006884699d, y: 0.7058809719104129d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279135055297836d, y: 0.1066863666841612d), new NpgsqlTypes.NpgsqlPoint(x: 0.40769464850198356d, y: 0.7121722991976517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3720645148739632d, y: 0.6274215296410147d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7902110782715094d, y: 0.9709466695018123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725415375970392d, y: 0.34104997516028235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133754372272154d, y: 0.3522064248232628d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9290045346522432d, y: 0.6619287821175311d), new NpgsqlTypes.NpgsqlPoint(x: 0.45665065242312175d, y: 0.7610693236730682d), new NpgsqlTypes.NpgsqlPoint(x: 0.1861848865931892d, y: 0.7554419489000365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9151938931100234d, y: 0.9569007257465793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9189726769245999d, y: 0.24990692124479963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7775453585390869d, y: 0.22368908568125456d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7827962017387542d, y: 0.34340368218589656d), new NpgsqlTypes.NpgsqlPoint(x: 0.09144946851324853d, y: 0.799635954318862d), new NpgsqlTypes.NpgsqlPoint(x: 0.05361534513729371d, y: 0.2047041578512353d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39839698028242687d, y: 0.5387126254875363d), new NpgsqlTypes.NpgsqlPoint(x: 0.40038304084612686d, y: 0.4100514683169937d), new NpgsqlTypes.NpgsqlPoint(x: 0.09969229112898892d, y: 0.32265917196602945d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7503196814380155d, y: 0.9664318647480263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6132162402749659d, y: 0.27203191422085327d), new NpgsqlTypes.NpgsqlPoint(x: 0.36800466032330825d, y: 0.4397499192535481d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.051851138374685135d, y: 0.4998168796865784d), new NpgsqlTypes.NpgsqlPoint(x: 0.4092250685933104d, y: 0.5213976481105396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978706703717897d, y: 0.95575016864968d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09469108965103601d, y: 0.4972818919791959d), new NpgsqlTypes.NpgsqlPoint(x: 0.626116331484516d, y: 0.22276966162937828d), new NpgsqlTypes.NpgsqlPoint(x: 0.2981034816072886d, y: 0.9295695516945457d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215179587541038d, y: 0.28512535105412207d), new NpgsqlTypes.NpgsqlPoint(x: 0.12404036879395586d, y: 0.9498807121017994d), new NpgsqlTypes.NpgsqlPoint(x: 0.2303678060017913d, y: 0.17718313828205123d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5409031488117434d, y: 0.7969023523660025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745432947927849d, y: 0.5025985709545007d), new NpgsqlTypes.NpgsqlPoint(x: 0.32957472408463884d, y: 0.6790716495766019d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9118122924252257d, y: 0.5120761463151187d), new NpgsqlTypes.NpgsqlPoint(x: 0.1681925244901744d, y: 0.6226666222232123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953937990740983d, y: 0.8643434145877811d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6343353400896302d, y: 0.5094420178311436d), new NpgsqlTypes.NpgsqlPoint(x: 0.2310483240641834d, y: 0.22576790191342677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7986882572501539d, y: 0.28152830675829743d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3123783320258592d, y: 0.13386941010744435d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838476385389714d, y: 0.7864140173611931d), new NpgsqlTypes.NpgsqlPoint(x: 0.1281734942922087d, y: 0.8515219574139323d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8015097072467818d, y: 0.18133743738733044d), new NpgsqlTypes.NpgsqlPoint(x: 0.749249271751129d, y: 0.3838056735725043d), new NpgsqlTypes.NpgsqlPoint(x: 0.12348072161558388d, y: 0.592925345486858d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1950741050550202d, y: 0.4180867548620224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342689924461852d, y: 0.5043594384618663d), new NpgsqlTypes.NpgsqlPoint(x: 0.22501043672166543d, y: 0.6696772149146014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3605647510418635d, y: 0.5882237881526952d), new NpgsqlTypes.NpgsqlPoint(x: 0.10261438728571537d, y: 0.13048386732045592d), new NpgsqlTypes.NpgsqlPoint(x: 0.35402859398986575d, y: 0.7882694215037055d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23750711780582867d, y: 0.3884229870520769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9206215080877624d, y: 0.5085306309524859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9471119174413388d, y: 0.07289258737315274d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11470497121452361d, y: 0.275228396695001d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159422169115838d, y: 0.8568401356037068d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092479011529941d, y: 0.7765809548076105d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1809042296518386d, y: 0.9459693801985718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907088341637071d, y: 0.9831288803190076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026142426895862d, y: 0.27813188154238266d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.608062795021491d, y: 0.900798639507925d), new NpgsqlTypes.NpgsqlPoint(x: 0.07451148889975656d, y: 0.21293366579765172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5241076090352143d, y: 0.654581123033373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3453605948596815d, y: 0.9977761317327726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030196251269068d, y: 0.3182692681544862d), new NpgsqlTypes.NpgsqlPoint(x: 0.733089892985817d, y: 0.20075683852893422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.037815303564234126d, y: 0.7733789772507479d), new NpgsqlTypes.NpgsqlPoint(x: 0.30924535294836764d, y: 0.4319924341627953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851217054193013d, y: 0.614474907785603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46007570069341686d, y: 0.28235810575636644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456155830720631d, y: 0.12264246464614659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6589030003222915d, y: 0.6146395193009234d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.811605243009424d, y: 0.2557532167221007d), new NpgsqlTypes.NpgsqlPoint(x: 0.12424665641953248d, y: 0.40303504253702016d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644265884911647d, y: 0.9126813029276516d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8597541748410474d, y: 0.3571023321398802d), new NpgsqlTypes.NpgsqlPoint(x: 0.23424686811298445d, y: 0.36047561114293847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361083905949264d, y: 0.5909179457472521d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6582664024752233d, y: 0.8030109260016984d), new NpgsqlTypes.NpgsqlPoint(x: 0.23715162500750542d, y: 0.8403981348397511d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930135885685937d, y: 0.24086226939210342d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9266954035073551d, y: 0.16516337277928983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196628805734157d, y: 0.8213108673887608d), new NpgsqlTypes.NpgsqlPoint(x: 0.26397801858159786d, y: 0.0538575049263601d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414816678658943d, y: 0.4950217832142765d), new NpgsqlTypes.NpgsqlPoint(x: 0.35960752650061467d, y: 0.820946248300495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9413116993378475d, y: 0.31403231962160716d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01267097408615947d, y: 0.13253789906879243d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195873257386264d, y: 0.8357705625534488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7640364887504196d, y: 0.3992061708677469d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8259270037822034d, y: 0.6178451879625144d), new NpgsqlTypes.NpgsqlPoint(x: 0.4127893697931635d, y: 0.769218426553357d), new NpgsqlTypes.NpgsqlPoint(x: 0.02063119836771432d, y: 0.6689052298356678d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6261640406590963d, y: 0.6087576410548007d), new NpgsqlTypes.NpgsqlPoint(x: 0.58381325393639d, y: 0.3562877928958914d), new NpgsqlTypes.NpgsqlPoint(x: 0.23690998970608412d, y: 0.9967146673505921d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.98830428467256d, y: 0.20639399724683072d), new NpgsqlTypes.NpgsqlPoint(x: 0.0848573219924228d, y: 0.5128976454796694d), new NpgsqlTypes.NpgsqlPoint(x: 0.3292991836392204d, y: 0.32241714990207515d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.66530472060659d, y: 0.7364223557306306d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111735968064303d, y: 0.14835990179371317d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500599211799224d, y: 0.22388444515513872d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14402212349287835d, y: 0.38460850103251565d), new NpgsqlTypes.NpgsqlPoint(x: 0.2887263064318577d, y: 0.8003457353413652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5113269656025173d, y: 0.8086690749618484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8331528331229495d, y: 0.93089779122756d), new NpgsqlTypes.NpgsqlPoint(x: 0.40189039562816187d, y: 0.20670766191546042d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250324829449742d, y: 0.16712355171946836d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7670233065208604d, y: 0.3718236587040229d), new NpgsqlTypes.NpgsqlPoint(x: 0.2047273742977661d, y: 0.8659404942196568d), new NpgsqlTypes.NpgsqlPoint(x: 0.04342854961655962d, y: 0.645261588442944d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.943238138898782d, y: 0.05079096629200075d), new NpgsqlTypes.NpgsqlPoint(x: 0.858648817624082d, y: 0.8590202439687387d), new NpgsqlTypes.NpgsqlPoint(x: 0.22355583763928377d, y: 0.0961072169483479d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8146615967981099d, y: 0.22521039851259494d), new NpgsqlTypes.NpgsqlPoint(x: 0.24797363755254054d, y: 0.16365623053613743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489391082816195d, y: 0.37646022946511315d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6814429455907611d, y: 0.05986058189260335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751434201506314d, y: 0.13926178738017625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608575318920647d, y: 0.69164244650971d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6143995814882215d, y: 0.1706723368103451d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752105751521394d, y: 0.31528956532896235d), new NpgsqlTypes.NpgsqlPoint(x: 0.08131080005792424d, y: 0.8196212004799793d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369233777145588d, y: 0.15393791884976538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750088398979718d, y: 0.7094811624392856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301695446626654d, y: 0.43236044513322014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6060880438963355d, y: 0.4535656498437106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2158173028399879d, y: 0.8270387185649766d), new NpgsqlTypes.NpgsqlPoint(x: 0.22291427566979527d, y: 0.4033912159424884d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6935919575897322d, y: 0.41992260119323066d), new NpgsqlTypes.NpgsqlPoint(x: 0.4473587876292938d, y: 0.2774046841846536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363779754870984d, y: 0.8616472089542573d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5477720444020738d, y: 0.8522029874530763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3877438543031121d, y: 0.13726555187899303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4886713267184023d, y: 0.8971508341203565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9623496607711092d, y: 0.722066691146643d), new NpgsqlTypes.NpgsqlPoint(x: 0.34332913414097366d, y: 0.7844197876672192d), new NpgsqlTypes.NpgsqlPoint(x: 0.14129354927168092d, y: 0.996233360459673d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025438062982796716d, y: 0.6807199560273726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5760163522584656d, y: 0.5042183914315269d), new NpgsqlTypes.NpgsqlPoint(x: 0.658347710204461d, y: 0.5908785799393569d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8475704472255076d, y: 0.5871889782487427d), new NpgsqlTypes.NpgsqlPoint(x: 0.881232588089271d, y: 0.879686564697039d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244019632220017d, y: 0.4148713824032031d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373705689910771d, y: 0.7686773713070287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741108261250399d, y: 0.03360438924422371d), new NpgsqlTypes.NpgsqlPoint(x: 0.44164715294364765d, y: 0.4882937391332185d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44046185275231653d, y: 0.9120221953126973d), new NpgsqlTypes.NpgsqlPoint(x: 0.04337531748289336d, y: 0.5272467516333738d), new NpgsqlTypes.NpgsqlPoint(x: 0.74039847247276d, y: 0.33984838635625236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9237034680890744d, y: 0.005972529331008447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407566833938404d, y: 0.4769585405079656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827767417094034d, y: 0.09687627045436387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5180333256850355d, y: 0.8614984675820478d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500723653236614d, y: 0.20880774310428407d), new NpgsqlTypes.NpgsqlPoint(x: 0.613499496985623d, y: 0.40338665814998564d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652098830190164d, y: 0.5773682270355606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162413765400858d, y: 0.9441600115764517d), new NpgsqlTypes.NpgsqlPoint(x: 0.28291391458193627d, y: 0.9564489976615131d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18948151521985657d, y: 0.02840730750018594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851452953538439d, y: 0.49016032105942076d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413891176153273d, y: 0.9122843752356488d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5984768464357537d, y: 0.7465047161422362d), new NpgsqlTypes.NpgsqlPoint(x: 0.009975439812134002d, y: 0.49712239846630446d), new NpgsqlTypes.NpgsqlPoint(x: 0.061420482857619585d, y: 0.3340537364271893d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.239472955997716d, y: 0.22678889937603353d), new NpgsqlTypes.NpgsqlPoint(x: 0.2182803258416648d, y: 0.06186557259875103d), new NpgsqlTypes.NpgsqlPoint(x: 0.2289487310352507d, y: 0.3346867488744385d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5345313429975108d, y: 0.024724262516207074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3570671099039924d, y: 0.5197194925668686d), new NpgsqlTypes.NpgsqlPoint(x: 0.41173695058976767d, y: 0.9618250946150663d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47688416257116006d, y: 0.09753611055060174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925409380257475d, y: 0.7301490380423081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299129006154999d, y: 0.6610757572265642d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7018387590114934d, y: 0.8793726672494062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6591500817408374d, y: 0.669256709437895d), new NpgsqlTypes.NpgsqlPoint(x: 0.14503910542440024d, y: 0.1137585094292961d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8929919023956708d, y: 0.756915217467157d), new NpgsqlTypes.NpgsqlPoint(x: 0.789340005326477d, y: 0.10925794191409544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009946039183009d, y: 0.14930317462431286d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7129235580621377d, y: 0.9746165692624101d), new NpgsqlTypes.NpgsqlPoint(x: 0.674986674119324d, y: 0.03984305049252801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567448082109896d, y: 0.5398557792567691d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6271288745739989d, y: 0.8657434925062377d), new NpgsqlTypes.NpgsqlPoint(x: 0.36138217993735233d, y: 0.8581547357598758d), new NpgsqlTypes.NpgsqlPoint(x: 0.2345303831552974d, y: 0.6263946534553785d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.769325819513251d, y: 0.5883437348145185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591661438296888d, y: 0.6026363059892994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661334380286905d, y: 0.06514165837161234d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9420848663447589d, y: 0.21690865838428097d), new NpgsqlTypes.NpgsqlPoint(x: 0.03991251033609766d, y: 0.6744348054216908d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097198266871698d, y: 0.20723859281692425d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37367626811634724d, y: 0.9353225136307551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770528218740591d, y: 0.4949881921663677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667514540467864d, y: 0.420787728806598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6193616915094916d, y: 0.48702759288929776d), new NpgsqlTypes.NpgsqlPoint(x: 0.1581264946130132d, y: 0.17018688269592963d), new NpgsqlTypes.NpgsqlPoint(x: 0.1763324474388599d, y: 0.9416205690578414d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6315811070332464d, y: 0.48635726676502467d), new NpgsqlTypes.NpgsqlPoint(x: 0.21523944992614807d, y: 0.6842651354548732d), new NpgsqlTypes.NpgsqlPoint(x: 0.052843312439629475d, y: 0.4553445183344641d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9506412441006448d, y: 0.8847072770107133d), new NpgsqlTypes.NpgsqlPoint(x: 0.13567327921353223d, y: 0.6136692831623496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7791466259849597d, y: 0.3811009879096914d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46982796871207244d, y: 0.40126680724365227d), new NpgsqlTypes.NpgsqlPoint(x: 0.3540455009063179d, y: 0.14485041819009437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6461073420108925d, y: 0.9787459457570492d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023932195234244835d, y: 0.11977707309004082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9596220795993533d, y: 0.7144216764866502d), new NpgsqlTypes.NpgsqlPoint(x: 0.08464864176418985d, y: 0.4786069863499678d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9800758505148858d, y: 0.2802465318856616d), new NpgsqlTypes.NpgsqlPoint(x: 0.553555938651541d, y: 0.5165432515114463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931193217974114d, y: 0.6705413045918658d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.898431384944649d, y: 0.4590274003432354d), new NpgsqlTypes.NpgsqlPoint(x: 0.22853207522276853d, y: 0.290384168712958d), new NpgsqlTypes.NpgsqlPoint(x: 0.9803134842450438d, y: 0.21212354395471822d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9815073494641122d, y: 0.45477739010396756d), new NpgsqlTypes.NpgsqlPoint(x: 0.954123857803116d, y: 0.261883526476796d), new NpgsqlTypes.NpgsqlPoint(x: 0.22264118374544017d, y: 0.47235469139691744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2563301814849267d, y: 0.3587494614208795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8106508252417776d, y: 0.9775458094760285d), new NpgsqlTypes.NpgsqlPoint(x: 0.1704582250461848d, y: 0.9330248618055047d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4169999862347912d, y: 0.20518682010727196d), new NpgsqlTypes.NpgsqlPoint(x: 0.1591280595449035d, y: 0.8299196931271184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4248614374729126d, y: 0.054869253066484935d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4181477368648021d, y: 0.08190504026119327d), new NpgsqlTypes.NpgsqlPoint(x: 0.4339727933553973d, y: 0.6290081616684092d), new NpgsqlTypes.NpgsqlPoint(x: 0.876460335267746d, y: 0.40923208578094605d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5950361067387596d, y: 0.601475165071372d), new NpgsqlTypes.NpgsqlPoint(x: 0.4125756814492889d, y: 0.7585141540350295d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798313449140776d, y: 0.012650897047667087d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6485502900029461d, y: 0.2607979629799996d), new NpgsqlTypes.NpgsqlPoint(x: 0.47064907493317865d, y: 0.5301663388034265d), new NpgsqlTypes.NpgsqlPoint(x: 0.575015416343828d, y: 0.8094691212079284d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7246618166209644d, y: 0.5174821665668582d), new NpgsqlTypes.NpgsqlPoint(x: 0.45419020687347134d, y: 0.16305738326575026d), new NpgsqlTypes.NpgsqlPoint(x: 0.20737233494540575d, y: 0.2751811800660129d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5517452952419012d, y: 0.09398045346227313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928267319394424d, y: 0.8024267898936681d), new NpgsqlTypes.NpgsqlPoint(x: 0.678182158337307d, y: 0.8612910847991815d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6284412532573241d, y: 0.7602365356955246d), new NpgsqlTypes.NpgsqlPoint(x: 0.930184206994621d, y: 0.20639685311648082d), new NpgsqlTypes.NpgsqlPoint(x: 0.7509381572836439d, y: 0.3851928212036243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9371119688125069d, y: 0.7170808959616598d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017681097358503983d, y: 0.002420586366039146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4059648926288272d, y: 0.8338179851866052d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6817014286274828d, y: 0.159979468431931d), new NpgsqlTypes.NpgsqlPoint(x: 0.5321889211285443d, y: 0.7312944408279591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453388777066508d, y: 0.11182012110294792d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39126090444487993d, y: 0.465883563212953d), new NpgsqlTypes.NpgsqlPoint(x: 0.47842880011331346d, y: 0.5641725446379324d), new NpgsqlTypes.NpgsqlPoint(x: 0.216378867194432d, y: 0.39261754471120425d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.853396379319914d, y: 0.07446216299349062d), new NpgsqlTypes.NpgsqlPoint(x: 0.8817851630669691d, y: 0.3227638156788878d), new NpgsqlTypes.NpgsqlPoint(x: 0.019101443979473776d, y: 0.33419953577471007d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1855102729155289d, y: 0.27930101574712296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846348032946303d, y: 0.46970173474478394d), new NpgsqlTypes.NpgsqlPoint(x: 0.36538220028636603d, y: 0.08955678670941347d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20955048044809832d, y: 0.13720082568623482d), new NpgsqlTypes.NpgsqlPoint(x: 0.37531420533661264d, y: 0.47033774437285647d), new NpgsqlTypes.NpgsqlPoint(x: 0.25086003140543556d, y: 0.4190528349618662d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16222257142818375d, y: 0.7959601484965836d), new NpgsqlTypes.NpgsqlPoint(x: 0.1224787372094438d, y: 0.4649398772742377d), new NpgsqlTypes.NpgsqlPoint(x: 0.12541324044591817d, y: 0.8279055333475236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9994189281752692d, y: 0.4346817660737241d), new NpgsqlTypes.NpgsqlPoint(x: 0.175543270154365d, y: 0.15318448559094322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3502693597531886d, y: 0.43265473694971635d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6998206182695587d, y: 0.13646841957387745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7305586384428584d, y: 0.048160174774654396d), new NpgsqlTypes.NpgsqlPoint(x: 0.31655837249456054d, y: 0.46068721740045904d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3646448835660159d, y: 0.8329866708417919d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923722665363547d, y: 0.6981814501222785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759725154103243d, y: 0.5639833080516873d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7379554781549449d, y: 0.6812801243652707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5381184758854743d, y: 0.240045817880987d), new NpgsqlTypes.NpgsqlPoint(x: 0.10659083312637507d, y: 0.5794418544197532d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9237803588864314d, y: 0.15549454037668897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761913580736775d, y: 0.2158458372836377d), new NpgsqlTypes.NpgsqlPoint(x: 0.9141605445935471d, y: 0.9417262781798039d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40240992009754584d, y: 0.9638875182743979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283746306507402d, y: 0.19035598383441654d), new NpgsqlTypes.NpgsqlPoint(x: 0.2904005897120375d, y: 0.8163264587519431d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9285334441397013d, y: 0.5709066385837444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265579365820453d, y: 0.1793816538796702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112571552328722d, y: 0.08283185468084042d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008809203180016989d, y: 0.17285830456296358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047865505753959d, y: 0.7943718467120893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599010235929581d, y: 0.8605616992102286d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23040892920527722d, y: 0.59260967253727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255921308853823d, y: 0.3469363957440279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6190444199740724d, y: 0.17724679018756295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7944581905279577d, y: 0.968334623607634d), new NpgsqlTypes.NpgsqlPoint(x: 0.01406502283530453d, y: 0.2673043833877591d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005710733520824d, y: 0.13460222427998603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08004001063588417d, y: 0.5388700443702306d), new NpgsqlTypes.NpgsqlPoint(x: 0.24340032600462702d, y: 0.4616344300945857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938433459362866d, y: 0.643531509207941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4053304932689309d, y: 0.7209691186793827d), new NpgsqlTypes.NpgsqlPoint(x: 0.038737756653517974d, y: 0.8740662487662668d), new NpgsqlTypes.NpgsqlPoint(x: 0.41185733267603364d, y: 0.5562046999661844d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7691553120829973d, y: 0.22138824235734345d), new NpgsqlTypes.NpgsqlPoint(x: 0.14691446435737854d, y: 0.4173552262509701d), new NpgsqlTypes.NpgsqlPoint(x: 0.26156206306240737d, y: 0.5532211119789721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8808147875283364d, y: 0.5475317418178917d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235269244212651d, y: 0.4924175059859488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232801421937186d, y: 0.9415824100691257d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9305579482523637d, y: 0.5820624731339229d), new NpgsqlTypes.NpgsqlPoint(x: 0.1719695904536266d, y: 0.5930174498659337d), new NpgsqlTypes.NpgsqlPoint(x: 0.21000243261443996d, y: 0.19473946470551173d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23673824759575157d, y: 0.8420680203952452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963662842441017d, y: 0.3648765066271593d), new NpgsqlTypes.NpgsqlPoint(x: 0.15558476200939697d, y: 0.24998926172460267d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.524501324566083d, y: 0.33618441966608925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895953266306805d, y: 0.3013500563553898d), new NpgsqlTypes.NpgsqlPoint(x: 0.42650359711768926d, y: 0.1200324756333343d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19924702031501118d, y: 0.7905532055935529d), new NpgsqlTypes.NpgsqlPoint(x: 0.43780167209322507d, y: 0.7792213508228378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7037090835930877d, y: 0.5140871801661596d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7160929039602103d, y: 0.17576065085559855d), new NpgsqlTypes.NpgsqlPoint(x: 0.885791766638425d, y: 0.6954312644772178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981027802252517d, y: 0.7157964213764907d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1313878199321531d, y: 0.3898164251046655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4237760917946142d, y: 0.5006674174698524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947574673103321d, y: 0.5891881242806452d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6079720040683518d, y: 0.09773823498059864d), new NpgsqlTypes.NpgsqlPoint(x: 0.09736833855135141d, y: 0.06454667921176704d), new NpgsqlTypes.NpgsqlPoint(x: 0.2901682997444466d, y: 0.6564736842366012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.475070581140813d, y: 0.609100315811943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4811991932500683d, y: 0.8449330948084058d), new NpgsqlTypes.NpgsqlPoint(x: 0.3744924918649122d, y: 0.48663804584878634d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5116841471914336d, y: 0.7111525774817186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3110073171457838d, y: 0.09964837924939951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384459386012934d, y: 0.07715247996472596d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17157967148685915d, y: 0.32017141347036804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566169491371913d, y: 0.953023338037444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424093633997134d, y: 0.4152287269082966d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04096248851486628d, y: 0.9892382019055003d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192342957697599d, y: 0.4856949202789801d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040082838923441d, y: 0.5868100279504328d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08554098386372622d, y: 0.6332211896368135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800660486431743d, y: 0.30755390020680695d), new NpgsqlTypes.NpgsqlPoint(x: 0.03556182711657463d, y: 0.07956666088719477d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7997875003762335d, y: 0.84023462788112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381913054061832d, y: 0.27002216896623144d), new NpgsqlTypes.NpgsqlPoint(x: 0.029226804662984884d, y: 0.49696285597541323d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9878200123198134d, y: 0.20361527539518443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497841932909239d, y: 0.16898319604304557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662380679698034d, y: 0.006817105851954497d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14487349499611168d, y: 0.546061901936799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896438863206925d, y: 0.3436352533934872d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685358629376527d, y: 0.24282944090719427d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09939378289078393d, y: 0.4588581882817523d), new NpgsqlTypes.NpgsqlPoint(x: 0.47079728570809154d, y: 0.3658097185189978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786347849638597d, y: 0.1897248100330996d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7524980365884869d, y: 0.36824108973170455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056490644425323d, y: 0.6451169325210132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9327363942750085d, y: 0.5330420249532309d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14871142417448846d, y: 0.3895110507856121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421812397788495d, y: 0.7444124705402603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602038857455384d, y: 0.6598240938564376d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4246397969171638d, y: 0.9600855003804686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6030678133651675d, y: 0.9675741364442343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863979539576683d, y: 0.2868401045486686d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5512904701621544d, y: 0.7781279742544547d), new NpgsqlTypes.NpgsqlPoint(x: 0.11668083071151425d, y: 0.9072435463414782d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057171437978444d, y: 0.5663312513597278d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5443105076071554d, y: 0.697972802869826d), new NpgsqlTypes.NpgsqlPoint(x: 0.47744165248527126d, y: 0.20669421413518152d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769425684803519d, y: 0.9677690312969751d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9803473798572137d, y: 0.17042922278941075d), new NpgsqlTypes.NpgsqlPoint(x: 0.19269570847805428d, y: 0.7897763348960585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5154663011251439d, y: 0.2375939276225726d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464884741868234d, y: 0.7329284102494618d), new NpgsqlTypes.NpgsqlPoint(x: 0.1479333601758297d, y: 0.3698116735677094d), new NpgsqlTypes.NpgsqlPoint(x: 0.4552658988376671d, y: 0.8549699388488393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158351887916428d, y: 0.4919338117724813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4490562647412504d, y: 0.903990350662206d), new NpgsqlTypes.NpgsqlPoint(x: 0.011216484286641237d, y: 0.2831433449139491d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9921845304340926d, y: 0.17267986295662563d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587653248004018d, y: 0.7909719957427795d), new NpgsqlTypes.NpgsqlPoint(x: 0.08204477894155615d, y: 0.8592801562949375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4049881430758425d, y: 0.7490097762497261d), new NpgsqlTypes.NpgsqlPoint(x: 0.2131881933937183d, y: 0.27556712185153875d), new NpgsqlTypes.NpgsqlPoint(x: 0.926341853430647d, y: 0.5487192845495715d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9307662094408387d, y: 0.4130510000091727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8111689428033183d, y: 0.7000003842718386d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790471707866241d, y: 0.24094764147757597d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759846787303273d, y: 0.006496115857432039d), new NpgsqlTypes.NpgsqlPoint(x: 0.44640303895439704d, y: 0.9002835204964227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533306824442722d, y: 0.8280315927504123d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7026983280539116d, y: 0.974929136649081d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793783998943258d, y: 0.7490894081802575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8509309954296104d, y: 0.6186087259310062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6150419507651376d, y: 0.6139580470336148d), new NpgsqlTypes.NpgsqlPoint(x: 0.36520331201076195d, y: 0.6786022133331927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832207651075275d, y: 0.20377704826725684d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.608087079474297d, y: 0.3446921985193403d), new NpgsqlTypes.NpgsqlPoint(x: 0.30863795896623647d, y: 0.5488238802652445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4755406875008942d, y: 0.26299088345876875d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7047774077943645d, y: 0.004605062422274098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103125055336487d, y: 0.7300027566077908d), new NpgsqlTypes.NpgsqlPoint(x: 0.20758632936111776d, y: 0.8748744568881527d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8308010611504338d, y: 0.08449614376849202d), new NpgsqlTypes.NpgsqlPoint(x: 0.4637203172933355d, y: 0.7339806027444701d), new NpgsqlTypes.NpgsqlPoint(x: 0.922726702857735d, y: 0.7126361616010788d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38047235606194096d, y: 0.9538476346287014d), new NpgsqlTypes.NpgsqlPoint(x: 0.21513283527722993d, y: 0.4367050871828123d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464326767775737d, y: 0.2291447875348499d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6653919184532571d, y: 0.7078234990477597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026298014952546d, y: 0.2998853548889222d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282766936458129d, y: 0.6388927403981975d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.988254292322411d, y: 0.2057723519980974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433796614627694d, y: 0.962691379089779d), new NpgsqlTypes.NpgsqlPoint(x: 0.16688414519006778d, y: 0.1396372574621738d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1422079413563262d, y: 0.31977128567446145d), new NpgsqlTypes.NpgsqlPoint(x: 0.044283810395883694d, y: 0.5727486243515945d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317880094973086d, y: 0.813224511282606d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9591293029251222d, y: 0.07624472725714726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5003412636943276d, y: 0.5011178829343483d), new NpgsqlTypes.NpgsqlPoint(x: 0.31605010162364855d, y: 0.5101984084689061d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7253650007773651d, y: 0.9857883208113907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233546951393409d, y: 0.20795509658730083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7291022630418947d, y: 0.6615920225586968d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5764808945838346d, y: 0.6337007063083488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6948988093009348d, y: 0.036649763084543485d), new NpgsqlTypes.NpgsqlPoint(x: 0.933777293621208d, y: 0.3077137829097696d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1621126199214058d, y: 0.6119925591491634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3782922463340005d, y: 0.29712522259020446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668721229040924d, y: 0.5667239356800176d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007931701464895413d, y: 0.28997949393787414d), new NpgsqlTypes.NpgsqlPoint(x: 0.3201923642217913d, y: 0.3907553000348477d), new NpgsqlTypes.NpgsqlPoint(x: 0.07003265704120853d, y: 0.7419570199328448d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8619071676856601d, y: 0.22257755850946892d), new NpgsqlTypes.NpgsqlPoint(x: 0.13017093990994644d, y: 0.2559716936126317d), new NpgsqlTypes.NpgsqlPoint(x: 0.31644254975089114d, y: 0.33350776800319115d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.947730975677285d, y: 0.5313280465352821d), new NpgsqlTypes.NpgsqlPoint(x: 0.6331070259138489d, y: 0.7738150065491911d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139463952756028d, y: 0.1271464410715808d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8451184746719043d, y: 0.4558884213343469d), new NpgsqlTypes.NpgsqlPoint(x: 0.6250626039458183d, y: 0.037901213161195546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093765379034406d, y: 0.35511411668564385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25176888291940236d, y: 0.5609711932749063d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162890584856042d, y: 0.1814669237127451d), new NpgsqlTypes.NpgsqlPoint(x: 0.11113895526337003d, y: 0.7469565188061331d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1868371788460208d, y: 0.5298107916376188d), new NpgsqlTypes.NpgsqlPoint(x: 0.09851279356563725d, y: 0.9143455320119046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6771421055345777d, y: 0.49641213926791083d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7576631681781385d, y: 0.6654038018106255d), new NpgsqlTypes.NpgsqlPoint(x: 0.3904676090978113d, y: 0.7396884720879553d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758185391763874d, y: 0.009982716170409578d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8375218402403384d, y: 0.08130242649571484d), new NpgsqlTypes.NpgsqlPoint(x: 0.0373840635306405d, y: 0.07435699251641104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3671427109036237d, y: 0.8282490168766516d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7947090569666018d, y: 0.3618121165117347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7046979521437073d, y: 0.7973462079713655d), new NpgsqlTypes.NpgsqlPoint(x: 0.4766462762851861d, y: 0.4943833197153298d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9825354396065867d, y: 0.19133044711218405d), new NpgsqlTypes.NpgsqlPoint(x: 0.4453196945670407d, y: 0.9714322802807263d), new NpgsqlTypes.NpgsqlPoint(x: 0.684582473940046d, y: 0.0779182499238864d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7835680955979524d, y: 0.4339837901477789d), new NpgsqlTypes.NpgsqlPoint(x: 0.09718707004822069d, y: 0.9186997806808317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141546532238311d, y: 0.10354032084082143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09149607618099398d, y: 0.3441422772285352d), new NpgsqlTypes.NpgsqlPoint(x: 0.06726071607576911d, y: 0.07152535852064179d), new NpgsqlTypes.NpgsqlPoint(x: 0.04062535191078975d, y: 0.32382437022820343d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6120854381824369d, y: 0.6800607691404361d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434691449194732d, y: 0.40221047765637685d), new NpgsqlTypes.NpgsqlPoint(x: 0.2776756057765055d, y: 0.39339590680081826d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6097794815495068d, y: 0.7977163153162072d), new NpgsqlTypes.NpgsqlPoint(x: 0.905280366519753d, y: 0.8023541182768569d), new NpgsqlTypes.NpgsqlPoint(x: 0.44331723710873094d, y: 0.5619579686390825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.831464276671941d, y: 0.2622525009033153d), new NpgsqlTypes.NpgsqlPoint(x: 0.1840499456413417d, y: 0.4718342805641089d), new NpgsqlTypes.NpgsqlPoint(x: 0.2004550125182728d, y: 0.8518429862508063d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6031074872764551d, y: 0.6599059324699831d), new NpgsqlTypes.NpgsqlPoint(x: 0.16918001557713525d, y: 0.2498136648081719d), new NpgsqlTypes.NpgsqlPoint(x: 0.24294142759508897d, y: 0.7217369708637291d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3985005384439232d, y: 0.8253120021293296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4443327251976381d, y: 0.5335458938900665d), new NpgsqlTypes.NpgsqlPoint(x: 0.17870652938563325d, y: 0.832815898518361d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3779542664753196d, y: 0.5736602350372674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429991625491469d, y: 0.6451301876016139d), new NpgsqlTypes.NpgsqlPoint(x: 0.4319520261032307d, y: 0.7917248719948738d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4104772244510877d, y: 0.3898418177903509d), new NpgsqlTypes.NpgsqlPoint(x: 0.18151541591732256d, y: 0.05516595587068529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840404913252273d, y: 0.9146514933247558d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26083668659601533d, y: 0.6330436694469341d), new NpgsqlTypes.NpgsqlPoint(x: 0.9167062212206675d, y: 0.7519209903159949d), new NpgsqlTypes.NpgsqlPoint(x: 0.127477030144739d, y: 0.7576133098673304d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3290240331471477d, y: 0.4284975806515017d), new NpgsqlTypes.NpgsqlPoint(x: 0.4277291325933963d, y: 0.28597972956614426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681372027013358d, y: 0.9024963407984721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5823451594139444d, y: 0.05187040063503823d), new NpgsqlTypes.NpgsqlPoint(x: 0.07626131363673261d, y: 0.8675096642449507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759467309665242d, y: 0.9074317117542252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7101943359097049d, y: 0.7076136291213538d), new NpgsqlTypes.NpgsqlPoint(x: 0.9703224437206968d, y: 0.8936182267591436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5510233726697473d, y: 0.3644695441328242d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00017330327288622716d, y: 0.38272801988695626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018260318450334d, y: 0.9275256222272505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2335500754715838d, y: 0.6205020457648828d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.641624221655149d, y: 0.3908773727158934d), new NpgsqlTypes.NpgsqlPoint(x: 0.37503424549280606d, y: 0.05994394046852147d), new NpgsqlTypes.NpgsqlPoint(x: 0.15181966109732425d, y: 0.14135834786053003d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7043371229972104d, y: 0.15616469359899354d), new NpgsqlTypes.NpgsqlPoint(x: 0.061077168507416846d, y: 0.9063059322236602d), new NpgsqlTypes.NpgsqlPoint(x: 0.22558377280803033d, y: 0.9885990683716331d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9276132401914857d, y: 0.3959655283137151d), new NpgsqlTypes.NpgsqlPoint(x: 0.0412709453554444d, y: 0.35377025618755975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382219344413194d, y: 0.6587681776988848d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14366645431477876d, y: 0.6273482063449123d), new NpgsqlTypes.NpgsqlPoint(x: 0.043656997130920416d, y: 0.5592028173312654d), new NpgsqlTypes.NpgsqlPoint(x: 0.21570162782929314d, y: 0.9751507925993664d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22699815110612065d, y: 0.8578505774165136d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975233554497346d, y: 0.834460213062698d), new NpgsqlTypes.NpgsqlPoint(x: 0.3389530372263836d, y: 0.5573687468180478d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7473248114065317d, y: 0.8769419677317029d), new NpgsqlTypes.NpgsqlPoint(x: 0.34493682787438584d, y: 0.24500911652412394d), new NpgsqlTypes.NpgsqlPoint(x: 0.2698732846770132d, y: 0.85924691467317d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8150037836870974d, y: 0.6016072682878411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5399213667502035d, y: 0.5317218441676547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294905998872645d, y: 0.9581159022844973d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.494239541885518d, y: 0.18392926015414934d), new NpgsqlTypes.NpgsqlPoint(x: 0.07441975939930412d, y: 0.9027247268690476d), new NpgsqlTypes.NpgsqlPoint(x: 0.16975460052776747d, y: 0.8572971655108911d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17743531760394116d, y: 0.6216679375308878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959472303893856d, y: 0.07975326811224326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351946928947651d, y: 0.1571617482991955d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07314744919837368d, y: 0.11048001432418975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7548418705298484d, y: 0.8781771148624469d), new NpgsqlTypes.NpgsqlPoint(x: 0.9702923452537572d, y: 0.4822901647583753d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6837545845065813d, y: 0.19858758900624007d), new NpgsqlTypes.NpgsqlPoint(x: 0.28089900900380205d, y: 0.46175057835743594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5131928605987425d, y: 0.11400371586761959d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6490712668896499d, y: 0.8727896909206313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384380624704687d, y: 0.14893507151099095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969075477647927d, y: 0.3608218570344741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7581846708050004d, y: 0.06628762408962652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006006111897264d, y: 0.8163995035122409d), new NpgsqlTypes.NpgsqlPoint(x: 0.877506399212086d, y: 0.2648460223134603d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8420072475062339d, y: 0.47498279066102556d), new NpgsqlTypes.NpgsqlPoint(x: 0.06313999386171865d, y: 0.5437265855002623d), new NpgsqlTypes.NpgsqlPoint(x: 0.924076743096641d, y: 0.7504561911445154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29800886957964123d, y: 0.6675494714005015d), new NpgsqlTypes.NpgsqlPoint(x: 0.858889827119737d, y: 0.27365521620191735d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947146112749285d, y: 0.612242639515694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8790763323510676d, y: 0.8794959732178707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9808682369646469d, y: 0.68795585832356d), new NpgsqlTypes.NpgsqlPoint(x: 0.62075173577752d, y: 0.04895330082306226d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07581750904417484d, y: 0.7090737591805063d), new NpgsqlTypes.NpgsqlPoint(x: 0.860401793542686d, y: 0.8837442446221828d), new NpgsqlTypes.NpgsqlPoint(x: 0.3737573054174923d, y: 0.7899948109538381d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759667247711989d, y: 0.43313252295147575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623197927980573d, y: 0.6650761378019979d), new NpgsqlTypes.NpgsqlPoint(x: 0.2075119140045376d, y: 0.32422862407838016d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.845916749180794d, y: 0.9869184303393046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186458520037277d, y: 0.10897124867303587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3709154579177889d, y: 0.9465127112204068d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9992056935485594d, y: 0.7440640293791715d), new NpgsqlTypes.NpgsqlPoint(x: 0.000963309383667954d, y: 0.30313678050629667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100892295997367d, y: 0.04038210944748366d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7591812446763234d, y: 0.7093561993703184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7079371280945232d, y: 0.46961525837759377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4987323366032861d, y: 0.11408116769410326d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6269853111848188d, y: 0.36515504201010607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7493969724195967d, y: 0.7839942437453988d), new NpgsqlTypes.NpgsqlPoint(x: 0.014567094731453456d, y: 0.45538855021168345d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989569436783439d, y: 0.8127774173268933d), new NpgsqlTypes.NpgsqlPoint(x: 0.2599072224792973d, y: 0.5888526662607493d), new NpgsqlTypes.NpgsqlPoint(x: 0.1627862821060727d, y: 0.2074910284817758d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49493780888961214d, y: 0.5858713082600744d), new NpgsqlTypes.NpgsqlPoint(x: 0.35624322205771386d, y: 0.2832321034430013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449268983611117d, y: 0.8249156918397612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8137203918467693d, y: 0.4626045192671603d), new NpgsqlTypes.NpgsqlPoint(x: 0.16375704746127762d, y: 0.3006736345891545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6795168357653334d, y: 0.5280304018660876d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4794723650751799d, y: 0.014322352618963308d), new NpgsqlTypes.NpgsqlPoint(x: 0.49500583282584254d, y: 0.7617550474805868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651994952491257d, y: 0.947150087397492d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7978209051945051d, y: 0.36970828875166994d), new NpgsqlTypes.NpgsqlPoint(x: 0.717849115440598d, y: 0.6025134132885344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4824140728731292d, y: 0.13832270521850787d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5812965738415118d, y: 0.7001808315803751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759086230507647d, y: 0.42117981625636136d), new NpgsqlTypes.NpgsqlPoint(x: 0.504651286894144d, y: 0.6450947982183247d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3131905846723795d, y: 0.45524716598453774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992671531160394d, y: 0.49999825385777574d), new NpgsqlTypes.NpgsqlPoint(x: 0.16890807852434242d, y: 0.24886771734280977d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9500071559718363d, y: 0.055241017158550676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2930853740668732d, y: 0.7752521406268104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596197174856498d, y: 0.5185251488618049d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8442929971078457d, y: 0.29051553790033857d), new NpgsqlTypes.NpgsqlPoint(x: 0.028699842123120933d, y: 0.1643720582183663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017451215672535d, y: 0.014032228219710285d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7664437462239369d, y: 0.3220221418004534d), new NpgsqlTypes.NpgsqlPoint(x: 0.4327831774380815d, y: 0.28482448321755627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9755915072927844d, y: 0.9832921759640698d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39685974587867856d, y: 0.48691300244962965d), new NpgsqlTypes.NpgsqlPoint(x: 0.3405141594316148d, y: 0.7325916331379899d), new NpgsqlTypes.NpgsqlPoint(x: 0.026801141094364267d, y: 0.17218541469178705d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013124114823981792d, y: 0.959603625703137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837422843552277d, y: 0.1789786108573438d), new NpgsqlTypes.NpgsqlPoint(x: 0.2314092099038878d, y: 0.6859368144838671d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01156224436392661d, y: 0.19305563208219367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7537190439557546d, y: 0.7884133682879896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133403033764863d, y: 0.7118232078541626d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06914283968899193d, y: 0.0825495433412381d), new NpgsqlTypes.NpgsqlPoint(x: 0.42824252844240507d, y: 0.886370246544912d), new NpgsqlTypes.NpgsqlPoint(x: 0.493552314924236d, y: 0.6587586636926104d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7599952963667159d, y: 0.13933268184437309d), new NpgsqlTypes.NpgsqlPoint(x: 0.7524528391379172d, y: 0.5569224225265176d), new NpgsqlTypes.NpgsqlPoint(x: 0.470700311191974d, y: 0.886462743983141d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2828807801833687d, y: 0.10646633529280536d), new NpgsqlTypes.NpgsqlPoint(x: 0.47712383086160104d, y: 0.4842914957335025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8569905322882372d, y: 0.2912503888244933d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9475606807189887d, y: 0.5053852092054112d), new NpgsqlTypes.NpgsqlPoint(x: 0.09718195500152282d, y: 0.5059433517850792d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660039243768381d, y: 0.39785933313086796d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8603103852472881d, y: 0.6446824242479133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8256651867675255d, y: 0.6365240243674626d), new NpgsqlTypes.NpgsqlPoint(x: 0.01612120223615421d, y: 0.1951977141684461d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7017102227046061d, y: 0.9264317012934793d), new NpgsqlTypes.NpgsqlPoint(x: 0.17721569950994343d, y: 0.1770577426840253d), new NpgsqlTypes.NpgsqlPoint(x: 0.715037743317436d, y: 0.8944956301298375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3694669521615267d, y: 0.4602647834860577d), new NpgsqlTypes.NpgsqlPoint(x: 0.28161854389848573d, y: 0.7282962385049946d), new NpgsqlTypes.NpgsqlPoint(x: 0.07230601062931219d, y: 0.016307844507489788d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7803027176397744d, y: 0.6300809281874368d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249582957635756d, y: 0.29798699421310315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264690261780516d, y: 0.287739033591321d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8967595609378904d, y: 0.6042107196652134d), new NpgsqlTypes.NpgsqlPoint(x: 0.1254644256272459d, y: 0.42073781859313375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533432500676901d, y: 0.3519411978506114d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2176959144426669d, y: 0.25753426790502754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191610182991521d, y: 0.4228295678956294d), new NpgsqlTypes.NpgsqlPoint(x: 0.4170924434876565d, y: 0.3435180703798747d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5351143853731841d, y: 0.02663825785646734d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842467169324778d, y: 0.7879302649793629d), new NpgsqlTypes.NpgsqlPoint(x: 0.38411443103879583d, y: 0.4207865901875266d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9863352943715423d, y: 0.2045861096759929d), new NpgsqlTypes.NpgsqlPoint(x: 0.176440389215493d, y: 0.8676632148460218d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894738660599651d, y: 0.9379244813541543d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6646428153335681d, y: 0.6249161061703611d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756237530451566d, y: 0.026858598593218264d), new NpgsqlTypes.NpgsqlPoint(x: 0.04701157790475863d, y: 0.6198917535494815d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5064933315521605d, y: 0.9039963573083135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062006684456124d, y: 0.43363582420482183d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384473345582676d, y: 0.6428353839186782d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8270176064582058d, y: 0.05105255201141268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9095795887103751d, y: 0.2818874747570732d), new NpgsqlTypes.NpgsqlPoint(x: 0.1373890825683255d, y: 0.42301507125563054d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.822281612916198d, y: 0.6086100679898243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760790194074537d, y: 0.24875351045419614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479116642859509d, y: 0.22423690070314095d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6123531704530967d, y: 0.7194831083234656d), new NpgsqlTypes.NpgsqlPoint(x: 0.13902013440018524d, y: 0.6540707065110921d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531234337242499d, y: 0.6437439426221757d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.848694337123952d, y: 0.694426312552155d), new NpgsqlTypes.NpgsqlPoint(x: 0.24034486324974014d, y: 0.3486706218415814d), new NpgsqlTypes.NpgsqlPoint(x: 0.904350735358426d, y: 0.3134323312268412d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9519392311212189d, y: 0.4402467658677095d), new NpgsqlTypes.NpgsqlPoint(x: 0.661657423209923d, y: 0.8471415999549898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7191986413446926d, y: 0.16152490217344773d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3872447175608902d, y: 0.24389299979486334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7695283922962886d, y: 0.7447916164468178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6830335808877285d, y: 0.13577262988176197d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0880087230711376d, y: 0.16338511800879574d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835716151869923d, y: 0.2320938636254195d), new NpgsqlTypes.NpgsqlPoint(x: 0.408695590121657d, y: 0.7447978950936032d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7637432808834563d, y: 0.5057759575966114d), new NpgsqlTypes.NpgsqlPoint(x: 0.1452101995381333d, y: 0.08983759690929904d), new NpgsqlTypes.NpgsqlPoint(x: 0.9069478372373746d, y: 0.393937954726412d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8419431348886696d, y: 0.4500280827680634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010832709871868d, y: 0.052928830193537446d), new NpgsqlTypes.NpgsqlPoint(x: 0.46469982118279085d, y: 0.802560679942862d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4277075224193272d, y: 0.8641490480106432d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210115483038962d, y: 0.8222875323024093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6674008859693297d, y: 0.9128277350631118d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07622383215302109d, y: 0.5692048863845658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662034821097176d, y: 0.42201438031831107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484274349286855d, y: 0.4728479893599882d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0965529298688802d, y: 0.047149812264800084d), new NpgsqlTypes.NpgsqlPoint(x: 0.7632383653253748d, y: 0.8132148380881572d), new NpgsqlTypes.NpgsqlPoint(x: 0.07214414750228326d, y: 0.6082642005471319d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.781560315491473d, y: 0.31540973083308443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5455512409751696d, y: 0.33730252920596704d), new NpgsqlTypes.NpgsqlPoint(x: 0.06091943381912257d, y: 0.38600990782504496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8084996102433146d, y: 0.3025031351216124d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529186749528791d, y: 0.6578441447544243d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942452320832917d, y: 0.3392351138444514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9265948094395485d, y: 0.15028778969716117d), new NpgsqlTypes.NpgsqlPoint(x: 0.37240578737014685d, y: 0.4898920525883165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807918876972937d, y: 0.7770603070594416d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44807898827614867d, y: 0.1965585207849313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159284861567948d, y: 0.939373765282671d), new NpgsqlTypes.NpgsqlPoint(x: 0.43070741639680876d, y: 0.3933174142428385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828469818380633d, y: 0.38190651863075953d), new NpgsqlTypes.NpgsqlPoint(x: 0.19056621844126043d, y: 0.3849311734911878d), new NpgsqlTypes.NpgsqlPoint(x: 0.37806905649289213d, y: 0.011587505435242673d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7368321604692788d, y: 0.4886047408763029d), new NpgsqlTypes.NpgsqlPoint(x: 0.778951849887683d, y: 0.1385498623173297d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533726236600638d, y: 0.9130869418938838d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20881972642894875d, y: 0.44138647131119224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745297955350936d, y: 0.7402648445739484d), new NpgsqlTypes.NpgsqlPoint(x: 0.38881383997819896d, y: 0.08207589723914888d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5737765972318819d, y: 0.3760186982644481d), new NpgsqlTypes.NpgsqlPoint(x: 0.055207677112693254d, y: 0.44680508332438096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2421143701578775d, y: 0.9583295290884237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7386336468167845d, y: 0.7988632039116654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312639227287212d, y: 0.8238367974457437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3358399855672153d, y: 0.0759200239812905d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7843087935284878d, y: 0.9734905081590695d), new NpgsqlTypes.NpgsqlPoint(x: 0.3343178907564037d, y: 0.43432817620963116d), new NpgsqlTypes.NpgsqlPoint(x: 0.20251971554649317d, y: 0.4251720654032948d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6924372753437401d, y: 0.16590525503535736d), new NpgsqlTypes.NpgsqlPoint(x: 0.6763770637091647d, y: 0.7921971821661832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073087228669208d, y: 0.7979865899637889d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5855808251716985d, y: 0.9896239116399826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730454149554875d, y: 0.38106826702198826d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902830195651595d, y: 0.5552349120964998d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.333878248108856d, y: 0.212687242437542d), new NpgsqlTypes.NpgsqlPoint(x: 0.11590121018470567d, y: 0.05119612356406433d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876704783048404d, y: 0.4554759024990839d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9994119611266947d, y: 0.05952212797839018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132225615539255d, y: 0.5378807057322579d), new NpgsqlTypes.NpgsqlPoint(x: 0.487087060142106d, y: 0.001104608499441273d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5402293829706545d, y: 0.2196554530787751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694106307123296d, y: 0.47749193105613663d), new NpgsqlTypes.NpgsqlPoint(x: 0.03209917552600117d, y: 0.5870509901099257d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5906069018037724d, y: 0.881602240814856d), new NpgsqlTypes.NpgsqlPoint(x: 0.017694006529599182d, y: 0.5944798765050523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9482677323608277d, y: 0.7567262886179161d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2859643034380154d, y: 0.630645607443391d), new NpgsqlTypes.NpgsqlPoint(x: 0.12098053248599538d, y: 0.49219384585833237d), new NpgsqlTypes.NpgsqlPoint(x: 0.318708745741238d, y: 0.8338418212147375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5929084514502458d, y: 0.22217241888728845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520622229629184d, y: 0.9453338346320934d), new NpgsqlTypes.NpgsqlPoint(x: 0.06451671060130448d, y: 0.38033470764898303d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7092790934923222d, y: 0.9692324319278856d), new NpgsqlTypes.NpgsqlPoint(x: 0.720819982584811d, y: 0.45203664575926716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523128741606252d, y: 0.3299639251744011d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8687934007077889d, y: 0.36077548181245434d), new NpgsqlTypes.NpgsqlPoint(x: 0.014245205511745018d, y: 0.6472963494870876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8978773961292679d, y: 0.4148201487277874d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006842832196022441d, y: 0.5573723912103968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390769862852324d, y: 0.7349388476953559d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007729206899381d, y: 0.10485306322741095d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9907825198113122d, y: 0.6101616221760129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401639911950852d, y: 0.5544383736267284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6894102616567973d, y: 0.9836213888595545d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03188052377215633d, y: 0.3191110981053935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368916501868827d, y: 0.19663144008750866d), new NpgsqlTypes.NpgsqlPoint(x: 0.28661777767120455d, y: 0.2860653845830038d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05524603854695875d, y: 0.7845565090621581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800243783566567d, y: 0.05273584058622194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882620877081539d, y: 0.20594494307048472d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8100707051547131d, y: 0.24143272253217762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863457113920061d, y: 0.7100465475685275d), new NpgsqlTypes.NpgsqlPoint(x: 0.507802735885341d, y: 0.6304045938341413d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6634601651010893d, y: 0.742946277726375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9871212042836686d, y: 0.5319797312433577d), new NpgsqlTypes.NpgsqlPoint(x: 0.23481784263142458d, y: 0.5614633475579438d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9446492533668819d, y: 0.7761560075198698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324198833970405d, y: 0.002523220026924511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056370043929044d, y: 0.8450376906970071d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108154161989909d, y: 0.1772783446634102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908199728098747d, y: 0.188677940403421d), new NpgsqlTypes.NpgsqlPoint(x: 0.3351023861801853d, y: 0.39754946465703744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18055052413091754d, y: 0.2618414656665503d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463500986366943d, y: 0.8563806957602006d), new NpgsqlTypes.NpgsqlPoint(x: 0.3524332617054574d, y: 0.7250638212535645d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5420413709523391d, y: 0.6144035513886204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3944380033438667d, y: 0.06581153465564349d), new NpgsqlTypes.NpgsqlPoint(x: 0.4976078141670741d, y: 0.7167679206150898d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969177429500183d, y: 0.28383892290909196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953024466868466d, y: 0.5776582594617916d), new NpgsqlTypes.NpgsqlPoint(x: 0.4335488557650333d, y: 0.8680847929296035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.605204257876893d, y: 0.49227794992904184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000171675255088d, y: 0.9006900067387377d), new NpgsqlTypes.NpgsqlPoint(x: 0.12309140636254479d, y: 0.264506767901979d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24927789750758844d, y: 0.6453836308773875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046928900898067d, y: 0.2647111206348153d), new NpgsqlTypes.NpgsqlPoint(x: 0.08344832138429614d, y: 0.9441334290562915d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8055999165877165d, y: 0.4073966916117112d), new NpgsqlTypes.NpgsqlPoint(x: 0.29998969248701357d, y: 0.09318334272746198d), new NpgsqlTypes.NpgsqlPoint(x: 0.20064377315472026d, y: 0.005972302538041596d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8129770171125584d, y: 0.4929191799662507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7182695101136539d, y: 0.7636594014222504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7377503515307646d, y: 0.2752707389599828d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8314599228840069d, y: 0.9332139949395486d), new NpgsqlTypes.NpgsqlPoint(x: 0.5599795098385913d, y: 0.7484793040862734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5938048812366107d, y: 0.7509594570198302d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6531523372296828d, y: 0.6561539725204437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134041087487351d, y: 0.5657696441252681d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003435683811451d, y: 0.5527398709643586d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6190928158315415d, y: 0.004643839730908539d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273796952635472d, y: 0.1286452581027714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483923883128442d, y: 0.33202543790630457d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9661391094052685d, y: 0.31980688825667547d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815687431002669d, y: 0.9217405807076293d), new NpgsqlTypes.NpgsqlPoint(x: 0.7380657863208542d, y: 0.8982545864857888d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7614618048969589d, y: 0.8345789814882917d), new NpgsqlTypes.NpgsqlPoint(x: 0.15632932984994774d, y: 0.9805178453440523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6768422830469625d, y: 0.0883469699136229d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036489496886154216d, y: 0.6516051193463754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750096233422166d, y: 0.9338007754637301d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679913279173825d, y: 0.9718198495160104d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.137679058457419d, y: 0.15219918905413077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331429141095004d, y: 0.3754802460890174d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956857897612486d, y: 0.17643099926915762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1121646051994567d, y: 0.5354708208282022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9080127836995935d, y: 0.19644828602116493d), new NpgsqlTypes.NpgsqlPoint(x: 0.0038725008727523713d, y: 0.8760512254986668d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7743840055804915d, y: 0.8775989926070974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8954565194223546d, y: 0.34006822588209684d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455181762657621d, y: 0.1577521890860889d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7766406461112706d, y: 0.7795985938883195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654135651573711d, y: 0.9886767200121467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8105163396834356d, y: 0.0992477279804399d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369437860548303d, y: 0.9642634637092791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135552515643824d, y: 0.7348398450941911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6217052405723671d, y: 0.5485024896944483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8199834326778966d, y: 0.8513117333237867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647538985150099d, y: 0.06912748386112233d), new NpgsqlTypes.NpgsqlPoint(x: 0.694881020251051d, y: 0.3907839699024479d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9771497655519998d, y: 0.892700985532737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691399697875086d, y: 0.14166889923640325d), new NpgsqlTypes.NpgsqlPoint(x: 0.17606757839162956d, y: 0.5267689270973887d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD1E2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9419761056991401d, y: 0.7925693927450539d), new NpgsqlTypes.NpgsqlPoint(x: 0.3786081031073848d, y: 0.7042939461549921d), new NpgsqlTypes.NpgsqlPoint(x: 0.8650051321235689d, y: 0.781488581210748d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7212349117454215d, y: 0.6848765671356487d), new NpgsqlTypes.NpgsqlPoint(x: 0.07548005694002491d, y: 0.5745333519617909d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663801745951768d, y: 0.35343071878686216d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5618533191719391d, y: 0.09125850690075543d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599271226938031d, y: 0.2979501566440894d), new NpgsqlTypes.NpgsqlPoint(x: 0.48732476763852706d, y: 0.3251676669492559d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9412731815004797d, y: 0.9990648849422941d), new NpgsqlTypes.NpgsqlPoint(x: 0.04489624761663147d, y: 0.5346392516518376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066319021511394d, y: 0.16894535891402251d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 188,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39142557749645523d, y: 0.568133112622615d), new NpgsqlTypes.NpgsqlPoint(x: 0.14946706395045295d, y: 0.019957825589857148d), new NpgsqlTypes.NpgsqlPoint(x: 0.2867502928652551d, y: 0.7969613418021133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25676174541483643d, y: 0.3813474812037274d), new NpgsqlTypes.NpgsqlPoint(x: 0.31611466929199017d, y: 0.4557002291966885d), new NpgsqlTypes.NpgsqlPoint(x: 0.35195954065234336d, y: 0.7599412266637738d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7489383151557573d, y: 0.4569797409799544d), new NpgsqlTypes.NpgsqlPoint(x: 0.28018234195831326d, y: 0.23949883044518128d), new NpgsqlTypes.NpgsqlPoint(x: 0.46012522696934066d, y: 0.46164885978496917d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
INSERT INTO public.npgsqlpolygonpolygonlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)), 
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
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd1e2mi_id
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
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                methodParametrName: "npgsqlpolygonpolygonlistd1e2mi_id", 
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
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 178;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 44, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 16, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 146, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 178, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 53, query1, 170, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 128, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 31, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatch(connection, 61, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MI),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2M),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonlistd1e2mi mi ON mi.id = m.npgsqlpolygonpolygonlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
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
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI), typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MI>();
                ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA), typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD1E2MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

