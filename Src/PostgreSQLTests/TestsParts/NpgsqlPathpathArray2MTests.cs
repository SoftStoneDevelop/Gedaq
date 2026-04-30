

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
    internal partial interface INpgsqlPathListpathArray
    {
    }
    
    internal partial class NpgsqlPathListpathArray : INpgsqlPathListpathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray2M[] _testData = new NpgsqlPathpathArray2M[]
        {
            new NpgsqlPathpathArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592890795097794d, y: 0.5781546399472447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973823149557933d, y: 0.7015858566358467d), new NpgsqlTypes.NpgsqlPoint(x: 0.24911545072948016d, y: 0.395119411583425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039191375512653615d, y: 0.7157705633928149d), new NpgsqlTypes.NpgsqlPoint(x: 0.3558472482202597d, y: 0.6972288051734082d), new NpgsqlTypes.NpgsqlPoint(x: 0.13663175532120364d, y: 0.32417084234848803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.707203760350569d, y: 0.901551010950519d), new NpgsqlTypes.NpgsqlPoint(x: 0.13137192985412205d, y: 0.6564408907779095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428698604704133d, y: 0.910228506479374d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48110323340715233d, y: 0.1391069668247159d), new NpgsqlTypes.NpgsqlPoint(x: 0.2639222027429524d, y: 0.1359780365242217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827720406596804d, y: 0.12497129038629862d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37528684506553533d, y: 0.6519988060459349d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178633521251293d, y: 0.8737249455768872d), new NpgsqlTypes.NpgsqlPoint(x: 0.1851047967143452d, y: 0.24467032953828738d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.839988312655524d, y: 0.1318195446388697d), new NpgsqlTypes.NpgsqlPoint(x: 0.17513776655566082d, y: 0.7731446362214554d), new NpgsqlTypes.NpgsqlPoint(x: 0.413760981557144d, y: 0.2151015538841533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45763799088270773d, y: 0.8316906207665002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593936452080326d, y: 0.7026614135802973d), new NpgsqlTypes.NpgsqlPoint(x: 0.06557757259344255d, y: 0.40034128040769934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14281906965561875d, y: 0.26621081250185485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519938731844954d, y: 0.7636585588697454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471270586383737d, y: 0.653611794512919d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005126570358630844d, y: 0.41807128290828643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3569098600539259d, y: 0.9831815010400528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8803298689234892d, y: 0.8318219716443606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34222496806197633d, y: 0.6803142874561219d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208157174957485d, y: 0.8313509527034202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7355272626832866d, y: 0.9862576316406894d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7048186570527903d, y: 0.46319842150441326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5698054132653316d, y: 0.6896336463293345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780588837918869d, y: 0.24279217844208023d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9173316572975675d, y: 0.7963769900240937d), new NpgsqlTypes.NpgsqlPoint(x: 0.869083406149947d, y: 0.9087759054941338d), new NpgsqlTypes.NpgsqlPoint(x: 0.31429244748778307d, y: 0.22262572876345443d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3259388649384435d, y: 0.12573093401701563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9943023534692176d, y: 0.4868216873388641d), new NpgsqlTypes.NpgsqlPoint(x: 0.23126371794997824d, y: 0.4711791047472106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5038615834587382d, y: 0.0346232356435614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8764058864520291d, y: 0.3861149622329252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6924952750863422d, y: 0.3280651971189399d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7386496193839368d, y: 0.25874287874572954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2348004554385582d, y: 0.7679590402077177d), new NpgsqlTypes.NpgsqlPoint(x: 0.06658152440097953d, y: 0.43808958686535016d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2748371791078694d, y: 0.8973121967393949d), new NpgsqlTypes.NpgsqlPoint(x: 0.011698290732679806d, y: 0.060796469551610555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666504304044731d, y: 0.10792956700334189d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07666000704142939d, y: 0.8730427259290238d), new NpgsqlTypes.NpgsqlPoint(x: 0.5458117908048906d, y: 0.153332460879954d), new NpgsqlTypes.NpgsqlPoint(x: 0.04617007207486845d, y: 0.5278484688092048d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.859401312417595d, y: 0.753294645935659d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097448052158338d, y: 0.8366380959450058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8225724175311582d, y: 0.47803999012079723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5301423937027311d, y: 0.673829441430366d), new NpgsqlTypes.NpgsqlPoint(x: 0.28062862778054987d, y: 0.6623341655586418d), new NpgsqlTypes.NpgsqlPoint(x: 0.0728416868981534d, y: 0.9704051052101889d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890155572467768d, y: 0.20850620767803174d), new NpgsqlTypes.NpgsqlPoint(x: 0.891808799648185d, y: 0.05610116077873528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704222224212076d, y: 0.650910354698181d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.911118118223431d, y: 0.9123468144266141d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179057262552589d, y: 0.563947052280388d), new NpgsqlTypes.NpgsqlPoint(x: 0.229746549144627d, y: 0.7979768651705086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5032461205960416d, y: 0.17384833910517383d), new NpgsqlTypes.NpgsqlPoint(x: 0.28443611489591325d, y: 0.09656765496207875d), new NpgsqlTypes.NpgsqlPoint(x: 0.41246791920256554d, y: 0.14896664444301777d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8227044746662723d, y: 0.6090121173240143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528174984490071d, y: 0.9720356135032406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21523766268334776d, y: 0.9210196054879886d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.457472897714129d, y: 0.11891763807789946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784793002595188d, y: 0.7516783534577113d), new NpgsqlTypes.NpgsqlPoint(x: 0.06693296600253762d, y: 0.2210925736783429d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9262520503708049d, y: 0.43928293889767667d), new NpgsqlTypes.NpgsqlPoint(x: 0.4381448057506573d, y: 0.5874635143839382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9299468167780067d, y: 0.23547325042567935d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2467262075679817d, y: 0.6004311682099539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769087611759013d, y: 0.3884501738357242d), new NpgsqlTypes.NpgsqlPoint(x: 0.24455297923270658d, y: 0.902465929512882d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1387441346502114d, y: 0.8077629281560399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9632159698608234d, y: 0.48960162320205947d), new NpgsqlTypes.NpgsqlPoint(x: 0.39008253677964333d, y: 0.34123548027869977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1012060150948002d, y: 0.7519506676648499d), new NpgsqlTypes.NpgsqlPoint(x: 0.12836278144516056d, y: 0.5252381082553362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8410436267574005d, y: 0.8215203127918154d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2679413780995813d, y: 0.45404251754899283d), new NpgsqlTypes.NpgsqlPoint(x: 0.12471117056886305d, y: 0.47856435877857784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9368725861966316d, y: 0.37149961252583574d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05218630698379301d, y: 0.6483759969444071d), new NpgsqlTypes.NpgsqlPoint(x: 0.21135624464553138d, y: 0.9863428460390543d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911929522504671d, y: 0.04057762293028966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15861986694112085d, y: 0.08142102374499405d), new NpgsqlTypes.NpgsqlPoint(x: 0.07421710263546821d, y: 0.849606187006878d), new NpgsqlTypes.NpgsqlPoint(x: 0.06367544448616269d, y: 0.42853980631403243d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21962035506095012d, y: 0.8620994592807297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364015013123612d, y: 0.08984481788102683d), new NpgsqlTypes.NpgsqlPoint(x: 0.02614488185765551d, y: 0.6485793511019102d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284248322079103d, y: 0.7366808494614474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290111043731069d, y: 0.5720429949791748d), new NpgsqlTypes.NpgsqlPoint(x: 0.22278234054441548d, y: 0.5005369543990892d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6888533689777527d, y: 0.7227639790394413d), new NpgsqlTypes.NpgsqlPoint(x: 0.4786438785258943d, y: 0.06291276508259425d), new NpgsqlTypes.NpgsqlPoint(x: 0.890837341298867d, y: 0.0622278215824027d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4636466156176796d, y: 0.13748426643440192d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279496426670695d, y: 0.11090050852467948d), new NpgsqlTypes.NpgsqlPoint(x: 0.4865681093580285d, y: 0.7459859494210391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5577691920087964d, y: 0.5215033249176015d), new NpgsqlTypes.NpgsqlPoint(x: 0.2721773157274078d, y: 0.18456495336928125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764143958656348d, y: 0.014265633799968702d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6131789624161462d, y: 0.2903843975067759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6420167167366229d, y: 0.13164256689832832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449113922057914d, y: 0.8116804527161944d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6298704861638402d, y: 0.6047109516797662d), new NpgsqlTypes.NpgsqlPoint(x: 0.3874219754291097d, y: 0.036125416518572484d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624125834668611d, y: 0.6668652371917323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.75982229525278d, y: 0.9833164045444283d), new NpgsqlTypes.NpgsqlPoint(x: 0.16106599356746198d, y: 0.7173206830401625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820296563786316d, y: 0.648137027960129d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4326916993611055d, y: 0.889689112508693d), new NpgsqlTypes.NpgsqlPoint(x: 0.5740479837277758d, y: 0.6007253389217077d), new NpgsqlTypes.NpgsqlPoint(x: 0.39647643650777464d, y: 0.4583776850268988d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6104038325332706d, y: 0.6014278069071848d), new NpgsqlTypes.NpgsqlPoint(x: 0.42883705920394943d, y: 0.09958978307682365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4433903559611224d, y: 0.06073813631071123d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7425871388108688d, y: 0.15335065323638286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194158064318594d, y: 0.1877283063048707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668723556350728d, y: 0.1421949442956958d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1949368951494288d, y: 0.21155246275637307d), new NpgsqlTypes.NpgsqlPoint(x: 0.020387997327204865d, y: 0.5659432941255195d), new NpgsqlTypes.NpgsqlPoint(x: 0.05979379814708019d, y: 0.5785205099162118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21008093621212276d, y: 0.68236011828993d), new NpgsqlTypes.NpgsqlPoint(x: 0.15833375991467136d, y: 0.4131352428417172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525768398651877d, y: 0.8255871950289473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13850290294014045d, y: 0.8398912470978789d), new NpgsqlTypes.NpgsqlPoint(x: 0.31728647211514815d, y: 0.17705698750350707d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228236887140739d, y: 0.37606757053029227d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3744990843157724d, y: 0.7191439812756031d), new NpgsqlTypes.NpgsqlPoint(x: 0.36467017300066495d, y: 0.06665346286919749d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912059298770472d, y: 0.4372928731233696d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11486678321485311d, y: 0.31679766367275064d), new NpgsqlTypes.NpgsqlPoint(x: 0.27881550320896165d, y: 0.7102703445239315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244414503185664d, y: 0.27586687362698714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9296212936125277d, y: 0.9004020502439424d), new NpgsqlTypes.NpgsqlPoint(x: 0.2789884862504368d, y: 0.47258573807483284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5528851882318926d, y: 0.23370821402116526d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7285500922110982d, y: 0.11342697704908178d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902318002947747d, y: 0.6038012831689831d), new NpgsqlTypes.NpgsqlPoint(x: 0.46300385327696647d, y: 0.20422210513007533d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.025539756817608672d, y: 0.465127015399871d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388354330031881d, y: 0.09682415942115119d), new NpgsqlTypes.NpgsqlPoint(x: 0.06083681082363768d, y: 0.6051171467638493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012056604683120309d, y: 0.17512593022152434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8036581291549809d, y: 0.8672252597434544d), new NpgsqlTypes.NpgsqlPoint(x: 0.04615634873717456d, y: 0.29474793993965165d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1411540407050924d, y: 0.049050485111944764d), new NpgsqlTypes.NpgsqlPoint(x: 0.2894925655696793d, y: 0.971599400768644d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688377163386973d, y: 0.3763392890045322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6698613194719157d, y: 0.17740108514488817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577669336760587d, y: 0.14155966056135172d), new NpgsqlTypes.NpgsqlPoint(x: 0.04308041719836686d, y: 0.915775838064493d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7987267680633181d, y: 0.2623211159204758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381453997101343d, y: 0.2365693672452266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335390578387068d, y: 0.5281683061736279d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31642970898303d, y: 0.9879656669621166d), new NpgsqlTypes.NpgsqlPoint(x: 0.21981158004307833d, y: 0.6329305026914158d), new NpgsqlTypes.NpgsqlPoint(x: 0.30423556856421863d, y: 0.5440486851075963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7575304370856286d, y: 0.9141824092854581d), new NpgsqlTypes.NpgsqlPoint(x: 0.22579771519579517d, y: 0.3463411646863467d), new NpgsqlTypes.NpgsqlPoint(x: 0.934888421161032d, y: 0.9362897042976228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546490840023658d, y: 0.07728592028353232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9997194459126855d, y: 0.7338893109797194d), new NpgsqlTypes.NpgsqlPoint(x: 0.09048696730185901d, y: 0.6989024849735254d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6202973836840537d, y: 0.4146901982888258d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576574582299981d, y: 0.9679013248940785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644696401868632d, y: 0.891068155354107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029022181819213344d, y: 0.047288862336336335d), new NpgsqlTypes.NpgsqlPoint(x: 0.08749719070644812d, y: 0.3130374588053956d), new NpgsqlTypes.NpgsqlPoint(x: 0.4155936075242539d, y: 0.6523785516768003d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21487247610780313d, y: 0.8807268900097501d), new NpgsqlTypes.NpgsqlPoint(x: 0.1717287855790628d, y: 0.062293530911345374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6254432503690873d, y: 0.25437858839498195d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4217571899613022d, y: 0.40184372219041997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577148053254859d, y: 0.10447919539273265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159463787013576d, y: 0.43414358972138956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2121357694600673d, y: 0.3961161514238225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5612876082586844d, y: 0.12995659156562556d), new NpgsqlTypes.NpgsqlPoint(x: 0.22546999402304568d, y: 0.19744224472509853d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18692110901407866d, y: 0.6608834540297372d), new NpgsqlTypes.NpgsqlPoint(x: 0.6821144880411341d, y: 0.8411124414543698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209514415673866d, y: 0.7089933859688916d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43845160923666326d, y: 0.11779974987925446d), new NpgsqlTypes.NpgsqlPoint(x: 0.009798408317981955d, y: 0.5003496652346787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976581099539282d, y: 0.16504475543801367d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.565449630852454d, y: 0.3347774253258399d), new NpgsqlTypes.NpgsqlPoint(x: 0.05816405776562106d, y: 0.7379380442347124d), new NpgsqlTypes.NpgsqlPoint(x: 0.013629328813454356d, y: 0.21904830663285768d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7598576985972674d, y: 0.4754348347897849d), new NpgsqlTypes.NpgsqlPoint(x: 0.1499442505124895d, y: 0.8524975734648111d), new NpgsqlTypes.NpgsqlPoint(x: 0.6895943154769026d, y: 0.6100028080717378d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6755098392903194d, y: 0.784601508815335d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944021107154442d, y: 0.5466037449673082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6304277177004352d, y: 0.19689206453408592d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8169249406962066d, y: 0.3221290801626009d), new NpgsqlTypes.NpgsqlPoint(x: 0.09819185403611286d, y: 0.9475628924808114d), new NpgsqlTypes.NpgsqlPoint(x: 0.05698791492659461d, y: 0.25230043905056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44698594855266216d, y: 0.28074980394592397d), new NpgsqlTypes.NpgsqlPoint(x: 0.15673473247521696d, y: 0.05419895348168491d), new NpgsqlTypes.NpgsqlPoint(x: 0.08956211761545518d, y: 0.6651960896139031d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5073156183966102d, y: 0.807748117019513d), new NpgsqlTypes.NpgsqlPoint(x: 0.39182938810937695d, y: 0.2185155064686578d), new NpgsqlTypes.NpgsqlPoint(x: 0.39594087115544163d, y: 0.26687952866738507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6376417573828973d, y: 0.7695113332619776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3810321644809417d, y: 0.9320186316075001d), new NpgsqlTypes.NpgsqlPoint(x: 0.31251918654113264d, y: 0.46182527267209705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16194942152548852d, y: 0.8109069811002008d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679630741977846d, y: 0.019521389128849265d), new NpgsqlTypes.NpgsqlPoint(x: 0.22263844124148668d, y: 0.11785914433712186d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049759280929027594d, y: 0.5559237877551577d), new NpgsqlTypes.NpgsqlPoint(x: 0.17742476870077328d, y: 0.4675446201326553d), new NpgsqlTypes.NpgsqlPoint(x: 0.19590343737614435d, y: 0.85601111890173d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41007250276326446d, y: 0.28440217424525904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6083435474397834d, y: 0.2640397691819728d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516810641458487d, y: 0.43139188017605257d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9172104733122198d, y: 0.4957987106700593d), new NpgsqlTypes.NpgsqlPoint(x: 0.16637605466155847d, y: 0.5259478104178306d), new NpgsqlTypes.NpgsqlPoint(x: 0.47107824177423174d, y: 0.35787947542563225d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.516464131817111d, y: 0.7024362211148693d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640685392148332d, y: 0.5304660479498083d), new NpgsqlTypes.NpgsqlPoint(x: 0.23732322052858368d, y: 0.08220475566182206d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3251294260710208d, y: 0.7490655626160063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7685468564054327d, y: 0.6249372232703648d), new NpgsqlTypes.NpgsqlPoint(x: 0.27729934129644485d, y: 0.6108385183592412d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23115846747792645d, y: 0.09743287784336174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5366105501542935d, y: 0.11536053568798832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559485994964675d, y: 0.29986904799983205d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7835863758832688d, y: 0.42162863770212766d), new NpgsqlTypes.NpgsqlPoint(x: 0.9727178248786342d, y: 0.42277933670696055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6513483113529844d, y: 0.8446257200820317d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6888731149127801d, y: 0.5766495967580546d), new NpgsqlTypes.NpgsqlPoint(x: 0.9554659470803939d, y: 0.498428925539689d), new NpgsqlTypes.NpgsqlPoint(x: 0.49278545634812143d, y: 0.8970008350144741d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7165744201752869d, y: 0.29239555374733106d), new NpgsqlTypes.NpgsqlPoint(x: 0.12393687264880182d, y: 0.6595542116071155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322342468479187d, y: 0.22982205500151653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9825995384302199d, y: 0.7967252662340821d), new NpgsqlTypes.NpgsqlPoint(x: 0.027146964397276263d, y: 0.5057394384834599d), new NpgsqlTypes.NpgsqlPoint(x: 0.2151146232274017d, y: 0.8146186657750781d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9284760143343691d, y: 0.022829079014479947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080454731436465d, y: 0.2696343249046791d), new NpgsqlTypes.NpgsqlPoint(x: 0.16558190590603472d, y: 0.7934872558042969d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602600183901526d, y: 0.03244891839724828d), new NpgsqlTypes.NpgsqlPoint(x: 0.04251748682373535d, y: 0.512346366860492d), new NpgsqlTypes.NpgsqlPoint(x: 0.440385926760429d, y: 0.6924004177196703d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8823772276544937d, y: 0.10077703548450256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732863601964811d, y: 0.5303229409964466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816957608199306d, y: 0.03961405556248421d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9700593238099451d, y: 0.5621355286074416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6310036346520572d, y: 0.49446220600665924d), new NpgsqlTypes.NpgsqlPoint(x: 0.29201187107645754d, y: 0.9841806831058216d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5141364392433404d, y: 0.7619560565145503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7322760759919008d, y: 0.33791797292759473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974700632210663d, y: 0.8886423331296249d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.791386259392233d, y: 0.1056224719385751d), new NpgsqlTypes.NpgsqlPoint(x: 0.08549698030795172d, y: 0.8099497982655377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069348123152834d, y: 0.08291559580616403d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07757469294022401d, y: 0.11190034080381872d), new NpgsqlTypes.NpgsqlPoint(x: 0.23432044592105727d, y: 0.94058494785733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7342546690649522d, y: 0.4462535381077384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39224603251077006d, y: 0.5968652939061987d), new NpgsqlTypes.NpgsqlPoint(x: 0.047661024721432854d, y: 0.842842297348472d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673758348924433d, y: 0.1469672962740638d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10863311183271473d, y: 0.6893429913728379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177737543851019d, y: 0.22814542679318106d), new NpgsqlTypes.NpgsqlPoint(x: 0.648874647645499d, y: 0.7866210618044384d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0863785391840759d, y: 0.304699333891545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110819848145682d, y: 0.534709067347139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572263299959076d, y: 0.1796633594956658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6803527175245117d, y: 0.21758556579659172d), new NpgsqlTypes.NpgsqlPoint(x: 0.591756972931007d, y: 0.7760486868910622d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648492274154438d, y: 0.47755711509211185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9281533035736467d, y: 0.3208785912570993d), new NpgsqlTypes.NpgsqlPoint(x: 0.3705288962130323d, y: 0.2248166777829168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845053989862275d, y: 0.978176132405178d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17901643008372392d, y: 0.5086350077752977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696712452717755d, y: 0.7257331896812829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519292161765891d, y: 0.6000162466925871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7049238951866614d, y: 0.7983874115215442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082875457704383d, y: 0.1562451753312334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568116364739342d, y: 0.8826043683835966d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3488481283459747d, y: 0.008239660694502327d), new NpgsqlTypes.NpgsqlPoint(x: 0.44768048548161277d, y: 0.8493139805298221d), new NpgsqlTypes.NpgsqlPoint(x: 0.537573881124692d, y: 0.9381208383118005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18503375826612634d, y: 0.6538761318377162d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595963846144088d, y: 0.011399319294528087d), new NpgsqlTypes.NpgsqlPoint(x: 0.942930598553896d, y: 0.0532724470864786d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9636506574968988d, y: 0.5482807622277897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8135249914777211d, y: 0.8015810816794977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5392572180915978d, y: 0.37793010755204104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2950720283047631d, y: 0.8972261693958359d), new NpgsqlTypes.NpgsqlPoint(x: 0.20707452339732202d, y: 0.8785974321739336d), new NpgsqlTypes.NpgsqlPoint(x: 0.46781398356275505d, y: 0.9322796756154599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23680015875575444d, y: 0.31926422676977073d), new NpgsqlTypes.NpgsqlPoint(x: 0.6161460827710368d, y: 0.6560726703829011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544222456469396d, y: 0.638814127737929d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8533349686374634d, y: 0.4287860606189585d), new NpgsqlTypes.NpgsqlPoint(x: 0.025280768642602314d, y: 0.017254759964044575d), new NpgsqlTypes.NpgsqlPoint(x: 0.026184941376750315d, y: 0.9223267148317117d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14177560854390925d, y: 0.05041370122622846d), new NpgsqlTypes.NpgsqlPoint(x: 0.07535699100957849d, y: 0.464464984701628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836879892819477d, y: 0.7239326458203706d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8680879728643536d, y: 0.6549692251931369d), new NpgsqlTypes.NpgsqlPoint(x: 0.42880412193369666d, y: 0.49393826882434966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766235507602196d, y: 0.3294319813421308d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22884972429678363d, y: 0.1442917917359554d), new NpgsqlTypes.NpgsqlPoint(x: 0.12996983754805724d, y: 0.5397945460876612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628660000527697d, y: 0.004612134827340686d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9955913495396154d, y: 0.11612355939342178d), new NpgsqlTypes.NpgsqlPoint(x: 0.10900493570151681d, y: 0.9841557270645249d), new NpgsqlTypes.NpgsqlPoint(x: 0.910888235856408d, y: 0.8040375154142522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5070755425590703d, y: 0.9250478972964142d), new NpgsqlTypes.NpgsqlPoint(x: 0.9982981881431701d, y: 0.1927573608187969d), new NpgsqlTypes.NpgsqlPoint(x: 0.1798812778150808d, y: 0.8438796660052529d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6684792544196383d, y: 0.9129823686690254d), new NpgsqlTypes.NpgsqlPoint(x: 0.21088850333787945d, y: 0.6578722515586392d), new NpgsqlTypes.NpgsqlPoint(x: 0.6474415088241391d, y: 0.7439938784094043d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37123711182986585d, y: 0.053934046559120596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445289542135382d, y: 0.5574170793521562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788222233481157d, y: 0.41753098928703647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9695287354295575d, y: 0.8071457027627946d), new NpgsqlTypes.NpgsqlPoint(x: 0.13959238897964488d, y: 0.27021156014572045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9732311087968472d, y: 0.3602342413819023d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307224912336443d, y: 0.3638107444026346d), new NpgsqlTypes.NpgsqlPoint(x: 0.059849288328166494d, y: 0.640674931525224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8214817385209163d, y: 0.23624731550230704d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5092684808202202d, y: 0.6438675454088121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358152403945811d, y: 0.6878417887809284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516377502780579d, y: 0.047386897664645766d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47713852814810664d, y: 0.5751800317264748d), new NpgsqlTypes.NpgsqlPoint(x: 0.12250419292232062d, y: 0.9259892799452788d), new NpgsqlTypes.NpgsqlPoint(x: 0.402283852857488d, y: 0.5047838436413425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.473831517720705d, y: 0.9851830517994017d), new NpgsqlTypes.NpgsqlPoint(x: 0.12506616631543488d, y: 0.8633255419517253d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286501978354873d, y: 0.8464284650822842d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.733249910792933d, y: 0.484945758975864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586749508253294d, y: 0.6286063067270123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401727607358967d, y: 0.7698672045091564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3440016568573837d, y: 0.3056238644953688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256522288470345d, y: 0.8122794252535449d), new NpgsqlTypes.NpgsqlPoint(x: 0.38606761104987974d, y: 0.9094606966745794d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17542785914858283d, y: 0.8462932943587755d), new NpgsqlTypes.NpgsqlPoint(x: 0.693823003424081d, y: 0.2114338037305873d), new NpgsqlTypes.NpgsqlPoint(x: 0.1378673354550045d, y: 0.4801282721550908d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.534767625784693d, y: 0.23424234514406694d), new NpgsqlTypes.NpgsqlPoint(x: 0.556207003026262d, y: 0.5161671880889868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701017493361654d, y: 0.5574961249348438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2886090393405579d, y: 0.1452626888432278d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116552833616813d, y: 0.8310557364707745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920452386924665d, y: 0.32109768157726026d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12533293308042714d, y: 0.2950077055721144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127212413144933d, y: 0.0793022024426665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679120489060187d, y: 0.8592871094695183d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6329550335354635d, y: 0.15756725554332562d), new NpgsqlTypes.NpgsqlPoint(x: 0.4814095600880903d, y: 0.6681006275796786d), new NpgsqlTypes.NpgsqlPoint(x: 0.13376181066321957d, y: 0.16961568375952418d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41568899132106274d, y: 0.8536748676716782d), new NpgsqlTypes.NpgsqlPoint(x: 0.17726346663507087d, y: 0.5236448249019763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5480769338511406d, y: 0.3165067824980775d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.82945404769096d, y: 0.2493611749052551d), new NpgsqlTypes.NpgsqlPoint(x: 0.22881178936969093d, y: 0.6106169648382777d), new NpgsqlTypes.NpgsqlPoint(x: 0.26449340270141775d, y: 0.26833183592380083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11889993494116213d, y: 0.6212264366492518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617063039976101d, y: 0.9562634961220733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3691033783926634d, y: 0.615097880209411d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20330723127466077d, y: 0.6976197560651427d), new NpgsqlTypes.NpgsqlPoint(x: 0.3445969988096462d, y: 0.7180660174095722d), new NpgsqlTypes.NpgsqlPoint(x: 0.41646934663519597d, y: 0.6934692097454596d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28358314628838965d, y: 0.02894859923734905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430254594248335d, y: 0.1995202315246708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3932612891079651d, y: 0.6100188936756221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.814711401145961d, y: 0.3810578299217263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388849998494556d, y: 0.2639423457860046d), new NpgsqlTypes.NpgsqlPoint(x: 0.840689181153174d, y: 0.8912793861045043d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.419104032197667d, y: 0.5395123653481264d), new NpgsqlTypes.NpgsqlPoint(x: 0.47724934883683623d, y: 0.9893983922808879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4404211299782891d, y: 0.8639682216117721d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6771011083426914d, y: 0.5477506406593281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364178549350153d, y: 0.5369212105994494d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966873300883308d, y: 0.36373133351635034d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12767907978288728d, y: 0.9842109957630416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8360889971970231d, y: 0.8979477806139259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640046124080008d, y: 0.13977348791816324d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6139335154352845d, y: 0.8928590450605225d), new NpgsqlTypes.NpgsqlPoint(x: 0.20162299481788848d, y: 0.8080986711723236d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017402233061734051d, y: 0.1058933775222175d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5252638856464662d, y: 0.9749935707494627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112831928557796d, y: 0.7979292609757399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487518839061755d, y: 0.23814145151598254d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32127244854366355d, y: 0.06862065126741612d), new NpgsqlTypes.NpgsqlPoint(x: 0.0918080692757921d, y: 0.28706613189408425d), new NpgsqlTypes.NpgsqlPoint(x: 0.19019791272889852d, y: 0.8612620529087872d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8619714727932721d, y: 0.8675962477733067d), new NpgsqlTypes.NpgsqlPoint(x: 0.08878137892431903d, y: 0.5332694909935598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488605271719743d, y: 0.24962136772325116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1659130939606276d, y: 0.1893193297366651d), new NpgsqlTypes.NpgsqlPoint(x: 0.07127155756604142d, y: 0.5292570581026723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569478748525989d, y: 0.23627930089889593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7586531921389887d, y: 0.5036455968310334d), new NpgsqlTypes.NpgsqlPoint(x: 0.2464728100822441d, y: 0.2632821046206091d), new NpgsqlTypes.NpgsqlPoint(x: 0.29554876674124153d, y: 0.557093770343886d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8447894076895557d, y: 0.9887864688581611d), new NpgsqlTypes.NpgsqlPoint(x: 0.3072323918471228d, y: 0.7598216640285905d), new NpgsqlTypes.NpgsqlPoint(x: 0.031975874719253894d, y: 0.751889987286671d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4693921009336852d, y: 0.41708662265159346d), new NpgsqlTypes.NpgsqlPoint(x: 0.12933117495446167d, y: 0.5672487024420632d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272225700691098d, y: 0.4100157933221662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9488561915935827d, y: 0.8630245463694053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4138280532693346d, y: 0.9840583476338912d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939392377610959d, y: 0.042092077300622144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.185104297308206d, y: 0.3099533130839872d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981286178773633d, y: 0.25122963289123323d), new NpgsqlTypes.NpgsqlPoint(x: 0.273159800512508d, y: 0.7338938390967679d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9681558181290604d, y: 0.6170773019066713d), new NpgsqlTypes.NpgsqlPoint(x: 0.47020746648674816d, y: 0.7579530964985579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352928578740604d, y: 0.44544063883631535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7337505930908699d, y: 0.7500596205019483d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456690850379303d, y: 0.7620884630134118d), new NpgsqlTypes.NpgsqlPoint(x: 0.3091744540492969d, y: 0.6848066123235325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04095200697555157d, y: 0.3754738191234702d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908113878711609d, y: 0.9248634937872382d), new NpgsqlTypes.NpgsqlPoint(x: 0.4037471941995151d, y: 0.7392137938548331d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5344024357410673d, y: 0.46556933111634247d), new NpgsqlTypes.NpgsqlPoint(x: 0.21620956881720743d, y: 0.05805894843891024d), new NpgsqlTypes.NpgsqlPoint(x: 0.27552014302531136d, y: 0.4010309112233772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33207310886090746d, y: 0.05914686538682945d), new NpgsqlTypes.NpgsqlPoint(x: 0.19245461328627678d, y: 0.6854257702640556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595023974391539d, y: 0.10891511565961465d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7199467848343328d, y: 0.5221870010103459d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067827179652024d, y: 0.6948644595296335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209738374088935d, y: 0.5247193911312384d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3555566989749541d, y: 0.998456747137983d), new NpgsqlTypes.NpgsqlPoint(x: 0.3928008191989899d, y: 0.29417539201823506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453574719135882d, y: 0.05534888426426121d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6804804204158365d, y: 0.33272907226058d), new NpgsqlTypes.NpgsqlPoint(x: 0.4746652051916356d, y: 0.09316898583350797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2816576612561933d, y: 0.2992283831036734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5005834705360422d, y: 0.6670636668484391d), new NpgsqlTypes.NpgsqlPoint(x: 0.3899385053673605d, y: 0.08588664676721769d), new NpgsqlTypes.NpgsqlPoint(x: 0.796849871621072d, y: 0.4839342920470606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7940001254746827d, y: 0.46468716804786325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6643347936914172d, y: 0.5765102486303234d), new NpgsqlTypes.NpgsqlPoint(x: 0.8059542433072652d, y: 0.9441729415250958d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6443752804479145d, y: 0.7478017675574803d), new NpgsqlTypes.NpgsqlPoint(x: 0.25381334337118955d, y: 0.6855124166226059d), new NpgsqlTypes.NpgsqlPoint(x: 0.13038179912161074d, y: 0.4998994335362337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3237554450292629d, y: 0.8445479050110344d), new NpgsqlTypes.NpgsqlPoint(x: 0.3870852921387592d, y: 0.9362125176140339d), new NpgsqlTypes.NpgsqlPoint(x: 0.46932436988091986d, y: 0.19617606960118483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8919196501640065d, y: 0.5941149498143631d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721781135667025d, y: 0.35953474028737287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048855946484192d, y: 0.8080669227411528d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1050015944829289d, y: 0.8676618325297207d), new NpgsqlTypes.NpgsqlPoint(x: 0.37783841727853484d, y: 0.04751342461030372d), new NpgsqlTypes.NpgsqlPoint(x: 0.06944161477175959d, y: 0.4505408678952302d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3943538308493111d, y: 0.8062531858633133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315720317546465d, y: 0.7747334964896702d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518457101910296d, y: 0.5753280852116415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9634566882463583d, y: 0.1389883486077954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110528954367682d, y: 0.6487642440305403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065241566445465d, y: 0.06670655523954871d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4746056183597993d, y: 0.9022040796247616d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153372240865006d, y: 0.7905557554180239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9448121735176876d, y: 0.31974204702567555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5990378095676019d, y: 0.9089328653507489d), new NpgsqlTypes.NpgsqlPoint(x: 0.17850029127085754d, y: 0.12782818957792896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540025837446733d, y: 0.5067807797611048d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5238978872912915d, y: 0.7170653945126942d), new NpgsqlTypes.NpgsqlPoint(x: 0.9243092077647808d, y: 0.6586900071451164d), new NpgsqlTypes.NpgsqlPoint(x: 0.13689503417744964d, y: 0.0035458319770054203d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7293431519650255d, y: 0.31073399084744535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9841258807027403d, y: 0.42157492324702905d), new NpgsqlTypes.NpgsqlPoint(x: 0.47404715149716237d, y: 0.3154420945855382d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13750220007791758d, y: 0.33201769792089786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561859260422393d, y: 0.6807187670647101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427855876656955d, y: 0.08149579606393897d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07642431514878667d, y: 0.6864759224379884d), new NpgsqlTypes.NpgsqlPoint(x: 0.3396325320325453d, y: 0.5299057647621652d), new NpgsqlTypes.NpgsqlPoint(x: 0.05132778657977277d, y: 0.1820713976187267d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09447340309186836d, y: 0.12978831610676111d), new NpgsqlTypes.NpgsqlPoint(x: 0.023807308956975914d, y: 0.7585883689645548d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624662528152945d, y: 0.8041241679831586d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4583298402924755d, y: 0.9480190504687475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108831082971276d, y: 0.3587571190803317d), new NpgsqlTypes.NpgsqlPoint(x: 0.7331062565332489d, y: 0.7065632410352245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4893365697215677d, y: 0.9424687968028839d), new NpgsqlTypes.NpgsqlPoint(x: 0.04039649644978249d, y: 0.5920563906329406d), new NpgsqlTypes.NpgsqlPoint(x: 0.29914555340004145d, y: 0.8601613581588237d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6566925285769759d, y: 0.9114436551844927d), new NpgsqlTypes.NpgsqlPoint(x: 0.3037497571173564d, y: 0.34033721688535934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412531824194066d, y: 0.5837692479944749d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9390234955140024d, y: 0.7889581559788617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677123896433186d, y: 0.8286575422727688d), new NpgsqlTypes.NpgsqlPoint(x: 0.23467724090364372d, y: 0.9717209991380337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9458789573897347d, y: 0.3579031717390937d), new NpgsqlTypes.NpgsqlPoint(x: 0.63561019296914d, y: 0.20485929041393847d), new NpgsqlTypes.NpgsqlPoint(x: 0.31242675822826693d, y: 0.8444247501953559d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7781096944059775d, y: 0.8680598768084861d), new NpgsqlTypes.NpgsqlPoint(x: 0.18567295425813912d, y: 0.17293909660002016d), new NpgsqlTypes.NpgsqlPoint(x: 0.019065497644353058d, y: 0.5323691643327682d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17689282342486035d, y: 0.407810802011891d), new NpgsqlTypes.NpgsqlPoint(x: 0.45590229633194d, y: 0.49744697821058137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3785257995312544d, y: 0.7279814796174755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6889487139020972d, y: 0.7404655461865379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454300021935269d, y: 0.1424617749741084d), new NpgsqlTypes.NpgsqlPoint(x: 0.27819628884400727d, y: 0.07857645704126714d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6582218755748881d, y: 0.7551506803735597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4407786688278952d, y: 0.010979805142849686d), new NpgsqlTypes.NpgsqlPoint(x: 0.31672828546199816d, y: 0.265489160257375d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10480443912653203d, y: 0.2426593406611296d), new NpgsqlTypes.NpgsqlPoint(x: 0.37549607695228493d, y: 0.1279574949943122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559338469919984d, y: 0.578892251307719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8443568962160432d, y: 0.6180458140694278d), new NpgsqlTypes.NpgsqlPoint(x: 0.2692514675878539d, y: 0.6635718875898262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694957457895613d, y: 0.175609535765605d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031135575812517025d, y: 0.8663251465582557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4093590046979593d, y: 0.5357941195932076d), new NpgsqlTypes.NpgsqlPoint(x: 0.07622136165206261d, y: 0.12442616814463037d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4563573502476944d, y: 0.8594703676309718d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978629262241397d, y: 0.31810364499549204d), new NpgsqlTypes.NpgsqlPoint(x: 0.65452933225548d, y: 0.39487684698071956d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3074622974964014d, y: 0.6157556464198182d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638073518052471d, y: 0.07903050109319376d), new NpgsqlTypes.NpgsqlPoint(x: 0.31148584021860115d, y: 0.10268394013865056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7871300293801907d, y: 0.7308909402392d), new NpgsqlTypes.NpgsqlPoint(x: 0.0667567577375473d, y: 0.7435574814855187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5296402110098939d, y: 0.4533107905318313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830949096992526d, y: 0.4202892095714662d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587008124605769d, y: 0.08486520889818638d), new NpgsqlTypes.NpgsqlPoint(x: 0.07881933770709182d, y: 0.7837597826228668d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5425205227512794d, y: 0.8816938023953523d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397002090336303d, y: 0.03875874910064048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4573087001870939d, y: 0.47690902098589605d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5056299464625035d, y: 0.8178100413191686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6718014121790524d, y: 0.7014867581379807d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576961195131579d, y: 0.24472137047126663d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05240593754802103d, y: 0.4220248340754953d), new NpgsqlTypes.NpgsqlPoint(x: 0.881471924543336d, y: 0.33615216430938644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837916574545025d, y: 0.6584675251041187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5857939534479493d, y: 0.556363106395932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741741984092842d, y: 0.7675245293568586d), new NpgsqlTypes.NpgsqlPoint(x: 0.2372258809120127d, y: 0.07934940628820575d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.060416706890824234d, y: 0.9591235971001415d), new NpgsqlTypes.NpgsqlPoint(x: 0.1638069898097273d, y: 0.12013231281692516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8732637810178352d, y: 0.7055643227128543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9163411624175329d, y: 0.4997456346861481d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738385478508517d, y: 0.7540310863057773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5641282163904395d, y: 0.817704172878425d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6556445133565062d, y: 0.7870915001589229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926300624575427d, y: 0.8831296451935118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362628717739236d, y: 0.07640071746162802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6335688419966478d, y: 0.5621236172544863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317995121397042d, y: 0.3419121419623923d), new NpgsqlTypes.NpgsqlPoint(x: 0.21063814840075412d, y: 0.5621994735154354d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20806046375486564d, y: 0.8026084953952088d), new NpgsqlTypes.NpgsqlPoint(x: 0.539377567768052d, y: 0.4726858594332788d), new NpgsqlTypes.NpgsqlPoint(x: 0.3981370070451147d, y: 0.7085345417607908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906584516247588d, y: 0.23963118674385975d), new NpgsqlTypes.NpgsqlPoint(x: 0.685146095465082d, y: 0.01721707274912354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949643769937943d, y: 0.37478265281545464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8466193213856447d, y: 0.11821052552248212d), new NpgsqlTypes.NpgsqlPoint(x: 0.27819192928942094d, y: 0.7934059529629337d), new NpgsqlTypes.NpgsqlPoint(x: 0.514905024916807d, y: 0.8999582924466227d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3297319949008187d, y: 0.48524610028182025d), new NpgsqlTypes.NpgsqlPoint(x: 0.15376467351216083d, y: 0.8736911189691056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916584937858777d, y: 0.8665707374041645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1134136417256788d, y: 0.5995216573734351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8151892957814523d, y: 0.7593149788552687d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737950063183679d, y: 0.3802766300370263d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13572558312442828d, y: 0.013550195676433785d), new NpgsqlTypes.NpgsqlPoint(x: 0.12942135193317894d, y: 0.5594685332336439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8979516363124158d, y: 0.20397627306241606d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67733982314297d, y: 0.8656985207383773d), new NpgsqlTypes.NpgsqlPoint(x: 0.1668761649793108d, y: 0.6414447954211474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840672443415497d, y: 0.9033887470393686d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.895964669171775d, y: 0.23262449752050596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247774237349299d, y: 0.1315682178908495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443008887215296d, y: 0.17957560259121463d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044796519720634254d, y: 0.7646398983126669d), new NpgsqlTypes.NpgsqlPoint(x: 0.5717474632986572d, y: 0.3190665292463064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7358946132147699d, y: 0.8410836458567805d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6378987261205996d, y: 0.8934096655031533d), new NpgsqlTypes.NpgsqlPoint(x: 0.12459810738036536d, y: 0.9405614256731376d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676100431287767d, y: 0.21565868326058268d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4862538399162232d, y: 0.8496994968993281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572120712868414d, y: 0.44299824055144055d), new NpgsqlTypes.NpgsqlPoint(x: 0.195808790458863d, y: 0.5309645127381913d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9756215609676837d, y: 0.6317458164429691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407857298322624d, y: 0.006498446010779424d), new NpgsqlTypes.NpgsqlPoint(x: 0.26495529954045005d, y: 0.0686421262636524d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43733510526190655d, y: 0.7104107244402271d), new NpgsqlTypes.NpgsqlPoint(x: 0.33754982438624115d, y: 0.9188349701846783d), new NpgsqlTypes.NpgsqlPoint(x: 0.28459450944956055d, y: 0.9131585521923181d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.914961776367499d, y: 0.7745966838546058d), new NpgsqlTypes.NpgsqlPoint(x: 0.1321628600904392d, y: 0.722520119136201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7792931716362279d, y: 0.7950120079501436d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02242456161015305d, y: 0.5828692007799493d), new NpgsqlTypes.NpgsqlPoint(x: 0.07216138030001029d, y: 0.029215315597446723d), new NpgsqlTypes.NpgsqlPoint(x: 0.3612283529420086d, y: 0.6109445022536452d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1458693496713841d, y: 0.6556643178904508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5127389132367777d, y: 0.46948951848989506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3535023424827627d, y: 0.9091504892187334d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35807640699594145d, y: 0.885311742036091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829547739388635d, y: 0.2071150637273308d), new NpgsqlTypes.NpgsqlPoint(x: 0.14058172926740298d, y: 0.5007628608836082d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770219479368675d, y: 0.1006472220774054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531751223908252d, y: 0.4197747226808246d), new NpgsqlTypes.NpgsqlPoint(x: 0.1388267954217971d, y: 0.5550326315375614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9510232615479789d, y: 0.6708214057860663d), new NpgsqlTypes.NpgsqlPoint(x: 0.46709856788215043d, y: 0.03258631144096025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9772455074601185d, y: 0.5313628862812739d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006737708784137708d, y: 0.7736416517490953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741381447609315d, y: 0.6921656396312087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844696925622033d, y: 0.9284865695364208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.94230253618655d, y: 0.06683346949975888d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009689813331618113d, y: 0.7399624700814794d), new NpgsqlTypes.NpgsqlPoint(x: 0.004451179738240274d, y: 0.6495332866767592d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8383632137504886d, y: 0.03539365936633765d), new NpgsqlTypes.NpgsqlPoint(x: 0.30643966760221475d, y: 0.22265057879939765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136358475388099d, y: 0.0006014537079067628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.725015462309338d, y: 0.17339451472460898d), new NpgsqlTypes.NpgsqlPoint(x: 0.2523866665135486d, y: 0.107596164477331d), new NpgsqlTypes.NpgsqlPoint(x: 0.07878680108053004d, y: 0.49955701269188724d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23494290627324022d, y: 0.31591262393111585d), new NpgsqlTypes.NpgsqlPoint(x: 0.04272255548273585d, y: 0.448076716406852d), new NpgsqlTypes.NpgsqlPoint(x: 0.00485791366676025d, y: 0.27612337377627516d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0360396224286873d, y: 0.15175805255222508d), new NpgsqlTypes.NpgsqlPoint(x: 0.06979964248221926d, y: 0.602403421575391d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412187018025376d, y: 0.32128416318326125d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2221455596005727d, y: 0.5365729970709566d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728730065135516d, y: 0.7610280986382802d), new NpgsqlTypes.NpgsqlPoint(x: 0.563016393347005d, y: 0.3154446293241908d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5791404166395175d, y: 0.284914260406796d), new NpgsqlTypes.NpgsqlPoint(x: 0.04573247009620163d, y: 0.6181487313940965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8101181664889696d, y: 0.7671797384504796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6436421524587992d, y: 0.8136855157684739d), new NpgsqlTypes.NpgsqlPoint(x: 0.4825494496790791d, y: 0.5570198045191989d), new NpgsqlTypes.NpgsqlPoint(x: 0.6241307809543258d, y: 0.7119879200241689d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9180526359041651d, y: 0.07711789854341466d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455105520087236d, y: 0.883484070959296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533546141751697d, y: 0.17317102427502917d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3313192204499985d, y: 0.4660532269206117d), new NpgsqlTypes.NpgsqlPoint(x: 0.24817773998173465d, y: 0.5002123336130667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177506318444287d, y: 0.42243202047445716d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13339397436258427d, y: 0.4402192510129094d), new NpgsqlTypes.NpgsqlPoint(x: 0.38546193239493975d, y: 0.10758066075179296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189619464423697d, y: 0.12883265095083518d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25422711651342345d, y: 0.9496976661784321d), new NpgsqlTypes.NpgsqlPoint(x: 0.20433019758968962d, y: 0.0782270679200624d), new NpgsqlTypes.NpgsqlPoint(x: 0.3100983532267916d, y: 0.49674236988289144d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1701411437703384d, y: 0.18019953335870498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183268439222155d, y: 0.5087248689126153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312397943657747d, y: 0.5008141718966984d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4105865617903156d, y: 0.923859397288599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6512339150631977d, y: 0.7848557955163545d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948711952611076d, y: 0.04981321646425796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47262334955082863d, y: 0.8393172756453781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078404866213252d, y: 0.9919587846562299d), new NpgsqlTypes.NpgsqlPoint(x: 0.23778916264139716d, y: 0.21619037196463164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9421115558041044d, y: 0.6877077539252104d), new NpgsqlTypes.NpgsqlPoint(x: 0.2314252458958327d, y: 0.8911144683544312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034427241588442d, y: 0.9294079364406707d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005772102623807007d, y: 0.329998482918459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126159993994999d, y: 0.44131945955074725d), new NpgsqlTypes.NpgsqlPoint(x: 0.09995107151177562d, y: 0.2907401007959354d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04261917264152659d, y: 0.9220816184800412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330815682378501d, y: 0.818510885850985d), new NpgsqlTypes.NpgsqlPoint(x: 0.026466370458354094d, y: 0.3533202573815478d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11511092486947516d, y: 0.593005778915531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5882419529239596d, y: 0.8253955650851574d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678855575796633d, y: 0.9083048471513855d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8620504501389176d, y: 0.4962958466019315d), new NpgsqlTypes.NpgsqlPoint(x: 0.08213880348562419d, y: 0.259472191941435d), new NpgsqlTypes.NpgsqlPoint(x: 0.702420870620843d, y: 0.69887162247086d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6877866114780624d, y: 0.4487135430423024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475133145020533d, y: 0.8507628864737027d), new NpgsqlTypes.NpgsqlPoint(x: 0.26119040101637814d, y: 0.7231276533528987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776929166800518d, y: 0.4848290525782867d), new NpgsqlTypes.NpgsqlPoint(x: 0.24679385097976392d, y: 0.20984411104229894d), new NpgsqlTypes.NpgsqlPoint(x: 0.2623850173519652d, y: 0.8450045488141482d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07950899679474843d, y: 0.5510334442040915d), new NpgsqlTypes.NpgsqlPoint(x: 0.49871069014893465d, y: 0.727997322698298d), new NpgsqlTypes.NpgsqlPoint(x: 0.2834692394728774d, y: 0.5040964640620662d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42735294152379166d, y: 0.36106671544696d), new NpgsqlTypes.NpgsqlPoint(x: 0.895814906798181d, y: 0.6517295242901567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4200091413261886d, y: 0.49331408920493847d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6408505653798675d, y: 0.5860330945363345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373090949200648d, y: 0.17184175559909387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4748290089121695d, y: 0.3520523367262445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30189338553919953d, y: 0.6494117467476368d), new NpgsqlTypes.NpgsqlPoint(x: 0.044820167038558734d, y: 0.2408950165836523d), new NpgsqlTypes.NpgsqlPoint(x: 0.25411862986299305d, y: 0.17068803441751412d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12056522317890028d, y: 0.8466861216692745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583351101809785d, y: 0.5399210263949348d), new NpgsqlTypes.NpgsqlPoint(x: 0.01612898550546349d, y: 0.39366770361678116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526119074949843d, y: 0.2639092550736555d), new NpgsqlTypes.NpgsqlPoint(x: 0.01895510557004365d, y: 0.24629146399176804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8990151501839256d, y: 0.6456488911806351d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3550909230284027d, y: 0.5664791958611636d), new NpgsqlTypes.NpgsqlPoint(x: 0.4884030701944415d, y: 0.16084937316116388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566101660262576d, y: 0.5880844720982192d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35326865451153977d, y: 0.7666622435452155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411409941630675d, y: 0.37174660216135635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7310643596554d, y: 0.3584100671116529d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7873948411452961d, y: 0.26508008535153493d), new NpgsqlTypes.NpgsqlPoint(x: 0.3162019728210359d, y: 0.7709901192942712d), new NpgsqlTypes.NpgsqlPoint(x: 0.4885633585637801d, y: 0.3423645564623464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9809140948424105d, y: 0.1374673267207438d), new NpgsqlTypes.NpgsqlPoint(x: 0.5159306548464208d, y: 0.007509894561578578d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823878403045875d, y: 0.6176810453728317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5832589449969526d, y: 0.3927770059992023d), new NpgsqlTypes.NpgsqlPoint(x: 0.7743163592682322d, y: 0.5145254959066313d), new NpgsqlTypes.NpgsqlPoint(x: 0.129012804187844d, y: 0.6160299069556836d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7949187816718681d, y: 0.4467593522561407d), new NpgsqlTypes.NpgsqlPoint(x: 0.65725747003223d, y: 0.6282205125170829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4951656918595838d, y: 0.8363878172425185d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5578401673038009d, y: 0.09553317408876727d), new NpgsqlTypes.NpgsqlPoint(x: 0.19579459390768927d, y: 0.018048196254856763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7507656429896826d, y: 0.8913066579878317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8026671223239993d, y: 0.5467487653784134d), new NpgsqlTypes.NpgsqlPoint(x: 0.522121376041513d, y: 0.7955595751039032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802880275573553d, y: 0.5062745513204647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7792516175829501d, y: 0.014735483770459301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5572859836045169d, y: 0.6938796983472669d), new NpgsqlTypes.NpgsqlPoint(x: 0.31350073017547364d, y: 0.9181730814627618d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30521922853270467d, y: 0.12430123353106715d), new NpgsqlTypes.NpgsqlPoint(x: 0.03668672775396875d, y: 0.6980225428328427d), new NpgsqlTypes.NpgsqlPoint(x: 0.979098485203177d, y: 0.4734655588295954d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.651291754402967d, y: 0.9560186311365074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8081519714554848d, y: 0.7835958999236102d), new NpgsqlTypes.NpgsqlPoint(x: 0.3847660025529518d, y: 0.7755571923603669d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06325235189626355d, y: 0.6862495490730862d), new NpgsqlTypes.NpgsqlPoint(x: 0.054923011615699235d, y: 0.10814462994456442d), new NpgsqlTypes.NpgsqlPoint(x: 0.004077202787521328d, y: 0.6651915005755644d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9046761472028544d, y: 0.8527432080715569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8153614037258708d, y: 0.8828223511073903d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875381592302848d, y: 0.934313400541277d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9203828441067015d, y: 0.2775149297937225d), new NpgsqlTypes.NpgsqlPoint(x: 0.4070747698310777d, y: 0.7325849704857754d), new NpgsqlTypes.NpgsqlPoint(x: 0.04466771039605599d, y: 0.6696106002973109d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4533786432949153d, y: 0.8868375309404627d), new NpgsqlTypes.NpgsqlPoint(x: 0.24297982541242635d, y: 0.7977498319351713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254572294387477d, y: 0.7209678953643107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05049137667439163d, y: 0.9841193131529706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633568782152854d, y: 0.238022144245415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5048404638496821d, y: 0.36157447605943727d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8201378138043204d, y: 0.4376742543731893d), new NpgsqlTypes.NpgsqlPoint(x: 0.5053426951742459d, y: 0.679737961561385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889033145564044d, y: 0.1409404502899757d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9746515227617267d, y: 0.6367660197941097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189133695833811d, y: 0.4153854403888584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7777873191258783d, y: 0.8097575494246304d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8842304927276411d, y: 0.44423019506665373d), new NpgsqlTypes.NpgsqlPoint(x: 0.389763425269528d, y: 0.011724062913304412d), new NpgsqlTypes.NpgsqlPoint(x: 0.26856957255799685d, y: 0.8963965379805525d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9210633767588057d, y: 0.7351562206807909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779499450868894d, y: 0.9656592639755038d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519428355622094d, y: 0.2834050471454729d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20565119700448764d, y: 0.5702447922064636d), new NpgsqlTypes.NpgsqlPoint(x: 0.40599324343322374d, y: 0.2371946724727344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7925505046444453d, y: 0.9011049796605116d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05756926883619751d, y: 0.6098156829211331d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932682029632224d, y: 0.3644233248426779d), new NpgsqlTypes.NpgsqlPoint(x: 0.18087384953540053d, y: 0.363199458047858d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05889147005335427d, y: 0.40835298763457606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133425275906995d, y: 0.9113168674852975d), new NpgsqlTypes.NpgsqlPoint(x: 0.10139460324594951d, y: 0.04315801110225148d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9580641601387483d, y: 0.824342260977739d), new NpgsqlTypes.NpgsqlPoint(x: 0.624948957499391d, y: 0.837569218087152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266341423445183d, y: 0.6188729044322104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7468760606935634d, y: 0.23140526720316967d), new NpgsqlTypes.NpgsqlPoint(x: 0.13683921651467612d, y: 0.2440986800213606d), new NpgsqlTypes.NpgsqlPoint(x: 0.23724546797734425d, y: 0.7654068248649046d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07364895813580286d, y: 0.837743774207673d), new NpgsqlTypes.NpgsqlPoint(x: 0.40049350614612d, y: 0.6994231926926437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3589051127638183d, y: 0.9656583306568244d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 197,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9009932889672456d, y: 0.5141637618890401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899805482971837d, y: 0.15864292531778346d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922963616289857d, y: 0.3326641725026276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5519033380387448d, y: 0.794167899273971d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379696687958124d, y: 0.46809743518864955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247546118906986d, y: 0.707656869054129d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.026338524954846343d, y: 0.7789011796636239d), new NpgsqlTypes.NpgsqlPoint(x: 0.9743575940995808d, y: 0.8969635304535644d), new NpgsqlTypes.NpgsqlPoint(x: 0.46406508971681826d, y: 0.08864367439950771d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4169147535426273d, y: 0.808643775137417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3153212861071304d, y: 0.497727572461813d), new NpgsqlTypes.NpgsqlPoint(x: 0.46336922158095906d, y: 0.9951353050113347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48403188209432124d, y: 0.6286453319264382d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977228412560467d, y: 0.8268444626009688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594945257522466d, y: 0.6633689915325369d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9785913182615694d, y: 0.8563589825416289d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749427943098245d, y: 0.6410206575753571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581571924034232d, y: 0.8377913665532032d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6014100167041541d, y: 0.9587081864568534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832408057561045d, y: 0.27359759681733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7308074705716635d, y: 0.23286160692777014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0705878434646171d, y: 0.4297793955794037d), new NpgsqlTypes.NpgsqlPoint(x: 0.4206507170984456d, y: 0.5395471785003202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988327921038157d, y: 0.9858870154777142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005035718095989017d, y: 0.8556060115318076d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942848623752097d, y: 0.03558810785109978d), new NpgsqlTypes.NpgsqlPoint(x: 0.08911435858251637d, y: 0.8792320258527272d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 202,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27340243727005364d, y: 0.46305226695674484d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199186262955158d, y: 0.8808016952449823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8239043265128798d, y: 0.18585470404575155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.368141777125058d, y: 0.8512363592819676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952085439207664d, y: 0.7471607129697069d), new NpgsqlTypes.NpgsqlPoint(x: 0.410729995481394d, y: 0.7291969998614537d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15829333546042212d, y: 0.6736870490728473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801371175075154d, y: 0.9883379528056627d), new NpgsqlTypes.NpgsqlPoint(x: 0.015299687421215347d, y: 0.84007484429787d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2904386693882125d, y: 0.9547401730147197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3783705309561993d, y: 0.14574669338944346d), new NpgsqlTypes.NpgsqlPoint(x: 0.043601564845876184d, y: 0.733111729110814d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7624473570553109d, y: 0.7535946578665732d), new NpgsqlTypes.NpgsqlPoint(x: 0.25342773202107904d, y: 0.5366215790778534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110101724835463d, y: 0.44479540994894307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374569867960584d, y: 0.15919279235806771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923753297326514d, y: 0.5238524965491275d), new NpgsqlTypes.NpgsqlPoint(x: 0.04580592146450502d, y: 0.6465999940692732d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.843825271319312d, y: 0.4504346222940302d), new NpgsqlTypes.NpgsqlPoint(x: 0.3645859918946277d, y: 0.6540888059615907d), new NpgsqlTypes.NpgsqlPoint(x: 0.14384370709352934d, y: 0.7665269760882536d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
INSERT INTO public.npgsqlpathpatharray2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathArray)), 
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray2mi_id
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
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                methodParametrName: "npgsqlpathpatharray2mi_id", 
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
                List<NpgsqlPathpathArray2M> models = null;

                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray2M> models = null;

                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 95;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 46;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 63;
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M), typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                await((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 68, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 157, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray2M>();
                var models2 = new List<FlatNpgsqlPathpathArray2M>();
                ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 171, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
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
FROM public.npgsqlpathpatharray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray2M>();
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray2m m
LEFT JOIN public.npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await((INpgsqlPathListpathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 151))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPathListpathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 186, 37))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MI),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray2M),
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
FROM public.binary_npgsqlpathpatharray2m m
LEFT JOIN public.binary_npgsqlpathpatharray2mi mi ON mi.id = m.npgsqlpathpatharray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray2M)],
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
            asPartInterface: typeof(INpgsqlPathListpathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathListpathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray2mi
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
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI), typeof(NpgsqlPathpathArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                await ((INpgsqlPathListpathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MI>();
                var models2 = new List<NpgsqlPathpathArray2MI>();
                ((INpgsqlPathListpathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray)),
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
                var models = await ((INpgsqlPathListpathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA), typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                await ((INpgsqlPathListpathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray2MIWA>();
                var models2 = new List<NpgsqlPathpathArray2MIWA>();
                ((INpgsqlPathListpathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathArray))]
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
                var models = await ((INpgsqlPathListpathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

