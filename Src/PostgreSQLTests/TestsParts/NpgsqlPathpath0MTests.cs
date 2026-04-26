

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690841481210927d, y: 0.028121963085477653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512376575545201d, y: 0.8954482322638081d), new NpgsqlTypes.NpgsqlPoint(x: 0.15688039576780288d, y: 0.012567748775523135d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8945218273523177d, y: 0.05248965778107528d), new NpgsqlTypes.NpgsqlPoint(x: 0.49770935630650115d, y: 0.8285524584234553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884748497625652d, y: 0.9901657982490656d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311580327686312d, y: 0.5406285816066773d), new NpgsqlTypes.NpgsqlPoint(x: 0.24616421738087035d, y: 0.6617808658209087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6123032081788635d, y: 0.6869865224358056d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.933399995631563d, y: 0.13310248295271354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742862354271344d, y: 0.18107865516239008d), new NpgsqlTypes.NpgsqlPoint(x: 0.05631371890896886d, y: 0.2340841324390308d)),
},
            new NpgsqlPathpath0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2937858844088477d, y: 0.5583853344578861d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531030505344272d, y: 0.7341734380259576d), new NpgsqlTypes.NpgsqlPoint(x: 0.38554855046464365d, y: 0.47240026997655105d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4485545063464442d, y: 0.7603491795997745d), new NpgsqlTypes.NpgsqlPoint(x: 0.19656837438945807d, y: 0.14382055022876705d), new NpgsqlTypes.NpgsqlPoint(x: 0.26631324311666693d, y: 0.017834211592813842d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4788366627996591d, y: 0.5872910219180304d), new NpgsqlTypes.NpgsqlPoint(x: 0.30320867938397555d, y: 0.38974179809927123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719910399311119d, y: 0.30342187649400587d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477215166852014d, y: 0.6732204822133785d), new NpgsqlTypes.NpgsqlPoint(x: 0.835991966217932d, y: 0.31665298306534695d), new NpgsqlTypes.NpgsqlPoint(x: 0.27062663457128544d, y: 0.2152686050117426d)),
},
            new NpgsqlPathpath0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811055219072799d, y: 0.5543909982688051d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069966200210871d, y: 0.427156321294468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2353486713402514d, y: 0.45540995241039317d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7072001715645777d, y: 0.8218046742140434d), new NpgsqlTypes.NpgsqlPoint(x: 0.723045747125272d, y: 0.9638234694125905d), new NpgsqlTypes.NpgsqlPoint(x: 0.783086270603516d, y: 0.3468435140271463d)),
},
            new NpgsqlPathpath0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2754110237174744d, y: 0.391976045581503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845591051345014d, y: 0.5166430179344337d), new NpgsqlTypes.NpgsqlPoint(x: 0.1850578397638506d, y: 0.3884199214210068d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.535620632128272d, y: 0.6112869270408334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10992691391014975d, y: 0.43545657992618503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974439508304068d, y: 0.3911344952917206d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469037412655845d, y: 0.35872877217013155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598045906485059d, y: 0.2685785707297754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0046064598443597005d, y: 0.8245470297048284d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39122303776295253d, y: 0.8330628607241071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967029285182125d, y: 0.804762150220035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525221875681772d, y: 0.06010469167806465d)),
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6590583294806022d, y: 0.4100075388118256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125927053700401d, y: 0.1230961285891683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2320060966862436d, y: 0.8804690233001936d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303676169541933d, y: 0.6367150762890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095704303342392d, y: 0.3319599571294013d), new NpgsqlTypes.NpgsqlPoint(x: 0.13067555840759482d, y: 0.6188702850531561d)),
},
            new NpgsqlPathpath0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8284710640340448d, y: 0.7780459116030978d), new NpgsqlTypes.NpgsqlPoint(x: 0.10628540820258836d, y: 0.5178599330045829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961619030863794d, y: 0.5484697801303399d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2366644322920195d, y: 0.1243664676729832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344156350863917d, y: 0.005783559564560781d), new NpgsqlTypes.NpgsqlPoint(x: 0.014670408050547423d, y: 0.9292022425622717d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5160126746421919d, y: 0.44399757190418987d), new NpgsqlTypes.NpgsqlPoint(x: 0.97888486439751d, y: 0.4472166922606492d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106022912269802d, y: 0.9380379796262376d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9088893596588391d, y: 0.9898709898926085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218569300085473d, y: 0.9949569147951911d), new NpgsqlTypes.NpgsqlPoint(x: 0.21902777595044398d, y: 0.3427010303733652d)),
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39701184681648993d, y: 0.038678045739952926d), new NpgsqlTypes.NpgsqlPoint(x: 0.13077718912787717d, y: 0.7452255833947999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356058659378562d, y: 0.04034670064080481d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5967844636343422d, y: 0.4550206677165256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383605246957039d, y: 0.5028903524282919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236324001796061d, y: 0.7774137379574807d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2355729803977462d, y: 0.9183571371282031d), new NpgsqlTypes.NpgsqlPoint(x: 0.41840686193206145d, y: 0.4092789290248575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689360161985237d, y: 0.06726600901788049d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011410767607512473d, y: 0.4441136209959343d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490215385623391d, y: 0.8665895657428704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482234213890483d, y: 0.5363949610867361d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9976081887883214d, y: 0.20451788891748335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1735060095920251d, y: 0.6862819201953573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351981246854681d, y: 0.6932320982413059d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498344022958535d, y: 0.8710878052360539d), new NpgsqlTypes.NpgsqlPoint(x: 0.47709934292786615d, y: 0.2172961711941518d), new NpgsqlTypes.NpgsqlPoint(x: 0.030328205217899473d, y: 0.18302604932167132d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947577377211907d, y: 0.19741775834931385d), new NpgsqlTypes.NpgsqlPoint(x: 0.16129881436955418d, y: 0.47068270798991274d), new NpgsqlTypes.NpgsqlPoint(x: 0.787382827268766d, y: 0.8682118892426601d)),
},
            new NpgsqlPathpath0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526778419097933d, y: 0.23431937923293988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077294825863115d, y: 0.3102321630534024d), new NpgsqlTypes.NpgsqlPoint(x: 0.28009928332382394d, y: 0.310395416067459d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.937587864860008d, y: 0.9731792599274249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378838908067856d, y: 0.4495635914427316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954971515487575d, y: 0.7737751608845364d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.62107254300405d, y: 0.8832073026782741d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334832657101622d, y: 0.2734335716538021d), new NpgsqlTypes.NpgsqlPoint(x: 0.35361489906200605d, y: 0.09754838340875571d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738922430841923d, y: 0.23064901712310615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482098776064065d, y: 0.5758960058014085d), new NpgsqlTypes.NpgsqlPoint(x: 0.19269184598417066d, y: 0.08553845731194676d)),
},
            new NpgsqlPathpath0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553945712688482d, y: 0.7966434722113973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882503126181364d, y: 0.12977015804083047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900836599586975d, y: 0.5575180168060572d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523997922998912d, y: 0.4323935268804411d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973347417198084d, y: 0.051766651705433375d), new NpgsqlTypes.NpgsqlPoint(x: 0.22945923898929188d, y: 0.6498471609008527d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5918910219929896d, y: 0.6900670095927186d), new NpgsqlTypes.NpgsqlPoint(x: 0.21242986492365d, y: 0.8953640396625933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278102572849629d, y: 0.1186908256292587d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107142076892958d, y: 0.5148827884833809d), new NpgsqlTypes.NpgsqlPoint(x: 0.981291988324665d, y: 0.8046221867251142d), new NpgsqlTypes.NpgsqlPoint(x: 0.19160179861074123d, y: 0.5879007829466474d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792769620782126d, y: 0.1135478082130027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549066367894375d, y: 0.5370389877809956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8352187519652093d, y: 0.37621541170380246d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7515725224540075d, y: 0.13747180212456211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25276303252551724d, y: 0.5042829742506724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806770275670727d, y: 0.3360197461771842d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999549514668371d, y: 0.23121144069501098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679061759698655d, y: 0.5521221994660792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612623688259395d, y: 0.03997569202031337d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7206602527273472d, y: 0.19745589182809808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998367988920754d, y: 0.14196745354137918d), new NpgsqlTypes.NpgsqlPoint(x: 0.15028350037933746d, y: 0.4780737546327041d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15450016691448953d, y: 0.9138219171281908d), new NpgsqlTypes.NpgsqlPoint(x: 0.33857619963915075d, y: 0.5953772068929787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555047862825206d, y: 0.31103650891425993d)),
},
            new NpgsqlPathpath0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3432481563505487d, y: 0.612326657066268d), new NpgsqlTypes.NpgsqlPoint(x: 0.18450305975070191d, y: 0.33823464865230746d), new NpgsqlTypes.NpgsqlPoint(x: 0.30575855162618226d, y: 0.9823678623262814d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9586128051999129d, y: 0.13271911850644802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17056684213554563d, y: 0.5689455261223539d), new NpgsqlTypes.NpgsqlPoint(x: 0.49914462594915776d, y: 0.20885471297347913d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38666705844445715d, y: 0.2639921198834143d), new NpgsqlTypes.NpgsqlPoint(x: 0.19681279592616263d, y: 0.6891399497390712d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030496874869906376d, y: 0.13541231019067168d)),
},
            new NpgsqlPathpath0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4675297488765794d, y: 0.0988779810364071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620841863986144d, y: 0.14546650445180487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20201285616739018d, y: 0.9335712322392595d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42599580334342635d, y: 0.7923807789405005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701861261692679d, y: 0.45035621619513877d), new NpgsqlTypes.NpgsqlPoint(x: 0.21918844111191138d, y: 0.867633472039068d)),
},
            new NpgsqlPathpath0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14451313789286002d, y: 0.5504001786492523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641285799996592d, y: 0.9182531459345166d), new NpgsqlTypes.NpgsqlPoint(x: 0.02895046999927786d, y: 0.866486348577206d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028566423387859d, y: 0.30119318695869857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297778678761438d, y: 0.9563457657352354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692695966202707d, y: 0.6465648405647674d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14319344322231586d, y: 0.6364356749525206d), new NpgsqlTypes.NpgsqlPoint(x: 0.21900445188363915d, y: 0.9340267816188148d), new NpgsqlTypes.NpgsqlPoint(x: 0.260530747494085d, y: 0.8763300928040453d)),
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2714698380347964d, y: 0.6136827620571135d), new NpgsqlTypes.NpgsqlPoint(x: 0.027029908324224916d, y: 0.12138085336853721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391539981638d, y: 0.25974211560842975d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7721144921194402d, y: 0.47890220317332044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633101914033305d, y: 0.4450013562967783d), new NpgsqlTypes.NpgsqlPoint(x: 0.1687873623079179d, y: 0.3823576020135817d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07571473600946366d, y: 0.7889376293767698d), new NpgsqlTypes.NpgsqlPoint(x: 0.21981840731035096d, y: 0.34477837200946126d), new NpgsqlTypes.NpgsqlPoint(x: 0.825786115393182d, y: 0.7875446104030528d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012647693916916d, y: 0.6121275228277524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682868198582357d, y: 0.6894258551367215d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589342526146607d, y: 0.7111004556875891d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49210119118183493d, y: 0.47162366489870133d), new NpgsqlTypes.NpgsqlPoint(x: 0.42483999836737163d, y: 0.5035848879745997d), new NpgsqlTypes.NpgsqlPoint(x: 0.10244861119429782d, y: 0.6098511436446634d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303314126456524d, y: 0.05168120189413905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626264686080316d, y: 0.7804268520453854d), new NpgsqlTypes.NpgsqlPoint(x: 0.827048479376937d, y: 0.6288257965925629d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8473090969957064d, y: 0.32364575962813413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457338104886006d, y: 0.6431206538481294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874296484344398d, y: 0.1773879330501067d)),
},
            new NpgsqlPathpath0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8682126769378182d, y: 0.19168689535332661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897560849835883d, y: 0.8167474935135276d), new NpgsqlTypes.NpgsqlPoint(x: 0.774349868298468d, y: 0.4864230850058304d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5874283107157677d, y: 0.4103084000743772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184812584270049d, y: 0.7600819111330228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474974015452766d, y: 0.5686105136691664d)),
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8601155858947097d, y: 0.5120220211906857d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150114626498773d, y: 0.44997435309025535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432987474574358d, y: 0.46699275517308847d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633535658683795d, y: 0.4881371344298965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044626859024311d, y: 0.6819123433101222d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905307026288098d, y: 0.4521700961853472d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3999942293875788d, y: 0.11941080511168634d), new NpgsqlTypes.NpgsqlPoint(x: 0.13828549247524136d, y: 0.7833271210548062d), new NpgsqlTypes.NpgsqlPoint(x: 0.240551591565902d, y: 0.05620716941346904d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5635056108198272d, y: 0.7183369903061987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405772840350816d, y: 0.8863166949393558d), new NpgsqlTypes.NpgsqlPoint(x: 0.16008509308926444d, y: 0.047325013870092913d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8323627847257308d, y: 0.08988661794919295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712681911117923d, y: 0.3280089529942499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701876672328392d, y: 0.961355024020145d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805755784479325d, y: 0.8978633697979649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678359463690328d, y: 0.8106864709350717d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996350582843261d, y: 0.8809665206966493d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.803424670753287d, y: 0.9161967615602892d), new NpgsqlTypes.NpgsqlPoint(x: 0.860928086592998d, y: 0.7255952869354579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905174864876891d, y: 0.5443616833558882d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12959544752212016d, y: 0.6648110097047486d), new NpgsqlTypes.NpgsqlPoint(x: 0.01707465483819226d, y: 0.56032734202323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961490445399431d, y: 0.09349549541967306d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9383505470635968d, y: 0.36035799996611173d), new NpgsqlTypes.NpgsqlPoint(x: 0.443845874048992d, y: 0.11904123277117407d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008982205966576d, y: 0.3204849515079641d)),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7072001715645777d, y: 0.8218046742140434d), new NpgsqlTypes.NpgsqlPoint(x: 0.723045747125272d, y: 0.9638234694125905d), new NpgsqlTypes.NpgsqlPoint(x: 0.783086270603516d, y: 0.3468435140271463d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39122303776295253d, y: 0.8330628607241071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967029285182125d, y: 0.804762150220035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525221875681772d, y: 0.06010469167806465d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303676169541933d, y: 0.6367150762890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095704303342392d, y: 0.3319599571294013d), new NpgsqlTypes.NpgsqlPoint(x: 0.13067555840759482d, y: 0.6188702850531561d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9088893596588391d, y: 0.9898709898926085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218569300085473d, y: 0.9949569147951911d), new NpgsqlTypes.NpgsqlPoint(x: 0.21902777595044398d, y: 0.3427010303733652d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9976081887883214d, y: 0.20451788891748335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1735060095920251d, y: 0.6862819201953573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351981246854681d, y: 0.6932320982413059d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947577377211907d, y: 0.19741775834931385d), new NpgsqlTypes.NpgsqlPoint(x: 0.16129881436955418d, y: 0.47068270798991274d), new NpgsqlTypes.NpgsqlPoint(x: 0.787382827268766d, y: 0.8682118892426601d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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

                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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

                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
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

                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 58, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 125, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatchAsync(connection, 74, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatch(connection, 56, 75))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690841481210927d, y: 0.028121963085477653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512376575545201d, y: 0.8954482322638081d), new NpgsqlTypes.NpgsqlPoint(x: 0.15688039576780288d, y: 0.012567748775523135d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8945218273523177d, y: 0.05248965778107528d), new NpgsqlTypes.NpgsqlPoint(x: 0.49770935630650115d, y: 0.8285524584234553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884748497625652d, y: 0.9901657982490656d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311580327686312d, y: 0.5406285816066773d), new NpgsqlTypes.NpgsqlPoint(x: 0.24616421738087035d, y: 0.6617808658209087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6123032081788635d, y: 0.6869865224358056d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.933399995631563d, y: 0.13310248295271354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742862354271344d, y: 0.18107865516239008d), new NpgsqlTypes.NpgsqlPoint(x: 0.05631371890896886d, y: 0.2340841324390308d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2937858844088477d, y: 0.5583853344578861d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531030505344272d, y: 0.7341734380259576d), new NpgsqlTypes.NpgsqlPoint(x: 0.38554855046464365d, y: 0.47240026997655105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4485545063464442d, y: 0.7603491795997745d), new NpgsqlTypes.NpgsqlPoint(x: 0.19656837438945807d, y: 0.14382055022876705d), new NpgsqlTypes.NpgsqlPoint(x: 0.26631324311666693d, y: 0.017834211592813842d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4788366627996591d, y: 0.5872910219180304d), new NpgsqlTypes.NpgsqlPoint(x: 0.30320867938397555d, y: 0.38974179809927123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719910399311119d, y: 0.30342187649400587d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477215166852014d, y: 0.6732204822133785d), new NpgsqlTypes.NpgsqlPoint(x: 0.835991966217932d, y: 0.31665298306534695d), new NpgsqlTypes.NpgsqlPoint(x: 0.27062663457128544d, y: 0.2152686050117426d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811055219072799d, y: 0.5543909982688051d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069966200210871d, y: 0.427156321294468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2353486713402514d, y: 0.45540995241039317d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7072001715645777d, y: 0.8218046742140434d), new NpgsqlTypes.NpgsqlPoint(x: 0.723045747125272d, y: 0.9638234694125905d), new NpgsqlTypes.NpgsqlPoint(x: 0.783086270603516d, y: 0.3468435140271463d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2754110237174744d, y: 0.391976045581503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845591051345014d, y: 0.5166430179344337d), new NpgsqlTypes.NpgsqlPoint(x: 0.1850578397638506d, y: 0.3884199214210068d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.535620632128272d, y: 0.6112869270408334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10992691391014975d, y: 0.43545657992618503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974439508304068d, y: 0.3911344952917206d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469037412655845d, y: 0.35872877217013155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598045906485059d, y: 0.2685785707297754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0046064598443597005d, y: 0.8245470297048284d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39122303776295253d, y: 0.8330628607241071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967029285182125d, y: 0.804762150220035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525221875681772d, y: 0.06010469167806465d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6590583294806022d, y: 0.4100075388118256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125927053700401d, y: 0.1230961285891683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2320060966862436d, y: 0.8804690233001936d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303676169541933d, y: 0.6367150762890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095704303342392d, y: 0.3319599571294013d), new NpgsqlTypes.NpgsqlPoint(x: 0.13067555840759482d, y: 0.6188702850531561d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8284710640340448d, y: 0.7780459116030978d), new NpgsqlTypes.NpgsqlPoint(x: 0.10628540820258836d, y: 0.5178599330045829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961619030863794d, y: 0.5484697801303399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2366644322920195d, y: 0.1243664676729832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344156350863917d, y: 0.005783559564560781d), new NpgsqlTypes.NpgsqlPoint(x: 0.014670408050547423d, y: 0.9292022425622717d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5160126746421919d, y: 0.44399757190418987d), new NpgsqlTypes.NpgsqlPoint(x: 0.97888486439751d, y: 0.4472166922606492d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106022912269802d, y: 0.9380379796262376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9088893596588391d, y: 0.9898709898926085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218569300085473d, y: 0.9949569147951911d), new NpgsqlTypes.NpgsqlPoint(x: 0.21902777595044398d, y: 0.3427010303733652d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39701184681648993d, y: 0.038678045739952926d), new NpgsqlTypes.NpgsqlPoint(x: 0.13077718912787717d, y: 0.7452255833947999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356058659378562d, y: 0.04034670064080481d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5967844636343422d, y: 0.4550206677165256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383605246957039d, y: 0.5028903524282919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236324001796061d, y: 0.7774137379574807d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2355729803977462d, y: 0.9183571371282031d), new NpgsqlTypes.NpgsqlPoint(x: 0.41840686193206145d, y: 0.4092789290248575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689360161985237d, y: 0.06726600901788049d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011410767607512473d, y: 0.4441136209959343d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490215385623391d, y: 0.8665895657428704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482234213890483d, y: 0.5363949610867361d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9976081887883214d, y: 0.20451788891748335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1735060095920251d, y: 0.6862819201953573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351981246854681d, y: 0.6932320982413059d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498344022958535d, y: 0.8710878052360539d), new NpgsqlTypes.NpgsqlPoint(x: 0.47709934292786615d, y: 0.2172961711941518d), new NpgsqlTypes.NpgsqlPoint(x: 0.030328205217899473d, y: 0.18302604932167132d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947577377211907d, y: 0.19741775834931385d), new NpgsqlTypes.NpgsqlPoint(x: 0.16129881436955418d, y: 0.47068270798991274d), new NpgsqlTypes.NpgsqlPoint(x: 0.787382827268766d, y: 0.8682118892426601d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526778419097933d, y: 0.23431937923293988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077294825863115d, y: 0.3102321630534024d), new NpgsqlTypes.NpgsqlPoint(x: 0.28009928332382394d, y: 0.310395416067459d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.937587864860008d, y: 0.9731792599274249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378838908067856d, y: 0.4495635914427316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954971515487575d, y: 0.7737751608845364d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.62107254300405d, y: 0.8832073026782741d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334832657101622d, y: 0.2734335716538021d), new NpgsqlTypes.NpgsqlPoint(x: 0.35361489906200605d, y: 0.09754838340875571d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738922430841923d, y: 0.23064901712310615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482098776064065d, y: 0.5758960058014085d), new NpgsqlTypes.NpgsqlPoint(x: 0.19269184598417066d, y: 0.08553845731194676d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553945712688482d, y: 0.7966434722113973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882503126181364d, y: 0.12977015804083047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900836599586975d, y: 0.5575180168060572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523997922998912d, y: 0.4323935268804411d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973347417198084d, y: 0.051766651705433375d), new NpgsqlTypes.NpgsqlPoint(x: 0.22945923898929188d, y: 0.6498471609008527d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5918910219929896d, y: 0.6900670095927186d), new NpgsqlTypes.NpgsqlPoint(x: 0.21242986492365d, y: 0.8953640396625933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278102572849629d, y: 0.1186908256292587d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107142076892958d, y: 0.5148827884833809d), new NpgsqlTypes.NpgsqlPoint(x: 0.981291988324665d, y: 0.8046221867251142d), new NpgsqlTypes.NpgsqlPoint(x: 0.19160179861074123d, y: 0.5879007829466474d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792769620782126d, y: 0.1135478082130027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549066367894375d, y: 0.5370389877809956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8352187519652093d, y: 0.37621541170380246d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7515725224540075d, y: 0.13747180212456211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25276303252551724d, y: 0.5042829742506724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806770275670727d, y: 0.3360197461771842d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999549514668371d, y: 0.23121144069501098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679061759698655d, y: 0.5521221994660792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612623688259395d, y: 0.03997569202031337d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7206602527273472d, y: 0.19745589182809808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998367988920754d, y: 0.14196745354137918d), new NpgsqlTypes.NpgsqlPoint(x: 0.15028350037933746d, y: 0.4780737546327041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15450016691448953d, y: 0.9138219171281908d), new NpgsqlTypes.NpgsqlPoint(x: 0.33857619963915075d, y: 0.5953772068929787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555047862825206d, y: 0.31103650891425993d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3432481563505487d, y: 0.612326657066268d), new NpgsqlTypes.NpgsqlPoint(x: 0.18450305975070191d, y: 0.33823464865230746d), new NpgsqlTypes.NpgsqlPoint(x: 0.30575855162618226d, y: 0.9823678623262814d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9586128051999129d, y: 0.13271911850644802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17056684213554563d, y: 0.5689455261223539d), new NpgsqlTypes.NpgsqlPoint(x: 0.49914462594915776d, y: 0.20885471297347913d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38666705844445715d, y: 0.2639921198834143d), new NpgsqlTypes.NpgsqlPoint(x: 0.19681279592616263d, y: 0.6891399497390712d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030496874869906376d, y: 0.13541231019067168d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4675297488765794d, y: 0.0988779810364071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620841863986144d, y: 0.14546650445180487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20201285616739018d, y: 0.9335712322392595d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42599580334342635d, y: 0.7923807789405005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701861261692679d, y: 0.45035621619513877d), new NpgsqlTypes.NpgsqlPoint(x: 0.21918844111191138d, y: 0.867633472039068d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14451313789286002d, y: 0.5504001786492523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641285799996592d, y: 0.9182531459345166d), new NpgsqlTypes.NpgsqlPoint(x: 0.02895046999927786d, y: 0.866486348577206d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028566423387859d, y: 0.30119318695869857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297778678761438d, y: 0.9563457657352354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692695966202707d, y: 0.6465648405647674d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14319344322231586d, y: 0.6364356749525206d), new NpgsqlTypes.NpgsqlPoint(x: 0.21900445188363915d, y: 0.9340267816188148d), new NpgsqlTypes.NpgsqlPoint(x: 0.260530747494085d, y: 0.8763300928040453d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2714698380347964d, y: 0.6136827620571135d), new NpgsqlTypes.NpgsqlPoint(x: 0.027029908324224916d, y: 0.12138085336853721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391539981638d, y: 0.25974211560842975d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7721144921194402d, y: 0.47890220317332044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633101914033305d, y: 0.4450013562967783d), new NpgsqlTypes.NpgsqlPoint(x: 0.1687873623079179d, y: 0.3823576020135817d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07571473600946366d, y: 0.7889376293767698d), new NpgsqlTypes.NpgsqlPoint(x: 0.21981840731035096d, y: 0.34477837200946126d), new NpgsqlTypes.NpgsqlPoint(x: 0.825786115393182d, y: 0.7875446104030528d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012647693916916d, y: 0.6121275228277524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682868198582357d, y: 0.6894258551367215d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589342526146607d, y: 0.7111004556875891d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49210119118183493d, y: 0.47162366489870133d), new NpgsqlTypes.NpgsqlPoint(x: 0.42483999836737163d, y: 0.5035848879745997d), new NpgsqlTypes.NpgsqlPoint(x: 0.10244861119429782d, y: 0.6098511436446634d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303314126456524d, y: 0.05168120189413905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626264686080316d, y: 0.7804268520453854d), new NpgsqlTypes.NpgsqlPoint(x: 0.827048479376937d, y: 0.6288257965925629d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8473090969957064d, y: 0.32364575962813413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457338104886006d, y: 0.6431206538481294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874296484344398d, y: 0.1773879330501067d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8682126769378182d, y: 0.19168689535332661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897560849835883d, y: 0.8167474935135276d), new NpgsqlTypes.NpgsqlPoint(x: 0.774349868298468d, y: 0.4864230850058304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5874283107157677d, y: 0.4103084000743772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184812584270049d, y: 0.7600819111330228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474974015452766d, y: 0.5686105136691664d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8601155858947097d, y: 0.5120220211906857d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150114626498773d, y: 0.44997435309025535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432987474574358d, y: 0.46699275517308847d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633535658683795d, y: 0.4881371344298965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044626859024311d, y: 0.6819123433101222d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905307026288098d, y: 0.4521700961853472d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3999942293875788d, y: 0.11941080511168634d), new NpgsqlTypes.NpgsqlPoint(x: 0.13828549247524136d, y: 0.7833271210548062d), new NpgsqlTypes.NpgsqlPoint(x: 0.240551591565902d, y: 0.05620716941346904d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5635056108198272d, y: 0.7183369903061987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405772840350816d, y: 0.8863166949393558d), new NpgsqlTypes.NpgsqlPoint(x: 0.16008509308926444d, y: 0.047325013870092913d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8323627847257308d, y: 0.08988661794919295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712681911117923d, y: 0.3280089529942499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701876672328392d, y: 0.961355024020145d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805755784479325d, y: 0.8978633697979649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678359463690328d, y: 0.8106864709350717d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996350582843261d, y: 0.8809665206966493d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.803424670753287d, y: 0.9161967615602892d), new NpgsqlTypes.NpgsqlPoint(x: 0.860928086592998d, y: 0.7255952869354579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905174864876891d, y: 0.5443616833558882d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12959544752212016d, y: 0.6648110097047486d), new NpgsqlTypes.NpgsqlPoint(x: 0.01707465483819226d, y: 0.56032734202323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961490445399431d, y: 0.09349549541967306d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9383505470635968d, y: 0.36035799996611173d), new NpgsqlTypes.NpgsqlPoint(x: 0.443845874048992d, y: 0.11904123277117407d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008982205966576d, y: 0.3204849515079641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.690841481210927d, y: 0.028121963085477653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7512376575545201d, y: 0.8954482322638081d), new NpgsqlTypes.NpgsqlPoint(x: 0.15688039576780288d, y: 0.012567748775523135d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8945218273523177d, y: 0.05248965778107528d), new NpgsqlTypes.NpgsqlPoint(x: 0.49770935630650115d, y: 0.8285524584234553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884748497625652d, y: 0.9901657982490656d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6311580327686312d, y: 0.5406285816066773d), new NpgsqlTypes.NpgsqlPoint(x: 0.24616421738087035d, y: 0.6617808658209087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6123032081788635d, y: 0.6869865224358056d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.933399995631563d, y: 0.13310248295271354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742862354271344d, y: 0.18107865516239008d), new NpgsqlTypes.NpgsqlPoint(x: 0.05631371890896886d, y: 0.2340841324390308d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2937858844088477d, y: 0.5583853344578861d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531030505344272d, y: 0.7341734380259576d), new NpgsqlTypes.NpgsqlPoint(x: 0.38554855046464365d, y: 0.47240026997655105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4485545063464442d, y: 0.7603491795997745d), new NpgsqlTypes.NpgsqlPoint(x: 0.19656837438945807d, y: 0.14382055022876705d), new NpgsqlTypes.NpgsqlPoint(x: 0.26631324311666693d, y: 0.017834211592813842d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4788366627996591d, y: 0.5872910219180304d), new NpgsqlTypes.NpgsqlPoint(x: 0.30320867938397555d, y: 0.38974179809927123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719910399311119d, y: 0.30342187649400587d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7477215166852014d, y: 0.6732204822133785d), new NpgsqlTypes.NpgsqlPoint(x: 0.835991966217932d, y: 0.31665298306534695d), new NpgsqlTypes.NpgsqlPoint(x: 0.27062663457128544d, y: 0.2152686050117426d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811055219072799d, y: 0.5543909982688051d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069966200210871d, y: 0.427156321294468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2353486713402514d, y: 0.45540995241039317d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7072001715645777d, y: 0.8218046742140434d), new NpgsqlTypes.NpgsqlPoint(x: 0.723045747125272d, y: 0.9638234694125905d), new NpgsqlTypes.NpgsqlPoint(x: 0.783086270603516d, y: 0.3468435140271463d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2754110237174744d, y: 0.391976045581503d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845591051345014d, y: 0.5166430179344337d), new NpgsqlTypes.NpgsqlPoint(x: 0.1850578397638506d, y: 0.3884199214210068d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.535620632128272d, y: 0.6112869270408334d), new NpgsqlTypes.NpgsqlPoint(x: 0.10992691391014975d, y: 0.43545657992618503d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974439508304068d, y: 0.3911344952917206d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5469037412655845d, y: 0.35872877217013155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598045906485059d, y: 0.2685785707297754d), new NpgsqlTypes.NpgsqlPoint(x: 0.0046064598443597005d, y: 0.8245470297048284d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39122303776295253d, y: 0.8330628607241071d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967029285182125d, y: 0.804762150220035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525221875681772d, y: 0.06010469167806465d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6590583294806022d, y: 0.4100075388118256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125927053700401d, y: 0.1230961285891683d), new NpgsqlTypes.NpgsqlPoint(x: 0.2320060966862436d, y: 0.8804690233001936d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303676169541933d, y: 0.6367150762890075d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095704303342392d, y: 0.3319599571294013d), new NpgsqlTypes.NpgsqlPoint(x: 0.13067555840759482d, y: 0.6188702850531561d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8284710640340448d, y: 0.7780459116030978d), new NpgsqlTypes.NpgsqlPoint(x: 0.10628540820258836d, y: 0.5178599330045829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961619030863794d, y: 0.5484697801303399d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2366644322920195d, y: 0.1243664676729832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9344156350863917d, y: 0.005783559564560781d), new NpgsqlTypes.NpgsqlPoint(x: 0.014670408050547423d, y: 0.9292022425622717d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5160126746421919d, y: 0.44399757190418987d), new NpgsqlTypes.NpgsqlPoint(x: 0.97888486439751d, y: 0.4472166922606492d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106022912269802d, y: 0.9380379796262376d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9088893596588391d, y: 0.9898709898926085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218569300085473d, y: 0.9949569147951911d), new NpgsqlTypes.NpgsqlPoint(x: 0.21902777595044398d, y: 0.3427010303733652d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39701184681648993d, y: 0.038678045739952926d), new NpgsqlTypes.NpgsqlPoint(x: 0.13077718912787717d, y: 0.7452255833947999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356058659378562d, y: 0.04034670064080481d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((58)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5967844636343422d, y: 0.4550206677165256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383605246957039d, y: 0.5028903524282919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236324001796061d, y: 0.7774137379574807d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((27)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2355729803977462d, y: 0.9183571371282031d), new NpgsqlTypes.NpgsqlPoint(x: 0.41840686193206145d, y: 0.4092789290248575d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689360161985237d, y: 0.06726600901788049d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011410767607512473d, y: 0.4441136209959343d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490215385623391d, y: 0.8665895657428704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8482234213890483d, y: 0.5363949610867361d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9976081887883214d, y: 0.20451788891748335d), new NpgsqlTypes.NpgsqlPoint(x: 0.1735060095920251d, y: 0.6862819201953573d), new NpgsqlTypes.NpgsqlPoint(x: 0.9351981246854681d, y: 0.6932320982413059d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498344022958535d, y: 0.8710878052360539d), new NpgsqlTypes.NpgsqlPoint(x: 0.47709934292786615d, y: 0.2172961711941518d), new NpgsqlTypes.NpgsqlPoint(x: 0.030328205217899473d, y: 0.18302604932167132d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9947577377211907d, y: 0.19741775834931385d), new NpgsqlTypes.NpgsqlPoint(x: 0.16129881436955418d, y: 0.47068270798991274d), new NpgsqlTypes.NpgsqlPoint(x: 0.787382827268766d, y: 0.8682118892426601d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526778419097933d, y: 0.23431937923293988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6077294825863115d, y: 0.3102321630534024d), new NpgsqlTypes.NpgsqlPoint(x: 0.28009928332382394d, y: 0.310395416067459d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.937587864860008d, y: 0.9731792599274249d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378838908067856d, y: 0.4495635914427316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954971515487575d, y: 0.7737751608845364d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.62107254300405d, y: 0.8832073026782741d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334832657101622d, y: 0.2734335716538021d), new NpgsqlTypes.NpgsqlPoint(x: 0.35361489906200605d, y: 0.09754838340875571d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9738922430841923d, y: 0.23064901712310615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11482098776064065d, y: 0.5758960058014085d), new NpgsqlTypes.NpgsqlPoint(x: 0.19269184598417066d, y: 0.08553845731194676d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553945712688482d, y: 0.7966434722113973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882503126181364d, y: 0.12977015804083047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900836599586975d, y: 0.5575180168060572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523997922998912d, y: 0.4323935268804411d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973347417198084d, y: 0.051766651705433375d), new NpgsqlTypes.NpgsqlPoint(x: 0.22945923898929188d, y: 0.6498471609008527d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5918910219929896d, y: 0.6900670095927186d), new NpgsqlTypes.NpgsqlPoint(x: 0.21242986492365d, y: 0.8953640396625933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278102572849629d, y: 0.1186908256292587d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107142076892958d, y: 0.5148827884833809d), new NpgsqlTypes.NpgsqlPoint(x: 0.981291988324665d, y: 0.8046221867251142d), new NpgsqlTypes.NpgsqlPoint(x: 0.19160179861074123d, y: 0.5879007829466474d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((75)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3792769620782126d, y: 0.1135478082130027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549066367894375d, y: 0.5370389877809956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8352187519652093d, y: 0.37621541170380246d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7515725224540075d, y: 0.13747180212456211d), new NpgsqlTypes.NpgsqlPoint(x: 0.25276303252551724d, y: 0.5042829742506724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806770275670727d, y: 0.3360197461771842d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999549514668371d, y: 0.23121144069501098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679061759698655d, y: 0.5521221994660792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612623688259395d, y: 0.03997569202031337d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7206602527273472d, y: 0.19745589182809808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998367988920754d, y: 0.14196745354137918d), new NpgsqlTypes.NpgsqlPoint(x: 0.15028350037933746d, y: 0.4780737546327041d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15450016691448953d, y: 0.9138219171281908d), new NpgsqlTypes.NpgsqlPoint(x: 0.33857619963915075d, y: 0.5953772068929787d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555047862825206d, y: 0.31103650891425993d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3432481563505487d, y: 0.612326657066268d), new NpgsqlTypes.NpgsqlPoint(x: 0.18450305975070191d, y: 0.33823464865230746d), new NpgsqlTypes.NpgsqlPoint(x: 0.30575855162618226d, y: 0.9823678623262814d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((49)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9586128051999129d, y: 0.13271911850644802d), new NpgsqlTypes.NpgsqlPoint(x: 0.17056684213554563d, y: 0.5689455261223539d), new NpgsqlTypes.NpgsqlPoint(x: 0.49914462594915776d, y: 0.20885471297347913d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38666705844445715d, y: 0.2639921198834143d), new NpgsqlTypes.NpgsqlPoint(x: 0.19681279592616263d, y: 0.6891399497390712d), new NpgsqlTypes.NpgsqlPoint(x: 0.0030496874869906376d, y: 0.13541231019067168d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4675297488765794d, y: 0.0988779810364071d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620841863986144d, y: 0.14546650445180487d), new NpgsqlTypes.NpgsqlPoint(x: 0.20201285616739018d, y: 0.9335712322392595d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42599580334342635d, y: 0.7923807789405005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701861261692679d, y: 0.45035621619513877d), new NpgsqlTypes.NpgsqlPoint(x: 0.21918844111191138d, y: 0.867633472039068d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14451313789286002d, y: 0.5504001786492523d), new NpgsqlTypes.NpgsqlPoint(x: 0.2641285799996592d, y: 0.9182531459345166d), new NpgsqlTypes.NpgsqlPoint(x: 0.02895046999927786d, y: 0.866486348577206d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9028566423387859d, y: 0.30119318695869857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297778678761438d, y: 0.9563457657352354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692695966202707d, y: 0.6465648405647674d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14319344322231586d, y: 0.6364356749525206d), new NpgsqlTypes.NpgsqlPoint(x: 0.21900445188363915d, y: 0.9340267816188148d), new NpgsqlTypes.NpgsqlPoint(x: 0.260530747494085d, y: 0.8763300928040453d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2714698380347964d, y: 0.6136827620571135d), new NpgsqlTypes.NpgsqlPoint(x: 0.027029908324224916d, y: 0.12138085336853721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391539981638d, y: 0.25974211560842975d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7721144921194402d, y: 0.47890220317332044d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633101914033305d, y: 0.4450013562967783d), new NpgsqlTypes.NpgsqlPoint(x: 0.1687873623079179d, y: 0.3823576020135817d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07571473600946366d, y: 0.7889376293767698d), new NpgsqlTypes.NpgsqlPoint(x: 0.21981840731035096d, y: 0.34477837200946126d), new NpgsqlTypes.NpgsqlPoint(x: 0.825786115393182d, y: 0.7875446104030528d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012647693916916d, y: 0.6121275228277524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682868198582357d, y: 0.6894258551367215d), new NpgsqlTypes.NpgsqlPoint(x: 0.4589342526146607d, y: 0.7111004556875891d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49210119118183493d, y: 0.47162366489870133d), new NpgsqlTypes.NpgsqlPoint(x: 0.42483999836737163d, y: 0.5035848879745997d), new NpgsqlTypes.NpgsqlPoint(x: 0.10244861119429782d, y: 0.6098511436446634d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((63)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1303314126456524d, y: 0.05168120189413905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3626264686080316d, y: 0.7804268520453854d), new NpgsqlTypes.NpgsqlPoint(x: 0.827048479376937d, y: 0.6288257965925629d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8473090969957064d, y: 0.32364575962813413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457338104886006d, y: 0.6431206538481294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874296484344398d, y: 0.1773879330501067d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8682126769378182d, y: 0.19168689535332661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897560849835883d, y: 0.8167474935135276d), new NpgsqlTypes.NpgsqlPoint(x: 0.774349868298468d, y: 0.4864230850058304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5874283107157677d, y: 0.4103084000743772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8184812584270049d, y: 0.7600819111330228d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474974015452766d, y: 0.5686105136691664d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8601155858947097d, y: 0.5120220211906857d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150114626498773d, y: 0.44997435309025535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432987474574358d, y: 0.46699275517308847d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7633535658683795d, y: 0.4881371344298965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044626859024311d, y: 0.6819123433101222d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905307026288098d, y: 0.4521700961853472d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3999942293875788d, y: 0.11941080511168634d), new NpgsqlTypes.NpgsqlPoint(x: 0.13828549247524136d, y: 0.7833271210548062d), new NpgsqlTypes.NpgsqlPoint(x: 0.240551591565902d, y: 0.05620716941346904d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5635056108198272d, y: 0.7183369903061987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6405772840350816d, y: 0.8863166949393558d), new NpgsqlTypes.NpgsqlPoint(x: 0.16008509308926444d, y: 0.047325013870092913d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8323627847257308d, y: 0.08988661794919295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712681911117923d, y: 0.3280089529942499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701876672328392d, y: 0.961355024020145d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9805755784479325d, y: 0.8978633697979649d), new NpgsqlTypes.NpgsqlPoint(x: 0.8678359463690328d, y: 0.8106864709350717d), new NpgsqlTypes.NpgsqlPoint(x: 0.4996350582843261d, y: 0.8809665206966493d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.803424670753287d, y: 0.9161967615602892d), new NpgsqlTypes.NpgsqlPoint(x: 0.860928086592998d, y: 0.7255952869354579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905174864876891d, y: 0.5443616833558882d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12959544752212016d, y: 0.6648110097047486d), new NpgsqlTypes.NpgsqlPoint(x: 0.01707465483819226d, y: 0.56032734202323d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961490445399431d, y: 0.09349549541967306d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9383505470635968d, y: 0.36035799996611173d), new NpgsqlTypes.NpgsqlPoint(x: 0.443845874048992d, y: 0.11904123277117407d), new NpgsqlTypes.NpgsqlPoint(x: 0.09008982205966576d, y: 0.3204849515079641d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

