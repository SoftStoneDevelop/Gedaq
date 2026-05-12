

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
    internal partial interface INpgsqlLineMArraylineMMArrayD1
    {
    }
    
    internal partial class NpgsqlLineMArraylineMMArrayD1 : INpgsqlLineMArraylineMMArrayD1
    {


#region TestData

        private readonly NpgsqlLinelineMMArrayD1E1M[] _testData = new NpgsqlLinelineMMArrayD1E1M[]
        {
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4099538557233158d, b: 0.07517524991036806d, c: 0.9782566191971658d),
new NpgsqlTypes.NpgsqlLine(a: 0.3058091854732444d, b: 0.9965690547512775d, c: 0.6244359112091075d),
new NpgsqlTypes.NpgsqlLine(a: 0.18370472179496877d, b: 0.1157136057678283d, c: 0.7056363589145969d),
new NpgsqlTypes.NpgsqlLine(a: 0.2723324973286536d, b: 0.2727321257185953d, c: 0.9469630994796581d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8364249114326254d, b: 0.7616446585091169d, c: 0.5499997229492005d),
new NpgsqlTypes.NpgsqlLine(a: 0.004978118160033795d, b: 0.9990712118551226d, c: 0.918384900014883d),
new NpgsqlTypes.NpgsqlLine(a: 0.6300059231954647d, b: 0.6785809993550462d, c: 0.38172767797468954d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9211987432666643d, b: 0.9898536474151971d, c: 0.8931917501824013d),
new NpgsqlTypes.NpgsqlLine(a: 0.5588446271433306d, b: 0.2849961047871601d, c: 0.973349602688576d),
new NpgsqlTypes.NpgsqlLine(a: 0.23734088496035677d, b: 0.6259834946335834d, c: 0.7750455324809359d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.029656340589562902d, b: 0.22485417848888367d, c: 0.8420574259921055d),
new NpgsqlTypes.NpgsqlLine(a: 0.39806751911925d, b: 0.38344706349841384d, c: 0.12592862405203198d),
new NpgsqlTypes.NpgsqlLine(a: 0.455840941294425d, b: 0.7908260920136071d, c: 0.8089053056699341d),
new NpgsqlTypes.NpgsqlLine(a: 0.8563483587609206d, b: 0.38570043268541054d, c: 0.7640567446584681d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43523931214765976d, b: 0.8365273519521792d, c: 0.8960215216199546d),
new NpgsqlTypes.NpgsqlLine(a: 0.7723899724335865d, b: 0.16701025784580925d, c: 0.6169149753017583d),
new NpgsqlTypes.NpgsqlLine(a: 0.7830777169889013d, b: 0.18478230843803434d, c: 0.5795842522385641d),
new NpgsqlTypes.NpgsqlLine(a: 0.2735014405487116d, b: 0.3064153350582688d, c: 0.638512577324818d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7062889556633651d, b: 0.9500222024421825d, c: 0.23607604156529072d),
new NpgsqlTypes.NpgsqlLine(a: 0.7581980239137414d, b: 0.3555665986555687d, c: 0.07124729011293485d),
new NpgsqlTypes.NpgsqlLine(a: 0.7451889143053713d, b: 0.9043150279356016d, c: 0.5509829600175639d),
new NpgsqlTypes.NpgsqlLine(a: 0.6347619344182173d, b: 0.5546949656071529d, c: 0.2599014463306559d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.55665103768769d, b: 0.5175701133829249d, c: 0.025824023003557017d),
new NpgsqlTypes.NpgsqlLine(a: 0.13243485168156932d, b: 0.3158166858708572d, c: 0.7649079765804906d),
new NpgsqlTypes.NpgsqlLine(a: 0.022009320237588836d, b: 0.07045402600275286d, c: 0.48604314634346746d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8675213199308315d, b: 0.9376320659194124d, c: 0.773750017498221d),
new NpgsqlTypes.NpgsqlLine(a: 0.15028917465335323d, b: 0.4657393658175132d, c: 0.8953932130310985d),
new NpgsqlTypes.NpgsqlLine(a: 0.8801376424170816d, b: 0.21296687321472774d, c: 0.3420045260241621d),
new NpgsqlTypes.NpgsqlLine(a: 0.6246534449082898d, b: 0.3296831548709793d, c: 0.408652081278311d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5737823711579491d, b: 0.5479113171504898d, c: 0.7927419516578345d),
new NpgsqlTypes.NpgsqlLine(a: 0.7767684378396805d, b: 0.6090989721217009d, c: 0.8198386074952548d),
new NpgsqlTypes.NpgsqlLine(a: 0.8251665700832983d, b: 0.9341804176004411d, c: 0.331722584922699d),
new NpgsqlTypes.NpgsqlLine(a: 0.779089126446497d, b: 0.387773839473726d, c: 0.7018252698951191d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4017140425510707d, b: 0.6471107139588058d, c: 0.950973144056893d),
new NpgsqlTypes.NpgsqlLine(a: 0.3281300974757059d, b: 0.7888779558695388d, c: 0.12744628848282658d),
new NpgsqlTypes.NpgsqlLine(a: 0.9682559349762716d, b: 0.34975320912999897d, c: 0.6679742379036354d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.34276665774476145d, b: 0.02062557353956851d, c: 0.5965114476126009d),
new NpgsqlTypes.NpgsqlLine(a: 0.7737355446927059d, b: 0.6841994830494704d, c: 0.5916073324866804d),
new NpgsqlTypes.NpgsqlLine(a: 0.01568515714438412d, b: 0.5743769560243535d, c: 0.43065293621116596d),
new NpgsqlTypes.NpgsqlLine(a: 0.007551092715605945d, b: 0.2162983252091113d, c: 0.24027142257915446d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12471916129390115d, b: 0.4676841352677348d, c: 0.8714096885451557d),
new NpgsqlTypes.NpgsqlLine(a: 0.36052957366491667d, b: 0.8392596212989321d, c: 0.844797282631518d),
new NpgsqlTypes.NpgsqlLine(a: 0.7096337604581515d, b: 0.9254889552367611d, c: 0.9482293198329212d),
new NpgsqlTypes.NpgsqlLine(a: 0.0429159052311513d, b: 0.31077376496656006d, c: 0.565499833960594d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4285720406898995d, b: 0.2435079199739807d, c: 0.1324194027369291d),
new NpgsqlTypes.NpgsqlLine(a: 0.1520945488728781d, b: 0.4776054859358384d, c: 0.5430475552989549d),
new NpgsqlTypes.NpgsqlLine(a: 0.8092059409946114d, b: 0.9835756282112748d, c: 0.8269473604161615d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4079314372648958d, b: 0.06482564739792684d, c: 0.9601891467097609d),
new NpgsqlTypes.NpgsqlLine(a: 0.6649836231341271d, b: 0.7115606839124249d, c: 0.9668150154049502d),
new NpgsqlTypes.NpgsqlLine(a: 0.9423486319489751d, b: 0.20878534047779151d, c: 0.9621784735955239d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01305774382614766d, b: 0.7684887634282137d, c: 0.15173390193756375d),
new NpgsqlTypes.NpgsqlLine(a: 0.06306080118121038d, b: 0.7294870510115202d, c: 0.03192239993193002d),
new NpgsqlTypes.NpgsqlLine(a: 0.38547419382955783d, b: 0.5620267435079805d, c: 0.799884395741845d),
new NpgsqlTypes.NpgsqlLine(a: 0.1905961839847763d, b: 0.432259710730011d, c: 0.2909958980126246d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9666253558057415d, b: 0.32541160789336787d, c: 0.31410995771755035d),
new NpgsqlTypes.NpgsqlLine(a: 0.6322981326462231d, b: 0.9810408170711076d, c: 0.5610433449895965d),
new NpgsqlTypes.NpgsqlLine(a: 0.0852076390013441d, b: 0.5082259608104027d, c: 0.10099704730194392d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.04541664765396347d, b: 0.7892714616245978d, c: 0.437421853178001d),
new NpgsqlTypes.NpgsqlLine(a: 0.5715252932300039d, b: 0.09679306406138122d, c: 0.5581439957523107d),
new NpgsqlTypes.NpgsqlLine(a: 0.6270983931951468d, b: 0.4399754651205797d, c: 0.5769894264144284d),
new NpgsqlTypes.NpgsqlLine(a: 0.23033580339093018d, b: 0.04436750105109122d, c: 0.33680415371285777d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5013592471197951d, b: 0.4907360257349114d, c: 0.513748571168197d),
new NpgsqlTypes.NpgsqlLine(a: 0.5778367323603845d, b: 0.01937969417321006d, c: 0.6110843156044936d),
new NpgsqlTypes.NpgsqlLine(a: 0.5350182653247371d, b: 0.37060418043651844d, c: 0.40078448296923264d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4662288185202036d, b: 0.29268750555723244d, c: 0.8956512935697996d),
new NpgsqlTypes.NpgsqlLine(a: 0.7358016363667792d, b: 0.49810323719239313d, c: 0.1920477176807135d),
new NpgsqlTypes.NpgsqlLine(a: 0.45961168404987063d, b: 0.9558356084504859d, c: 0.34464694905120075d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3092683519389531d, b: 0.37448100284099295d, c: 0.12925246723292538d),
new NpgsqlTypes.NpgsqlLine(a: 0.05685756978005918d, b: 0.5028628614930063d, c: 0.6145098265418323d),
new NpgsqlTypes.NpgsqlLine(a: 0.27057628039384785d, b: 0.8581514880991787d, c: 0.5888042369304278d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24650086030587082d, b: 0.32634691481839395d, c: 0.757116046131551d),
new NpgsqlTypes.NpgsqlLine(a: 0.48982779707616086d, b: 0.6708898019422026d, c: 0.8914891613275554d),
new NpgsqlTypes.NpgsqlLine(a: 0.6292466503697012d, b: 0.43511967101120663d, c: 0.5116844372536962d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5319689759621798d, b: 0.8524304865086326d, c: 0.028785691622548515d),
new NpgsqlTypes.NpgsqlLine(a: 0.13067684665706147d, b: 0.20515309112553948d, c: 0.5828808235838038d),
new NpgsqlTypes.NpgsqlLine(a: 0.8095130614706179d, b: 0.2979340075731388d, c: 0.11702011581944316d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10085458214791587d, b: 0.36352893908982264d, c: 0.41483443824585975d),
new NpgsqlTypes.NpgsqlLine(a: 0.49574456648768206d, b: 0.07085286139563474d, c: 0.6557452846073852d),
new NpgsqlTypes.NpgsqlLine(a: 0.42555746534721517d, b: 0.7011732551086437d, c: 0.10937283733237735d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11227941441526412d, b: 0.6409866854498516d, c: 0.9604138656315371d),
new NpgsqlTypes.NpgsqlLine(a: 0.42681711281294754d, b: 0.06681497219083554d, c: 0.9477157522082761d),
new NpgsqlTypes.NpgsqlLine(a: 0.9687490094651924d, b: 0.9971034618641678d, c: 0.9365040780632331d),
new NpgsqlTypes.NpgsqlLine(a: 0.21626053724413052d, b: 0.45606351877306905d, c: 0.8154233134888934d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5036320048750135d, b: 0.7955447319117809d, c: 0.19945820666542657d),
new NpgsqlTypes.NpgsqlLine(a: 0.10981702707836427d, b: 0.9790207814007219d, c: 0.9581667388907953d),
new NpgsqlTypes.NpgsqlLine(a: 0.7451920885799213d, b: 0.5935676820772112d, c: 0.7297206235466145d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4632030846756522d, b: 0.9227397348953665d, c: 0.8387037459876915d),
new NpgsqlTypes.NpgsqlLine(a: 0.23825381604551044d, b: 0.26053704183387905d, c: 0.3196624704986759d),
new NpgsqlTypes.NpgsqlLine(a: 0.9681271475176986d, b: 0.31340200400531626d, c: 0.8179382443816678d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6224581273226854d, b: 0.20574313514485754d, c: 0.5214718883745961d),
new NpgsqlTypes.NpgsqlLine(a: 0.9655236433678218d, b: 0.7237590213582947d, c: 0.7215305070863197d),
new NpgsqlTypes.NpgsqlLine(a: 0.7957410531118015d, b: 0.13589896584973504d, c: 0.4483225768465714d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8643964380679343d, b: 0.6927749304872031d, c: 0.6840035406672303d),
new NpgsqlTypes.NpgsqlLine(a: 0.8037352855836133d, b: 0.8601947822317899d, c: 0.6072192194165105d),
new NpgsqlTypes.NpgsqlLine(a: 0.19821642570248021d, b: 0.5243190604905557d, c: 0.8625106791267902d),
new NpgsqlTypes.NpgsqlLine(a: 0.026632024901149465d, b: 0.3624530544540071d, c: 0.7233244989915837d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.13010212103041952d, b: 0.3325498267887296d, c: 0.8740835334216367d),
new NpgsqlTypes.NpgsqlLine(a: 0.4288524257904144d, b: 0.7969079931980951d, c: 0.9643677044294592d),
new NpgsqlTypes.NpgsqlLine(a: 0.38233265543773354d, b: 0.8662275008808556d, c: 0.7084964246013827d),
new NpgsqlTypes.NpgsqlLine(a: 0.8718129136295438d, b: 0.25451968967731375d, c: 0.27221520033323887d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48738859551208513d, b: 0.7022687478262031d, c: 0.7437839064446281d),
new NpgsqlTypes.NpgsqlLine(a: 0.4038312496736677d, b: 0.38018303831609446d, c: 0.5802899289488841d),
new NpgsqlTypes.NpgsqlLine(a: 0.1729441204270198d, b: 0.2275159322914192d, c: 0.42155875664691556d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0008530553138603736d, b: 0.6884329085465971d, c: 0.8850510372325903d),
new NpgsqlTypes.NpgsqlLine(a: 0.9019589438491389d, b: 0.5649267922997452d, c: 0.6446474662349373d),
new NpgsqlTypes.NpgsqlLine(a: 0.7956656014024643d, b: 0.5508574271442204d, c: 0.5530878514639812d),
new NpgsqlTypes.NpgsqlLine(a: 0.5777275954508846d, b: 0.47414855997290395d, c: 0.1285606744911283d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4298802305821233d, b: 0.13140960882860353d, c: 0.6607127479437804d),
new NpgsqlTypes.NpgsqlLine(a: 0.7053346040141515d, b: 0.1496144305828322d, c: 0.2175279530578148d),
new NpgsqlTypes.NpgsqlLine(a: 0.3479892077039404d, b: 0.9527013547273898d, c: 0.9236897630590979d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5303504498134316d, b: 0.9076258071678257d, c: 0.4830414456798662d),
new NpgsqlTypes.NpgsqlLine(a: 0.4075608444409089d, b: 0.5529950206934443d, c: 0.007174188310595575d),
new NpgsqlTypes.NpgsqlLine(a: 0.928619119357191d, b: 0.8947589766059504d, c: 0.5336211536428414d),
new NpgsqlTypes.NpgsqlLine(a: 0.1601087198266452d, b: 0.8872283189188678d, c: 0.4290109184464589d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7144935215544915d, b: 0.2913689824778274d, c: 0.732695226363285d),
new NpgsqlTypes.NpgsqlLine(a: 0.8286970112973762d, b: 0.43218952564038104d, c: 0.6773356799926714d),
new NpgsqlTypes.NpgsqlLine(a: 0.1814276266877921d, b: 0.24854111510916876d, c: 0.8743724096001295d),
new NpgsqlTypes.NpgsqlLine(a: 0.13695358345609576d, b: 0.016661626721901968d, c: 0.8950402390789433d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9867427714264739d, b: 0.6261010274859783d, c: 0.9788722409975249d),
new NpgsqlTypes.NpgsqlLine(a: 0.8555806155222265d, b: 0.13393112228286141d, c: 0.6025730126677696d),
new NpgsqlTypes.NpgsqlLine(a: 0.36978730169075935d, b: 0.6725959742015301d, c: 0.04260245647284644d),
new NpgsqlTypes.NpgsqlLine(a: 0.36731152648881626d, b: 0.3220548554648254d, c: 0.08565580827119001d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.358196389993624d, b: 0.19432077502541334d, c: 0.3844624533230021d),
new NpgsqlTypes.NpgsqlLine(a: 0.7658027862363624d, b: 0.1646301473955205d, c: 0.8511905761166765d),
new NpgsqlTypes.NpgsqlLine(a: 0.8959027975641204d, b: 0.17392050990438046d, c: 0.5292062307260277d),
new NpgsqlTypes.NpgsqlLine(a: 0.6351373211245211d, b: 0.8371657488127141d, c: 0.1820565300015652d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.29455946338933015d, b: 0.5653753589516634d, c: 0.21233701170773933d),
new NpgsqlTypes.NpgsqlLine(a: 0.934018588107394d, b: 0.6363950164227629d, c: 0.752359125676945d),
new NpgsqlTypes.NpgsqlLine(a: 0.836398511315574d, b: 0.9659897061440234d, c: 0.32911864796675094d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.425315781020814d, b: 0.9914495805059217d, c: 0.6477393799656197d),
new NpgsqlTypes.NpgsqlLine(a: 0.13520114741049494d, b: 0.7262906217467783d, c: 0.9563017899613176d),
new NpgsqlTypes.NpgsqlLine(a: 0.7733538284243366d, b: 0.7676220514475911d, c: 0.49869697475925123d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9784912874972143d, b: 0.5470174065393738d, c: 0.32608692947168494d),
new NpgsqlTypes.NpgsqlLine(a: 0.16830252397778567d, b: 0.7437137170399165d, c: 0.076243607843686d),
new NpgsqlTypes.NpgsqlLine(a: 0.778916523014242d, b: 0.9862362883535171d, c: 0.4193076328322095d),
new NpgsqlTypes.NpgsqlLine(a: 0.8166585516013776d, b: 0.4400153784931333d, c: 0.1944962340202152d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2864416292147731d, b: 0.6955295521876506d, c: 0.21988927105243083d),
new NpgsqlTypes.NpgsqlLine(a: 0.4398787098024539d, b: 0.3138256365813814d, c: 0.5576804107044356d),
new NpgsqlTypes.NpgsqlLine(a: 0.1309633804045276d, b: 0.18278112684412506d, c: 0.8310535888901377d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9062663146419637d, b: 0.10467005474435553d, c: 0.7715935702375827d),
new NpgsqlTypes.NpgsqlLine(a: 0.33531115306434867d, b: 0.6425883996159504d, c: 0.3500654474689866d),
new NpgsqlTypes.NpgsqlLine(a: 0.4363817289718547d, b: 0.34946048214478664d, c: 0.5846579713702028d),
new NpgsqlTypes.NpgsqlLine(a: 0.9620469175527302d, b: 0.6869878879746121d, c: 0.001041190900624156d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9589634479767123d, b: 0.4361334583188481d, c: 0.6422503042597881d),
new NpgsqlTypes.NpgsqlLine(a: 0.572703625176505d, b: 0.27048590518065974d, c: 0.7051959973677661d),
new NpgsqlTypes.NpgsqlLine(a: 0.04203189716072386d, b: 0.48652185275250726d, c: 0.3285861478269827d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23228360526511715d, b: 0.35323826625474175d, c: 0.9377321778616015d),
new NpgsqlTypes.NpgsqlLine(a: 0.46086611802255617d, b: 0.6435273715577231d, c: 0.6090359700812255d),
new NpgsqlTypes.NpgsqlLine(a: 0.3374689241080736d, b: 0.7688449040939436d, c: 0.7319842367505356d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9426749832228579d, b: 0.5159154315223073d, c: 0.608849940330262d),
new NpgsqlTypes.NpgsqlLine(a: 0.553871920825682d, b: 0.9941880838417307d, c: 0.8830548363028997d),
new NpgsqlTypes.NpgsqlLine(a: 0.18064901046513226d, b: 0.438532524193344d, c: 0.10075394146149308d),
new NpgsqlTypes.NpgsqlLine(a: 0.12506209075031482d, b: 0.7678641797825275d, c: 0.5300169277568495d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8643120450875859d, b: 0.16982971144061232d, c: 0.2830191470498662d),
new NpgsqlTypes.NpgsqlLine(a: 0.8304228548892153d, b: 0.7665541432603454d, c: 0.5105408190991627d),
new NpgsqlTypes.NpgsqlLine(a: 0.8519456648877981d, b: 0.8316422602502538d, c: 0.9422306013684669d),
new NpgsqlTypes.NpgsqlLine(a: 0.41897764360675627d, b: 0.9612527633736548d, c: 0.6957709539378324d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4948977424666171d, b: 0.4566545322229527d, c: 0.054089718882468496d),
new NpgsqlTypes.NpgsqlLine(a: 0.5747355628241941d, b: 0.7097029702378974d, c: 0.5985239681232112d),
new NpgsqlTypes.NpgsqlLine(a: 0.4234711388078387d, b: 0.05051015955024918d, c: 0.6928193391489446d),
new NpgsqlTypes.NpgsqlLine(a: 0.36837398428026313d, b: 0.2419677523585425d, c: 0.9194392320688922d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8555885253484107d, b: 0.8521764294789114d, c: 0.3580193282345746d),
new NpgsqlTypes.NpgsqlLine(a: 0.48096716216236035d, b: 0.08386591359164541d, c: 0.7270448886482092d),
new NpgsqlTypes.NpgsqlLine(a: 0.9584055495272283d, b: 0.41246453474321143d, c: 0.38002533548259876d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3665270978729952d, b: 0.2203517295243026d, c: 0.031342859927125044d),
new NpgsqlTypes.NpgsqlLine(a: 0.15218123863847866d, b: 0.8592232799939125d, c: 0.22953677544091233d),
new NpgsqlTypes.NpgsqlLine(a: 0.8703988397602408d, b: 0.5246153250114107d, c: 0.049374509494587104d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5747495414765478d, b: 0.4525993045068464d, c: 0.5989386022255851d),
new NpgsqlTypes.NpgsqlLine(a: 0.4606465216381641d, b: 0.8056230110521009d, c: 0.9651603087876026d),
new NpgsqlTypes.NpgsqlLine(a: 0.3736166193047554d, b: 0.44958785436966975d, c: 0.328521679466115d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5257493570248293d, b: 0.1488823242691334d, c: 0.7971064789943779d),
new NpgsqlTypes.NpgsqlLine(a: 0.16215808340366633d, b: 0.8694181068016913d, c: 0.6553455352678764d),
new NpgsqlTypes.NpgsqlLine(a: 0.03449411577091044d, b: 0.35455284806836385d, c: 0.29188107309823186d),
new NpgsqlTypes.NpgsqlLine(a: 0.3906396090602102d, b: 0.26341989980798985d, c: 0.7915066224229305d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05410857978298478d, b: 0.903876947825848d, c: 0.008396193142197306d),
new NpgsqlTypes.NpgsqlLine(a: 0.6679974047167075d, b: 0.4460639259733703d, c: 0.15253525482461527d),
new NpgsqlTypes.NpgsqlLine(a: 0.5420047516084465d, b: 0.7087125689801191d, c: 0.08799194499286145d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.016030539431578616d, b: 0.3700851398754429d, c: 0.619671832255114d),
new NpgsqlTypes.NpgsqlLine(a: 0.20554925929829104d, b: 0.5112694387422441d, c: 0.10168100373429445d),
new NpgsqlTypes.NpgsqlLine(a: 0.7854426040046483d, b: 0.7358115408016778d, c: 0.004956703688137942d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32356101037844287d, b: 0.669274052331553d, c: 0.6277125396861616d),
new NpgsqlTypes.NpgsqlLine(a: 0.29403915594672714d, b: 0.8271056529095833d, c: 0.0958352120178303d),
new NpgsqlTypes.NpgsqlLine(a: 0.8648196232170727d, b: 0.7331748823462861d, c: 0.26571582075976896d),
new NpgsqlTypes.NpgsqlLine(a: 0.40092914012130576d, b: 0.24497853203154596d, c: 0.9736845426343244d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7203524642127108d, b: 0.3752689175686086d, c: 0.9217490923740327d),
new NpgsqlTypes.NpgsqlLine(a: 0.42054269404403255d, b: 0.4608988842320272d, c: 0.3550552105719116d),
new NpgsqlTypes.NpgsqlLine(a: 0.16272570702883282d, b: 0.8198949395522959d, c: 0.8847810252117563d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7904065029756026d, b: 0.8513728673411495d, c: 0.8293641981249807d),
new NpgsqlTypes.NpgsqlLine(a: 0.24416432491167228d, b: 0.9225779969703528d, c: 0.32105846127636384d),
new NpgsqlTypes.NpgsqlLine(a: 0.5594059005237745d, b: 0.21760277953622065d, c: 0.7626227528662065d),
new NpgsqlTypes.NpgsqlLine(a: 0.6769647055448743d, b: 0.09949411856858603d, c: 0.7671323979829093d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.672471851115132d, b: 0.9704132516256628d, c: 0.3718998817841459d),
new NpgsqlTypes.NpgsqlLine(a: 0.6237497579450663d, b: 0.3881760652388059d, c: 0.7184680103175869d),
new NpgsqlTypes.NpgsqlLine(a: 0.46752273846337766d, b: 0.5639805903616543d, c: 0.22317283698462898d),
new NpgsqlTypes.NpgsqlLine(a: 0.21795557645893127d, b: 0.17222692286053076d, c: 0.6752092147075863d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3095664537493805d, b: 0.9362744562873836d, c: 0.8136938074396955d),
new NpgsqlTypes.NpgsqlLine(a: 0.43118543827761024d, b: 0.21558416432189498d, c: 0.5656027911592778d),
new NpgsqlTypes.NpgsqlLine(a: 0.4148022909925828d, b: 0.3036209509474991d, c: 0.7653001734243196d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8672504239580581d, b: 0.10893527844923878d, c: 0.4289536174756374d),
new NpgsqlTypes.NpgsqlLine(a: 0.38955943949651717d, b: 0.7602732167799525d, c: 0.22285734357993925d),
new NpgsqlTypes.NpgsqlLine(a: 0.4147296575356262d, b: 0.6257941329676248d, c: 0.9980919847840326d),
new NpgsqlTypes.NpgsqlLine(a: 0.5638189696883718d, b: 0.19010670180942557d, c: 0.28959109210791334d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8854632645040267d, b: 0.11567401534395338d, c: 0.5527333506078561d),
new NpgsqlTypes.NpgsqlLine(a: 0.7445257232459903d, b: 0.12060333100676868d, c: 0.33795909927068146d),
new NpgsqlTypes.NpgsqlLine(a: 0.5361870892532005d, b: 0.020108667443716532d, c: 0.7138140394204795d),
new NpgsqlTypes.NpgsqlLine(a: 0.13175314252447645d, b: 0.5163287300309777d, c: 0.7948719542785411d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17643920686814596d, b: 0.5245917948670223d, c: 0.2058696747305392d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107144414573575d, b: 0.7841521399748231d, c: 0.2518968747756283d),
new NpgsqlTypes.NpgsqlLine(a: 0.11293717443756723d, b: 0.1267683074860534d, c: 0.5513676621526676d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48714568642069767d, b: 0.48753048535860966d, c: 0.721261707375061d),
new NpgsqlTypes.NpgsqlLine(a: 0.16781656830344294d, b: 0.8855754979907644d, c: 0.20631542929045343d),
new NpgsqlTypes.NpgsqlLine(a: 0.03412196620472352d, b: 0.7087407948087792d, c: 0.7840098706337486d),
new NpgsqlTypes.NpgsqlLine(a: 0.22494774990997357d, b: 0.09845531223139159d, c: 0.04628641822227064d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28894803363127786d, b: 0.05549877176118723d, c: 0.36074070665325486d),
new NpgsqlTypes.NpgsqlLine(a: 0.6193026638542323d, b: 0.7870635270536728d, c: 0.9725479536207916d),
new NpgsqlTypes.NpgsqlLine(a: 0.6625803974772336d, b: 0.034668678542719045d, c: 0.5564125834145486d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20618606832014597d, b: 0.9705793044594275d, c: 0.5729108874069863d),
new NpgsqlTypes.NpgsqlLine(a: 0.8248339004537858d, b: 0.46865398877530196d, c: 0.24115225948719676d),
new NpgsqlTypes.NpgsqlLine(a: 0.9054488939172282d, b: 0.6287692181402493d, c: 0.43046345186293533d),
new NpgsqlTypes.NpgsqlLine(a: 0.20510673954229364d, b: 0.25863098828824116d, c: 0.7813450732517688d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18517394767795603d, b: 0.39350053425153275d, c: 0.6547342386872851d),
new NpgsqlTypes.NpgsqlLine(a: 0.0074526512277756085d, b: 0.6587574088361511d, c: 0.20433945900434203d),
new NpgsqlTypes.NpgsqlLine(a: 0.9560737085348698d, b: 0.4819701336544422d, c: 0.4140354335635167d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3067914764953218d, b: 0.7605372419454559d, c: 0.9481051846182081d),
new NpgsqlTypes.NpgsqlLine(a: 0.8138782281008692d, b: 0.23755056569688193d, c: 0.9073229846427282d),
new NpgsqlTypes.NpgsqlLine(a: 0.612931716468449d, b: 0.48177519849962336d, c: 0.9043865428848048d),
new NpgsqlTypes.NpgsqlLine(a: 0.7430529344679154d, b: 0.6797597293693921d, c: 0.987667705212984d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4286304951989739d, b: 0.8024168105305263d, c: 0.8036140649103987d),
new NpgsqlTypes.NpgsqlLine(a: 0.5073726568599009d, b: 0.5255831300127319d, c: 0.7873852673499141d),
new NpgsqlTypes.NpgsqlLine(a: 0.3491234029922987d, b: 0.14534066542580415d, c: 0.7819401819178317d),
new NpgsqlTypes.NpgsqlLine(a: 0.18884944716074115d, b: 0.008367289324855975d, c: 0.31146381774414333d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.011631785222280255d, b: 0.6232845085749001d, c: 0.38255148987166965d),
new NpgsqlTypes.NpgsqlLine(a: 0.5958996605650595d, b: 0.7034058340085138d, c: 0.8282806458898485d),
new NpgsqlTypes.NpgsqlLine(a: 0.8034754480821944d, b: 0.18189637653271562d, c: 0.5912829681559618d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7737164693880466d, b: 0.7514246153081888d, c: 0.7163082151223427d),
new NpgsqlTypes.NpgsqlLine(a: 0.7843015337488105d, b: 0.21864962646024133d, c: 0.21379816177929523d),
new NpgsqlTypes.NpgsqlLine(a: 0.9977270166734147d, b: 0.12032159115329233d, c: 0.2049913497530188d),
new NpgsqlTypes.NpgsqlLine(a: 0.9001971704580096d, b: 0.408400458320467d, c: 0.5132101210444336d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5053332688673878d, b: 0.7644328723459379d, c: 0.8263052450545983d),
new NpgsqlTypes.NpgsqlLine(a: 0.034515660235389545d, b: 0.2053336356724843d, c: 0.381233804788909d),
new NpgsqlTypes.NpgsqlLine(a: 0.16445804323791036d, b: 0.9242996862447028d, c: 0.35382001189599355d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3398937351313559d, b: 0.44735939014497816d, c: 0.01421169457391458d),
new NpgsqlTypes.NpgsqlLine(a: 0.27002193004446573d, b: 0.42149634197555796d, c: 0.5201126510844716d),
new NpgsqlTypes.NpgsqlLine(a: 0.584891071003519d, b: 0.6346866604723317d, c: 0.41285360674505966d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3664880542669745d, b: 0.2529449372445395d, c: 0.34625796493476513d),
new NpgsqlTypes.NpgsqlLine(a: 0.7324800054835214d, b: 0.852579237503521d, c: 0.03288865481436676d),
new NpgsqlTypes.NpgsqlLine(a: 0.6780305085006157d, b: 0.34862047716823097d, c: 0.3304097863120131d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.21573850851023957d, b: 0.4068865204655754d, c: 0.5417763874676811d),
new NpgsqlTypes.NpgsqlLine(a: 0.6357205005774516d, b: 0.3280210856529381d, c: 0.9041248990986632d),
new NpgsqlTypes.NpgsqlLine(a: 0.8889958864666425d, b: 0.836087383208786d, c: 0.59995489122076d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9175238738001904d, b: 0.1581790564123301d, c: 0.28419872862712403d),
new NpgsqlTypes.NpgsqlLine(a: 0.21160261894611254d, b: 0.3079315726948285d, c: 0.5596121325153414d),
new NpgsqlTypes.NpgsqlLine(a: 0.697108809323847d, b: 0.7328486427301998d, c: 0.661093222147625d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.14288487702433106d, b: 0.28229903658425415d, c: 0.9500293608525786d),
new NpgsqlTypes.NpgsqlLine(a: 0.3503116083673006d, b: 0.0826880855717268d, c: 0.9068711017420835d),
new NpgsqlTypes.NpgsqlLine(a: 0.5500035236615805d, b: 0.5339894232424273d, c: 0.52201546489854d),
new NpgsqlTypes.NpgsqlLine(a: 0.22652870766798916d, b: 0.5529828713307949d, c: 0.843079145485119d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11973112095170768d, b: 0.9162759980153414d, c: 0.338722320609383d),
new NpgsqlTypes.NpgsqlLine(a: 0.08855242467904423d, b: 0.7886384916928838d, c: 0.8890734586219724d),
new NpgsqlTypes.NpgsqlLine(a: 0.6724273135432733d, b: 0.7688487879486424d, c: 0.5354003759316224d),
new NpgsqlTypes.NpgsqlLine(a: 0.5408102415096001d, b: 0.007952303352740553d, c: 0.031236860404450284d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1583486393385486d, b: 0.25786410369506585d, c: 0.7499986938520448d),
new NpgsqlTypes.NpgsqlLine(a: 0.8530508906939677d, b: 0.41289978356859613d, c: 0.9266357308948722d),
new NpgsqlTypes.NpgsqlLine(a: 0.009355397447010194d, b: 0.9013772512116908d, c: 0.18074569029163712d),
new NpgsqlTypes.NpgsqlLine(a: 0.12193717041636654d, b: 0.8836499113035309d, c: 0.2144489404684511d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47384138761198147d, b: 0.26750041688321935d, c: 0.906866716142284d),
new NpgsqlTypes.NpgsqlLine(a: 0.4105173725578589d, b: 0.6692654911862873d, c: 0.7942273184816238d),
new NpgsqlTypes.NpgsqlLine(a: 0.39674428122047245d, b: 0.03007674845578623d, c: 0.8744492862443196d),
new NpgsqlTypes.NpgsqlLine(a: 0.08302544478592622d, b: 0.9031969945691458d, c: 0.5083386561390045d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40561818455711063d, b: 0.7904806002599357d, c: 0.6609122203486605d),
new NpgsqlTypes.NpgsqlLine(a: 0.3072024952068545d, b: 0.6984347706050696d, c: 0.9430449069266399d),
new NpgsqlTypes.NpgsqlLine(a: 0.015565306035187798d, b: 0.8790178093538572d, c: 0.33357871594159827d),
},
    ModelInner = new NpgsqlLinelineMMArrayD1E1MI
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9977109931822495d, b: 0.8665629853170126d, c: 0.2965819580121495d),
new NpgsqlTypes.NpgsqlLine(a: 0.30307670866045977d, b: 0.7577165709506364d, c: 0.779739688169007d),
new NpgsqlTypes.NpgsqlLine(a: 0.829014546386591d, b: 0.15129253386767605d, c: 0.9333434590380955d),
new NpgsqlTypes.NpgsqlLine(a: 0.027451945388400678d, b: 0.7143550355634429d, c: 0.9638187384985717d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30231394005873213d, b: 0.3780659603593072d, c: 0.10461881719477606d),
new NpgsqlTypes.NpgsqlLine(a: 0.6360231003146257d, b: 0.03929622383690845d, c: 0.013684444611617108d),
new NpgsqlTypes.NpgsqlLine(a: 0.4118007103903569d, b: 0.23900104623703067d, c: 0.5282440498290796d),
new NpgsqlTypes.NpgsqlLine(a: 0.6712615153949455d, b: 0.29232641583467134d, c: 0.06131006775059533d),
},
},
            new NpgsqlLinelineMMArrayD1E1M
{
    Id = 185,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01972746162609751d, b: 0.8667988969403249d, c: 0.5849402672898698d),
new NpgsqlTypes.NpgsqlLine(a: 0.2524644763733215d, b: 0.23293891030283842d, c: 0.08093400024387121d),
new NpgsqlTypes.NpgsqlLine(a: 0.5659481991940827d, b: 0.08626047806293724d, c: 0.20034090769637192d),
new NpgsqlTypes.NpgsqlLine(a: 0.46124770275532634d, b: 0.6272107982356073d, c: 0.4796904606952853d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9233278329742016d, b: 0.3289415304551009d, c: 0.5620400317827126d),
new NpgsqlTypes.NpgsqlLine(a: 0.49123300974610895d, b: 0.13349183966845135d, c: 0.1780867919679452d),
new NpgsqlTypes.NpgsqlLine(a: 0.9789988636145176d, b: 0.739949942755954d, c: 0.5865885358865031d),
new NpgsqlTypes.NpgsqlLine(a: 0.8037095300167049d, b: 0.06767242279686614d, c: 0.8862641432115711d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.01305774382614766d, b: 0.7684887634282137d, c: 0.15173390193756375d),
new NpgsqlTypes.NpgsqlLine(a: 0.06306080118121038d, b: 0.7294870510115202d, c: 0.03192239993193002d),
new NpgsqlTypes.NpgsqlLine(a: 0.38547419382955783d, b: 0.5620267435079805d, c: 0.799884395741845d),
new NpgsqlTypes.NpgsqlLine(a: 0.1905961839847763d, b: 0.432259710730011d, c: 0.2909958980126246d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinemmarrayd1e1mi_id
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
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinemmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3092683519389531d, b: 0.37448100284099295d, c: 0.12925246723292538d),
new NpgsqlTypes.NpgsqlLine(a: 0.05685756978005918d, b: 0.5028628614930063d, c: 0.6145098265418323d),
new NpgsqlTypes.NpgsqlLine(a: 0.27057628039384785d, b: 0.8581514880991787d, c: 0.5888042369304278d),
}));
                nullable =  ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineMArraylineMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8643964380679343d, b: 0.6927749304872031d, c: 0.6840035406672303d),
new NpgsqlTypes.NpgsqlLine(a: 0.8037352855836133d, b: 0.8601947822317899d, c: 0.6072192194165105d),
new NpgsqlTypes.NpgsqlLine(a: 0.19821642570248021d, b: 0.5243190604905557d, c: 0.8625106791267902d),
new NpgsqlTypes.NpgsqlLine(a: 0.026632024901149465d, b: 0.3624530544540071d, c: 0.7233244989915837d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineMMArrayD1E1M> models = null;

                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineMArraylineMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M), typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 85, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 28, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 172, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 98, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
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
FROM public.npgsqllinelinemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineMMArrayD1E1M>();
                 ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 85, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
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
                var models = await((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineMArraylineMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 38, 72))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineMArraylineMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineMArraylineMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 125);
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                NpgsqlLinelineMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
FROM public.binary_npgsqllinelinemmarrayd1e1m m
LEFT JOIN public.binary_npgsqllinelinemmarrayd1e1mi mi ON mi.id = m.npgsqllinelinemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineMArraylineMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineMArraylineMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineMArraylineMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
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
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI), typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MI>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA), typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                await ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlLinelineMMArrayD1E1MIWA>();
                ((INpgsqlLineMArraylineMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineMArraylineMMArrayD1))]
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
                var models = await ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineMArraylineMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

