

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
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7654575414670103d, y: 0.26219812574660906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119702635508069d, y: 0.17908581891292874d), new NpgsqlTypes.NpgsqlPoint(x: 0.030831884478202065d, y: 0.03038436116054677d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9751247319990594d, y: 0.2996895970086858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846038397304433d, y: 0.18350865974004926d), new NpgsqlTypes.NpgsqlPoint(x: 0.156626310847914d, y: 0.6209836205919637d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.757625671753621d, y: 0.9355795413164895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048625110554147d, y: 0.17052924315576656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003751128774202d, y: 0.22555807505428438d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46557739334445025d, y: 0.7071815562072957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1071162286427958d, y: 0.268952518526265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651201570814072d, y: 0.9692897143713601d)),
},
            new NpgsqlPathpath0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49542222531946856d, y: 0.25850803382969956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732705319600395d, y: 0.1158610900888507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694471361711103d, y: 0.6097802858771723d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2567448532673525d, y: 0.3113903833485633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26721345514070927d, y: 0.2890228890295191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128334031026352d, y: 0.7685064883863342d)),
},
            new NpgsqlPathpath0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3728395641395563d, y: 0.06432211935715104d), new NpgsqlTypes.NpgsqlPoint(x: 0.0938992386820715d, y: 0.06000023707266089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629796059508937d, y: 0.4065809476780804d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575457750477854d, y: 0.8923586823855909d), new NpgsqlTypes.NpgsqlPoint(x: 0.31207165636936396d, y: 0.05791679548706197d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008391166988133136d, y: 0.48258724153293486d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8193716506702433d, y: 0.5888594772987292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4703639263885029d, y: 0.47490893272382617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7649231702696642d, y: 0.8501537861205917d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23788048412026563d, y: 0.8543191153040705d), new NpgsqlTypes.NpgsqlPoint(x: 0.32638240448738753d, y: 0.7169960033352651d), new NpgsqlTypes.NpgsqlPoint(x: 0.21540726914125508d, y: 0.7588879906250243d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343816600214699d, y: 0.237782247828197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614480573767437d, y: 0.18317372360022466d), new NpgsqlTypes.NpgsqlPoint(x: 0.1940540687927933d, y: 0.07500996708346352d)),
},
            new NpgsqlPathpath0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036329199070740725d, y: 0.6714201364838256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159293383214573d, y: 0.7018496372230986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264167749408722d, y: 0.25073685281244573d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069660400243627d, y: 0.31666726666323086d), new NpgsqlTypes.NpgsqlPoint(x: 0.31115069308943377d, y: 0.22659009812373965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45345833124861745d, y: 0.3883164543314601d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8685057484664256d, y: 0.6853508426968442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760930617529707d, y: 0.19582041752495016d), new NpgsqlTypes.NpgsqlPoint(x: 0.22573734974605253d, y: 0.10766570824365107d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3851590468730194d, y: 0.7990214017037219d), new NpgsqlTypes.NpgsqlPoint(x: 0.162538205308841d, y: 0.6125371331385615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486129374297783d, y: 0.08590797696259045d)),
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24171528534150188d, y: 0.6495165407237137d), new NpgsqlTypes.NpgsqlPoint(x: 0.08338411180965244d, y: 0.545364205795609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510473106896846d, y: 0.8910570211828288d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27066906582455763d, y: 0.4071070273776548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519814821694877d, y: 0.18400806119157098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842221165771355d, y: 0.9606898575496307d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02486217783267508d, y: 0.11768069893719657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567222880345095d, y: 0.07852666406147257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980770714862313d, y: 0.460406788642993d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6301643582396214d, y: 0.5627352603480816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157187534998958d, y: 0.9404207180015172d), new NpgsqlTypes.NpgsqlPoint(x: 0.15614077910745405d, y: 0.2921592702312832d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11694734693834752d, y: 0.2026515854844314d), new NpgsqlTypes.NpgsqlPoint(x: 0.24625042193913727d, y: 0.890086441443794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611762860274105d, y: 0.8652098721822991d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4088244355695685d, y: 0.6145657112009618d), new NpgsqlTypes.NpgsqlPoint(x: 0.908423226056009d, y: 0.07226698758420991d), new NpgsqlTypes.NpgsqlPoint(x: 0.836825423585869d, y: 0.36254407912836073d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5496198213094947d, y: 0.17705330947882225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3341276320286207d, y: 0.1895437010190727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536577811641673d, y: 0.42264233099640913d)),
},
            new NpgsqlPathpath0M
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618251996545751d, y: 0.8352092983793243d), new NpgsqlTypes.NpgsqlPoint(x: 0.793993984733719d, y: 0.3471276243300686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286765251488063d, y: 0.7390766379785723d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11637698385546047d, y: 0.4814402986091121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628257962552589d, y: 0.06645668294138585d), new NpgsqlTypes.NpgsqlPoint(x: 0.18752908907689825d, y: 0.532716035528991d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2669930946768325d, y: 0.9390552927866251d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645499421049548d, y: 0.9949212577456974d), new NpgsqlTypes.NpgsqlPoint(x: 0.14438907922001376d, y: 0.405241071444677d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09253559795538191d, y: 0.9876401939570113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617667910182757d, y: 0.5041306273534856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087786564966816d, y: 0.28835579009120116d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33974718294936423d, y: 0.09332969781177569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218778381706282d, y: 0.3490746187599991d), new NpgsqlTypes.NpgsqlPoint(x: 0.17884999896075293d, y: 0.1327174172034833d)),
},
            new NpgsqlPathpath0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6182151447531051d, y: 0.7631818455278088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013502671038352d, y: 0.5599471449263884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287597391684983d, y: 0.9681015232160567d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12615340488880555d, y: 0.8312613423313402d), new NpgsqlTypes.NpgsqlPoint(x: 0.49388151821233917d, y: 0.02866929840377952d), new NpgsqlTypes.NpgsqlPoint(x: 0.01235745290161161d, y: 0.006458228206529526d)),
},
            new NpgsqlPathpath0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15465460779833662d, y: 0.3719487074099883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779423987440576d, y: 0.6675846744977898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843057048422949d, y: 0.9101041033226565d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18434811982861776d, y: 0.5741290694893636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843452333517091d, y: 0.6641672745835225d), new NpgsqlTypes.NpgsqlPoint(x: 0.351608142912362d, y: 0.17054977059777454d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521135421770666d, y: 0.6721183417850701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050036128268379d, y: 0.5556449488510882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302581631545683d, y: 0.44919078713749017d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354538411766391d, y: 0.41243174869199817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373755000673569d, y: 0.5491427747756463d), new NpgsqlTypes.NpgsqlPoint(x: 0.24871667450358426d, y: 0.1437265605309732d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6701615883664672d, y: 0.30406239044653927d), new NpgsqlTypes.NpgsqlPoint(x: 0.2286144993404582d, y: 0.3676374961823108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278330795888492d, y: 0.7139218291396418d)),
},
            new NpgsqlPathpath0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17044581681021986d, y: 0.6852293892421901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213086014494723d, y: 0.846794089330242d), new NpgsqlTypes.NpgsqlPoint(x: 0.252644787291713d, y: 0.3318909799907853d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945667076474282d, y: 0.8115443345401409d), new NpgsqlTypes.NpgsqlPoint(x: 0.550394124204832d, y: 0.5813901988987692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518558439319796d, y: 0.20985859644325344d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22455712618864676d, y: 0.955746609003242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708730344325222d, y: 0.7376881166098967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988996127054153d, y: 0.47744847982520067d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050423757657295454d, y: 0.29673596473593067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056640742940975d, y: 0.7356157017098015d), new NpgsqlTypes.NpgsqlPoint(x: 0.021681945119665036d, y: 0.0035468640808435925d)),
},
            new NpgsqlPathpath0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3232126854087536d, y: 0.35928408985966986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630118329672957d, y: 0.5778151988327498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138733040559319d, y: 0.6763746373380696d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006065479866755097d, y: 0.18933529903684743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962737824908348d, y: 0.4063252315591255d), new NpgsqlTypes.NpgsqlPoint(x: 0.14313086022079446d, y: 0.7206358954961635d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444645916148096d, y: 0.6355521961253178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708709653140881d, y: 0.294401894330903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070249204639245d, y: 0.6340817214751564d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7563769684955294d, y: 0.3933939976528099d), new NpgsqlTypes.NpgsqlPoint(x: 0.07085798004089272d, y: 0.8737970791983829d), new NpgsqlTypes.NpgsqlPoint(x: 0.35553339718830146d, y: 0.14114390725913473d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26482737960653335d, y: 0.9975139347043223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336669588774708d, y: 0.19293839488682651d), new NpgsqlTypes.NpgsqlPoint(x: 0.19436529422652604d, y: 0.5104499740783477d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8442148479319219d, y: 0.38887500961550936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566353726312171d, y: 0.6454178330630372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084170384723213d, y: 0.07306914838015333d)),
},
            new NpgsqlPathpath0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907081525474434d, y: 0.3663544991615807d), new NpgsqlTypes.NpgsqlPoint(x: 0.09739520839733007d, y: 0.38645850323215103d), new NpgsqlTypes.NpgsqlPoint(x: 0.48698312511077746d, y: 0.7790735444672992d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1293948313016261d, y: 0.504455950868777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776641525724561d, y: 0.8752957610806521d), new NpgsqlTypes.NpgsqlPoint(x: 0.01176115408909384d, y: 0.7388683953067458d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7011938297447926d, y: 0.018492379093572597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171443065180943d, y: 0.5387918192551516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512719076119485d, y: 0.08467423277864627d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5368001296179936d, y: 0.5417672382365435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231143830491859d, y: 0.3651887901315194d), new NpgsqlTypes.NpgsqlPoint(x: 0.39516195344314176d, y: 0.903618600148932d)),
},
            new NpgsqlPathpath0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8071061819995555d, y: 0.8654038931724453d), new NpgsqlTypes.NpgsqlPoint(x: 0.53065591504027d, y: 0.5692203217476369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357805966111224d, y: 0.43640288916307535d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37017442370649223d, y: 0.4679423164199351d), new NpgsqlTypes.NpgsqlPoint(x: 0.027691855577717805d, y: 0.8755614119845363d), new NpgsqlTypes.NpgsqlPoint(x: 0.29411551619057974d, y: 0.5306418608130502d)),
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5203591352186403d, y: 0.8256956012358712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613977465252077d, y: 0.867402213246189d), new NpgsqlTypes.NpgsqlPoint(x: 0.1472503484422879d, y: 0.48446615644505797d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7896081148650264d, y: 0.7816240500848779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571142747883221d, y: 0.08105308411665912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890078687967419d, y: 0.8287158949225163d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111559575834439d, y: 0.7345019158636209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9985678457205666d, y: 0.8188178213756084d), new NpgsqlTypes.NpgsqlPoint(x: 0.45520772218529715d, y: 0.13953619739935652d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316050002489055d, y: 0.8174385473256979d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533573115629847d, y: 0.8558754944226084d), new NpgsqlTypes.NpgsqlPoint(x: 0.18693351545256431d, y: 0.9575814590703918d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705065444243957d, y: 0.06828498567219088d), new NpgsqlTypes.NpgsqlPoint(x: 0.23963118441828601d, y: 0.01119285270293624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099574759845976d, y: 0.1849136237970168d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6562022514669424d, y: 0.3326043482987344d), new NpgsqlTypes.NpgsqlPoint(x: 0.23828262680134604d, y: 0.6426199921664505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761610383994276d, y: 0.2892329754024071d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359496888274465d, y: 0.34325558503041587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245629459468631d, y: 0.11325578568814776d), new NpgsqlTypes.NpgsqlPoint(x: 0.13971072993230305d, y: 0.1463203900365332d)),
},
            new NpgsqlPathpath0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803639101699972d, y: 0.24814953193220857d), new NpgsqlTypes.NpgsqlPoint(x: 0.321531156934307d, y: 0.366846775966192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211163874289954d, y: 0.5218540147918371d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9405641278023411d, y: 0.05176599607641874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429527268452152d, y: 0.854973576434967d), new NpgsqlTypes.NpgsqlPoint(x: 0.311140906050718d, y: 0.28623891336454166d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903316176608463d, y: 0.7742613068720549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749405826924004d, y: 0.1262089545132573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267137630883866d, y: 0.6210370639443515d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893101942891136d, y: 0.4924730073083805d), new NpgsqlTypes.NpgsqlPoint(x: 0.41049881279362377d, y: 0.13450417928641256d), new NpgsqlTypes.NpgsqlPoint(x: 0.3342531858340536d, y: 0.4419369933500491d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28094799808261406d, y: 0.9481665416982867d), new NpgsqlTypes.NpgsqlPoint(x: 0.40752328959620643d, y: 0.7867517919173775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486109702308364d, y: 0.7415979604935828d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7651444053709641d, y: 0.907597160261291d), new NpgsqlTypes.NpgsqlPoint(x: 0.12541109325373534d, y: 0.5134759802570208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455028596068434d, y: 0.1125984393104782d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2888384793982375d, y: 0.7142269406082533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652285552993543d, y: 0.9419957741585051d), new NpgsqlTypes.NpgsqlPoint(x: 0.0040223130018312014d, y: 0.7921241376638011d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16500821068445304d, y: 0.9976766126257612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636976781759496d, y: 0.2674691683589051d), new NpgsqlTypes.NpgsqlPoint(x: 0.846986688951362d, y: 0.9099545673176409d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395870212854166d, y: 0.13658976364825837d), new NpgsqlTypes.NpgsqlPoint(x: 0.21970757164054233d, y: 0.28606515198585303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492194975559402d, y: 0.25157875042052114d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6494659658583054d, y: 0.855862411908031d), new NpgsqlTypes.NpgsqlPoint(x: 0.489150035550738d, y: 0.6359357928164676d), new NpgsqlTypes.NpgsqlPoint(x: 0.10047741687440681d, y: 0.09697009742517315d)),
},
            new NpgsqlPathpath0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2529783869651755d, y: 0.7571155808423765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9685247761923159d, y: 0.7203625682807238d), new NpgsqlTypes.NpgsqlPoint(x: 0.059218226243029304d, y: 0.7007955515063737d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2957085212689856d, y: 0.45105716725354683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949816647618245d, y: 0.46245314345723576d), new NpgsqlTypes.NpgsqlPoint(x: 0.00243630110989812d, y: 0.07254092043666249d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6652574140948087d, y: 0.8422321939029848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979379398766976d, y: 0.2767570312827349d), new NpgsqlTypes.NpgsqlPoint(x: 0.695356856120965d, y: 0.396120289685704d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5034770506714581d, y: 0.17980999179037926d), new NpgsqlTypes.NpgsqlPoint(x: 0.991063175092553d, y: 0.0759331309125666d), new NpgsqlTypes.NpgsqlPoint(x: 0.17442930791187783d, y: 0.04148073777618255d)),
},
            new NpgsqlPathpath0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793537326906323d, y: 0.23372332728586265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713021344500037d, y: 0.3503496531178062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315633780591753d, y: 0.3714107160353948d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36931755464554905d, y: 0.2963318442811449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168459491072488d, y: 0.8775677554023602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4659701188711064d, y: 0.6171959557039335d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7380859149465913d, y: 0.9979177883035222d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354598826324067d, y: 0.9539162071811946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962294594536978d, y: 0.5393609078052063d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3074826053960583d, y: 0.41195946287595886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9427821673547143d, y: 0.4346413666499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499722579546381d, y: 0.7502217904174607d)),
},
            new NpgsqlPathpath0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194897285858146d, y: 0.8052233341693654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30786458272510064d, y: 0.48402373471054494d), new NpgsqlTypes.NpgsqlPoint(x: 0.42057020264110523d, y: 0.635602136871061d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9690028800225218d, y: 0.5961589844538191d), new NpgsqlTypes.NpgsqlPoint(x: 0.29130001120584037d, y: 0.07358320171177712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472888760912556d, y: 0.24125371210101798d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1736541225299968d, y: 0.22973849556911385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820251608584095d, y: 0.4464056207393462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3975207345106503d, y: 0.7548190644597805d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5738707890485407d, y: 0.2851127067881599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477147427184788d, y: 0.42853973442646d), new NpgsqlTypes.NpgsqlPoint(x: 0.056471215897265004d, y: 0.39440403431719573d)),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343816600214699d, y: 0.237782247828197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614480573767437d, y: 0.18317372360022466d), new NpgsqlTypes.NpgsqlPoint(x: 0.1940540687927933d, y: 0.07500996708346352d))));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3851590468730194d, y: 0.7990214017037219d), new NpgsqlTypes.NpgsqlPoint(x: 0.162538205308841d, y: 0.6125371331385615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486129374297783d, y: 0.08590797696259045d))));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5496198213094947d, y: 0.17705330947882225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3341276320286207d, y: 0.1895437010190727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536577811641673d, y: 0.42264233099640913d))));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33974718294936423d, y: 0.09332969781177569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218778381706282d, y: 0.3490746187599991d), new NpgsqlTypes.NpgsqlPoint(x: 0.17884999896075293d, y: 0.1327174172034833d))));
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
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 102;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
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
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[30],_testData[34], false);
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
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[34], false);
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
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[34], false);
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
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 140, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 29, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 160, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[34], false);
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
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[34], false);
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
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 41, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[34], false);
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
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[30], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[31], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[32], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[33], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7654575414670103d, y: 0.26219812574660906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119702635508069d, y: 0.17908581891292874d), new NpgsqlTypes.NpgsqlPoint(x: 0.030831884478202065d, y: 0.03038436116054677d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9751247319990594d, y: 0.2996895970086858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846038397304433d, y: 0.18350865974004926d), new NpgsqlTypes.NpgsqlPoint(x: 0.156626310847914d, y: 0.6209836205919637d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.757625671753621d, y: 0.9355795413164895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048625110554147d, y: 0.17052924315576656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003751128774202d, y: 0.22555807505428438d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46557739334445025d, y: 0.7071815562072957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1071162286427958d, y: 0.268952518526265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651201570814072d, y: 0.9692897143713601d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49542222531946856d, y: 0.25850803382969956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732705319600395d, y: 0.1158610900888507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694471361711103d, y: 0.6097802858771723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2567448532673525d, y: 0.3113903833485633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26721345514070927d, y: 0.2890228890295191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128334031026352d, y: 0.7685064883863342d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3728395641395563d, y: 0.06432211935715104d), new NpgsqlTypes.NpgsqlPoint(x: 0.0938992386820715d, y: 0.06000023707266089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629796059508937d, y: 0.4065809476780804d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575457750477854d, y: 0.8923586823855909d), new NpgsqlTypes.NpgsqlPoint(x: 0.31207165636936396d, y: 0.05791679548706197d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008391166988133136d, y: 0.48258724153293486d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8193716506702433d, y: 0.5888594772987292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4703639263885029d, y: 0.47490893272382617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7649231702696642d, y: 0.8501537861205917d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23788048412026563d, y: 0.8543191153040705d), new NpgsqlTypes.NpgsqlPoint(x: 0.32638240448738753d, y: 0.7169960033352651d), new NpgsqlTypes.NpgsqlPoint(x: 0.21540726914125508d, y: 0.7588879906250243d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343816600214699d, y: 0.237782247828197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614480573767437d, y: 0.18317372360022466d), new NpgsqlTypes.NpgsqlPoint(x: 0.1940540687927933d, y: 0.07500996708346352d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036329199070740725d, y: 0.6714201364838256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159293383214573d, y: 0.7018496372230986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264167749408722d, y: 0.25073685281244573d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069660400243627d, y: 0.31666726666323086d), new NpgsqlTypes.NpgsqlPoint(x: 0.31115069308943377d, y: 0.22659009812373965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45345833124861745d, y: 0.3883164543314601d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8685057484664256d, y: 0.6853508426968442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760930617529707d, y: 0.19582041752495016d), new NpgsqlTypes.NpgsqlPoint(x: 0.22573734974605253d, y: 0.10766570824365107d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3851590468730194d, y: 0.7990214017037219d), new NpgsqlTypes.NpgsqlPoint(x: 0.162538205308841d, y: 0.6125371331385615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486129374297783d, y: 0.08590797696259045d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24171528534150188d, y: 0.6495165407237137d), new NpgsqlTypes.NpgsqlPoint(x: 0.08338411180965244d, y: 0.545364205795609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510473106896846d, y: 0.8910570211828288d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27066906582455763d, y: 0.4071070273776548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519814821694877d, y: 0.18400806119157098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842221165771355d, y: 0.9606898575496307d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02486217783267508d, y: 0.11768069893719657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567222880345095d, y: 0.07852666406147257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980770714862313d, y: 0.460406788642993d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6301643582396214d, y: 0.5627352603480816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157187534998958d, y: 0.9404207180015172d), new NpgsqlTypes.NpgsqlPoint(x: 0.15614077910745405d, y: 0.2921592702312832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11694734693834752d, y: 0.2026515854844314d), new NpgsqlTypes.NpgsqlPoint(x: 0.24625042193913727d, y: 0.890086441443794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611762860274105d, y: 0.8652098721822991d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4088244355695685d, y: 0.6145657112009618d), new NpgsqlTypes.NpgsqlPoint(x: 0.908423226056009d, y: 0.07226698758420991d), new NpgsqlTypes.NpgsqlPoint(x: 0.836825423585869d, y: 0.36254407912836073d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5496198213094947d, y: 0.17705330947882225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3341276320286207d, y: 0.1895437010190727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536577811641673d, y: 0.42264233099640913d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618251996545751d, y: 0.8352092983793243d), new NpgsqlTypes.NpgsqlPoint(x: 0.793993984733719d, y: 0.3471276243300686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286765251488063d, y: 0.7390766379785723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11637698385546047d, y: 0.4814402986091121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628257962552589d, y: 0.06645668294138585d), new NpgsqlTypes.NpgsqlPoint(x: 0.18752908907689825d, y: 0.532716035528991d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2669930946768325d, y: 0.9390552927866251d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645499421049548d, y: 0.9949212577456974d), new NpgsqlTypes.NpgsqlPoint(x: 0.14438907922001376d, y: 0.405241071444677d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09253559795538191d, y: 0.9876401939570113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617667910182757d, y: 0.5041306273534856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087786564966816d, y: 0.28835579009120116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33974718294936423d, y: 0.09332969781177569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218778381706282d, y: 0.3490746187599991d), new NpgsqlTypes.NpgsqlPoint(x: 0.17884999896075293d, y: 0.1327174172034833d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6182151447531051d, y: 0.7631818455278088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013502671038352d, y: 0.5599471449263884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287597391684983d, y: 0.9681015232160567d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12615340488880555d, y: 0.8312613423313402d), new NpgsqlTypes.NpgsqlPoint(x: 0.49388151821233917d, y: 0.02866929840377952d), new NpgsqlTypes.NpgsqlPoint(x: 0.01235745290161161d, y: 0.006458228206529526d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15465460779833662d, y: 0.3719487074099883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779423987440576d, y: 0.6675846744977898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843057048422949d, y: 0.9101041033226565d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18434811982861776d, y: 0.5741290694893636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843452333517091d, y: 0.6641672745835225d), new NpgsqlTypes.NpgsqlPoint(x: 0.351608142912362d, y: 0.17054977059777454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521135421770666d, y: 0.6721183417850701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050036128268379d, y: 0.5556449488510882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302581631545683d, y: 0.44919078713749017d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354538411766391d, y: 0.41243174869199817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373755000673569d, y: 0.5491427747756463d), new NpgsqlTypes.NpgsqlPoint(x: 0.24871667450358426d, y: 0.1437265605309732d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6701615883664672d, y: 0.30406239044653927d), new NpgsqlTypes.NpgsqlPoint(x: 0.2286144993404582d, y: 0.3676374961823108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278330795888492d, y: 0.7139218291396418d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17044581681021986d, y: 0.6852293892421901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213086014494723d, y: 0.846794089330242d), new NpgsqlTypes.NpgsqlPoint(x: 0.252644787291713d, y: 0.3318909799907853d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945667076474282d, y: 0.8115443345401409d), new NpgsqlTypes.NpgsqlPoint(x: 0.550394124204832d, y: 0.5813901988987692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518558439319796d, y: 0.20985859644325344d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22455712618864676d, y: 0.955746609003242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708730344325222d, y: 0.7376881166098967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988996127054153d, y: 0.47744847982520067d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050423757657295454d, y: 0.29673596473593067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056640742940975d, y: 0.7356157017098015d), new NpgsqlTypes.NpgsqlPoint(x: 0.021681945119665036d, y: 0.0035468640808435925d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3232126854087536d, y: 0.35928408985966986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630118329672957d, y: 0.5778151988327498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138733040559319d, y: 0.6763746373380696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006065479866755097d, y: 0.18933529903684743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962737824908348d, y: 0.4063252315591255d), new NpgsqlTypes.NpgsqlPoint(x: 0.14313086022079446d, y: 0.7206358954961635d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444645916148096d, y: 0.6355521961253178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708709653140881d, y: 0.294401894330903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070249204639245d, y: 0.6340817214751564d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7563769684955294d, y: 0.3933939976528099d), new NpgsqlTypes.NpgsqlPoint(x: 0.07085798004089272d, y: 0.8737970791983829d), new NpgsqlTypes.NpgsqlPoint(x: 0.35553339718830146d, y: 0.14114390725913473d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26482737960653335d, y: 0.9975139347043223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336669588774708d, y: 0.19293839488682651d), new NpgsqlTypes.NpgsqlPoint(x: 0.19436529422652604d, y: 0.5104499740783477d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8442148479319219d, y: 0.38887500961550936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566353726312171d, y: 0.6454178330630372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084170384723213d, y: 0.07306914838015333d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907081525474434d, y: 0.3663544991615807d), new NpgsqlTypes.NpgsqlPoint(x: 0.09739520839733007d, y: 0.38645850323215103d), new NpgsqlTypes.NpgsqlPoint(x: 0.48698312511077746d, y: 0.7790735444672992d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1293948313016261d, y: 0.504455950868777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776641525724561d, y: 0.8752957610806521d), new NpgsqlTypes.NpgsqlPoint(x: 0.01176115408909384d, y: 0.7388683953067458d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7011938297447926d, y: 0.018492379093572597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171443065180943d, y: 0.5387918192551516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512719076119485d, y: 0.08467423277864627d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5368001296179936d, y: 0.5417672382365435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231143830491859d, y: 0.3651887901315194d), new NpgsqlTypes.NpgsqlPoint(x: 0.39516195344314176d, y: 0.903618600148932d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8071061819995555d, y: 0.8654038931724453d), new NpgsqlTypes.NpgsqlPoint(x: 0.53065591504027d, y: 0.5692203217476369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357805966111224d, y: 0.43640288916307535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37017442370649223d, y: 0.4679423164199351d), new NpgsqlTypes.NpgsqlPoint(x: 0.027691855577717805d, y: 0.8755614119845363d), new NpgsqlTypes.NpgsqlPoint(x: 0.29411551619057974d, y: 0.5306418608130502d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5203591352186403d, y: 0.8256956012358712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613977465252077d, y: 0.867402213246189d), new NpgsqlTypes.NpgsqlPoint(x: 0.1472503484422879d, y: 0.48446615644505797d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7896081148650264d, y: 0.7816240500848779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571142747883221d, y: 0.08105308411665912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890078687967419d, y: 0.8287158949225163d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111559575834439d, y: 0.7345019158636209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9985678457205666d, y: 0.8188178213756084d), new NpgsqlTypes.NpgsqlPoint(x: 0.45520772218529715d, y: 0.13953619739935652d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316050002489055d, y: 0.8174385473256979d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533573115629847d, y: 0.8558754944226084d), new NpgsqlTypes.NpgsqlPoint(x: 0.18693351545256431d, y: 0.9575814590703918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705065444243957d, y: 0.06828498567219088d), new NpgsqlTypes.NpgsqlPoint(x: 0.23963118441828601d, y: 0.01119285270293624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099574759845976d, y: 0.1849136237970168d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6562022514669424d, y: 0.3326043482987344d), new NpgsqlTypes.NpgsqlPoint(x: 0.23828262680134604d, y: 0.6426199921664505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761610383994276d, y: 0.2892329754024071d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359496888274465d, y: 0.34325558503041587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245629459468631d, y: 0.11325578568814776d), new NpgsqlTypes.NpgsqlPoint(x: 0.13971072993230305d, y: 0.1463203900365332d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803639101699972d, y: 0.24814953193220857d), new NpgsqlTypes.NpgsqlPoint(x: 0.321531156934307d, y: 0.366846775966192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211163874289954d, y: 0.5218540147918371d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9405641278023411d, y: 0.05176599607641874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429527268452152d, y: 0.854973576434967d), new NpgsqlTypes.NpgsqlPoint(x: 0.311140906050718d, y: 0.28623891336454166d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903316176608463d, y: 0.7742613068720549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749405826924004d, y: 0.1262089545132573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267137630883866d, y: 0.6210370639443515d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893101942891136d, y: 0.4924730073083805d), new NpgsqlTypes.NpgsqlPoint(x: 0.41049881279362377d, y: 0.13450417928641256d), new NpgsqlTypes.NpgsqlPoint(x: 0.3342531858340536d, y: 0.4419369933500491d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28094799808261406d, y: 0.9481665416982867d), new NpgsqlTypes.NpgsqlPoint(x: 0.40752328959620643d, y: 0.7867517919173775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486109702308364d, y: 0.7415979604935828d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7651444053709641d, y: 0.907597160261291d), new NpgsqlTypes.NpgsqlPoint(x: 0.12541109325373534d, y: 0.5134759802570208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455028596068434d, y: 0.1125984393104782d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2888384793982375d, y: 0.7142269406082533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652285552993543d, y: 0.9419957741585051d), new NpgsqlTypes.NpgsqlPoint(x: 0.0040223130018312014d, y: 0.7921241376638011d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16500821068445304d, y: 0.9976766126257612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636976781759496d, y: 0.2674691683589051d), new NpgsqlTypes.NpgsqlPoint(x: 0.846986688951362d, y: 0.9099545673176409d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395870212854166d, y: 0.13658976364825837d), new NpgsqlTypes.NpgsqlPoint(x: 0.21970757164054233d, y: 0.28606515198585303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492194975559402d, y: 0.25157875042052114d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6494659658583054d, y: 0.855862411908031d), new NpgsqlTypes.NpgsqlPoint(x: 0.489150035550738d, y: 0.6359357928164676d), new NpgsqlTypes.NpgsqlPoint(x: 0.10047741687440681d, y: 0.09697009742517315d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2529783869651755d, y: 0.7571155808423765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9685247761923159d, y: 0.7203625682807238d), new NpgsqlTypes.NpgsqlPoint(x: 0.059218226243029304d, y: 0.7007955515063737d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2957085212689856d, y: 0.45105716725354683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949816647618245d, y: 0.46245314345723576d), new NpgsqlTypes.NpgsqlPoint(x: 0.00243630110989812d, y: 0.07254092043666249d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6652574140948087d, y: 0.8422321939029848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979379398766976d, y: 0.2767570312827349d), new NpgsqlTypes.NpgsqlPoint(x: 0.695356856120965d, y: 0.396120289685704d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5034770506714581d, y: 0.17980999179037926d), new NpgsqlTypes.NpgsqlPoint(x: 0.991063175092553d, y: 0.0759331309125666d), new NpgsqlTypes.NpgsqlPoint(x: 0.17442930791187783d, y: 0.04148073777618255d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793537326906323d, y: 0.23372332728586265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713021344500037d, y: 0.3503496531178062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315633780591753d, y: 0.3714107160353948d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36931755464554905d, y: 0.2963318442811449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168459491072488d, y: 0.8775677554023602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4659701188711064d, y: 0.6171959557039335d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7380859149465913d, y: 0.9979177883035222d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354598826324067d, y: 0.9539162071811946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962294594536978d, y: 0.5393609078052063d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3074826053960583d, y: 0.41195946287595886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9427821673547143d, y: 0.4346413666499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499722579546381d, y: 0.7502217904174607d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194897285858146d, y: 0.8052233341693654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30786458272510064d, y: 0.48402373471054494d), new NpgsqlTypes.NpgsqlPoint(x: 0.42057020264110523d, y: 0.635602136871061d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9690028800225218d, y: 0.5961589844538191d), new NpgsqlTypes.NpgsqlPoint(x: 0.29130001120584037d, y: 0.07358320171177712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472888760912556d, y: 0.24125371210101798d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1736541225299968d, y: 0.22973849556911385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820251608584095d, y: 0.4464056207393462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3975207345106503d, y: 0.7548190644597805d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5738707890485407d, y: 0.2851127067881599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477147427184788d, y: 0.42853973442646d), new NpgsqlTypes.NpgsqlPoint(x: 0.056471215897265004d, y: 0.39440403431719573d)))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7654575414670103d, y: 0.26219812574660906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8119702635508069d, y: 0.17908581891292874d), new NpgsqlTypes.NpgsqlPoint(x: 0.030831884478202065d, y: 0.03038436116054677d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9751247319990594d, y: 0.2996895970086858d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846038397304433d, y: 0.18350865974004926d), new NpgsqlTypes.NpgsqlPoint(x: 0.156626310847914d, y: 0.6209836205919637d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((3)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.757625671753621d, y: 0.9355795413164895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048625110554147d, y: 0.17052924315576656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003751128774202d, y: 0.22555807505428438d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46557739334445025d, y: 0.7071815562072957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1071162286427958d, y: 0.268952518526265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651201570814072d, y: 0.9692897143713601d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49542222531946856d, y: 0.25850803382969956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732705319600395d, y: 0.1158610900888507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694471361711103d, y: 0.6097802858771723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2567448532673525d, y: 0.3113903833485633d), new NpgsqlTypes.NpgsqlPoint(x: 0.26721345514070927d, y: 0.2890228890295191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7128334031026352d, y: 0.7685064883863342d)))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3728395641395563d, y: 0.06432211935715104d), new NpgsqlTypes.NpgsqlPoint(x: 0.0938992386820715d, y: 0.06000023707266089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629796059508937d, y: 0.4065809476780804d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.575457750477854d, y: 0.8923586823855909d), new NpgsqlTypes.NpgsqlPoint(x: 0.31207165636936396d, y: 0.05791679548706197d), new NpgsqlTypes.NpgsqlPoint(x: 0.0008391166988133136d, y: 0.48258724153293486d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8193716506702433d, y: 0.5888594772987292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4703639263885029d, y: 0.47490893272382617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7649231702696642d, y: 0.8501537861205917d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23788048412026563d, y: 0.8543191153040705d), new NpgsqlTypes.NpgsqlPoint(x: 0.32638240448738753d, y: 0.7169960033352651d), new NpgsqlTypes.NpgsqlPoint(x: 0.21540726914125508d, y: 0.7588879906250243d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6343816600214699d, y: 0.237782247828197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9614480573767437d, y: 0.18317372360022466d), new NpgsqlTypes.NpgsqlPoint(x: 0.1940540687927933d, y: 0.07500996708346352d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036329199070740725d, y: 0.6714201364838256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159293383214573d, y: 0.7018496372230986d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264167749408722d, y: 0.25073685281244573d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6069660400243627d, y: 0.31666726666323086d), new NpgsqlTypes.NpgsqlPoint(x: 0.31115069308943377d, y: 0.22659009812373965d), new NpgsqlTypes.NpgsqlPoint(x: 0.45345833124861745d, y: 0.3883164543314601d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8685057484664256d, y: 0.6853508426968442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760930617529707d, y: 0.19582041752495016d), new NpgsqlTypes.NpgsqlPoint(x: 0.22573734974605253d, y: 0.10766570824365107d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3851590468730194d, y: 0.7990214017037219d), new NpgsqlTypes.NpgsqlPoint(x: 0.162538205308841d, y: 0.6125371331385615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486129374297783d, y: 0.08590797696259045d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24171528534150188d, y: 0.6495165407237137d), new NpgsqlTypes.NpgsqlPoint(x: 0.08338411180965244d, y: 0.545364205795609d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510473106896846d, y: 0.8910570211828288d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27066906582455763d, y: 0.4071070273776548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519814821694877d, y: 0.18400806119157098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5842221165771355d, y: 0.9606898575496307d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02486217783267508d, y: 0.11768069893719657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567222880345095d, y: 0.07852666406147257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9980770714862313d, y: 0.460406788642993d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6301643582396214d, y: 0.5627352603480816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157187534998958d, y: 0.9404207180015172d), new NpgsqlTypes.NpgsqlPoint(x: 0.15614077910745405d, y: 0.2921592702312832d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11694734693834752d, y: 0.2026515854844314d), new NpgsqlTypes.NpgsqlPoint(x: 0.24625042193913727d, y: 0.890086441443794d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611762860274105d, y: 0.8652098721822991d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4088244355695685d, y: 0.6145657112009618d), new NpgsqlTypes.NpgsqlPoint(x: 0.908423226056009d, y: 0.07226698758420991d), new NpgsqlTypes.NpgsqlPoint(x: 0.836825423585869d, y: 0.36254407912836073d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5496198213094947d, y: 0.17705330947882225d), new NpgsqlTypes.NpgsqlPoint(x: 0.3341276320286207d, y: 0.1895437010190727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536577811641673d, y: 0.42264233099640913d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((44)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618251996545751d, y: 0.8352092983793243d), new NpgsqlTypes.NpgsqlPoint(x: 0.793993984733719d, y: 0.3471276243300686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6286765251488063d, y: 0.7390766379785723d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11637698385546047d, y: 0.4814402986091121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8628257962552589d, y: 0.06645668294138585d), new NpgsqlTypes.NpgsqlPoint(x: 0.18752908907689825d, y: 0.532716035528991d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((30)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2669930946768325d, y: 0.9390552927866251d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645499421049548d, y: 0.9949212577456974d), new NpgsqlTypes.NpgsqlPoint(x: 0.14438907922001376d, y: 0.405241071444677d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09253559795538191d, y: 0.9876401939570113d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617667910182757d, y: 0.5041306273534856d), new NpgsqlTypes.NpgsqlPoint(x: 0.6087786564966816d, y: 0.28835579009120116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33974718294936423d, y: 0.09332969781177569d), new NpgsqlTypes.NpgsqlPoint(x: 0.8218778381706282d, y: 0.3490746187599991d), new NpgsqlTypes.NpgsqlPoint(x: 0.17884999896075293d, y: 0.1327174172034833d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6182151447531051d, y: 0.7631818455278088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013502671038352d, y: 0.5599471449263884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287597391684983d, y: 0.9681015232160567d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12615340488880555d, y: 0.8312613423313402d), new NpgsqlTypes.NpgsqlPoint(x: 0.49388151821233917d, y: 0.02866929840377952d), new NpgsqlTypes.NpgsqlPoint(x: 0.01235745290161161d, y: 0.006458228206529526d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15465460779833662d, y: 0.3719487074099883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779423987440576d, y: 0.6675846744977898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843057048422949d, y: 0.9101041033226565d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18434811982861776d, y: 0.5741290694893636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7843452333517091d, y: 0.6641672745835225d), new NpgsqlTypes.NpgsqlPoint(x: 0.351608142912362d, y: 0.17054977059777454d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6521135421770666d, y: 0.6721183417850701d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050036128268379d, y: 0.5556449488510882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7302581631545683d, y: 0.44919078713749017d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8354538411766391d, y: 0.41243174869199817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373755000673569d, y: 0.5491427747756463d), new NpgsqlTypes.NpgsqlPoint(x: 0.24871667450358426d, y: 0.1437265605309732d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6701615883664672d, y: 0.30406239044653927d), new NpgsqlTypes.NpgsqlPoint(x: 0.2286144993404582d, y: 0.3676374961823108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6278330795888492d, y: 0.7139218291396418d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17044581681021986d, y: 0.6852293892421901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213086014494723d, y: 0.846794089330242d), new NpgsqlTypes.NpgsqlPoint(x: 0.252644787291713d, y: 0.3318909799907853d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945667076474282d, y: 0.8115443345401409d), new NpgsqlTypes.NpgsqlPoint(x: 0.550394124204832d, y: 0.5813901988987692d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518558439319796d, y: 0.20985859644325344d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22455712618864676d, y: 0.955746609003242d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708730344325222d, y: 0.7376881166098967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988996127054153d, y: 0.47744847982520067d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050423757657295454d, y: 0.29673596473593067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056640742940975d, y: 0.7356157017098015d), new NpgsqlTypes.NpgsqlPoint(x: 0.021681945119665036d, y: 0.0035468640808435925d)))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3232126854087536d, y: 0.35928408985966986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630118329672957d, y: 0.5778151988327498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138733040559319d, y: 0.6763746373380696d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006065479866755097d, y: 0.18933529903684743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8962737824908348d, y: 0.4063252315591255d), new NpgsqlTypes.NpgsqlPoint(x: 0.14313086022079446d, y: 0.7206358954961635d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444645916148096d, y: 0.6355521961253178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708709653140881d, y: 0.294401894330903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7070249204639245d, y: 0.6340817214751564d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7563769684955294d, y: 0.3933939976528099d), new NpgsqlTypes.NpgsqlPoint(x: 0.07085798004089272d, y: 0.8737970791983829d), new NpgsqlTypes.NpgsqlPoint(x: 0.35553339718830146d, y: 0.14114390725913473d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26482737960653335d, y: 0.9975139347043223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3336669588774708d, y: 0.19293839488682651d), new NpgsqlTypes.NpgsqlPoint(x: 0.19436529422652604d, y: 0.5104499740783477d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8442148479319219d, y: 0.38887500961550936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566353726312171d, y: 0.6454178330630372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084170384723213d, y: 0.07306914838015333d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7907081525474434d, y: 0.3663544991615807d), new NpgsqlTypes.NpgsqlPoint(x: 0.09739520839733007d, y: 0.38645850323215103d), new NpgsqlTypes.NpgsqlPoint(x: 0.48698312511077746d, y: 0.7790735444672992d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1293948313016261d, y: 0.504455950868777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776641525724561d, y: 0.8752957610806521d), new NpgsqlTypes.NpgsqlPoint(x: 0.01176115408909384d, y: 0.7388683953067458d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7011938297447926d, y: 0.018492379093572597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5171443065180943d, y: 0.5387918192551516d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512719076119485d, y: 0.08467423277864627d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5368001296179936d, y: 0.5417672382365435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231143830491859d, y: 0.3651887901315194d), new NpgsqlTypes.NpgsqlPoint(x: 0.39516195344314176d, y: 0.903618600148932d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8071061819995555d, y: 0.8654038931724453d), new NpgsqlTypes.NpgsqlPoint(x: 0.53065591504027d, y: 0.5692203217476369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357805966111224d, y: 0.43640288916307535d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37017442370649223d, y: 0.4679423164199351d), new NpgsqlTypes.NpgsqlPoint(x: 0.027691855577717805d, y: 0.8755614119845363d), new NpgsqlTypes.NpgsqlPoint(x: 0.29411551619057974d, y: 0.5306418608130502d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5203591352186403d, y: 0.8256956012358712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8613977465252077d, y: 0.867402213246189d), new NpgsqlTypes.NpgsqlPoint(x: 0.1472503484422879d, y: 0.48446615644505797d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7896081148650264d, y: 0.7816240500848779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5571142747883221d, y: 0.08105308411665912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890078687967419d, y: 0.8287158949225163d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111559575834439d, y: 0.7345019158636209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9985678457205666d, y: 0.8188178213756084d), new NpgsqlTypes.NpgsqlPoint(x: 0.45520772218529715d, y: 0.13953619739935652d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3316050002489055d, y: 0.8174385473256979d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533573115629847d, y: 0.8558754944226084d), new NpgsqlTypes.NpgsqlPoint(x: 0.18693351545256431d, y: 0.9575814590703918d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705065444243957d, y: 0.06828498567219088d), new NpgsqlTypes.NpgsqlPoint(x: 0.23963118441828601d, y: 0.01119285270293624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099574759845976d, y: 0.1849136237970168d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6562022514669424d, y: 0.3326043482987344d), new NpgsqlTypes.NpgsqlPoint(x: 0.23828262680134604d, y: 0.6426199921664505d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761610383994276d, y: 0.2892329754024071d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359496888274465d, y: 0.34325558503041587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245629459468631d, y: 0.11325578568814776d), new NpgsqlTypes.NpgsqlPoint(x: 0.13971072993230305d, y: 0.1463203900365332d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803639101699972d, y: 0.24814953193220857d), new NpgsqlTypes.NpgsqlPoint(x: 0.321531156934307d, y: 0.366846775966192d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211163874289954d, y: 0.5218540147918371d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9405641278023411d, y: 0.05176599607641874d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429527268452152d, y: 0.854973576434967d), new NpgsqlTypes.NpgsqlPoint(x: 0.311140906050718d, y: 0.28623891336454166d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8903316176608463d, y: 0.7742613068720549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749405826924004d, y: 0.1262089545132573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267137630883866d, y: 0.6210370639443515d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5893101942891136d, y: 0.4924730073083805d), new NpgsqlTypes.NpgsqlPoint(x: 0.41049881279362377d, y: 0.13450417928641256d), new NpgsqlTypes.NpgsqlPoint(x: 0.3342531858340536d, y: 0.4419369933500491d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28094799808261406d, y: 0.9481665416982867d), new NpgsqlTypes.NpgsqlPoint(x: 0.40752328959620643d, y: 0.7867517919173775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486109702308364d, y: 0.7415979604935828d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7651444053709641d, y: 0.907597160261291d), new NpgsqlTypes.NpgsqlPoint(x: 0.12541109325373534d, y: 0.5134759802570208d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455028596068434d, y: 0.1125984393104782d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2888384793982375d, y: 0.7142269406082533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652285552993543d, y: 0.9419957741585051d), new NpgsqlTypes.NpgsqlPoint(x: 0.0040223130018312014d, y: 0.7921241376638011d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16500821068445304d, y: 0.9976766126257612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5636976781759496d, y: 0.2674691683589051d), new NpgsqlTypes.NpgsqlPoint(x: 0.846986688951362d, y: 0.9099545673176409d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395870212854166d, y: 0.13658976364825837d), new NpgsqlTypes.NpgsqlPoint(x: 0.21970757164054233d, y: 0.28606515198585303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3492194975559402d, y: 0.25157875042052114d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6494659658583054d, y: 0.855862411908031d), new NpgsqlTypes.NpgsqlPoint(x: 0.489150035550738d, y: 0.6359357928164676d), new NpgsqlTypes.NpgsqlPoint(x: 0.10047741687440681d, y: 0.09697009742517315d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2529783869651755d, y: 0.7571155808423765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9685247761923159d, y: 0.7203625682807238d), new NpgsqlTypes.NpgsqlPoint(x: 0.059218226243029304d, y: 0.7007955515063737d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((82)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2957085212689856d, y: 0.45105716725354683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5949816647618245d, y: 0.46245314345723576d), new NpgsqlTypes.NpgsqlPoint(x: 0.00243630110989812d, y: 0.07254092043666249d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6652574140948087d, y: 0.8422321939029848d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979379398766976d, y: 0.2767570312827349d), new NpgsqlTypes.NpgsqlPoint(x: 0.695356856120965d, y: 0.396120289685704d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5034770506714581d, y: 0.17980999179037926d), new NpgsqlTypes.NpgsqlPoint(x: 0.991063175092553d, y: 0.0759331309125666d), new NpgsqlTypes.NpgsqlPoint(x: 0.17442930791187783d, y: 0.04148073777618255d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5793537326906323d, y: 0.23372332728586265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713021344500037d, y: 0.3503496531178062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315633780591753d, y: 0.3714107160353948d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36931755464554905d, y: 0.2963318442811449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168459491072488d, y: 0.8775677554023602d), new NpgsqlTypes.NpgsqlPoint(x: 0.4659701188711064d, y: 0.6171959557039335d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7380859149465913d, y: 0.9979177883035222d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354598826324067d, y: 0.9539162071811946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5962294594536978d, y: 0.5393609078052063d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3074826053960583d, y: 0.41195946287595886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9427821673547143d, y: 0.4346413666499733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499722579546381d, y: 0.7502217904174607d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7194897285858146d, y: 0.8052233341693654d), new NpgsqlTypes.NpgsqlPoint(x: 0.30786458272510064d, y: 0.48402373471054494d), new NpgsqlTypes.NpgsqlPoint(x: 0.42057020264110523d, y: 0.635602136871061d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9690028800225218d, y: 0.5961589844538191d), new NpgsqlTypes.NpgsqlPoint(x: 0.29130001120584037d, y: 0.07358320171177712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472888760912556d, y: 0.24125371210101798d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1736541225299968d, y: 0.22973849556911385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8820251608584095d, y: 0.4464056207393462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3975207345106503d, y: 0.7548190644597805d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5738707890485407d, y: 0.2851127067881599d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477147427184788d, y: 0.42853973442646d), new NpgsqlTypes.NpgsqlPoint(x: 0.056471215897265004d, y: 0.39440403431719573d)))));

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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpath0MIWA),
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
            queryMapType: typeof(NpgsqlPathpath0MIWA),
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
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
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MI),
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
                var importCollection = new List<NpgsqlPathpath0MI>(2);
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
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MI>(2);
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
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
COPY public.binary_npgsqlpathpath0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpath0MIWA),
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpath0MIWA
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
                    NpgsqlPathpath0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPathpath0M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpath0M>();
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
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpath0M>();
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
                    NpgsqlPathpath0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlpathpath0mi
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI), typeof(NpgsqlPathpath0MI)],
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MI>();
                var models2 = new List<NpgsqlPathpath0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
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
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpath0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA), typeof(NpgsqlPathpath0MIWA)],
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpath0MIWA>();
                var models2 = new List<NpgsqlPathpath0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpath0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MIWA)],
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlPathpath0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

