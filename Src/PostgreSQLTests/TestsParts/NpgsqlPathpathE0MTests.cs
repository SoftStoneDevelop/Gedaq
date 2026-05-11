

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

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7143720116108454d, y: 0.23930850129916537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189450245864162d, y: 0.48319857556585677d), new NpgsqlTypes.NpgsqlPoint(x: 0.030533964066481567d, y: 0.39976844494801156d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833959263208322d, y: 0.36271238034269304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608108568083293d, y: 0.9867012534580587d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943415942781319d, y: 0.9081250743793784d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23983419961942376d, y: 0.9470028794500718d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788022893845393d, y: 0.9892709395193885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522014917046844d, y: 0.2811252886531874d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.283637443052169d, y: 0.5499393659630053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2321897375182227d, y: 0.8489792840715015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075438524323487d, y: 0.2647511502211197d)),
},
            new NpgsqlPathpathE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39986870680539766d, y: 0.7022513027028728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546294239423191d, y: 0.623475464006383d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356649433235677d, y: 0.9653070875681757d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.875612466890416d, y: 0.4036908998653135d), new NpgsqlTypes.NpgsqlPoint(x: 0.25171493164453584d, y: 0.07309555289193514d), new NpgsqlTypes.NpgsqlPoint(x: 0.823898145089971d, y: 0.6361919039279478d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699433567596118d, y: 0.7213012028097932d), new NpgsqlTypes.NpgsqlPoint(x: 0.05867474731827094d, y: 0.7556864585905051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7821308088643009d, y: 0.573385425839784d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531444566836382d, y: 0.9463465169726147d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716991759966795d, y: 0.1316955365442024d), new NpgsqlTypes.NpgsqlPoint(x: 0.08312481276390915d, y: 0.8313296408927594d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5396465047478655d, y: 0.5802217499229826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587507524506152d, y: 0.9023330592778743d), new NpgsqlTypes.NpgsqlPoint(x: 0.21361726589422558d, y: 0.8591097001675133d)),
},
            new NpgsqlPathpathE0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4949289001517784d, y: 0.6545806269536956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44804233978819497d, y: 0.45063354973286995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679870934853634d, y: 0.5751763222714994d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3265105076382864d, y: 0.0735874526598832d), new NpgsqlTypes.NpgsqlPoint(x: 0.10736330986302733d, y: 0.535414817736411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554942960591022d, y: 0.6345275429419768d)),
},
            new NpgsqlPathpathE0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526568446356745d, y: 0.10312929705385865d), new NpgsqlTypes.NpgsqlPoint(x: 0.16438797581254327d, y: 0.29500001316488655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822881547985765d, y: 0.3944566493226688d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07795202292696324d, y: 0.5586885183819899d), new NpgsqlTypes.NpgsqlPoint(x: 0.39197272981211484d, y: 0.38298183332324265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977743653881479d, y: 0.18908792707116262d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019544334177192035d, y: 0.20857217454083232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269065771630898d, y: 0.023153082193610897d), new NpgsqlTypes.NpgsqlPoint(x: 0.051046243119323265d, y: 0.6381032623695606d)),
},
            new NpgsqlPathpathE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4281177597818311d, y: 0.8637553007939267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536789846341995d, y: 0.4617528008097276d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360056823433544d, y: 0.5798491396968743d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00412792983488508d, y: 0.6840323550528066d), new NpgsqlTypes.NpgsqlPoint(x: 0.12831467031944244d, y: 0.3047791959251497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720912146874035d, y: 0.7112468309562707d)),
},
            new NpgsqlPathpathE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2938193344239859d, y: 0.08882736485059983d), new NpgsqlTypes.NpgsqlPoint(x: 0.0042317950400547755d, y: 0.7428972718769274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866557039284206d, y: 0.3830778546265804d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4227283378764879d, y: 0.315728377863119d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686306020298867d, y: 0.22738093088203104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000890478881046d, y: 0.07336037695178255d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6223432000981465d, y: 0.1851437625723792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096574861305271d, y: 0.6433452321255976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933803653049184d, y: 0.1649126699002974d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3651925464100181d, y: 0.20976190474687118d), new NpgsqlTypes.NpgsqlPoint(x: 0.289849867497165d, y: 0.9653632229437892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647685588219202d, y: 0.9717349677743325d)),
},
            new NpgsqlPathpathE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2907054968688654d, y: 0.03916832109093704d), new NpgsqlTypes.NpgsqlPoint(x: 0.20521809567285232d, y: 0.4989775242299255d), new NpgsqlTypes.NpgsqlPoint(x: 0.33756659040507186d, y: 0.3191568359845752d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48570883811372423d, y: 0.4584468159673746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838154972767702d, y: 0.5264127643094385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829204176062027d, y: 0.0038045058361072526d)),
},
            new NpgsqlPathpathE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7348642453238851d, y: 0.5629938744020422d), new NpgsqlTypes.NpgsqlPoint(x: 0.43692432423119365d, y: 0.6327986438953892d), new NpgsqlTypes.NpgsqlPoint(x: 0.23624773909707908d, y: 0.780788914899974d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0833593127970379d, y: 0.8476552164131024d), new NpgsqlTypes.NpgsqlPoint(x: 0.18852018685636673d, y: 0.9018265641886265d), new NpgsqlTypes.NpgsqlPoint(x: 0.11099725770372193d, y: 0.789591134256771d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2689500753325874d, y: 0.26704867003786803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307260565502532d, y: 0.7668899510016457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690455281343228d, y: 0.6646747733125287d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270873711938801d, y: 0.3387903313916033d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078625872309668d, y: 0.5546559968256018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602076407102113d, y: 0.8383625792187097d)),
},
            new NpgsqlPathpathE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5651353357552439d, y: 0.16171949740521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0424509098953203d, y: 0.2970957418834054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4124394300389582d, y: 0.25194476711690217d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04991276551318102d, y: 0.2787858984375653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816080469236913d, y: 0.6741842830074505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457904100907566d, y: 0.23598035792184402d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146805040919532d, y: 0.6971040612086045d), new NpgsqlTypes.NpgsqlPoint(x: 0.38382506433988595d, y: 0.5244421217792109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428852412514219d, y: 0.44196687371097976d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8221264858164191d, y: 0.3790633216321364d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926561752181606d, y: 0.07185153886089646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327653184838127d, y: 0.9862296141319162d)),
},
            new NpgsqlPathpathE0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252405878944822d, y: 0.9695894165621087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939352538997491d, y: 0.43730824090168985d), new NpgsqlTypes.NpgsqlPoint(x: 0.866369968822664d, y: 0.5511029656861524d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22825020545199926d, y: 0.46008618098608023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064046799486097d, y: 0.4822948157105106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137237680679658d, y: 0.678601191683131d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7126405680951395d, y: 0.43250487843344854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4687288531024292d, y: 0.020286051187559218d), new NpgsqlTypes.NpgsqlPoint(x: 0.1318997817720753d, y: 0.5784578008134389d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18030475099718968d, y: 0.06617753781731872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633455183401432d, y: 0.8843910725910725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772643042629299d, y: 0.699744801682318d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28057413396140796d, y: 0.6233017087494841d), new NpgsqlTypes.NpgsqlPoint(x: 0.28004706349739794d, y: 0.844028383131932d), new NpgsqlTypes.NpgsqlPoint(x: 0.23366488575698985d, y: 0.17708941244973586d)),
},
            new NpgsqlPathpathE0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9580593426536992d, y: 0.8263680402223531d), new NpgsqlTypes.NpgsqlPoint(x: 0.06588402189869058d, y: 0.33520298428325457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518496049468674d, y: 0.6539409994111787d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8160407194605704d, y: 0.9259646047522969d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463465431233606d, y: 0.2110379077376494d), new NpgsqlTypes.NpgsqlPoint(x: 0.41619373260363735d, y: 0.8537536138598265d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08203954819677672d, y: 0.20740196139175648d), new NpgsqlTypes.NpgsqlPoint(x: 0.376625518071554d, y: 0.1895233324302006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710894655969831d, y: 0.8492661443824259d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734689154350964d, y: 0.36638002318668894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468271597384413d, y: 0.40601199695871615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785088334068111d, y: 0.004672184024957171d)),
},
            new NpgsqlPathpathE0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09442883958501458d, y: 0.6587614261432594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814808222587707d, y: 0.3635933485675972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332817059335248d, y: 0.10916699858973244d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18828737728636713d, y: 0.31906994995570837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132628524506974d, y: 0.6986693964486573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971616285403503d, y: 0.6479688740172617d)),
},
            new NpgsqlPathpathE0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42254679676299656d, y: 0.35258756252220824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626830630111818d, y: 0.9911975342720974d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322730729813348d, y: 0.14459814400636273d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5108291098157155d, y: 0.7008529489314763d), new NpgsqlTypes.NpgsqlPoint(x: 0.34693084379108485d, y: 0.5357904993070636d), new NpgsqlTypes.NpgsqlPoint(x: 0.914409137682009d, y: 0.08409155959891634d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3221807456605448d, y: 0.6740821803560499d), new NpgsqlTypes.NpgsqlPoint(x: 0.760911389635363d, y: 0.9977323574270996d), new NpgsqlTypes.NpgsqlPoint(x: 0.38501012143945146d, y: 0.2866207988819093d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5037038704822292d, y: 0.19315665992082764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564707944918039d, y: 0.45107502224534535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107958451191351d, y: 0.8465671711840407d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09140642276253219d, y: 0.10583205222638392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685529801171515d, y: 0.7009436381241826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997418013630123d, y: 0.9106003428445207d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8034031173059375d, y: 0.8646377827852826d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544309134278648d, y: 0.46512359347479393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330787281536488d, y: 0.21350365592332443d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9588478015167333d, y: 0.736231786046028d), new NpgsqlTypes.NpgsqlPoint(x: 0.20848642631184067d, y: 0.2638478819240324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02434595323936095d, y: 0.6500125898498129d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9625761778253256d, y: 0.6830365926034855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499923302848675d, y: 0.9066277801373362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107906865330869d, y: 0.9531006845410528d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5892146144994566d, y: 0.9451729513850664d), new NpgsqlTypes.NpgsqlPoint(x: 0.40327287224020025d, y: 0.1535554829149277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302063475168851d, y: 0.9855732859660224d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7198430907438288d, y: 0.9472845322974073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642621882602587d, y: 0.6985373474958461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580390927200562d, y: 0.7529186913712924d)),
},
            new NpgsqlPathpathE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1240741691518441d, y: 0.4558299835838805d), new NpgsqlTypes.NpgsqlPoint(x: 0.24298126842104173d, y: 0.2386453564399259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577252280814541d, y: 0.4544561571988953d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8719331683289648d, y: 0.208807380063746d), new NpgsqlTypes.NpgsqlPoint(x: 0.37866696627316465d, y: 0.4512379874056286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489332700421929d, y: 0.7882099718890091d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6797783996259782d, y: 0.2834927601274234d), new NpgsqlTypes.NpgsqlPoint(x: 0.24363633453906808d, y: 0.40631414815456546d), new NpgsqlTypes.NpgsqlPoint(x: 0.523369086535264d, y: 0.9982091087143409d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 119,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47548687513215904d, y: 0.39387787970315824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586294708222446d, y: 0.9078704520914127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977291107033944d, y: 0.5174580192683705d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058913462666939975d, y: 0.6595970820409119d), new NpgsqlTypes.NpgsqlPoint(x: 0.44033219810759594d, y: 0.1183127944555653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089589642926045d, y: 0.7510441219025353d)),
},
            new NpgsqlPathpathE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6434684788993009d, y: 0.4391711707764888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318187656323166d, y: 0.5520235050136739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003798996468032d, y: 0.1137191229345077d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843908240632037d, y: 0.9860786375893061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449933564999345d, y: 0.8580680467599475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614880998938208d, y: 0.7353149078450116d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7705592261517684d, y: 0.6531837520272324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264302648115329d, y: 0.28817639037257614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469189203426465d, y: 0.3501322494320884d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005360622344821153d, y: 0.33603663483670354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221591103198319d, y: 0.08083370837571546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679963060855511d, y: 0.807840955051935d)),
},
            new NpgsqlPathpathE0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46582850813898047d, y: 0.6214818923303186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601134387981309d, y: 0.6673321789796977d), new NpgsqlTypes.NpgsqlPoint(x: 0.44398896049294556d, y: 0.09178403771940458d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499856625526043d, y: 0.8809782341945317d), new NpgsqlTypes.NpgsqlPoint(x: 0.053293722086866335d, y: 0.3630199596549011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526540030522019d, y: 0.4553974650485676d)),
},
            new NpgsqlPathpathE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07363844075051484d, y: 0.4303600100169195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122665426502273d, y: 0.49656754518722424d), new NpgsqlTypes.NpgsqlPoint(x: 0.828176486584434d, y: 0.5074564730723128d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2607497921017231d, y: 0.17868781430223246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323622317432081d, y: 0.44695537769084304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210075358658945d, y: 0.5727340108988549d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9522948568217326d, y: 0.13633726085351494d), new NpgsqlTypes.NpgsqlPoint(x: 0.14495328054725054d, y: 0.3869848107892099d), new NpgsqlTypes.NpgsqlPoint(x: 0.1025905988258613d, y: 0.6845024053521309d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5882997504400648d, y: 0.5507583973306788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44249358642572667d, y: 0.7992402053042718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435761215243945d, y: 0.6352836072327511d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32338433328181915d, y: 0.03166910920496979d), new NpgsqlTypes.NpgsqlPoint(x: 0.48451728443815756d, y: 0.4278570157969974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436964775459014d, y: 0.27304208809783215d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8497365361500211d, y: 0.14885797569984782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676942098271504d, y: 0.37815083151262097d), new NpgsqlTypes.NpgsqlPoint(x: 0.054203319586753396d, y: 0.41762517684844336d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23479173668831832d, y: 0.7696767556090818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968377464825163d, y: 0.14398649233100447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424739660262216d, y: 0.4524541424905223d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343694422692595d, y: 0.3839785443261079d), new NpgsqlTypes.NpgsqlPoint(x: 0.21107959781880514d, y: 0.9693073807175011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539324624087275d, y: 0.2263604885160756d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371552017919464d, y: 0.20432663429193443d), new NpgsqlTypes.NpgsqlPoint(x: 0.20049529739776972d, y: 0.7591271051569702d), new NpgsqlTypes.NpgsqlPoint(x: 0.877944300698197d, y: 0.25389572709649666d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9609438513109139d, y: 0.9436027553936442d), new NpgsqlTypes.NpgsqlPoint(x: 0.031707009872993686d, y: 0.20805339070272721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988652937505521d, y: 0.9397167065891096d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3177207088319318d, y: 0.9006363324738472d), new NpgsqlTypes.NpgsqlPoint(x: 0.682504813793493d, y: 0.08766380209854185d), new NpgsqlTypes.NpgsqlPoint(x: 0.09077506103413235d, y: 0.5987234947573027d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6059320824341882d, y: 0.7384743903827783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962844437017127d, y: 0.09024513712902715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981908482840734d, y: 0.4333299692393633d)),
},
            new NpgsqlPathpathE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1324343183029708d, y: 0.9815211007454812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294991606665739d, y: 0.2666566608829174d), new NpgsqlTypes.NpgsqlPoint(x: 0.027146232547874405d, y: 0.1604244799506288d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23847179619208292d, y: 0.7956238968371577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4903226547927385d, y: 0.9461590966415132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786244800041274d, y: 0.06366219614264379d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602599219173632d, y: 0.2378159477504136d), new NpgsqlTypes.NpgsqlPoint(x: 0.60959327864265d, y: 0.8198413058610227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217983878979047d, y: 0.26049591969395314d)),
},
            new NpgsqlPathpathE0M
{
    Id = 161,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4317868942102928d, y: 0.20901253515223595d), new NpgsqlTypes.NpgsqlPoint(x: 0.11198858300942371d, y: 0.6281588603395692d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804710689737384d, y: 0.49416866962294304d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
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
INSERT INTO public.npgsqlpathpathe0mi(
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3265105076382864d, y: 0.0735874526598832d), new NpgsqlTypes.NpgsqlPoint(x: 0.10736330986302733d, y: 0.535414817736411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554942960591022d, y: 0.6345275429419768d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019544334177192035d, y: 0.20857217454083232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269065771630898d, y: 0.023153082193610897d), new NpgsqlTypes.NpgsqlPoint(x: 0.051046243119323265d, y: 0.6381032623695606d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00412792983488508d, y: 0.6840323550528066d), new NpgsqlTypes.NpgsqlPoint(x: 0.12831467031944244d, y: 0.3047791959251497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720912146874035d, y: 0.7112468309562707d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3651925464100181d, y: 0.20976190474687118d), new NpgsqlTypes.NpgsqlPoint(x: 0.289849867497165d, y: 0.9653632229437892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647685588219202d, y: 0.9717349677743325d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
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
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48570883811372423d, y: 0.4584468159673746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838154972767702d, y: 0.5264127643094385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829204176062027d, y: 0.0038045058361072526d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270873711938801d, y: 0.3387903313916033d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078625872309668d, y: 0.5546559968256018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602076407102113d, y: 0.8383625792187097d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8221264858164191d, y: 0.3790633216321364d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926561752181606d, y: 0.07185153886089646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327653184838127d, y: 0.9862296141319162d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
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
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 26, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 126, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 151, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 119, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 116, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 51);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 147);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7143720116108454d, y: 0.23930850129916537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189450245864162d, y: 0.48319857556585677d), new NpgsqlTypes.NpgsqlPoint(x: 0.030533964066481567d, y: 0.39976844494801156d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833959263208322d, y: 0.36271238034269304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608108568083293d, y: 0.9867012534580587d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943415942781319d, y: 0.9081250743793784d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23983419961942376d, y: 0.9470028794500718d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788022893845393d, y: 0.9892709395193885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522014917046844d, y: 0.2811252886531874d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.283637443052169d, y: 0.5499393659630053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2321897375182227d, y: 0.8489792840715015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075438524323487d, y: 0.2647511502211197d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39986870680539766d, y: 0.7022513027028728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546294239423191d, y: 0.623475464006383d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356649433235677d, y: 0.9653070875681757d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.875612466890416d, y: 0.4036908998653135d), new NpgsqlTypes.NpgsqlPoint(x: 0.25171493164453584d, y: 0.07309555289193514d), new NpgsqlTypes.NpgsqlPoint(x: 0.823898145089971d, y: 0.6361919039279478d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699433567596118d, y: 0.7213012028097932d), new NpgsqlTypes.NpgsqlPoint(x: 0.05867474731827094d, y: 0.7556864585905051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7821308088643009d, y: 0.573385425839784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531444566836382d, y: 0.9463465169726147d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716991759966795d, y: 0.1316955365442024d), new NpgsqlTypes.NpgsqlPoint(x: 0.08312481276390915d, y: 0.8313296408927594d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5396465047478655d, y: 0.5802217499229826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587507524506152d, y: 0.9023330592778743d), new NpgsqlTypes.NpgsqlPoint(x: 0.21361726589422558d, y: 0.8591097001675133d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4949289001517784d, y: 0.6545806269536956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44804233978819497d, y: 0.45063354973286995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679870934853634d, y: 0.5751763222714994d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3265105076382864d, y: 0.0735874526598832d), new NpgsqlTypes.NpgsqlPoint(x: 0.10736330986302733d, y: 0.535414817736411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554942960591022d, y: 0.6345275429419768d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526568446356745d, y: 0.10312929705385865d), new NpgsqlTypes.NpgsqlPoint(x: 0.16438797581254327d, y: 0.29500001316488655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822881547985765d, y: 0.3944566493226688d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07795202292696324d, y: 0.5586885183819899d), new NpgsqlTypes.NpgsqlPoint(x: 0.39197272981211484d, y: 0.38298183332324265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977743653881479d, y: 0.18908792707116262d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019544334177192035d, y: 0.20857217454083232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269065771630898d, y: 0.023153082193610897d), new NpgsqlTypes.NpgsqlPoint(x: 0.051046243119323265d, y: 0.6381032623695606d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4281177597818311d, y: 0.8637553007939267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536789846341995d, y: 0.4617528008097276d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360056823433544d, y: 0.5798491396968743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00412792983488508d, y: 0.6840323550528066d), new NpgsqlTypes.NpgsqlPoint(x: 0.12831467031944244d, y: 0.3047791959251497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720912146874035d, y: 0.7112468309562707d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2938193344239859d, y: 0.08882736485059983d), new NpgsqlTypes.NpgsqlPoint(x: 0.0042317950400547755d, y: 0.7428972718769274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866557039284206d, y: 0.3830778546265804d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4227283378764879d, y: 0.315728377863119d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686306020298867d, y: 0.22738093088203104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000890478881046d, y: 0.07336037695178255d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6223432000981465d, y: 0.1851437625723792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096574861305271d, y: 0.6433452321255976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933803653049184d, y: 0.1649126699002974d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3651925464100181d, y: 0.20976190474687118d), new NpgsqlTypes.NpgsqlPoint(x: 0.289849867497165d, y: 0.9653632229437892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647685588219202d, y: 0.9717349677743325d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2907054968688654d, y: 0.03916832109093704d), new NpgsqlTypes.NpgsqlPoint(x: 0.20521809567285232d, y: 0.4989775242299255d), new NpgsqlTypes.NpgsqlPoint(x: 0.33756659040507186d, y: 0.3191568359845752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48570883811372423d, y: 0.4584468159673746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838154972767702d, y: 0.5264127643094385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829204176062027d, y: 0.0038045058361072526d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7348642453238851d, y: 0.5629938744020422d), new NpgsqlTypes.NpgsqlPoint(x: 0.43692432423119365d, y: 0.6327986438953892d), new NpgsqlTypes.NpgsqlPoint(x: 0.23624773909707908d, y: 0.780788914899974d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0833593127970379d, y: 0.8476552164131024d), new NpgsqlTypes.NpgsqlPoint(x: 0.18852018685636673d, y: 0.9018265641886265d), new NpgsqlTypes.NpgsqlPoint(x: 0.11099725770372193d, y: 0.789591134256771d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2689500753325874d, y: 0.26704867003786803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307260565502532d, y: 0.7668899510016457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690455281343228d, y: 0.6646747733125287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270873711938801d, y: 0.3387903313916033d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078625872309668d, y: 0.5546559968256018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602076407102113d, y: 0.8383625792187097d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5651353357552439d, y: 0.16171949740521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0424509098953203d, y: 0.2970957418834054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4124394300389582d, y: 0.25194476711690217d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04991276551318102d, y: 0.2787858984375653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816080469236913d, y: 0.6741842830074505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457904100907566d, y: 0.23598035792184402d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146805040919532d, y: 0.6971040612086045d), new NpgsqlTypes.NpgsqlPoint(x: 0.38382506433988595d, y: 0.5244421217792109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428852412514219d, y: 0.44196687371097976d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8221264858164191d, y: 0.3790633216321364d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926561752181606d, y: 0.07185153886089646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327653184838127d, y: 0.9862296141319162d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252405878944822d, y: 0.9695894165621087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939352538997491d, y: 0.43730824090168985d), new NpgsqlTypes.NpgsqlPoint(x: 0.866369968822664d, y: 0.5511029656861524d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22825020545199926d, y: 0.46008618098608023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064046799486097d, y: 0.4822948157105106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137237680679658d, y: 0.678601191683131d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7126405680951395d, y: 0.43250487843344854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4687288531024292d, y: 0.020286051187559218d), new NpgsqlTypes.NpgsqlPoint(x: 0.1318997817720753d, y: 0.5784578008134389d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18030475099718968d, y: 0.06617753781731872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633455183401432d, y: 0.8843910725910725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772643042629299d, y: 0.699744801682318d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28057413396140796d, y: 0.6233017087494841d), new NpgsqlTypes.NpgsqlPoint(x: 0.28004706349739794d, y: 0.844028383131932d), new NpgsqlTypes.NpgsqlPoint(x: 0.23366488575698985d, y: 0.17708941244973586d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9580593426536992d, y: 0.8263680402223531d), new NpgsqlTypes.NpgsqlPoint(x: 0.06588402189869058d, y: 0.33520298428325457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518496049468674d, y: 0.6539409994111787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8160407194605704d, y: 0.9259646047522969d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463465431233606d, y: 0.2110379077376494d), new NpgsqlTypes.NpgsqlPoint(x: 0.41619373260363735d, y: 0.8537536138598265d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08203954819677672d, y: 0.20740196139175648d), new NpgsqlTypes.NpgsqlPoint(x: 0.376625518071554d, y: 0.1895233324302006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710894655969831d, y: 0.8492661443824259d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734689154350964d, y: 0.36638002318668894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468271597384413d, y: 0.40601199695871615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785088334068111d, y: 0.004672184024957171d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09442883958501458d, y: 0.6587614261432594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814808222587707d, y: 0.3635933485675972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332817059335248d, y: 0.10916699858973244d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18828737728636713d, y: 0.31906994995570837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132628524506974d, y: 0.6986693964486573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971616285403503d, y: 0.6479688740172617d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42254679676299656d, y: 0.35258756252220824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626830630111818d, y: 0.9911975342720974d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322730729813348d, y: 0.14459814400636273d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5108291098157155d, y: 0.7008529489314763d), new NpgsqlTypes.NpgsqlPoint(x: 0.34693084379108485d, y: 0.5357904993070636d), new NpgsqlTypes.NpgsqlPoint(x: 0.914409137682009d, y: 0.08409155959891634d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3221807456605448d, y: 0.6740821803560499d), new NpgsqlTypes.NpgsqlPoint(x: 0.760911389635363d, y: 0.9977323574270996d), new NpgsqlTypes.NpgsqlPoint(x: 0.38501012143945146d, y: 0.2866207988819093d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5037038704822292d, y: 0.19315665992082764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564707944918039d, y: 0.45107502224534535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107958451191351d, y: 0.8465671711840407d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09140642276253219d, y: 0.10583205222638392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685529801171515d, y: 0.7009436381241826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997418013630123d, y: 0.9106003428445207d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8034031173059375d, y: 0.8646377827852826d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544309134278648d, y: 0.46512359347479393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330787281536488d, y: 0.21350365592332443d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9588478015167333d, y: 0.736231786046028d), new NpgsqlTypes.NpgsqlPoint(x: 0.20848642631184067d, y: 0.2638478819240324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02434595323936095d, y: 0.6500125898498129d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9625761778253256d, y: 0.6830365926034855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499923302848675d, y: 0.9066277801373362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107906865330869d, y: 0.9531006845410528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5892146144994566d, y: 0.9451729513850664d), new NpgsqlTypes.NpgsqlPoint(x: 0.40327287224020025d, y: 0.1535554829149277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302063475168851d, y: 0.9855732859660224d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7198430907438288d, y: 0.9472845322974073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642621882602587d, y: 0.6985373474958461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580390927200562d, y: 0.7529186913712924d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1240741691518441d, y: 0.4558299835838805d), new NpgsqlTypes.NpgsqlPoint(x: 0.24298126842104173d, y: 0.2386453564399259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577252280814541d, y: 0.4544561571988953d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8719331683289648d, y: 0.208807380063746d), new NpgsqlTypes.NpgsqlPoint(x: 0.37866696627316465d, y: 0.4512379874056286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489332700421929d, y: 0.7882099718890091d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6797783996259782d, y: 0.2834927601274234d), new NpgsqlTypes.NpgsqlPoint(x: 0.24363633453906808d, y: 0.40631414815456546d), new NpgsqlTypes.NpgsqlPoint(x: 0.523369086535264d, y: 0.9982091087143409d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47548687513215904d, y: 0.39387787970315824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586294708222446d, y: 0.9078704520914127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977291107033944d, y: 0.5174580192683705d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058913462666939975d, y: 0.6595970820409119d), new NpgsqlTypes.NpgsqlPoint(x: 0.44033219810759594d, y: 0.1183127944555653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089589642926045d, y: 0.7510441219025353d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6434684788993009d, y: 0.4391711707764888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318187656323166d, y: 0.5520235050136739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003798996468032d, y: 0.1137191229345077d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843908240632037d, y: 0.9860786375893061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449933564999345d, y: 0.8580680467599475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614880998938208d, y: 0.7353149078450116d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7705592261517684d, y: 0.6531837520272324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264302648115329d, y: 0.28817639037257614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469189203426465d, y: 0.3501322494320884d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005360622344821153d, y: 0.33603663483670354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221591103198319d, y: 0.08083370837571546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679963060855511d, y: 0.807840955051935d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46582850813898047d, y: 0.6214818923303186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601134387981309d, y: 0.6673321789796977d), new NpgsqlTypes.NpgsqlPoint(x: 0.44398896049294556d, y: 0.09178403771940458d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499856625526043d, y: 0.8809782341945317d), new NpgsqlTypes.NpgsqlPoint(x: 0.053293722086866335d, y: 0.3630199596549011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526540030522019d, y: 0.4553974650485676d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07363844075051484d, y: 0.4303600100169195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122665426502273d, y: 0.49656754518722424d), new NpgsqlTypes.NpgsqlPoint(x: 0.828176486584434d, y: 0.5074564730723128d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2607497921017231d, y: 0.17868781430223246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323622317432081d, y: 0.44695537769084304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210075358658945d, y: 0.5727340108988549d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9522948568217326d, y: 0.13633726085351494d), new NpgsqlTypes.NpgsqlPoint(x: 0.14495328054725054d, y: 0.3869848107892099d), new NpgsqlTypes.NpgsqlPoint(x: 0.1025905988258613d, y: 0.6845024053521309d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5882997504400648d, y: 0.5507583973306788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44249358642572667d, y: 0.7992402053042718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435761215243945d, y: 0.6352836072327511d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32338433328181915d, y: 0.03166910920496979d), new NpgsqlTypes.NpgsqlPoint(x: 0.48451728443815756d, y: 0.4278570157969974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436964775459014d, y: 0.27304208809783215d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8497365361500211d, y: 0.14885797569984782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676942098271504d, y: 0.37815083151262097d), new NpgsqlTypes.NpgsqlPoint(x: 0.054203319586753396d, y: 0.41762517684844336d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23479173668831832d, y: 0.7696767556090818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968377464825163d, y: 0.14398649233100447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424739660262216d, y: 0.4524541424905223d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343694422692595d, y: 0.3839785443261079d), new NpgsqlTypes.NpgsqlPoint(x: 0.21107959781880514d, y: 0.9693073807175011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539324624087275d, y: 0.2263604885160756d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371552017919464d, y: 0.20432663429193443d), new NpgsqlTypes.NpgsqlPoint(x: 0.20049529739776972d, y: 0.7591271051569702d), new NpgsqlTypes.NpgsqlPoint(x: 0.877944300698197d, y: 0.25389572709649666d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9609438513109139d, y: 0.9436027553936442d), new NpgsqlTypes.NpgsqlPoint(x: 0.031707009872993686d, y: 0.20805339070272721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988652937505521d, y: 0.9397167065891096d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3177207088319318d, y: 0.9006363324738472d), new NpgsqlTypes.NpgsqlPoint(x: 0.682504813793493d, y: 0.08766380209854185d), new NpgsqlTypes.NpgsqlPoint(x: 0.09077506103413235d, y: 0.5987234947573027d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6059320824341882d, y: 0.7384743903827783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962844437017127d, y: 0.09024513712902715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981908482840734d, y: 0.4333299692393633d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1324343183029708d, y: 0.9815211007454812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294991606665739d, y: 0.2666566608829174d), new NpgsqlTypes.NpgsqlPoint(x: 0.027146232547874405d, y: 0.1604244799506288d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23847179619208292d, y: 0.7956238968371577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4903226547927385d, y: 0.9461590966415132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786244800041274d, y: 0.06366219614264379d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602599219173632d, y: 0.2378159477504136d), new NpgsqlTypes.NpgsqlPoint(x: 0.60959327864265d, y: 0.8198413058610227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217983878979047d, y: 0.26049591969395314d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4317868942102928d, y: 0.20901253515223595d), new NpgsqlTypes.NpgsqlPoint(x: 0.11198858300942371d, y: 0.6281588603395692d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804710689737384d, y: 0.49416866962294304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7143720116108454d, y: 0.23930850129916537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189450245864162d, y: 0.48319857556585677d), new NpgsqlTypes.NpgsqlPoint(x: 0.030533964066481567d, y: 0.39976844494801156d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7833959263208322d, y: 0.36271238034269304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6608108568083293d, y: 0.9867012534580587d), new NpgsqlTypes.NpgsqlPoint(x: 0.1943415942781319d, y: 0.9081250743793784d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23983419961942376d, y: 0.9470028794500718d), new NpgsqlTypes.NpgsqlPoint(x: 0.08788022893845393d, y: 0.9892709395193885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2522014917046844d, y: 0.2811252886531874d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.283637443052169d, y: 0.5499393659630053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2321897375182227d, y: 0.8489792840715015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075438524323487d, y: 0.2647511502211197d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39986870680539766d, y: 0.7022513027028728d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546294239423191d, y: 0.623475464006383d), new NpgsqlTypes.NpgsqlPoint(x: 0.2356649433235677d, y: 0.9653070875681757d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.875612466890416d, y: 0.4036908998653135d), new NpgsqlTypes.NpgsqlPoint(x: 0.25171493164453584d, y: 0.07309555289193514d), new NpgsqlTypes.NpgsqlPoint(x: 0.823898145089971d, y: 0.6361919039279478d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5699433567596118d, y: 0.7213012028097932d), new NpgsqlTypes.NpgsqlPoint(x: 0.05867474731827094d, y: 0.7556864585905051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7821308088643009d, y: 0.573385425839784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531444566836382d, y: 0.9463465169726147d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716991759966795d, y: 0.1316955365442024d), new NpgsqlTypes.NpgsqlPoint(x: 0.08312481276390915d, y: 0.8313296408927594d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5396465047478655d, y: 0.5802217499229826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587507524506152d, y: 0.9023330592778743d), new NpgsqlTypes.NpgsqlPoint(x: 0.21361726589422558d, y: 0.8591097001675133d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4949289001517784d, y: 0.6545806269536956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44804233978819497d, y: 0.45063354973286995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9679870934853634d, y: 0.5751763222714994d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3265105076382864d, y: 0.0735874526598832d), new NpgsqlTypes.NpgsqlPoint(x: 0.10736330986302733d, y: 0.535414817736411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3554942960591022d, y: 0.6345275429419768d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526568446356745d, y: 0.10312929705385865d), new NpgsqlTypes.NpgsqlPoint(x: 0.16438797581254327d, y: 0.29500001316488655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822881547985765d, y: 0.3944566493226688d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07795202292696324d, y: 0.5586885183819899d), new NpgsqlTypes.NpgsqlPoint(x: 0.39197272981211484d, y: 0.38298183332324265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977743653881479d, y: 0.18908792707116262d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019544334177192035d, y: 0.20857217454083232d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269065771630898d, y: 0.023153082193610897d), new NpgsqlTypes.NpgsqlPoint(x: 0.051046243119323265d, y: 0.6381032623695606d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4281177597818311d, y: 0.8637553007939267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6536789846341995d, y: 0.4617528008097276d), new NpgsqlTypes.NpgsqlPoint(x: 0.2360056823433544d, y: 0.5798491396968743d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00412792983488508d, y: 0.6840323550528066d), new NpgsqlTypes.NpgsqlPoint(x: 0.12831467031944244d, y: 0.3047791959251497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720912146874035d, y: 0.7112468309562707d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2938193344239859d, y: 0.08882736485059983d), new NpgsqlTypes.NpgsqlPoint(x: 0.0042317950400547755d, y: 0.7428972718769274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6866557039284206d, y: 0.3830778546265804d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4227283378764879d, y: 0.315728377863119d), new NpgsqlTypes.NpgsqlPoint(x: 0.14686306020298867d, y: 0.22738093088203104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5000890478881046d, y: 0.07336037695178255d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6223432000981465d, y: 0.1851437625723792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096574861305271d, y: 0.6433452321255976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5933803653049184d, y: 0.1649126699002974d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3651925464100181d, y: 0.20976190474687118d), new NpgsqlTypes.NpgsqlPoint(x: 0.289849867497165d, y: 0.9653632229437892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647685588219202d, y: 0.9717349677743325d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2907054968688654d, y: 0.03916832109093704d), new NpgsqlTypes.NpgsqlPoint(x: 0.20521809567285232d, y: 0.4989775242299255d), new NpgsqlTypes.NpgsqlPoint(x: 0.33756659040507186d, y: 0.3191568359845752d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48570883811372423d, y: 0.4584468159673746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838154972767702d, y: 0.5264127643094385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829204176062027d, y: 0.0038045058361072526d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7348642453238851d, y: 0.5629938744020422d), new NpgsqlTypes.NpgsqlPoint(x: 0.43692432423119365d, y: 0.6327986438953892d), new NpgsqlTypes.NpgsqlPoint(x: 0.23624773909707908d, y: 0.780788914899974d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0833593127970379d, y: 0.8476552164131024d), new NpgsqlTypes.NpgsqlPoint(x: 0.18852018685636673d, y: 0.9018265641886265d), new NpgsqlTypes.NpgsqlPoint(x: 0.11099725770372193d, y: 0.789591134256771d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2689500753325874d, y: 0.26704867003786803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307260565502532d, y: 0.7668899510016457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690455281343228d, y: 0.6646747733125287d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7270873711938801d, y: 0.3387903313916033d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078625872309668d, y: 0.5546559968256018d), new NpgsqlTypes.NpgsqlPoint(x: 0.11602076407102113d, y: 0.8383625792187097d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5651353357552439d, y: 0.16171949740521663d), new NpgsqlTypes.NpgsqlPoint(x: 0.0424509098953203d, y: 0.2970957418834054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4124394300389582d, y: 0.25194476711690217d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04991276551318102d, y: 0.2787858984375653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816080469236913d, y: 0.6741842830074505d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457904100907566d, y: 0.23598035792184402d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9146805040919532d, y: 0.6971040612086045d), new NpgsqlTypes.NpgsqlPoint(x: 0.38382506433988595d, y: 0.5244421217792109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428852412514219d, y: 0.44196687371097976d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8221264858164191d, y: 0.3790633216321364d), new NpgsqlTypes.NpgsqlPoint(x: 0.09926561752181606d, y: 0.07185153886089646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5327653184838127d, y: 0.9862296141319162d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3252405878944822d, y: 0.9695894165621087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939352538997491d, y: 0.43730824090168985d), new NpgsqlTypes.NpgsqlPoint(x: 0.866369968822664d, y: 0.5511029656861524d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22825020545199926d, y: 0.46008618098608023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064046799486097d, y: 0.4822948157105106d), new NpgsqlTypes.NpgsqlPoint(x: 0.9137237680679658d, y: 0.678601191683131d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7126405680951395d, y: 0.43250487843344854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4687288531024292d, y: 0.020286051187559218d), new NpgsqlTypes.NpgsqlPoint(x: 0.1318997817720753d, y: 0.5784578008134389d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18030475099718968d, y: 0.06617753781731872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633455183401432d, y: 0.8843910725910725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2772643042629299d, y: 0.699744801682318d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28057413396140796d, y: 0.6233017087494841d), new NpgsqlTypes.NpgsqlPoint(x: 0.28004706349739794d, y: 0.844028383131932d), new NpgsqlTypes.NpgsqlPoint(x: 0.23366488575698985d, y: 0.17708941244973586d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9580593426536992d, y: 0.8263680402223531d), new NpgsqlTypes.NpgsqlPoint(x: 0.06588402189869058d, y: 0.33520298428325457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518496049468674d, y: 0.6539409994111787d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8160407194605704d, y: 0.9259646047522969d), new NpgsqlTypes.NpgsqlPoint(x: 0.18463465431233606d, y: 0.2110379077376494d), new NpgsqlTypes.NpgsqlPoint(x: 0.41619373260363735d, y: 0.8537536138598265d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08203954819677672d, y: 0.20740196139175648d), new NpgsqlTypes.NpgsqlPoint(x: 0.376625518071554d, y: 0.1895233324302006d), new NpgsqlTypes.NpgsqlPoint(x: 0.6710894655969831d, y: 0.8492661443824259d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9734689154350964d, y: 0.36638002318668894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6468271597384413d, y: 0.40601199695871615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785088334068111d, y: 0.004672184024957171d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09442883958501458d, y: 0.6587614261432594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814808222587707d, y: 0.3635933485675972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332817059335248d, y: 0.10916699858973244d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18828737728636713d, y: 0.31906994995570837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132628524506974d, y: 0.6986693964486573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971616285403503d, y: 0.6479688740172617d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42254679676299656d, y: 0.35258756252220824d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626830630111818d, y: 0.9911975342720974d), new NpgsqlTypes.NpgsqlPoint(x: 0.9322730729813348d, y: 0.14459814400636273d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5108291098157155d, y: 0.7008529489314763d), new NpgsqlTypes.NpgsqlPoint(x: 0.34693084379108485d, y: 0.5357904993070636d), new NpgsqlTypes.NpgsqlPoint(x: 0.914409137682009d, y: 0.08409155959891634d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3221807456605448d, y: 0.6740821803560499d), new NpgsqlTypes.NpgsqlPoint(x: 0.760911389635363d, y: 0.9977323574270996d), new NpgsqlTypes.NpgsqlPoint(x: 0.38501012143945146d, y: 0.2866207988819093d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5037038704822292d, y: 0.19315665992082764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564707944918039d, y: 0.45107502224534535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107958451191351d, y: 0.8465671711840407d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09140642276253219d, y: 0.10583205222638392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4685529801171515d, y: 0.7009436381241826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5997418013630123d, y: 0.9106003428445207d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8034031173059375d, y: 0.8646377827852826d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544309134278648d, y: 0.46512359347479393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330787281536488d, y: 0.21350365592332443d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9588478015167333d, y: 0.736231786046028d), new NpgsqlTypes.NpgsqlPoint(x: 0.20848642631184067d, y: 0.2638478819240324d), new NpgsqlTypes.NpgsqlPoint(x: 0.02434595323936095d, y: 0.6500125898498129d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9625761778253256d, y: 0.6830365926034855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6499923302848675d, y: 0.9066277801373362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107906865330869d, y: 0.9531006845410528d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5892146144994566d, y: 0.9451729513850664d), new NpgsqlTypes.NpgsqlPoint(x: 0.40327287224020025d, y: 0.1535554829149277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302063475168851d, y: 0.9855732859660224d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7198430907438288d, y: 0.9472845322974073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3642621882602587d, y: 0.6985373474958461d), new NpgsqlTypes.NpgsqlPoint(x: 0.8580390927200562d, y: 0.7529186913712924d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1240741691518441d, y: 0.4558299835838805d), new NpgsqlTypes.NpgsqlPoint(x: 0.24298126842104173d, y: 0.2386453564399259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5577252280814541d, y: 0.4544561571988953d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8719331683289648d, y: 0.208807380063746d), new NpgsqlTypes.NpgsqlPoint(x: 0.37866696627316465d, y: 0.4512379874056286d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489332700421929d, y: 0.7882099718890091d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6797783996259782d, y: 0.2834927601274234d), new NpgsqlTypes.NpgsqlPoint(x: 0.24363633453906808d, y: 0.40631414815456546d), new NpgsqlTypes.NpgsqlPoint(x: 0.523369086535264d, y: 0.9982091087143409d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((119)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47548687513215904d, y: 0.39387787970315824d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586294708222446d, y: 0.9078704520914127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977291107033944d, y: 0.5174580192683705d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.058913462666939975d, y: 0.6595970820409119d), new NpgsqlTypes.NpgsqlPoint(x: 0.44033219810759594d, y: 0.1183127944555653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089589642926045d, y: 0.7510441219025353d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6434684788993009d, y: 0.4391711707764888d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318187656323166d, y: 0.5520235050136739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003798996468032d, y: 0.1137191229345077d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843908240632037d, y: 0.9860786375893061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449933564999345d, y: 0.8580680467599475d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614880998938208d, y: 0.7353149078450116d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7705592261517684d, y: 0.6531837520272324d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264302648115329d, y: 0.28817639037257614d), new NpgsqlTypes.NpgsqlPoint(x: 0.9469189203426465d, y: 0.3501322494320884d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005360622344821153d, y: 0.33603663483670354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221591103198319d, y: 0.08083370837571546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679963060855511d, y: 0.807840955051935d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46582850813898047d, y: 0.6214818923303186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601134387981309d, y: 0.6673321789796977d), new NpgsqlTypes.NpgsqlPoint(x: 0.44398896049294556d, y: 0.09178403771940458d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499856625526043d, y: 0.8809782341945317d), new NpgsqlTypes.NpgsqlPoint(x: 0.053293722086866335d, y: 0.3630199596549011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526540030522019d, y: 0.4553974650485676d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07363844075051484d, y: 0.4303600100169195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122665426502273d, y: 0.49656754518722424d), new NpgsqlTypes.NpgsqlPoint(x: 0.828176486584434d, y: 0.5074564730723128d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2607497921017231d, y: 0.17868781430223246d), new NpgsqlTypes.NpgsqlPoint(x: 0.3323622317432081d, y: 0.44695537769084304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210075358658945d, y: 0.5727340108988549d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9522948568217326d, y: 0.13633726085351494d), new NpgsqlTypes.NpgsqlPoint(x: 0.14495328054725054d, y: 0.3869848107892099d), new NpgsqlTypes.NpgsqlPoint(x: 0.1025905988258613d, y: 0.6845024053521309d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5882997504400648d, y: 0.5507583973306788d), new NpgsqlTypes.NpgsqlPoint(x: 0.44249358642572667d, y: 0.7992402053042718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6435761215243945d, y: 0.6352836072327511d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32338433328181915d, y: 0.03166910920496979d), new NpgsqlTypes.NpgsqlPoint(x: 0.48451728443815756d, y: 0.4278570157969974d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436964775459014d, y: 0.27304208809783215d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8497365361500211d, y: 0.14885797569984782d), new NpgsqlTypes.NpgsqlPoint(x: 0.7676942098271504d, y: 0.37815083151262097d), new NpgsqlTypes.NpgsqlPoint(x: 0.054203319586753396d, y: 0.41762517684844336d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23479173668831832d, y: 0.7696767556090818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968377464825163d, y: 0.14398649233100447d), new NpgsqlTypes.NpgsqlPoint(x: 0.5424739660262216d, y: 0.4524541424905223d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343694422692595d, y: 0.3839785443261079d), new NpgsqlTypes.NpgsqlPoint(x: 0.21107959781880514d, y: 0.9693073807175011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6539324624087275d, y: 0.2263604885160756d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((93)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9371552017919464d, y: 0.20432663429193443d), new NpgsqlTypes.NpgsqlPoint(x: 0.20049529739776972d, y: 0.7591271051569702d), new NpgsqlTypes.NpgsqlPoint(x: 0.877944300698197d, y: 0.25389572709649666d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9609438513109139d, y: 0.9436027553936442d), new NpgsqlTypes.NpgsqlPoint(x: 0.031707009872993686d, y: 0.20805339070272721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988652937505521d, y: 0.9397167065891096d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3177207088319318d, y: 0.9006363324738472d), new NpgsqlTypes.NpgsqlPoint(x: 0.682504813793493d, y: 0.08766380209854185d), new NpgsqlTypes.NpgsqlPoint(x: 0.09077506103413235d, y: 0.5987234947573027d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6059320824341882d, y: 0.7384743903827783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962844437017127d, y: 0.09024513712902715d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981908482840734d, y: 0.4333299692393633d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1324343183029708d, y: 0.9815211007454812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294991606665739d, y: 0.2666566608829174d), new NpgsqlTypes.NpgsqlPoint(x: 0.027146232547874405d, y: 0.1604244799506288d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((102)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23847179619208292d, y: 0.7956238968371577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4903226547927385d, y: 0.9461590966415132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7786244800041274d, y: 0.06366219614264379d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5602599219173632d, y: 0.2378159477504136d), new NpgsqlTypes.NpgsqlPoint(x: 0.60959327864265d, y: 0.8198413058610227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217983878979047d, y: 0.26049591969395314d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((161)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4317868942102928d, y: 0.20901253515223595d), new NpgsqlTypes.NpgsqlPoint(x: 0.11198858300942371d, y: 0.6281588603395692d), new NpgsqlTypes.NpgsqlPoint(x: 0.3804710689737384d, y: 0.49416866962294304d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
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
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

