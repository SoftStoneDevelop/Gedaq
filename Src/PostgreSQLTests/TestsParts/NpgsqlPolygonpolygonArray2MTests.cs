

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904213146165875d, y: 0.030290761059853177d), new NpgsqlTypes.NpgsqlPoint(x: 0.3012544088721224d, y: 0.18836559834506317d), new NpgsqlTypes.NpgsqlPoint(x: 0.4093823693325521d, y: 0.5444046318879585d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5414307080900577d, y: 0.7255859245753683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5925016027290954d, y: 0.6850860423393427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179748185410605d, y: 0.36112228497078d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3846089173232532d, y: 0.40521782156019825d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555335971488335d, y: 0.9899688129990719d), new NpgsqlTypes.NpgsqlPoint(x: 0.7061114791821063d, y: 0.6030100524261867d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13540082583818613d, y: 0.11563172709587721d), new NpgsqlTypes.NpgsqlPoint(x: 0.3177639329286601d, y: 0.18159455218662812d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115353861179869d, y: 0.5246369820248966d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5790781973804823d, y: 0.17757221384662647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5768039947680019d, y: 0.5541874103781633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165557315013131d, y: 0.12908247119180405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4788895857834453d, y: 0.9095933756182504d), new NpgsqlTypes.NpgsqlPoint(x: 0.018841187487960487d, y: 0.4926867837979555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259374397863231d, y: 0.5443897212877009d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5735744846575767d, y: 0.14978109308255338d), new NpgsqlTypes.NpgsqlPoint(x: 0.14560726055319084d, y: 0.6168392945312895d), new NpgsqlTypes.NpgsqlPoint(x: 0.15797194043782015d, y: 0.2467083145383635d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6403965970037985d, y: 0.9033119017129941d), new NpgsqlTypes.NpgsqlPoint(x: 0.1238406242578517d, y: 0.40217457466169526d), new NpgsqlTypes.NpgsqlPoint(x: 0.3897860789371457d, y: 0.8148394221374277d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8008290790332906d, y: 0.07174473429243178d), new NpgsqlTypes.NpgsqlPoint(x: 0.03280680578838924d, y: 0.9817548759783601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569332427572784d, y: 0.25120495845071233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2775182748890125d, y: 0.43033697558467965d), new NpgsqlTypes.NpgsqlPoint(x: 0.4376260215365957d, y: 0.27658345602951584d), new NpgsqlTypes.NpgsqlPoint(x: 0.2253072477368505d, y: 0.03340752357731058d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8439224995186527d, y: 0.3946850784983248d), new NpgsqlTypes.NpgsqlPoint(x: 0.639806940687662d, y: 0.7041727862436106d), new NpgsqlTypes.NpgsqlPoint(x: 0.24909025536376572d, y: 0.5029289298248173d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04334577121643324d, y: 0.006946416911924547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544936712658131d, y: 0.18692361681772085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885179126562713d, y: 0.04656226460488766d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3119599814045958d, y: 0.32867477349809104d), new NpgsqlTypes.NpgsqlPoint(x: 0.24226488333899854d, y: 0.7326345548550544d), new NpgsqlTypes.NpgsqlPoint(x: 0.2551476154502683d, y: 0.48664899163051767d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2686118701954374d, y: 0.9260244226638307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075460301860939d, y: 0.20531958431749797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425199655254735d, y: 0.29845463698090124d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535414617753102d, y: 0.39107903473021444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616908457467789d, y: 0.6621902589840655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668972901219178d, y: 0.7956445611383619d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.71518015001898d, y: 0.8661013939527606d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561880429903378d, y: 0.8232353162389396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7371744702231705d, y: 0.6662007040938234d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6441146641502516d, y: 0.44663470138891914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6442747256222419d, y: 0.09766304375448587d), new NpgsqlTypes.NpgsqlPoint(x: 0.4380012097699253d, y: 0.5592672380815186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5419712833176668d, y: 0.9979752487823965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467705106069055d, y: 0.0446060746631719d), new NpgsqlTypes.NpgsqlPoint(x: 0.16108742654312325d, y: 0.6103206439161674d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5612177704330218d, y: 0.20828226232784897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930766411806718d, y: 0.41488014888961144d), new NpgsqlTypes.NpgsqlPoint(x: 0.919628261076023d, y: 0.28524938827416524d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8596094067984003d, y: 0.8720966886936701d), new NpgsqlTypes.NpgsqlPoint(x: 0.047884607902585974d, y: 0.31750666278030515d), new NpgsqlTypes.NpgsqlPoint(x: 0.37296679304295555d, y: 0.6123166009101175d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3397064215331138d, y: 0.4447127083910476d), new NpgsqlTypes.NpgsqlPoint(x: 0.13250909529096255d, y: 0.5912045024340483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107866324785426d, y: 0.28129047058692713d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8232635094659425d, y: 0.9405133099401336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691382257149894d, y: 0.3030746053302962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4257045267456304d, y: 0.4782046106560255d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45064912337807583d, y: 0.42103373194299787d), new NpgsqlTypes.NpgsqlPoint(x: 0.040241029685480156d, y: 0.7314145447243121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390177605745547d, y: 0.13164976657636318d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21103902590739465d, y: 0.8126056036734842d), new NpgsqlTypes.NpgsqlPoint(x: 0.47586001168985603d, y: 0.8051126618345888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8814237660029676d, y: 0.4818405015427819d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0757599182146742d, y: 0.3622777186505468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4569806147661676d, y: 0.9475693193665852d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296777302671273d, y: 0.8621006364759429d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.828473424844243d, y: 0.3382915199691189d), new NpgsqlTypes.NpgsqlPoint(x: 0.4585512489140342d, y: 0.41130864902539743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423570894961765d, y: 0.42803157812494586d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17767099108583695d, y: 0.6699489497878727d), new NpgsqlTypes.NpgsqlPoint(x: 0.1522268570215186d, y: 0.449194239117076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973138610645862d, y: 0.7326669678509439d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9575600833371284d, y: 0.5853977285148956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602119018373049d, y: 0.9011982255851271d), new NpgsqlTypes.NpgsqlPoint(x: 0.9212210790243125d, y: 0.7892574034384515d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.342288326839167d, y: 0.22644786718249965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913550846925873d, y: 0.8016095991041863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378952112764322d, y: 0.5686813005071246d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9173563069890911d, y: 0.7907684438260505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923930957704711d, y: 0.5964206179580679d), new NpgsqlTypes.NpgsqlPoint(x: 0.19728740544632373d, y: 0.8339770168420921d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09664968742457214d, y: 0.018901968441536687d), new NpgsqlTypes.NpgsqlPoint(x: 0.27879604023931315d, y: 0.6071481159337179d), new NpgsqlTypes.NpgsqlPoint(x: 0.17040201033264757d, y: 0.8718017243696673d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09314497782048825d, y: 0.5129634029026368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5824539077589883d, y: 0.6528772066225714d), new NpgsqlTypes.NpgsqlPoint(x: 0.4102867001674606d, y: 0.31765159497729023d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5227437932431014d, y: 0.043869989213095595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485706369957889d, y: 0.839314392450815d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964042014422879d, y: 0.9520299675338124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12955123303107796d, y: 0.00725976858092181d), new NpgsqlTypes.NpgsqlPoint(x: 0.7169816268925011d, y: 0.8842093181966647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186788695906981d, y: 0.49254791953365884d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4383986533648254d, y: 0.7412540852084534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174399364512547d, y: 0.9093426699042059d), new NpgsqlTypes.NpgsqlPoint(x: 0.15571906504816624d, y: 0.5448757013920682d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4617559597172358d, y: 0.24497614630001274d), new NpgsqlTypes.NpgsqlPoint(x: 0.39341039113995757d, y: 0.9147647905912424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339534547334058d, y: 0.9689512750469537d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361737783785111d, y: 0.5184101227260226d), new NpgsqlTypes.NpgsqlPoint(x: 0.022307363695124205d, y: 0.8193323034419818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5848105296255839d, y: 0.0647743443518467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24753817478927087d, y: 0.22872380870798048d), new NpgsqlTypes.NpgsqlPoint(x: 0.975951505951955d, y: 0.6234775044236136d), new NpgsqlTypes.NpgsqlPoint(x: 0.39333332915811803d, y: 0.5652456224664184d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9632220048155246d, y: 0.9575937557230673d), new NpgsqlTypes.NpgsqlPoint(x: 0.06125095838496886d, y: 0.6273169022323097d), new NpgsqlTypes.NpgsqlPoint(x: 0.07782173902515088d, y: 0.18289327661459487d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2255837698732931d, y: 0.7957741358490147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526121117493923d, y: 0.591917767243365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7307343757652236d, y: 0.7739087513346454d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7853976007389288d, y: 0.0952615857648984d), new NpgsqlTypes.NpgsqlPoint(x: 0.05990758152121978d, y: 0.9605138512674624d), new NpgsqlTypes.NpgsqlPoint(x: 0.986473028942327d, y: 0.6870912457335706d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7706342922506734d, y: 0.4083201365770599d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655510245080588d, y: 0.8208533148918167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356542625517827d, y: 0.8625641485845708d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44529273547694803d, y: 0.5390624285681119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739759668608775d, y: 0.7251305084901581d), new NpgsqlTypes.NpgsqlPoint(x: 0.3392954212527396d, y: 0.16698047552685058d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5501208699783056d, y: 0.12122228691993187d), new NpgsqlTypes.NpgsqlPoint(x: 0.49928819660385537d, y: 0.023219629059877178d), new NpgsqlTypes.NpgsqlPoint(x: 0.46304618065652026d, y: 0.7742032382353424d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10687811197737729d, y: 0.2416237311567675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646185060870982d, y: 0.44100882012610854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5123732719969148d, y: 0.27144877021747227d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47023012641783346d, y: 0.2690940424321825d), new NpgsqlTypes.NpgsqlPoint(x: 0.650445755234803d, y: 0.29081634258659284d), new NpgsqlTypes.NpgsqlPoint(x: 0.3547672404403096d, y: 0.8361814254556811d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29140558158426044d, y: 0.7273997145352163d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413911747778787d, y: 0.20572769365398735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757136795822063d, y: 0.27771652802828284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4507638575731785d, y: 0.8422125224337996d), new NpgsqlTypes.NpgsqlPoint(x: 0.24225736445938506d, y: 0.01924258922260713d), new NpgsqlTypes.NpgsqlPoint(x: 0.1647844977271462d, y: 0.11418915233048288d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7123714383124575d, y: 0.84079396737239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6116765389878968d, y: 0.6007845468824313d), new NpgsqlTypes.NpgsqlPoint(x: 0.22274440677255014d, y: 0.8452805727631112d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5959874510162596d, y: 0.6441503428723653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638336582761308d, y: 0.9792609759270119d), new NpgsqlTypes.NpgsqlPoint(x: 0.835226498319247d, y: 0.12721153628666504d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3579441357569584d, y: 0.8485932311741239d), new NpgsqlTypes.NpgsqlPoint(x: 0.46379477853619133d, y: 0.5688036642032787d), new NpgsqlTypes.NpgsqlPoint(x: 0.2905406777279803d, y: 0.663946555963912d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033251441116185165d, y: 0.47611066686242476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930930163322769d, y: 0.3581693939709275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856182338370502d, y: 0.2836471860441394d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3472101357239801d, y: 0.3976454687348673d), new NpgsqlTypes.NpgsqlPoint(x: 0.19692995558666915d, y: 0.5301879430730339d), new NpgsqlTypes.NpgsqlPoint(x: 0.7033203240354442d, y: 0.08248196425012133d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21972913100299685d, y: 0.402364290359285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574932374105585d, y: 0.5554380989161315d), new NpgsqlTypes.NpgsqlPoint(x: 0.34725046664316805d, y: 0.12547936661949433d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36218860082467685d, y: 0.4942213797625661d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008058757685056d, y: 0.6420947975513452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9214313200697631d, y: 0.19778217226887962d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.907208640194195d, y: 0.484765030450935d), new NpgsqlTypes.NpgsqlPoint(x: 0.753124711900105d, y: 0.8166855835862634d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725842459468238d, y: 0.7798828966176156d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6161715296295954d, y: 0.5645738872941949d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369198159077178d, y: 0.07327371770486357d), new NpgsqlTypes.NpgsqlPoint(x: 0.24094127094944406d, y: 0.05548774734683137d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5218915343750795d, y: 0.9000204124139386d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356339484127816d, y: 0.8288762043196998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3041531614407331d, y: 0.9846305382908298d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5593012582045942d, y: 0.4624498584713139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8708750832883292d, y: 0.9131139896428025d), new NpgsqlTypes.NpgsqlPoint(x: 0.18182798143025014d, y: 0.19980349677764508d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8423226224495342d, y: 0.5739207623063214d), new NpgsqlTypes.NpgsqlPoint(x: 0.8862043193368467d, y: 0.004828789425507352d), new NpgsqlTypes.NpgsqlPoint(x: 0.21009053507205322d, y: 0.4185430152180657d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6380804997669308d, y: 0.9713248430281798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840205963935489d, y: 0.6469096596903509d), new NpgsqlTypes.NpgsqlPoint(x: 0.17859786898131447d, y: 0.33618840388848537d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7608028919366541d, y: 0.3228714366180908d), new NpgsqlTypes.NpgsqlPoint(x: 0.49017586889309916d, y: 0.5027214146679092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8652622953301883d, y: 0.2159645217759386d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5582607976079309d, y: 0.2508632430975316d), new NpgsqlTypes.NpgsqlPoint(x: 0.07378382402823769d, y: 0.06678673937878121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7965613886655153d, y: 0.234596995431973d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8616690609655019d, y: 0.11248298262133927d), new NpgsqlTypes.NpgsqlPoint(x: 0.00024920635858705076d, y: 0.28375482934794205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7563639035924771d, y: 0.8597974092670757d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4249690054929339d, y: 0.03049094699681565d), new NpgsqlTypes.NpgsqlPoint(x: 0.18231289305356546d, y: 0.8081300738502201d), new NpgsqlTypes.NpgsqlPoint(x: 0.24793359804966797d, y: 0.1997977688324437d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6455938290779417d, y: 0.37112917977672955d), new NpgsqlTypes.NpgsqlPoint(x: 0.12480746518926644d, y: 0.49212952050584036d), new NpgsqlTypes.NpgsqlPoint(x: 0.979240105051204d, y: 0.8831384664138878d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11769760702098697d, y: 0.3618760184422708d), new NpgsqlTypes.NpgsqlPoint(x: 0.2857654744803819d, y: 0.8472326376214441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868511261840214d, y: 0.3262123588438608d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6037693119970072d, y: 0.22060082826906546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464924861578597d, y: 0.06552861405634902d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502577357608887d, y: 0.8465527536462748d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6867334760358669d, y: 0.30676545652329734d), new NpgsqlTypes.NpgsqlPoint(x: 0.10758050620339443d, y: 0.29654036254046867d), new NpgsqlTypes.NpgsqlPoint(x: 0.27040814810319314d, y: 0.5026461401895085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6672025996202591d, y: 0.9095680330196144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3202128095866913d, y: 0.7111426819350063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456331054788236d, y: 0.17268965437083894d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5003454787690276d, y: 0.5773319969009493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640643517905322d, y: 0.5581367849463309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540497700738317d, y: 0.7021805580854006d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6968161810151013d, y: 0.456915865427872d), new NpgsqlTypes.NpgsqlPoint(x: 0.02237063647252513d, y: 0.1308427083032051d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130319654411098d, y: 0.6045810743167659d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7617721287634974d, y: 0.29725133256379854d), new NpgsqlTypes.NpgsqlPoint(x: 0.060897671733181946d, y: 0.5548827954853691d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018354758130777d, y: 0.06296447858573417d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36004288556950126d, y: 0.5370399040907158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7023104553546037d, y: 0.20289234806246348d), new NpgsqlTypes.NpgsqlPoint(x: 0.21296631669908073d, y: 0.25439226028305684d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08667727040877493d, y: 0.650751178081967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753576562324307d, y: 0.22600957323035098d), new NpgsqlTypes.NpgsqlPoint(x: 0.3959185108308053d, y: 0.24094540470000791d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08146485717770102d, y: 0.28851305461725685d), new NpgsqlTypes.NpgsqlPoint(x: 0.07583892299266826d, y: 0.20810003550605882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074120124691226d, y: 0.7391002169140299d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7363574952706543d, y: 0.06254467306030842d), new NpgsqlTypes.NpgsqlPoint(x: 0.6048417790537514d, y: 0.7777480819688328d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891047209195762d, y: 0.5240115498008721d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23176198857673347d, y: 0.27511403994116923d), new NpgsqlTypes.NpgsqlPoint(x: 0.36413205634244916d, y: 0.8505113670698461d), new NpgsqlTypes.NpgsqlPoint(x: 0.4997758671008471d, y: 0.6277045065554873d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.482958665584439d, y: 0.4233944799575907d), new NpgsqlTypes.NpgsqlPoint(x: 0.19428901787630848d, y: 0.3223095477154079d), new NpgsqlTypes.NpgsqlPoint(x: 0.11491933775816143d, y: 0.8061858694346028d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5896076423383411d, y: 0.9034699101533606d), new NpgsqlTypes.NpgsqlPoint(x: 0.10528829900222414d, y: 0.24032970820754762d), new NpgsqlTypes.NpgsqlPoint(x: 0.07582513703958649d, y: 0.2290328273634129d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5450469600274608d, y: 0.16046407165384335d), new NpgsqlTypes.NpgsqlPoint(x: 0.5649695757243545d, y: 0.9171680523566208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9798802941572372d, y: 0.8707848532716372d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29029792592735326d, y: 0.9412310348775008d), new NpgsqlTypes.NpgsqlPoint(x: 0.32738447936486814d, y: 0.4403669660307412d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761156690740957d, y: 0.6201932177450141d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6342604903711605d, y: 0.46797505564149033d), new NpgsqlTypes.NpgsqlPoint(x: 0.07708759060324633d, y: 0.18433562633184553d), new NpgsqlTypes.NpgsqlPoint(x: 0.23908828329542509d, y: 0.8121341838356376d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05246348471842255d, y: 0.5802161522635754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2814789717936177d, y: 0.23096830336238683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525818538551973d, y: 0.8601814019974442d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.605019991054793d, y: 0.7981802262333005d), new NpgsqlTypes.NpgsqlPoint(x: 0.962452479181475d, y: 0.42745701466371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6214567472617932d, y: 0.22722487049080575d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.679714441809617d, y: 0.6798024468917927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8246040350575803d, y: 0.19081654644964108d), new NpgsqlTypes.NpgsqlPoint(x: 0.36447588120540597d, y: 0.281523146686931d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5663486904831982d, y: 0.4967927482405844d), new NpgsqlTypes.NpgsqlPoint(x: 0.42230483827755627d, y: 0.8852664255781382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022946132685882d, y: 0.6438015005792095d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4739624951304302d, y: 0.28327605107246623d), new NpgsqlTypes.NpgsqlPoint(x: 0.42188431171517604d, y: 0.20199170445409986d), new NpgsqlTypes.NpgsqlPoint(x: 0.22022042470116365d, y: 0.4640176276861464d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13737619747177843d, y: 0.15726176635563072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3076977795893311d, y: 0.09250912433676195d), new NpgsqlTypes.NpgsqlPoint(x: 0.17882634351520055d, y: 0.222863069139018d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6432249658524531d, y: 0.3148977222355488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7609317482006822d, y: 0.9168597466526069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842219630460275d, y: 0.3735667571291005d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28842270466255526d, y: 0.41002542442619716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056435250876756d, y: 0.9271307729918786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316735348078038d, y: 0.20130767995400545d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8659234044457463d, y: 0.42470161386996863d), new NpgsqlTypes.NpgsqlPoint(x: 0.1571590963641124d, y: 0.9556163342141961d), new NpgsqlTypes.NpgsqlPoint(x: 0.16566833547005522d, y: 0.3204087483630219d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3713160192936602d, y: 0.7987019723780358d), new NpgsqlTypes.NpgsqlPoint(x: 0.2705728639766509d, y: 0.0561843772397127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5909651760030578d, y: 0.8894617179625438d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32874785752020297d, y: 0.7944499910633888d), new NpgsqlTypes.NpgsqlPoint(x: 0.48178626064626173d, y: 0.059621812441816635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922640747819662d, y: 0.10584326647207154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3812165884659108d, y: 0.6390059253787261d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915239648591019d, y: 0.1748783552565607d), new NpgsqlTypes.NpgsqlPoint(x: 0.21808222817555845d, y: 0.6938886352871046d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10314955482146937d, y: 0.6580611041460469d), new NpgsqlTypes.NpgsqlPoint(x: 0.1426430912564921d, y: 0.856881554182483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452953544862259d, y: 0.6105312000775343d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.780451160342009d, y: 0.15416004638135095d), new NpgsqlTypes.NpgsqlPoint(x: 0.09955826039600613d, y: 0.9360660614067517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5936786774790765d, y: 0.9985594519449927d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837028128115101d, y: 0.6874268947781912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6883380839667678d, y: 0.5528359500918587d), new NpgsqlTypes.NpgsqlPoint(x: 0.397483256592838d, y: 0.24869119466489253d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25218033076787694d, y: 0.27265596138045023d), new NpgsqlTypes.NpgsqlPoint(x: 0.012413253323888318d, y: 0.061060526920536984d), new NpgsqlTypes.NpgsqlPoint(x: 0.38798592600215165d, y: 0.4573496367439859d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6411639824004597d, y: 0.061401948013126484d), new NpgsqlTypes.NpgsqlPoint(x: 0.32267617385023983d, y: 0.53136222386521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215401870399133d, y: 0.3913141429711888d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015577243706814348d, y: 0.6291435159318897d), new NpgsqlTypes.NpgsqlPoint(x: 0.1402320313123514d, y: 0.066010821409754d), new NpgsqlTypes.NpgsqlPoint(x: 0.45119985724129097d, y: 0.13553659767615267d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7780067757008939d, y: 0.31988937014807284d), new NpgsqlTypes.NpgsqlPoint(x: 0.28222677027747844d, y: 0.9171768257281849d), new NpgsqlTypes.NpgsqlPoint(x: 0.05079481321696744d, y: 0.32381153973598353d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7093769328804551d, y: 0.9623437879735182d), new NpgsqlTypes.NpgsqlPoint(x: 0.09295167744829969d, y: 0.9136213422196185d), new NpgsqlTypes.NpgsqlPoint(x: 0.11871718181146962d, y: 0.49750465155567036d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3054005899673652d, y: 0.9956555278193845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826375693763191d, y: 0.6655916510616255d), new NpgsqlTypes.NpgsqlPoint(x: 0.08584662078894523d, y: 0.5121515697898052d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48238052505097995d, y: 0.970662049307148d), new NpgsqlTypes.NpgsqlPoint(x: 0.24829065443240328d, y: 0.7055135329850131d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571219052710221d, y: 0.692556557410555d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2885543140942878d, y: 0.7420680815052583d), new NpgsqlTypes.NpgsqlPoint(x: 0.7087355393089249d, y: 0.7671564469694079d), new NpgsqlTypes.NpgsqlPoint(x: 0.3753369160183284d, y: 0.7020858277896423d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6320179032947134d, y: 0.4856835176701143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190103911867159d, y: 0.22934663809971634d), new NpgsqlTypes.NpgsqlPoint(x: 0.47761259177697934d, y: 0.9139775101668941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6068856085607227d, y: 0.2891002992998317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8064374408983106d, y: 0.014795010186906099d), new NpgsqlTypes.NpgsqlPoint(x: 0.6138758557126652d, y: 0.30827150491205835d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30159831976566076d, y: 0.5557440590202876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612038342877362d, y: 0.6037058258108358d), new NpgsqlTypes.NpgsqlPoint(x: 0.33251605914278337d, y: 0.9017861368091867d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07069979020950723d, y: 0.17395102024227505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9482420613896808d, y: 0.3469768366853734d), new NpgsqlTypes.NpgsqlPoint(x: 0.2822890183040404d, y: 0.129658775349224d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7674206086594789d, y: 0.6052125983118859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128699531454711d, y: 0.7265173302491968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126819882627009d, y: 0.1553360255613614d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12216749680093353d, y: 0.13870963539260417d), new NpgsqlTypes.NpgsqlPoint(x: 0.08465483414835362d, y: 0.8176249321166532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4730305130438771d, y: 0.10939280753625447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7121249525643881d, y: 0.8734178688844098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969898025261326d, y: 0.20125486435719175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3245184713938698d, y: 0.16746688813721533d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23712085517601011d, y: 0.500020253145399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885629669707673d, y: 0.10978965022489007d), new NpgsqlTypes.NpgsqlPoint(x: 0.10987920613213265d, y: 0.010550692054835165d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3074099354182789d, y: 0.9085380627579838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058074484357062d, y: 0.6196300708490841d), new NpgsqlTypes.NpgsqlPoint(x: 0.17505592388141633d, y: 0.17224456760443907d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07525408565331848d, y: 0.36759567136219495d), new NpgsqlTypes.NpgsqlPoint(x: 0.1129839458191284d, y: 0.24459755399578476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965422204128134d, y: 0.08430176976993942d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7306139460852439d, y: 0.027255159365622172d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168871207706817d, y: 0.3975569423208861d), new NpgsqlTypes.NpgsqlPoint(x: 0.2245978225986468d, y: 0.37799826044524365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16873160106259022d, y: 0.962294021692072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845665568407799d, y: 0.6327243701478001d), new NpgsqlTypes.NpgsqlPoint(x: 0.5222914052810602d, y: 0.013973120745675138d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4795469423727885d, y: 0.6741056043566334d), new NpgsqlTypes.NpgsqlPoint(x: 0.15999861904295165d, y: 0.2542922072363115d), new NpgsqlTypes.NpgsqlPoint(x: 0.2101307521043858d, y: 0.449194437856932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6347823954782642d, y: 0.2180908777662255d), new NpgsqlTypes.NpgsqlPoint(x: 0.27436411837501984d, y: 0.7815878368855027d), new NpgsqlTypes.NpgsqlPoint(x: 0.0735341608793677d, y: 0.012145272074281177d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1404989237140003d, y: 0.8051028656804846d), new NpgsqlTypes.NpgsqlPoint(x: 0.918413421322623d, y: 0.6446085036326439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045597180491252d, y: 0.6120878490625534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8076393125167838d, y: 0.7718997473846609d), new NpgsqlTypes.NpgsqlPoint(x: 0.11185902145451398d, y: 0.7121848028216242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180312750454926d, y: 0.7458367487556631d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3917939887326596d, y: 0.3499754407724105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9233662693738195d, y: 0.614569676446091d), new NpgsqlTypes.NpgsqlPoint(x: 0.10292860305632301d, y: 0.3940128865630409d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8375872780663843d, y: 0.9136752882259785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432873897684457d, y: 0.6053921468052244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845318925099882d, y: 0.8112268365208423d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7049876393631742d, y: 0.7314405979782178d), new NpgsqlTypes.NpgsqlPoint(x: 0.008238180636491288d, y: 0.9116478100911282d), new NpgsqlTypes.NpgsqlPoint(x: 0.43717212627075486d, y: 0.2613924285328003d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.634910116919894d, y: 0.827609451709511d), new NpgsqlTypes.NpgsqlPoint(x: 0.34618545710379367d, y: 0.9163588920694042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769800288146453d, y: 0.9705582338932882d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9462756427480205d, y: 0.6308232647137111d), new NpgsqlTypes.NpgsqlPoint(x: 0.29708108537670797d, y: 0.23634439399525986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8867497079902842d, y: 0.51074348115273d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9594600785166914d, y: 0.994827944161636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6650824429815398d, y: 0.22043124203384934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367601891560656d, y: 0.7020649562757328d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5419843740281334d, y: 0.20114882028566838d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840991403789874d, y: 0.4349337839173554d), new NpgsqlTypes.NpgsqlPoint(x: 0.4480608847496531d, y: 0.766535033989877d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8767201589610414d, y: 0.5739807790068046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9871684420223142d, y: 0.04878913327163259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382470301295014d, y: 0.2231152035337064d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10851368606921541d, y: 0.80578327614912d), new NpgsqlTypes.NpgsqlPoint(x: 0.5085903622165346d, y: 0.7696586101837983d), new NpgsqlTypes.NpgsqlPoint(x: 0.17741488044769615d, y: 0.8968426595091243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16591789207532615d, y: 0.31375309314360755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609953476179985d, y: 0.20205681573651202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8712456697999067d, y: 0.14103233706441243d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9173455048960854d, y: 0.08136173843471961d), new NpgsqlTypes.NpgsqlPoint(x: 0.6193616999389615d, y: 0.6150348298531022d), new NpgsqlTypes.NpgsqlPoint(x: 0.48850719919261254d, y: 0.06479569443321676d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15014988483715141d, y: 0.8972666233086841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156759534157616d, y: 0.8175141505686963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463496067436053d, y: 0.4184730257220465d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4543838609594931d, y: 0.7029267651678973d), new NpgsqlTypes.NpgsqlPoint(x: 0.5377004967617698d, y: 0.3282862797084738d), new NpgsqlTypes.NpgsqlPoint(x: 0.33811871216738576d, y: 0.7872030243496853d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33853269829007104d, y: 0.9674395858636597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2336561765501486d, y: 0.2794050045064258d), new NpgsqlTypes.NpgsqlPoint(x: 0.19090571399602474d, y: 0.4509251522589285d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19147226560999475d, y: 0.36415805162213133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4764608933556673d, y: 0.7151347400686392d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514754743719502d, y: 0.15115068170951074d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8164604576460156d, y: 0.7591573166278403d), new NpgsqlTypes.NpgsqlPoint(x: 0.755950673837101d, y: 0.6041739146367187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7831378710674921d, y: 0.8762841056084327d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8165462755808971d, y: 0.7314288337608567d), new NpgsqlTypes.NpgsqlPoint(x: 0.33451662672284577d, y: 0.3464727902650583d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018733892363329563d, y: 0.4388326669074163d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11314344666347886d, y: 0.8713347005147736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975324584161725d, y: 0.8380466904459463d), new NpgsqlTypes.NpgsqlPoint(x: 0.062367666855868364d, y: 0.1866969085105289d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20581203194352826d, y: 0.28632892894919426d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086350800697553d, y: 0.4387193126504101d), new NpgsqlTypes.NpgsqlPoint(x: 0.33662049825528084d, y: 0.6313935844145109d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9902015575762111d, y: 0.9498399215108884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456969518695219d, y: 0.2525906035162525d), new NpgsqlTypes.NpgsqlPoint(x: 0.6317803221755164d, y: 0.4159577151107744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7763671690670891d, y: 0.28425449282725557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244599430135395d, y: 0.4794795262178315d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167989080584655d, y: 0.11586311418415607d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6587010870922613d, y: 0.3654752430409033d), new NpgsqlTypes.NpgsqlPoint(x: 0.07577719500541524d, y: 0.21412874436113283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995054139126471d, y: 0.5886384360862755d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1366382460670954d, y: 0.09873578374753933d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853802403689581d, y: 0.02878153382192228d), new NpgsqlTypes.NpgsqlPoint(x: 0.19184703724686925d, y: 0.7208590170691697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6982299825384586d, y: 0.8994174441817938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536398326562373d, y: 0.08326959224850383d), new NpgsqlTypes.NpgsqlPoint(x: 0.606005413783746d, y: 0.5127983042445399d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6170423634352517d, y: 0.26202621327552444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20911927523046303d, y: 0.04640926079055696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2748019446879131d, y: 0.5862911569052521d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.567967797087556d, y: 0.1346986885703515d), new NpgsqlTypes.NpgsqlPoint(x: 0.15449651588750324d, y: 0.47356983180178724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8634580374009649d, y: 0.10685445529457305d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6366925207957812d, y: 0.6286620190692211d), new NpgsqlTypes.NpgsqlPoint(x: 0.19013971972659738d, y: 0.13459679424971893d), new NpgsqlTypes.NpgsqlPoint(x: 0.39077215880508576d, y: 0.6101941979486467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655284836810502d, y: 0.020694691390124476d), new NpgsqlTypes.NpgsqlPoint(x: 0.1393586921415486d, y: 0.26849774065548015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6901492454103411d, y: 0.5998527980101364d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4525905553211549d, y: 0.8153201309566163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4403053361955003d, y: 0.9094548210061126d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378736456120006d, y: 0.06154559039047258d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02371033543975143d, y: 0.7759014900527402d), new NpgsqlTypes.NpgsqlPoint(x: 0.27732894291094123d, y: 0.6435575717505034d), new NpgsqlTypes.NpgsqlPoint(x: 0.79078529311627d, y: 0.5995157633651874d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1445419382300306d, y: 0.42548943990674193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129188996773439d, y: 0.4231077244188566d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519475223892139d, y: 0.37427827306509576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8181774460841332d, y: 0.4027158366703747d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807324369570982d, y: 0.9890716875027633d), new NpgsqlTypes.NpgsqlPoint(x: 0.057961002802639716d, y: 0.723647941435486d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7856390405454142d, y: 0.7255072117562454d), new NpgsqlTypes.NpgsqlPoint(x: 0.37668124577752815d, y: 0.091154186861649d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655940158369832d, y: 0.09043197509400813d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3046220680865219d, y: 0.2549657791904898d), new NpgsqlTypes.NpgsqlPoint(x: 0.6069200510857171d, y: 0.37022832140446726d), new NpgsqlTypes.NpgsqlPoint(x: 0.22842136301776483d, y: 0.5591977855133063d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8282129760224112d, y: 0.025838025314873114d), new NpgsqlTypes.NpgsqlPoint(x: 0.05762675034077547d, y: 0.24674715027726324d), new NpgsqlTypes.NpgsqlPoint(x: 0.38788121998564074d, y: 0.9349504937006198d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0005081512696404333d, y: 0.7352259957883204d), new NpgsqlTypes.NpgsqlPoint(x: 0.596307321376858d, y: 0.7001773322629046d), new NpgsqlTypes.NpgsqlPoint(x: 0.06213765332296617d, y: 0.4448815483721743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5548506794098702d, y: 0.16809941064483047d), new NpgsqlTypes.NpgsqlPoint(x: 0.20850241254915713d, y: 0.35167266597557767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844244227254019d, y: 0.01206773215207646d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9103479716617935d, y: 0.1538234287076884d), new NpgsqlTypes.NpgsqlPoint(x: 0.44307369971778676d, y: 0.8284020398619489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6067766233559074d, y: 0.06533337839204734d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3645711367939348d, y: 0.6035379812472947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130311440706549d, y: 0.13760247934745595d), new NpgsqlTypes.NpgsqlPoint(x: 0.13178114746798464d, y: 0.5544396478184902d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3762869816025505d, y: 0.7298265954804498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945924904489695d, y: 0.9237848836033263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3794887370787394d, y: 0.5644674358807478d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29564928361580733d, y: 0.24896434965990277d), new NpgsqlTypes.NpgsqlPoint(x: 0.002308092713060428d, y: 0.6567958177845173d), new NpgsqlTypes.NpgsqlPoint(x: 0.575250344090423d, y: 0.8349869658673595d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4264486619400284d, y: 0.2551652738100443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3399215113262065d, y: 0.4821029194684503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439089769829083d, y: 0.6427375576206088d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6114643717071865d, y: 0.1663788158756343d), new NpgsqlTypes.NpgsqlPoint(x: 0.23611998959247704d, y: 0.2214702507429821d), new NpgsqlTypes.NpgsqlPoint(x: 0.4100329876851726d, y: 0.9572910161468634d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8144622009864124d, y: 0.3758301849804978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187855633226512d, y: 0.5553534000434518d), new NpgsqlTypes.NpgsqlPoint(x: 0.04690543487116472d, y: 0.4903420427108135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6695162282983753d, y: 0.8945406695370263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299014868551448d, y: 0.0498369597720999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910243614391006d, y: 0.780134326480422d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33482029891071696d, y: 0.9546170174971138d), new NpgsqlTypes.NpgsqlPoint(x: 0.08238246465244015d, y: 0.30823274286022206d), new NpgsqlTypes.NpgsqlPoint(x: 0.308642514210163d, y: 0.550270031202425d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3385308885325715d, y: 0.8792745500321513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928642548125433d, y: 0.3393831624618424d), new NpgsqlTypes.NpgsqlPoint(x: 0.01924045635961924d, y: 0.8684915948711929d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.050478409499736365d, y: 0.4751065318085429d), new NpgsqlTypes.NpgsqlPoint(x: 0.038115185595829826d, y: 0.2804499752131894d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413768598630404d, y: 0.029301821062849842d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5929742476650367d, y: 0.7372438300795616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992851735010617d, y: 0.9725889484125715d), new NpgsqlTypes.NpgsqlPoint(x: 0.39614827209715053d, y: 0.04090571352003369d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6274832219251603d, y: 0.7864462276255417d), new NpgsqlTypes.NpgsqlPoint(x: 0.1453973254876726d, y: 0.8211181750186627d), new NpgsqlTypes.NpgsqlPoint(x: 0.936139776104162d, y: 0.2978941949421574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6408159630166114d, y: 0.7594075447382757d), new NpgsqlTypes.NpgsqlPoint(x: 0.49118833931607964d, y: 0.13414954270376234d), new NpgsqlTypes.NpgsqlPoint(x: 0.18134451523395234d, y: 0.899895389451325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.515284290660073d, y: 0.48036600648455485d), new NpgsqlTypes.NpgsqlPoint(x: 0.22619143669717623d, y: 0.34424850887788516d), new NpgsqlTypes.NpgsqlPoint(x: 0.25216544080021885d, y: 0.17857343701322215d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6930306586551396d, y: 0.21907572594810132d), new NpgsqlTypes.NpgsqlPoint(x: 0.695623524402943d, y: 0.13980640533533506d), new NpgsqlTypes.NpgsqlPoint(x: 0.17554370767874927d, y: 0.29127781661930885d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3402766986534578d, y: 0.6891674305641025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666693105397997d, y: 0.1192756701303308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673095290940203d, y: 0.4040695132899428d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18210877379255275d, y: 0.8309162297619288d), new NpgsqlTypes.NpgsqlPoint(x: 0.17301580474424283d, y: 0.050414591435063216d), new NpgsqlTypes.NpgsqlPoint(x: 0.525394554794723d, y: 0.6785241419108856d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6448824904487535d, y: 0.3791460338889391d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173309506896963d, y: 0.07084466286676439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799998870339049d, y: 0.15308940735921683d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9367901440912382d, y: 0.10864356203114545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410004146850437d, y: 0.2773077521484112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970340742138767d, y: 0.5674672830744633d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5679829848337776d, y: 0.8561369843060996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132756209328439d, y: 0.6592016248502676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9193928109649374d, y: 0.7215402179665533d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28076399747430647d, y: 0.40553982273689326d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433977316852842d, y: 0.46069643512506264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531636489174915d, y: 0.37161665108036324d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8121274841780293d, y: 0.0249362845595692d), new NpgsqlTypes.NpgsqlPoint(x: 0.07014834532007541d, y: 0.9327372585337704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034994168017579d, y: 0.588502930836441d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11685326281634278d, y: 0.2534178863001719d), new NpgsqlTypes.NpgsqlPoint(x: 0.35589696805775484d, y: 0.47929906021436086d), new NpgsqlTypes.NpgsqlPoint(x: 0.17727913268568274d, y: 0.5129769922140158d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4735230315118555d, y: 0.4879077019172563d), new NpgsqlTypes.NpgsqlPoint(x: 0.14636490127431845d, y: 0.8357209765782363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116565978080761d, y: 0.20825929011967037d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7352210571429065d, y: 0.6058953948098377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854653603613185d, y: 0.8030367822416993d), new NpgsqlTypes.NpgsqlPoint(x: 0.31364702217642804d, y: 0.5478125330689952d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5296232943203317d, y: 0.9460246424330817d), new NpgsqlTypes.NpgsqlPoint(x: 0.1479328256781034d, y: 0.4501699237641503d), new NpgsqlTypes.NpgsqlPoint(x: 0.42511563615324044d, y: 0.01238718100481806d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7029393327537792d, y: 0.6187569933713011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708552731568592d, y: 0.32293818966678234d), new NpgsqlTypes.NpgsqlPoint(x: 0.014720886539169364d, y: 0.4597786443720294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9489348132863084d, y: 0.9568735897496518d), new NpgsqlTypes.NpgsqlPoint(x: 0.19614453610635774d, y: 0.9117822949337769d), new NpgsqlTypes.NpgsqlPoint(x: 0.036509950244656975d, y: 0.13449552564152456d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9917357825293623d, y: 0.38540336248087703d), new NpgsqlTypes.NpgsqlPoint(x: 0.904584443847793d, y: 0.06830740608807706d), new NpgsqlTypes.NpgsqlPoint(x: 0.41609624713152005d, y: 0.38856721962606866d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4542628871620207d, y: 0.113633684629591d), new NpgsqlTypes.NpgsqlPoint(x: 0.05808115196756691d, y: 0.02022206243776281d), new NpgsqlTypes.NpgsqlPoint(x: 0.46617538900167255d, y: 0.34983558409186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6698492403471448d, y: 0.7678742224206604d), new NpgsqlTypes.NpgsqlPoint(x: 0.19920431718867948d, y: 0.3000393670727446d), new NpgsqlTypes.NpgsqlPoint(x: 0.685239507550227d, y: 0.10726614434185555d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8699229691521208d, y: 0.6718018024982605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536573696367123d, y: 0.8033652578385642d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641699400683546d, y: 0.4241606385344082d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22099325414857607d, y: 0.9692304298871699d), new NpgsqlTypes.NpgsqlPoint(x: 0.2434819346471978d, y: 0.25705372027614815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325402562961912d, y: 0.5309896526169072d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22787049329521303d, y: 0.36040349656382287d), new NpgsqlTypes.NpgsqlPoint(x: 0.42994129008828874d, y: 0.6470948333296612d), new NpgsqlTypes.NpgsqlPoint(x: 0.42798622624706306d, y: 0.9457090846904284d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8217759107761688d, y: 0.6294475834333167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594545983080893d, y: 0.17454415942915025d), new NpgsqlTypes.NpgsqlPoint(x: 0.4331979909406267d, y: 0.42971123009766166d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4435182981552045d, y: 0.011142038163250212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422093060336232d, y: 0.902081755428605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3608499248646422d, y: 0.2281144876525375d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8680326358204978d, y: 0.8840833271453965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497223566877804d, y: 0.5450889209554004d), new NpgsqlTypes.NpgsqlPoint(x: 0.056906161974253355d, y: 0.9520609976596365d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5405355368671935d, y: 0.8667810581294267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4532949378376643d, y: 0.9641967377769347d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894751549974131d, y: 0.25519240233265217d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007039704241943334d, y: 0.6247531409318927d), new NpgsqlTypes.NpgsqlPoint(x: 0.09948051394303437d, y: 0.29584124323781824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957698850618813d, y: 0.4178217888884156d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15966112175116187d, y: 0.48713538938462775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8847504268500049d, y: 0.8915223615853424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881137358792608d, y: 0.7222030398786501d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27303566033132487d, y: 0.9389977657450951d), new NpgsqlTypes.NpgsqlPoint(x: 0.7470317199647538d, y: 0.133316423440084d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336501053492371d, y: 0.26549139954403145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.931305574794728d, y: 0.5870488847601563d), new NpgsqlTypes.NpgsqlPoint(x: 0.17208409948126846d, y: 0.7813899576160377d), new NpgsqlTypes.NpgsqlPoint(x: 0.17981071343745536d, y: 0.9265102761293363d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837958961959393d, y: 0.5880550429638717d), new NpgsqlTypes.NpgsqlPoint(x: 0.061871759973278095d, y: 0.2818583240541518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8264030579037877d, y: 0.9393297815969627d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9959454865704244d, y: 0.5607976943364517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3850233888279446d, y: 0.9785151006224371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118756915474594d, y: 0.4184234634826405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033065659283816995d, y: 0.3024210690753313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678511383665256d, y: 0.7918796321193811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173570533641075d, y: 0.021492208068159324d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07911941051238569d, y: 0.859097974586009d), new NpgsqlTypes.NpgsqlPoint(x: 0.07847666789754182d, y: 0.44601465794995643d), new NpgsqlTypes.NpgsqlPoint(x: 0.14008303219291496d, y: 0.7674172024173979d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7657686657348878d, y: 0.3777487931481083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641240898508081d, y: 0.5921918565308734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258888007932891d, y: 0.36567898023778755d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8694744851944368d, y: 0.5359639684558832d), new NpgsqlTypes.NpgsqlPoint(x: 0.34850193704173305d, y: 0.6382527108280424d), new NpgsqlTypes.NpgsqlPoint(x: 0.47137604904632346d, y: 0.6871529249740035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33920400138722373d, y: 0.028717622500844975d), new NpgsqlTypes.NpgsqlPoint(x: 0.39400956845100266d, y: 0.9629181217566373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054402689882427d, y: 0.6273690267009869d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3552018814252633d, y: 0.44385380737308466d), new NpgsqlTypes.NpgsqlPoint(x: 0.32731751378478524d, y: 0.2527411078346449d), new NpgsqlTypes.NpgsqlPoint(x: 0.34987993881754265d, y: 0.09112436200174479d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5503324043963439d, y: 0.8279592193182523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307937276371579d, y: 0.7072530501258764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491334436532003d, y: 0.5489086648892504d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7925208119347976d, y: 0.6104665569345289d), new NpgsqlTypes.NpgsqlPoint(x: 0.45779811373737045d, y: 0.4508883453811735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180232211207783d, y: 0.6887503183063439d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7057804894079714d, y: 0.5235750904784632d), new NpgsqlTypes.NpgsqlPoint(x: 0.06261989623058783d, y: 0.21841490684851883d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726203150661192d, y: 0.833270498502511d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0009066218074407217d, y: 0.3281055367426503d), new NpgsqlTypes.NpgsqlPoint(x: 0.11362021991984861d, y: 0.16743808666641413d), new NpgsqlTypes.NpgsqlPoint(x: 0.11612368389780892d, y: 0.19743602804718152d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5256742872914045d, y: 0.9258272057718693d), new NpgsqlTypes.NpgsqlPoint(x: 0.07856273338959885d, y: 0.5470433443482874d), new NpgsqlTypes.NpgsqlPoint(x: 0.046767974759200914d, y: 0.9751800807964649d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04569577794344615d, y: 0.032473882601029236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9421234191746177d, y: 0.8202372507493833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097022996425841d, y: 0.6919577796337193d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11875709857344896d, y: 0.6083931637295283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564529781830837d, y: 0.0392880286013545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754672460517039d, y: 0.6839693903904569d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22606159274417725d, y: 0.17941240727941732d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977737262400208d, y: 0.39909205608174625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495677717408529d, y: 0.20338230276478675d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38884098266286815d, y: 0.4704854302427026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9830703965582293d, y: 0.6042189559430118d), new NpgsqlTypes.NpgsqlPoint(x: 0.37116879569144134d, y: 0.7351174362059449d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7297835554710663d, y: 0.8458735459310036d), new NpgsqlTypes.NpgsqlPoint(x: 0.667887697516786d, y: 0.4237059241483645d), new NpgsqlTypes.NpgsqlPoint(x: 0.22812775086944326d, y: 0.7058968563575121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9133289067929367d, y: 0.6343336558648934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628727721529137d, y: 0.47780894517448946d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241022967605373d, y: 0.12129980385324046d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1754307703893222d, y: 0.6290306400311229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5377197182259835d, y: 0.16866294394817538d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623154881413773d, y: 0.7682008330826823d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5944626902307376d, y: 0.041198629723629754d), new NpgsqlTypes.NpgsqlPoint(x: 0.42532937882838695d, y: 0.13270499360629207d), new NpgsqlTypes.NpgsqlPoint(x: 0.14221532166519057d, y: 0.9454791053858073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41314481634537725d, y: 0.37553720574605576d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537887014525994d, y: 0.48978815901925976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903924464282269d, y: 0.6802450614763472d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6847633096910126d, y: 0.5427346780616245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000780833022969d, y: 0.02602253140963362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722869881212769d, y: 0.5925464132695971d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1711715241739309d, y: 0.2644500839099382d), new NpgsqlTypes.NpgsqlPoint(x: 0.1282809069834997d, y: 0.3856631043779001d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166302642902063d, y: 0.07329559198519353d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21876928519119143d, y: 0.5799886188785586d), new NpgsqlTypes.NpgsqlPoint(x: 0.25963741337572477d, y: 0.24129239661976853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8840963677570667d, y: 0.5159800689737524d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22506346721991188d, y: 0.815444966186921d), new NpgsqlTypes.NpgsqlPoint(x: 0.26174599003499566d, y: 0.5199665055550475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5985880782973267d, y: 0.655850949250613d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3745017056760913d, y: 0.5536099062684647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5191756586459552d, y: 0.23386628664019193d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241742576142488d, y: 0.16484670890511577d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2780140552764042d, y: 0.6268248040787279d), new NpgsqlTypes.NpgsqlPoint(x: 0.5383052945328274d, y: 0.11295885386460125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813795194063372d, y: 0.7313018170458488d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3987793713799237d, y: 0.278728338699347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05752827180475828d, y: 0.8681300932838772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283593309958168d, y: 0.5247382672929025d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6417846372495213d, y: 0.6540011204812914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443443954828114d, y: 0.30896378570075145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363657845249697d, y: 0.9809410698477237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22313519557286776d, y: 0.4587732403442034d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554368582718974d, y: 0.7857027461443494d), new NpgsqlTypes.NpgsqlPoint(x: 0.20188166944707375d, y: 0.787344839027633d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8284645599354117d, y: 0.34349723694300904d), new NpgsqlTypes.NpgsqlPoint(x: 0.008741520791720081d, y: 0.9754388472777134d), new NpgsqlTypes.NpgsqlPoint(x: 0.02451927968769374d, y: 0.46845228144692863d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8386477323784451d, y: 0.4599118278874684d), new NpgsqlTypes.NpgsqlPoint(x: 0.28844474284115096d, y: 0.31528061889115555d), new NpgsqlTypes.NpgsqlPoint(x: 0.001359979172102399d, y: 0.36028930595555875d)),

},
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 131, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[29], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 1, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 116, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 15, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 101, query2))
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[29], false);
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
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 97, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 24, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatch(connection, 61, 72))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray2M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

