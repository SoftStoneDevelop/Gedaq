

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5848076618461088d, y: 0.45369859398220913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6947423976117423d, y: 0.20695134031780593d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367059248127206d, y: 0.5473422452423429d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9112352581117897d, y: 0.867361266160983d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349692558724973d, y: 0.09973885044041864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738230047337193d, y: 0.7729055392668077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015847074169829778d, y: 0.2829353332332134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686240930399954d, y: 0.7439414484020133d), new NpgsqlTypes.NpgsqlPoint(x: 0.16379362559131894d, y: 0.6584173254923403d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3848844259712202d, y: 0.4695296104853476d), new NpgsqlTypes.NpgsqlPoint(x: 0.886671556504456d, y: 0.9701111398900101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029713303185323d, y: 0.417805777955062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5538330954684026d, y: 0.46715616974945984d), new NpgsqlTypes.NpgsqlPoint(x: 0.722889757124479d, y: 0.7203015162838919d), new NpgsqlTypes.NpgsqlPoint(x: 0.052345693632699586d, y: 0.2074248285664373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39714436329645586d, y: 0.5678114952445897d), new NpgsqlTypes.NpgsqlPoint(x: 0.3978363232794404d, y: 0.04639089065697943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3773539531830422d, y: 0.26036205369081367d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4376624636415728d, y: 0.48787160342698366d), new NpgsqlTypes.NpgsqlPoint(x: 0.7236433865777309d, y: 0.314020975118224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263354912037004d, y: 0.5874727369530227d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16658240527588786d, y: 0.5894115308990906d), new NpgsqlTypes.NpgsqlPoint(x: 0.845881396424811d, y: 0.2007702977866369d), new NpgsqlTypes.NpgsqlPoint(x: 0.12825933869149508d, y: 0.6534325371353191d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2670012617384089d, y: 0.15109338480335321d), new NpgsqlTypes.NpgsqlPoint(x: 0.569399851730936d, y: 0.07128257732949317d), new NpgsqlTypes.NpgsqlPoint(x: 0.36976800571105095d, y: 0.8174694715353725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16476941225067132d, y: 0.02388740264763556d), new NpgsqlTypes.NpgsqlPoint(x: 0.16939907328664183d, y: 0.6808116649078974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623546729263786d, y: 0.7483170990743938d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1690354275725775d, y: 0.4010630510830142d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575972895947578d, y: 0.00361753512756513d), new NpgsqlTypes.NpgsqlPoint(x: 0.22123169110771235d, y: 0.18940355638730721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38589133987920166d, y: 0.9456244924400966d), new NpgsqlTypes.NpgsqlPoint(x: 0.918576152241556d, y: 0.9616424680064106d), new NpgsqlTypes.NpgsqlPoint(x: 0.362045656450639d, y: 0.7070064348140636d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7962963969074166d, y: 0.3688176128185028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293216642407015d, y: 0.014613094319056996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902534321861898d, y: 0.7324617170925438d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22126404592355464d, y: 0.23627827914205313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9665510738223455d, y: 0.9715138308690484d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014827221514055d, y: 0.957523470271173d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7538405532616423d, y: 0.4424639950499175d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475234567488671d, y: 0.8325469807512118d), new NpgsqlTypes.NpgsqlPoint(x: 0.47864046587747155d, y: 0.4162981454080181d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29790076704974633d, y: 0.1649374923371152d), new NpgsqlTypes.NpgsqlPoint(x: 0.11113460746407011d, y: 0.39674660191162037d), new NpgsqlTypes.NpgsqlPoint(x: 0.600269637975754d, y: 0.0803661582523334d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2677549918291421d, y: 0.9219894374971529d), new NpgsqlTypes.NpgsqlPoint(x: 0.22709367692798066d, y: 0.8477416833012069d), new NpgsqlTypes.NpgsqlPoint(x: 0.042290526914397275d, y: 0.4681612422611191d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20213203977999972d, y: 0.8023400835263148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701469357409002d, y: 0.8230918612676931d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598159449296713d, y: 0.8714002524226885d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17525071300546768d, y: 0.012520967546215012d), new NpgsqlTypes.NpgsqlPoint(x: 0.45271950869832933d, y: 0.9216489737752732d), new NpgsqlTypes.NpgsqlPoint(x: 0.383800572549455d, y: 0.3274180753267576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02469284407819139d, y: 0.4759504740226652d), new NpgsqlTypes.NpgsqlPoint(x: 0.6247997274264979d, y: 0.33911958558446076d), new NpgsqlTypes.NpgsqlPoint(x: 0.03593974881311157d, y: 0.008314657038167694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8849682027941927d, y: 0.9449874089128019d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714106407597771d, y: 0.351023921099458d), new NpgsqlTypes.NpgsqlPoint(x: 0.41394897457553936d, y: 0.9579680681166625d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.709133617661403d, y: 0.7603741649489689d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062899880068538d, y: 0.39153240525435284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8657839019715138d, y: 0.8579172718531693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16407671665471446d, y: 0.014818651727375176d), new NpgsqlTypes.NpgsqlPoint(x: 0.47863584651251345d, y: 0.1331924286379944d), new NpgsqlTypes.NpgsqlPoint(x: 0.18955390050166476d, y: 0.1700952326697167d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5867610929634016d, y: 0.3432994797441028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418499619683064d, y: 0.19683346245939615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196173114884551d, y: 0.7640873682945644d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2903369032825798d, y: 0.7948532967733865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796778349009585d, y: 0.22298084411235652d), new NpgsqlTypes.NpgsqlPoint(x: 0.37269289511365133d, y: 0.45949205911561186d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5166787570276096d, y: 0.7555787824812915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684613281486212d, y: 0.7454176580416247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8284493071830988d, y: 0.7797275731809779d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6888444721064643d, y: 0.6928840475069619d), new NpgsqlTypes.NpgsqlPoint(x: 0.27195554731708904d, y: 0.69585878902265d), new NpgsqlTypes.NpgsqlPoint(x: 0.1643288609049025d, y: 0.5133099664624096d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8528922562389141d, y: 0.3823842796382422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332510578776864d, y: 0.8894149712321885d), new NpgsqlTypes.NpgsqlPoint(x: 0.782746560725837d, y: 0.4359052445417614d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3149892456976586d, y: 0.5879700995669228d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848526689948334d, y: 0.05672287715992297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5645856244970879d, y: 0.6573720847717129d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9521147978231961d, y: 0.8967910879382296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314931912858191d, y: 0.5084507697892835d), new NpgsqlTypes.NpgsqlPoint(x: 0.913724275887458d, y: 0.016615681303844942d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618037280509733d, y: 0.21366949374857047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624320589407521d, y: 0.47586988814968534d), new NpgsqlTypes.NpgsqlPoint(x: 0.703181814264813d, y: 0.8595782302778737d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31301051976052774d, y: 0.7789227592600394d), new NpgsqlTypes.NpgsqlPoint(x: 0.27402859928866785d, y: 0.1967056351206251d), new NpgsqlTypes.NpgsqlPoint(x: 0.2718395776649455d, y: 0.03967371219265203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9700854691522055d, y: 0.10588114181140917d), new NpgsqlTypes.NpgsqlPoint(x: 0.21775919010570877d, y: 0.1686922637341416d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371836704447196d, y: 0.7589290131342771d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14767247256681815d, y: 0.3747806448511518d), new NpgsqlTypes.NpgsqlPoint(x: 0.26579710442896753d, y: 0.5686111027706707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749645543539092d, y: 0.4061193573566646d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49333172937098446d, y: 0.2039400334763518d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832429200569901d, y: 0.9501722337528312d), new NpgsqlTypes.NpgsqlPoint(x: 0.23801330200485538d, y: 0.8621620931133136d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8652163686950526d, y: 0.6048809955314102d), new NpgsqlTypes.NpgsqlPoint(x: 0.025487472810099332d, y: 0.31023499989064995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612883011159228d, y: 0.6601205124745333d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23995277640791013d, y: 0.03371258990722259d), new NpgsqlTypes.NpgsqlPoint(x: 0.4697536118675949d, y: 0.5747000144826416d), new NpgsqlTypes.NpgsqlPoint(x: 0.5559625371530211d, y: 0.9982319851172966d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.840478927468775d, y: 0.6500126553781402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7065373907378686d, y: 0.6696847133813416d), new NpgsqlTypes.NpgsqlPoint(x: 0.7474093013060498d, y: 0.5213642602416825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49983446746628046d, y: 0.006023273792961303d), new NpgsqlTypes.NpgsqlPoint(x: 0.272607294270627d, y: 0.7786837823059285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231424218757737d, y: 0.04285399972119974d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4805484544080988d, y: 0.4404900719813515d), new NpgsqlTypes.NpgsqlPoint(x: 0.873266445580156d, y: 0.1779016433978743d), new NpgsqlTypes.NpgsqlPoint(x: 0.5320597854658695d, y: 0.7676230491545725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.935681293782176d, y: 0.15606176479513234d), new NpgsqlTypes.NpgsqlPoint(x: 0.637321945228673d, y: 0.8953457222202396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807714492485523d, y: 0.7178397233558482d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5713998829981027d, y: 0.39876575531609804d), new NpgsqlTypes.NpgsqlPoint(x: 0.33381512862358687d, y: 0.4109808527333286d), new NpgsqlTypes.NpgsqlPoint(x: 0.4193250509361439d, y: 0.616589290796358d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3229873437068249d, y: 0.8443646353338751d), new NpgsqlTypes.NpgsqlPoint(x: 0.24237557031823675d, y: 0.9123108889512672d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370625681365597d, y: 0.0038613682174085673d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42306087692955185d, y: 0.6065325006789857d), new NpgsqlTypes.NpgsqlPoint(x: 0.779455255564025d, y: 0.40093175000390646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8303661229783735d, y: 0.2731593153932361d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4829261320931032d, y: 0.5638073407495117d), new NpgsqlTypes.NpgsqlPoint(x: 0.28544301829064533d, y: 0.813515084382601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9851272223927555d, y: 0.9325427617559978d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2559551020990476d, y: 0.794593489768963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295551489672979d, y: 0.6832641137686599d), new NpgsqlTypes.NpgsqlPoint(x: 0.01867915094622552d, y: 0.3718840801146498d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2252428462761874d, y: 0.9216035962246896d), new NpgsqlTypes.NpgsqlPoint(x: 0.20835958608407779d, y: 0.31626235026276095d), new NpgsqlTypes.NpgsqlPoint(x: 0.27954978995801427d, y: 0.19793170876175092d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8513149480130218d, y: 0.1095340079353424d), new NpgsqlTypes.NpgsqlPoint(x: 0.17485877060981903d, y: 0.012640213201466688d), new NpgsqlTypes.NpgsqlPoint(x: 0.17637759813991005d, y: 0.9479925465816027d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9527410989771661d, y: 0.16848119477980006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637446204844555d, y: 0.4787135170618617d), new NpgsqlTypes.NpgsqlPoint(x: 0.9530639195730737d, y: 0.35399221571665207d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7940431151235917d, y: 0.6003501671788037d), new NpgsqlTypes.NpgsqlPoint(x: 0.0004984484662483579d, y: 0.8382294225196787d), new NpgsqlTypes.NpgsqlPoint(x: 0.042369309936910016d, y: 0.9103022475503613d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23852869518720865d, y: 0.22867008120418175d), new NpgsqlTypes.NpgsqlPoint(x: 0.06619471930086185d, y: 0.13332550734994741d), new NpgsqlTypes.NpgsqlPoint(x: 0.8537020044697242d, y: 0.5759486016990603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7985868176282204d, y: 0.5550088303850421d), new NpgsqlTypes.NpgsqlPoint(x: 0.22266333084109646d, y: 0.6751675147636031d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745037269192569d, y: 0.5529078772415997d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2376311384896338d, y: 0.08794333653153219d), new NpgsqlTypes.NpgsqlPoint(x: 0.21068313452857756d, y: 0.6949532928715795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6410786590040456d, y: 0.11110921629129977d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5624307411361462d, y: 0.7707551410936949d), new NpgsqlTypes.NpgsqlPoint(x: 0.40474086620806116d, y: 0.40515846120819954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2178658369247336d, y: 0.9053382150402532d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2220990842838918d, y: 0.09356272546148447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6898622607795514d, y: 0.08668032594546715d), new NpgsqlTypes.NpgsqlPoint(x: 0.1565763390554017d, y: 0.0897519516056644d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35334795396475693d, y: 0.785232518838219d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373572865793697d, y: 0.8576024898715833d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833662636958221d, y: 0.24831608817929784d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2151339774878832d, y: 0.44799282322943723d), new NpgsqlTypes.NpgsqlPoint(x: 0.758523485789102d, y: 0.4084333067163094d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574140458696937d, y: 0.770912289953581d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6636302697063992d, y: 0.40853564605553183d), new NpgsqlTypes.NpgsqlPoint(x: 0.00792954400990109d, y: 0.11735798318803592d), new NpgsqlTypes.NpgsqlPoint(x: 0.28926703922913755d, y: 0.6681832779688441d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7180732593610369d, y: 0.6294198496649908d), new NpgsqlTypes.NpgsqlPoint(x: 0.47128432423814925d, y: 0.42709089844741766d), new NpgsqlTypes.NpgsqlPoint(x: 0.017044589994801296d, y: 0.3093575617138373d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7720028163284869d, y: 0.26462871238673036d), new NpgsqlTypes.NpgsqlPoint(x: 0.798186648770107d, y: 0.5905491017511839d), new NpgsqlTypes.NpgsqlPoint(x: 0.7796050496012964d, y: 0.632335007071645d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2575892709184826d, y: 0.00021858321127321556d), new NpgsqlTypes.NpgsqlPoint(x: 0.18647913815173178d, y: 0.20426293934111273d), new NpgsqlTypes.NpgsqlPoint(x: 0.2843926895446661d, y: 0.10522536558991702d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32553264549653627d, y: 0.07191049450500409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815887449914119d, y: 0.7081194359843777d), new NpgsqlTypes.NpgsqlPoint(x: 0.2324460605067633d, y: 0.44387730633071687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5410926141360966d, y: 0.10217842050166759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224105756171683d, y: 0.7891849553268465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179269950693298d, y: 0.784914866440801d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1677435445552593d, y: 0.8545046071697423d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526942995815133d, y: 0.28256963361409326d), new NpgsqlTypes.NpgsqlPoint(x: 0.4743937714162403d, y: 0.825035061130319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056947993311974865d, y: 0.6778569653588217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4147803966383713d, y: 0.4951701489766819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094038972265851d, y: 0.20412614296011167d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8568766014450095d, y: 0.856117110686864d), new NpgsqlTypes.NpgsqlPoint(x: 0.003332837610109496d, y: 0.5090770087472832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679334894204854d, y: 0.6326448892522694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8336153106286593d, y: 0.08268821394981118d), new NpgsqlTypes.NpgsqlPoint(x: 0.567872185310944d, y: 0.06991036093695446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095013411932695d, y: 0.8715567427925835d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.831832883602744d, y: 0.06746409536413889d), new NpgsqlTypes.NpgsqlPoint(x: 0.04217755484179586d, y: 0.09286687142277006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475377400890752d, y: 0.6858232985040527d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8016654914074154d, y: 0.7468731920745988d), new NpgsqlTypes.NpgsqlPoint(x: 0.7967980197908759d, y: 0.3359475782639425d), new NpgsqlTypes.NpgsqlPoint(x: 0.803970296791032d, y: 0.780512173149789d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969356000419865d, y: 0.7912982491551999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6215819414074751d, y: 0.40435822031888013d), new NpgsqlTypes.NpgsqlPoint(x: 0.284184513809834d, y: 0.13251412713430166d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7311853138550537d, y: 0.16989566663751532d), new NpgsqlTypes.NpgsqlPoint(x: 0.619046164090327d, y: 0.5691053807283755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466053892961869d, y: 0.4498269867139253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7577365108592808d, y: 0.318376926840099d), new NpgsqlTypes.NpgsqlPoint(x: 0.2185243115861254d, y: 0.6254246485762545d), new NpgsqlTypes.NpgsqlPoint(x: 0.10232154997242682d, y: 0.751509776807304d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23191962886822104d, y: 0.7572288419333851d), new NpgsqlTypes.NpgsqlPoint(x: 0.3447731304562558d, y: 0.21637180358286523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971764247643728d, y: 0.9912540753255751d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9974884828174216d, y: 0.46565279644442303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4318278362800756d, y: 0.64809265692574d), new NpgsqlTypes.NpgsqlPoint(x: 0.3932462440591148d, y: 0.7878644365278471d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9279239178643909d, y: 0.5688335104416733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450185733910276d, y: 0.30014010825549786d), new NpgsqlTypes.NpgsqlPoint(x: 0.43752137553105086d, y: 0.0857676890890543d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5427762469683983d, y: 0.785904170785244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386656180602698d, y: 0.25708718970968747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495972119461481d, y: 0.30553737548342386d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06987298686821009d, y: 0.6339423234643622d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980879078315881d, y: 0.5056485204375445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6740833358828386d, y: 0.4713888372989563d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25723855074511504d, y: 0.335942936947633d), new NpgsqlTypes.NpgsqlPoint(x: 0.676407052077998d, y: 0.5470511553839967d), new NpgsqlTypes.NpgsqlPoint(x: 0.06182627571942889d, y: 0.2891773200383476d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2937173004453816d, y: 0.6000157775564258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211985362656895d, y: 0.15096911900112198d), new NpgsqlTypes.NpgsqlPoint(x: 0.855170277457594d, y: 0.216597750568564d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9088696117709146d, y: 0.18978800875593715d), new NpgsqlTypes.NpgsqlPoint(x: 0.10627085169341866d, y: 0.24561736829013825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7503227942809715d, y: 0.38363026973240455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38020232923032593d, y: 0.536133152161558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9114707807391519d, y: 0.26608890554691444d), new NpgsqlTypes.NpgsqlPoint(x: 0.2603252634551624d, y: 0.4143929455647013d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9883421845640805d, y: 0.7226965785479241d), new NpgsqlTypes.NpgsqlPoint(x: 0.3545261561211973d, y: 0.7188355035011723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807835366775228d, y: 0.33048540850144237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17874817646325258d, y: 0.006859020799602322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4007057774945535d, y: 0.32678009161206834d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892003470913084d, y: 0.7593398245755912d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10498276210414492d, y: 0.8203731498752103d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526754758399719d, y: 0.14965107998043192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608163191473653d, y: 0.6005391829127985d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011380836928121751d, y: 0.684992031592034d), new NpgsqlTypes.NpgsqlPoint(x: 0.18438470734446843d, y: 0.5335042046940933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889392987323612d, y: 0.7124557478619465d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.824727902981137d, y: 0.4878553441515623d), new NpgsqlTypes.NpgsqlPoint(x: 0.49720946561219737d, y: 0.1872959261840027d), new NpgsqlTypes.NpgsqlPoint(x: 0.3878614265756527d, y: 0.5027239454154226d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22347831994759337d, y: 0.8432394933842915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314139542601486d, y: 0.7111939417681185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459568481713173d, y: 0.9163861658225531d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7319396796873633d, y: 0.5912014091954403d), new NpgsqlTypes.NpgsqlPoint(x: 0.3576187384345072d, y: 0.9805865444426084d), new NpgsqlTypes.NpgsqlPoint(x: 0.40487437460736597d, y: 0.9239896778804306d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24167841614658958d, y: 0.6318869302724817d), new NpgsqlTypes.NpgsqlPoint(x: 0.0065194189720818585d, y: 0.806185931681005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548150090874665d, y: 0.28161373119544286d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7979175447312814d, y: 0.5659281629671714d), new NpgsqlTypes.NpgsqlPoint(x: 0.8576499418541278d, y: 0.29352942289491957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475432462583282d, y: 0.9178248825650145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4922017896958276d, y: 0.13876584069176578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003436445799217d, y: 0.1181709290377142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487633300577519d, y: 0.6540474254515929d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9946447386363391d, y: 0.7376972635496631d), new NpgsqlTypes.NpgsqlPoint(x: 0.7264033439844126d, y: 0.20899171548989803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7224775762671468d, y: 0.026560457331824217d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29024007830556253d, y: 0.9012637003627798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937054479539807d, y: 0.8104777398608141d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494790179697112d, y: 0.8776672764613268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4806516705280862d, y: 0.8631961107047708d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654859187454234d, y: 0.749583241479286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301889608224476d, y: 0.2029652259534529d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8590817020555638d, y: 0.806681854540972d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813218556358126d, y: 0.994428143944513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618310407914906d, y: 0.5855303807420676d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06319691059189947d, y: 0.31684247449707104d), new NpgsqlTypes.NpgsqlPoint(x: 0.42362396200819896d, y: 0.04323667828368272d), new NpgsqlTypes.NpgsqlPoint(x: 0.37368398196644936d, y: 0.25744295945489903d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42824892748433596d, y: 0.21734242784527058d), new NpgsqlTypes.NpgsqlPoint(x: 0.021025244407135935d, y: 0.9945382751467241d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021622910110612d, y: 0.2893016707052025d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5686082223275418d, y: 0.4170446620295456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230350473646054d, y: 0.4915668454917922d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932940346902714d, y: 0.3181402108242366d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9265226970607373d, y: 0.5231948733827853d), new NpgsqlTypes.NpgsqlPoint(x: 0.19593112266114288d, y: 0.12479643241606087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5508167284728676d, y: 0.8687846630798275d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43965906894277385d, y: 0.7244118736800177d), new NpgsqlTypes.NpgsqlPoint(x: 0.01959329580465785d, y: 0.5674804416686112d), new NpgsqlTypes.NpgsqlPoint(x: 0.524466987747887d, y: 0.4696235854431009d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8441823550341089d, y: 0.19351706991114714d), new NpgsqlTypes.NpgsqlPoint(x: 0.751782165932752d, y: 0.27825665337040617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8676055320199412d, y: 0.5274096722621747d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6394171405757062d, y: 0.017700420606806322d), new NpgsqlTypes.NpgsqlPoint(x: 0.22334821478554423d, y: 0.1350757224425796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988907862427742d, y: 0.33741317232141954d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28227482362978373d, y: 0.2760301720546815d), new NpgsqlTypes.NpgsqlPoint(x: 0.44033638419963006d, y: 0.9848162894212695d), new NpgsqlTypes.NpgsqlPoint(x: 0.17300496807131305d, y: 0.36611048147899405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5838960145525525d, y: 0.9560321440956285d), new NpgsqlTypes.NpgsqlPoint(x: 0.35673594973054357d, y: 0.5255632482652839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017867245839003d, y: 0.48514525588566915d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3250975904818527d, y: 0.3751304339643965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1274702179497672d, y: 0.1071739235425605d), new NpgsqlTypes.NpgsqlPoint(x: 0.673089289027183d, y: 0.5542820573299359d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008711761509056504d, y: 0.5673127892525524d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537733724734384d, y: 0.5179475043993776d), new NpgsqlTypes.NpgsqlPoint(x: 0.37907792133429097d, y: 0.11953722843505221d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06978124772993055d, y: 0.9650342730643813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9834459660213057d, y: 0.9723762617794701d), new NpgsqlTypes.NpgsqlPoint(x: 0.06070247942840057d, y: 0.12638998652793776d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15412782601173114d, y: 0.6085567802260896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302236284808022d, y: 0.9304318995095281d), new NpgsqlTypes.NpgsqlPoint(x: 0.11195866213488681d, y: 0.2283438924119644d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8646386450346191d, y: 0.6795433885058172d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379307412930515d, y: 0.39138375930653935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4628935230358089d, y: 0.4924670065811305d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6196439372367765d, y: 0.45734969490851574d), new NpgsqlTypes.NpgsqlPoint(x: 0.7941970407401866d, y: 0.09584316233610435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9160186333840951d, y: 0.37819108160522574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22117304345023514d, y: 0.10043724443512114d), new NpgsqlTypes.NpgsqlPoint(x: 0.10463625651393915d, y: 0.26040499456279276d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759284304933771d, y: 0.7528986750879492d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14490046216636498d, y: 0.38036173728805023d), new NpgsqlTypes.NpgsqlPoint(x: 0.447400354993869d, y: 0.5461176213989286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213974509977322d, y: 0.6429428158404578d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19382697621016964d, y: 0.6878289487678747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793201620461123d, y: 0.9348627182872401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5865186554235591d, y: 0.1883978226494335d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8149705338428272d, y: 0.7997304104362785d), new NpgsqlTypes.NpgsqlPoint(x: 0.1921928326496657d, y: 0.7032819842723077d), new NpgsqlTypes.NpgsqlPoint(x: 0.009882468956797785d, y: 0.5178680318692668d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4426196790921061d, y: 0.9990428529725014d), new NpgsqlTypes.NpgsqlPoint(x: 0.4923147580227555d, y: 0.5853124435789026d), new NpgsqlTypes.NpgsqlPoint(x: 0.1607085572332061d, y: 0.4491538907568222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2662233787461816d, y: 0.31406525759108095d), new NpgsqlTypes.NpgsqlPoint(x: 0.18363585777553393d, y: 0.2949473368368477d), new NpgsqlTypes.NpgsqlPoint(x: 0.16768171956338884d, y: 0.3554141505226722d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.930023437858798d, y: 0.2972321532293295d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681382731046261d, y: 0.5180777425123166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25986315308987373d, y: 0.39068328186306656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48757261794706996d, y: 0.8178159641270155d), new NpgsqlTypes.NpgsqlPoint(x: 0.34261487405487534d, y: 0.9493715297291277d), new NpgsqlTypes.NpgsqlPoint(x: 0.20934739335889363d, y: 0.1692171512787728d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3663397657980789d, y: 0.6704686669419891d), new NpgsqlTypes.NpgsqlPoint(x: 0.36417565153501785d, y: 0.3936724121167757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1677721078597465d, y: 0.9478829725126166d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11532745563559788d, y: 0.9093438218512792d), new NpgsqlTypes.NpgsqlPoint(x: 0.4644006303649011d, y: 0.9561527642937302d), new NpgsqlTypes.NpgsqlPoint(x: 0.76623561807208d, y: 0.936001712978049d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7188230336698581d, y: 0.6780533995414403d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938952996616157d, y: 0.6851724563442124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857402449071272d, y: 0.7029573728057926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4654833557417076d, y: 0.5032785538466479d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117492053217794d, y: 0.7821655830716021d), new NpgsqlTypes.NpgsqlPoint(x: 0.029997869283483358d, y: 0.583060511497573d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5767328929857896d, y: 0.5208559169976911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785750448790568d, y: 0.9667494910427782d), new NpgsqlTypes.NpgsqlPoint(x: 0.17972236720780976d, y: 0.17239322978697613d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23168036212059595d, y: 0.8483154553698925d), new NpgsqlTypes.NpgsqlPoint(x: 0.1285952006461436d, y: 0.5370546573810964d), new NpgsqlTypes.NpgsqlPoint(x: 0.13329522340155298d, y: 0.8258065713256967d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9750136554207718d, y: 0.9764650034856935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861585510705791d, y: 0.04203094444511557d), new NpgsqlTypes.NpgsqlPoint(x: 0.2956866199946977d, y: 0.04164077319929538d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3492005380282578d, y: 0.05998191350695781d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190400519775657d, y: 0.5021963558557531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871863100760806d, y: 0.32458823323607366d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8374586897508873d, y: 0.25801134950087634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745664067614572d, y: 0.7629321796408539d), new NpgsqlTypes.NpgsqlPoint(x: 0.16680323102557715d, y: 0.4895591410626995d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8152070985204067d, y: 0.39863468293254145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7392964323188306d, y: 0.889021956462819d), new NpgsqlTypes.NpgsqlPoint(x: 0.1393524122412354d, y: 0.27360893590667024d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014408168323292503d, y: 0.2851515350058147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718013491833358d, y: 0.8263620804337962d), new NpgsqlTypes.NpgsqlPoint(x: 0.11682916670112498d, y: 0.7220394758273557d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9821508861276231d, y: 0.02961805874542278d), new NpgsqlTypes.NpgsqlPoint(x: 0.31085695149344117d, y: 0.36111645185664687d), new NpgsqlTypes.NpgsqlPoint(x: 0.24024015212803695d, y: 0.5248352189670336d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.608114956393343d, y: 0.04790564229507466d), new NpgsqlTypes.NpgsqlPoint(x: 0.21899461835808154d, y: 0.8832565783524143d), new NpgsqlTypes.NpgsqlPoint(x: 0.0513312968081483d, y: 0.3814270995521496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.583879827818678d, y: 0.7538208949711681d), new NpgsqlTypes.NpgsqlPoint(x: 0.14160574809989446d, y: 0.6377735946831757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333598985986556d, y: 0.5633297425149195d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10534951982416663d, y: 0.6162236917061799d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098022271015521d, y: 0.741793274000483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989470543783802d, y: 0.6490161265796984d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3977166030970779d, y: 0.7856169086624192d), new NpgsqlTypes.NpgsqlPoint(x: 0.19487024190207847d, y: 0.0890855410463337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507285897086105d, y: 0.9470210328397101d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2238211906720463d, y: 0.9180173639046578d), new NpgsqlTypes.NpgsqlPoint(x: 0.19076610159138907d, y: 0.7451581548524396d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767622195253281d, y: 0.7696306326835094d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8545809482856446d, y: 0.7828288108394925d), new NpgsqlTypes.NpgsqlPoint(x: 0.934327921258167d, y: 0.14589984839776682d), new NpgsqlTypes.NpgsqlPoint(x: 0.9664015645308622d, y: 0.08830982039018154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5170560355025686d, y: 0.548997075489268d), new NpgsqlTypes.NpgsqlPoint(x: 0.818051242130114d, y: 0.8767549533564746d), new NpgsqlTypes.NpgsqlPoint(x: 0.004163998101790356d, y: 0.5117882035939447d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01739141689327539d, y: 0.4081027460569491d), new NpgsqlTypes.NpgsqlPoint(x: 0.45773101313732834d, y: 0.23556450797732742d), new NpgsqlTypes.NpgsqlPoint(x: 0.46225143204706554d, y: 1.6143909388754984E-05d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18462947248535522d, y: 0.6022973700284424d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571196285591417d, y: 0.5019297175498552d), new NpgsqlTypes.NpgsqlPoint(x: 0.02264403748169508d, y: 0.14699341287758005d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008079823237494232d, y: 0.707057301168649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5685535213553654d, y: 0.7968777400299234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271807696828823d, y: 0.015572396572216096d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8096190624435873d, y: 0.5087705860864131d), new NpgsqlTypes.NpgsqlPoint(x: 0.07787296804955557d, y: 0.851176313198241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9928081091845083d, y: 0.6116956332465544d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08457002897547206d, y: 0.6560286151413761d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959074809154127d, y: 0.8993232788951258d), new NpgsqlTypes.NpgsqlPoint(x: 0.4987004295938898d, y: 0.6887195932681605d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09776680138360394d, y: 0.48041160959213136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842553057599492d, y: 0.4551172545290758d), new NpgsqlTypes.NpgsqlPoint(x: 0.18342238126191157d, y: 0.6560153885355d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.95303574048485d, y: 0.3637638794507142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7591912956213165d, y: 0.7878246359730884d), new NpgsqlTypes.NpgsqlPoint(x: 0.007964171159659639d, y: 0.3130966942962544d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43459450173855974d, y: 0.25406180184314175d), new NpgsqlTypes.NpgsqlPoint(x: 0.347239835035252d, y: 0.8924167822068187d), new NpgsqlTypes.NpgsqlPoint(x: 0.692778325299027d, y: 0.03893676671323787d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30444586167577736d, y: 0.04409208349453175d), new NpgsqlTypes.NpgsqlPoint(x: 0.763585486177101d, y: 0.5083817509732139d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167253076923633d, y: 0.18827500388878082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5763448057893719d, y: 0.1970808959853665d), new NpgsqlTypes.NpgsqlPoint(x: 0.36874804418693286d, y: 0.7523052072616593d), new NpgsqlTypes.NpgsqlPoint(x: 0.42235564234417644d, y: 0.44242705995736276d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7855982364877276d, y: 0.11445519027539985d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097975569142548d, y: 0.9887526840337444d), new NpgsqlTypes.NpgsqlPoint(x: 0.15369823541531746d, y: 0.6708277206307741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8421156881390354d, y: 0.9689143647473258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6984639169615657d, y: 0.6889601646331358d), new NpgsqlTypes.NpgsqlPoint(x: 0.05933584538296233d, y: 0.27117651734926485d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6160437580264888d, y: 0.7170911288543831d), new NpgsqlTypes.NpgsqlPoint(x: 0.6991644876239627d, y: 0.7237236237926743d), new NpgsqlTypes.NpgsqlPoint(x: 0.04358772214238493d, y: 0.8389998511406289d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9730104714674069d, y: 0.2634893187808304d), new NpgsqlTypes.NpgsqlPoint(x: 0.2216749448802845d, y: 0.34434082710486724d), new NpgsqlTypes.NpgsqlPoint(x: 0.21944601422608023d, y: 0.35577628005262274d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.493905776046368d, y: 0.9928609894104642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381329007093779d, y: 0.5193483616225529d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692819169848673d, y: 0.13906115648196749d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7550897320509483d, y: 0.12517997660039948d), new NpgsqlTypes.NpgsqlPoint(x: 0.0884356150361243d, y: 0.5061719704105433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8045357496420522d, y: 0.2569414692636366d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7083617533791057d, y: 0.30219686328998474d), new NpgsqlTypes.NpgsqlPoint(x: 0.22205194069601686d, y: 0.2859039359916452d), new NpgsqlTypes.NpgsqlPoint(x: 0.2113258005513965d, y: 0.5611416910604214d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3523833973679398d, y: 0.5642256462703511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2574054689820965d, y: 0.004534094880761619d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934810582774635d, y: 0.08234727409493858d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8525694513799243d, y: 0.41644183770943977d), new NpgsqlTypes.NpgsqlPoint(x: 0.4048044970153113d, y: 0.7636802966751578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6436008484673704d, y: 0.75253155806049d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7008581371454377d, y: 0.7717800810935066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373162144008128d, y: 0.6589538373338334d), new NpgsqlTypes.NpgsqlPoint(x: 0.08312700477318102d, y: 0.7799257347025595d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0646434961825193d, y: 0.4740595773857048d), new NpgsqlTypes.NpgsqlPoint(x: 0.1498147139241448d, y: 0.5315981708289447d), new NpgsqlTypes.NpgsqlPoint(x: 0.28452758526083555d, y: 0.26730078703004656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6597466813146868d, y: 0.3286278825761536d), new NpgsqlTypes.NpgsqlPoint(x: 0.228704403825835d, y: 0.06708984263511675d), new NpgsqlTypes.NpgsqlPoint(x: 0.3605715550264872d, y: 0.2514318494901292d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.578617170563709d, y: 0.4061855055012267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875488502131453d, y: 0.09405654467711244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635491147534086d, y: 0.7868661972023057d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18021925000548156d, y: 0.6628406603284126d), new NpgsqlTypes.NpgsqlPoint(x: 0.18479303655179424d, y: 0.5829473763667903d), new NpgsqlTypes.NpgsqlPoint(x: 0.28166050997539316d, y: 0.1314483182474867d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2754930418808069d, y: 0.11916943950893522d), new NpgsqlTypes.NpgsqlPoint(x: 0.03459810091039961d, y: 0.8667912147699159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695414377208535d, y: 0.40775994948313243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07211478534832627d, y: 0.32769930463792896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411451342200502d, y: 0.6980411877227136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953570406381948d, y: 0.5949820862516483d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.504648087713899d, y: 0.3898494843310155d), new NpgsqlTypes.NpgsqlPoint(x: 0.782958115672497d, y: 0.2940563432979302d), new NpgsqlTypes.NpgsqlPoint(x: 0.0892886520974221d, y: 0.7775485868302013d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8171413878662128d, y: 0.794181439807524d), new NpgsqlTypes.NpgsqlPoint(x: 0.160285843013931d, y: 0.9295229068356577d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332172808840961d, y: 0.5798650433257515d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14570898005644362d, y: 0.37416237903860305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394450689405052d, y: 0.7895167865579606d), new NpgsqlTypes.NpgsqlPoint(x: 0.748619920738597d, y: 0.5581179605248165d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10594812168041434d, y: 0.8993077153245328d), new NpgsqlTypes.NpgsqlPoint(x: 0.13159058342452623d, y: 0.8645599027603017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055712176589763d, y: 0.14006891837591295d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5021722325874953d, y: 0.40228505210332854d), new NpgsqlTypes.NpgsqlPoint(x: 0.761457157225381d, y: 0.7881194518124222d), new NpgsqlTypes.NpgsqlPoint(x: 0.1570214836526561d, y: 0.26764564095157706d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06672123877459757d, y: 0.08613783578700263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6207077809726742d, y: 0.45073013247980653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006080964100935d, y: 0.4276030462690791d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2055737354966205d, y: 0.7985684853303866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122726003541591d, y: 0.07100913449689417d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788315610956758d, y: 0.7454670484263831d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40300622739654635d, y: 0.8678908878764985d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720059972710006d, y: 0.41460977001752564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874124522501207d, y: 0.8923375465988441d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5928555765113257d, y: 0.15190697236111395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072508250978603d, y: 0.3516598384070615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945623101258144d, y: 0.9118969174401163d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16711582562586857d, y: 0.13525317842700646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2490930421004256d, y: 0.3164148948598049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6092989596160272d, y: 0.295203182449985d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5872230430318811d, y: 0.16715186218489186d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555957937298527d, y: 0.32516235980417085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567760823202919d, y: 0.6353449567443862d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5950658869512877d, y: 0.661745819278387d), new NpgsqlTypes.NpgsqlPoint(x: 0.34112858962195025d, y: 0.12414126351516064d), new NpgsqlTypes.NpgsqlPoint(x: 0.005289434846744823d, y: 0.8844411092676835d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3998391879380664d, y: 0.7044582579399944d), new NpgsqlTypes.NpgsqlPoint(x: 0.57913659831079d, y: 0.4958461876135105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769043979485516d, y: 0.1404176727556834d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06069799361315642d, y: 0.2506897120221422d), new NpgsqlTypes.NpgsqlPoint(x: 0.23079735951187696d, y: 0.3774314741439143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691276193521798d, y: 0.7230416572722438d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37728740761195334d, y: 0.013141611813078602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6244899346436896d, y: 0.3307639045766235d), new NpgsqlTypes.NpgsqlPoint(x: 0.23519961383454568d, y: 0.13913857984776878d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28537233188293043d, y: 0.2604272739754999d), new NpgsqlTypes.NpgsqlPoint(x: 0.18857940382791527d, y: 0.4856412974940212d), new NpgsqlTypes.NpgsqlPoint(x: 0.016186855857095117d, y: 0.8026142731665977d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3297298362414066d, y: 0.6638360137454155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9414810512009493d, y: 0.09530821762350061d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930887989107475d, y: 0.770305452175762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1842445404728772d, y: 0.4020129177273547d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143970138583571d, y: 0.5198548382613944d), new NpgsqlTypes.NpgsqlPoint(x: 0.015407856711179058d, y: 0.35220971759455066d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47854929168362614d, y: 0.973406582541642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495424664038748d, y: 0.9996220631508783d), new NpgsqlTypes.NpgsqlPoint(x: 0.006351805826049883d, y: 0.2666426976513595d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43422910288039673d, y: 0.2947806721011762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678628696401727d, y: 0.1641653687565875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401532953309245d, y: 0.23788497767377204d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6498834747395383d, y: 0.39749500767416324d), new NpgsqlTypes.NpgsqlPoint(x: 0.22237383722854387d, y: 0.9463224109188754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4095801854340365d, y: 0.21084303269308335d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09237733394876069d, y: 0.737515672665867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876165158909508d, y: 0.3489612080836485d), new NpgsqlTypes.NpgsqlPoint(x: 0.11172858309467015d, y: 0.17157405785171176d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1607896914703839d, y: 0.8141032454543076d), new NpgsqlTypes.NpgsqlPoint(x: 0.14961448258880594d, y: 0.6532875414482097d), new NpgsqlTypes.NpgsqlPoint(x: 0.26474133931026855d, y: 0.9774833361844998d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2202321028785852d, y: 0.2920490675352092d), new NpgsqlTypes.NpgsqlPoint(x: 0.09333088716008253d, y: 0.6984303177317869d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375387147205806d, y: 0.5720606285032893d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2674111790406756d, y: 0.5126203115263173d), new NpgsqlTypes.NpgsqlPoint(x: 0.4966082662154131d, y: 0.7517495488801074d), new NpgsqlTypes.NpgsqlPoint(x: 0.7931316290582131d, y: 0.5097047487276598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22337449185050817d, y: 0.5416864645896513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870511773980705d, y: 0.7482087241258364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347916502513969d, y: 0.67491903813917d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8496092856926295d, y: 0.1863345998654411d), new NpgsqlTypes.NpgsqlPoint(x: 0.047459864954788045d, y: 0.1031834366643497d), new NpgsqlTypes.NpgsqlPoint(x: 0.22566713709371555d, y: 0.6519714926151131d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2920566189819803d, y: 0.1305927012947823d), new NpgsqlTypes.NpgsqlPoint(x: 0.09215752734973515d, y: 0.4772124637158861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192199823155882d, y: 0.1123388073504693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6751621946711418d, y: 0.6489968672219967d), new NpgsqlTypes.NpgsqlPoint(x: 0.40455494888094023d, y: 0.9407174185061056d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873385599026712d, y: 0.8318799133746015d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5180025009449089d, y: 0.3377108457771275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338398616489186d, y: 0.1227911477881456d), new NpgsqlTypes.NpgsqlPoint(x: 0.30059202623398007d, y: 0.1932896274470064d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.622924355267825d, y: 0.8362522151717616d), new NpgsqlTypes.NpgsqlPoint(x: 0.4499518898238385d, y: 0.3397312354024318d), new NpgsqlTypes.NpgsqlPoint(x: 0.011392047976433783d, y: 0.5085888377513957d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40707189043241254d, y: 0.6355966849721385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042035003218651d, y: 0.33762616482419683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389841328081259d, y: 0.6719418406610742d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10178487513043744d, y: 0.4320635756845165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750930011202826d, y: 0.9913372180658446d), new NpgsqlTypes.NpgsqlPoint(x: 0.46396694362194457d, y: 0.6157159565289249d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6418412778388897d, y: 0.6106581787752074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663595110395184d, y: 0.195360100166718d), new NpgsqlTypes.NpgsqlPoint(x: 0.2474218325277594d, y: 0.012308143606500233d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3426899869718485d, y: 0.6552067635215371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4218744853132004d, y: 0.2504839993835982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9681131048675297d, y: 0.7722850907867256d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5969984948890815d, y: 0.19390852598529107d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110026494925191d, y: 0.2360093737551766d), new NpgsqlTypes.NpgsqlPoint(x: 0.23179489713551427d, y: 0.9408064848462393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5663979622759657d, y: 0.3811384696193776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8300432701243194d, y: 0.33852736654827176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9824789081537041d, y: 0.27260921776348546d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6634381585051958d, y: 0.6080834921541817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619524913749129d, y: 0.42566471954648766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7339890763623271d, y: 0.4696905534276916d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47028657017280917d, y: 0.4704001297246324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953576294700537d, y: 0.3701712537177895d), new NpgsqlTypes.NpgsqlPoint(x: 0.21891368193593763d, y: 0.14896660493523628d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3868440330548004d, y: 0.7393186510622947d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711702640634783d, y: 0.16778987021033542d), new NpgsqlTypes.NpgsqlPoint(x: 0.07607368486383048d, y: 0.8430767504493875d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.989648877515358d, y: 0.5748113831013785d), new NpgsqlTypes.NpgsqlPoint(x: 0.20081112123602274d, y: 0.9227286793866962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5117619039495366d, y: 0.43436302013379746d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.819220138702974d, y: 0.1895769204862664d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804966311862829d, y: 0.4032946010987032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060375550196432d, y: 0.3278844536426532d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18775609918479963d, y: 0.8944965340464212d), new NpgsqlTypes.NpgsqlPoint(x: 0.4532923752094369d, y: 0.5733495770808819d), new NpgsqlTypes.NpgsqlPoint(x: 0.47259118854399285d, y: 0.3239371719172046d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2739138844792206d, y: 0.022044849478033868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540521322714457d, y: 0.11471818674437162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707106943565237d, y: 0.8383695633705672d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9383868079783751d, y: 0.810630648548908d), new NpgsqlTypes.NpgsqlPoint(x: 0.43845710574626806d, y: 0.4757423162539415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243467401372888d, y: 0.7926849129405636d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3208573186147119d, y: 0.1744479642171055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7578808183215726d, y: 0.49148788943764954d), new NpgsqlTypes.NpgsqlPoint(x: 0.37846566065387643d, y: 0.01767108387468508d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42691955822758476d, y: 0.43136020483809445d), new NpgsqlTypes.NpgsqlPoint(x: 0.19884867782609372d, y: 0.834767289137192d), new NpgsqlTypes.NpgsqlPoint(x: 0.16023718787946195d, y: 0.6985899546315764d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7132331103879322d, y: 0.2835334119826165d), new NpgsqlTypes.NpgsqlPoint(x: 0.04440138138067129d, y: 0.32675242656933257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550744697310519d, y: 0.16458211617811402d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1757819248084771d, y: 0.5324078265860136d), new NpgsqlTypes.NpgsqlPoint(x: 0.8328119981453004d, y: 0.8793849045603419d), new NpgsqlTypes.NpgsqlPoint(x: 0.7426773078584364d, y: 0.5946072423244944d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4339535466355955d, y: 0.3485699076211455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283846096046517d, y: 0.7286419417141893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185251879609682d, y: 0.8316811139418521d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4748249249838502d, y: 0.2430547085221859d), new NpgsqlTypes.NpgsqlPoint(x: 0.014573082767930567d, y: 0.4269175503129137d), new NpgsqlTypes.NpgsqlPoint(x: 0.41566613164871713d, y: 0.9237727069365631d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0843840205035773d, y: 0.9010560452823593d), new NpgsqlTypes.NpgsqlPoint(x: 0.000726888595242059d, y: 0.8183754612177229d), new NpgsqlTypes.NpgsqlPoint(x: 0.041264318003909284d, y: 0.057133702804186504d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9044584539512065d, y: 0.4354946703131721d), new NpgsqlTypes.NpgsqlPoint(x: 0.11812355668261287d, y: 0.48380103813930697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138364467788588d, y: 0.1385368954271401d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15199181213364177d, y: 0.10635810683602542d), new NpgsqlTypes.NpgsqlPoint(x: 0.41514039215233434d, y: 0.6675913015981997d), new NpgsqlTypes.NpgsqlPoint(x: 0.003995481266027334d, y: 0.6192016854072002d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17649476902537908d, y: 0.7767579575111349d), new NpgsqlTypes.NpgsqlPoint(x: 0.9819880001372981d, y: 0.24163511783916136d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425272451716671d, y: 0.10358968516399414d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2246930961902982d, y: 0.40692760228896574d), new NpgsqlTypes.NpgsqlPoint(x: 0.3439222779543194d, y: 0.46236867715423957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6017982504725937d, y: 0.6275774265133822d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9137584856284668d, y: 0.26435830104568014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179255922887324d, y: 0.1316695147143746d), new NpgsqlTypes.NpgsqlPoint(x: 0.34509224226862967d, y: 0.07554337332777161d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.581752808071575d, y: 0.9927630619679212d), new NpgsqlTypes.NpgsqlPoint(x: 0.05611441870419387d, y: 0.6430297831741244d), new NpgsqlTypes.NpgsqlPoint(x: 0.13584608430994705d, y: 0.2254413906721393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13471194903909556d, y: 0.22533376069657995d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962122089863571d, y: 0.4379092481903787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3353861220989325d, y: 0.025754276300049672d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9053778970156813d, y: 0.5606542027990661d), new NpgsqlTypes.NpgsqlPoint(x: 0.12010081843531395d, y: 0.027410837924392695d), new NpgsqlTypes.NpgsqlPoint(x: 0.36859177908825036d, y: 0.36847594609738066d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7798603406598699d, y: 0.9321026395117222d), new NpgsqlTypes.NpgsqlPoint(x: 0.1268920258420877d, y: 0.2447497170380859d), new NpgsqlTypes.NpgsqlPoint(x: 0.2988320348562785d, y: 0.850121713471006d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5681897195486713d, y: 0.42192710097194464d), new NpgsqlTypes.NpgsqlPoint(x: 0.1353141015633471d, y: 0.8476181214269869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3343085619961367d, y: 0.8986473559937255d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4415410305820481d, y: 0.6494237427354614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842587355766397d, y: 0.9738534417877224d), new NpgsqlTypes.NpgsqlPoint(x: 0.20262237169827468d, y: 0.26949939338644957d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45184379137095676d, y: 0.02595445859020773d), new NpgsqlTypes.NpgsqlPoint(x: 0.4208391492203034d, y: 0.11421636647117239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6498197823513508d, y: 0.35582721900054914d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39230968438294345d, y: 0.4929501496818257d), new NpgsqlTypes.NpgsqlPoint(x: 0.27543126610854674d, y: 0.20865813384738374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7064725473952339d, y: 0.09671617942523136d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6989105766483554d, y: 0.09950144523863236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3557248413251374d, y: 0.8331261104432232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707220500055875d, y: 0.846999549104103d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26304390463993177d, y: 0.006139531167763557d), new NpgsqlTypes.NpgsqlPoint(x: 0.653927653303875d, y: 0.8927241866046209d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158437686519025d, y: 0.15827772590509837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6222181452288114d, y: 0.35966722507781634d), new NpgsqlTypes.NpgsqlPoint(x: 0.11551097307818214d, y: 0.6962656236152788d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496924195518519d, y: 0.9993848851557345d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6628498672269989d, y: 0.820801385376867d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462106510368569d, y: 0.069736818601287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758932273332947d, y: 0.8276093010062197d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1569959760756432d, y: 0.1288804343143708d), new NpgsqlTypes.NpgsqlPoint(x: 0.39696697877064d, y: 0.8450461677168422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653583624227476d, y: 0.9537831580852082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4395225083261105d, y: 0.001854815007491517d), new NpgsqlTypes.NpgsqlPoint(x: 0.14606502446750658d, y: 0.10893712514172882d), new NpgsqlTypes.NpgsqlPoint(x: 0.43990897752440083d, y: 0.4131627070976498d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4705428596034358d, y: 0.6544112202130703d), new NpgsqlTypes.NpgsqlPoint(x: 0.36457850735994957d, y: 0.678185086629095d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123117231901074d, y: 0.9997980928528213d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9720467812185332d, y: 0.9742466532599441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779090857956052d, y: 0.5782118466617653d), new NpgsqlTypes.NpgsqlPoint(x: 0.43806895739170515d, y: 0.6040664210231217d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6892491613528481d, y: 0.35340664959838197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5930081037004492d, y: 0.8439137185758226d), new NpgsqlTypes.NpgsqlPoint(x: 0.1449242745529037d, y: 0.44282519058010683d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8283886329189571d, y: 0.3051069561154829d), new NpgsqlTypes.NpgsqlPoint(x: 0.18411039402109264d, y: 0.962040362472369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288657478176722d, y: 0.9305011786832525d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8305107738983531d, y: 0.4353943435149181d), new NpgsqlTypes.NpgsqlPoint(x: 0.07811012639853465d, y: 0.9403533409875172d), new NpgsqlTypes.NpgsqlPoint(x: 0.937693817900048d, y: 0.4158292140463825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23712441189904998d, y: 0.9514445613384087d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861116891942273d, y: 0.8603860531746852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364260517138803d, y: 0.8795084750744343d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3079392358113696d, y: 0.41988373029812265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6211434690791773d, y: 0.9845036839967946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831029632187168d, y: 0.014580612905429224d)),

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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
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
                parametr2.Value = 54;
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[27],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
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
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 29, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 29, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 48, query1, 38, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 90, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 88, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatch(connection, 57, 76))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
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
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
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

