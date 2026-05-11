

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
    internal partial interface INpgsqlPathMArraypathMMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD1 : INpgsqlPathMArraypathMMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD1E1M[] _testData = new NpgsqlPathpathMMArrayD1E1M[]
        {
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35729970274777445d, y: 0.657775210388494d), new NpgsqlTypes.NpgsqlPoint(x: 0.016451199048403087d, y: 0.96619263422938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8942884351439844d, y: 0.7238325499389453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7783040787775816d, y: 0.9922614808841806d), new NpgsqlTypes.NpgsqlPoint(x: 0.015054486433254466d, y: 0.4790996678272573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776858783795442d, y: 0.8679829141517161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43110666867372593d, y: 0.7505280276177532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841214610539233d, y: 0.47294276361852083d), new NpgsqlTypes.NpgsqlPoint(x: 0.42749087491549775d, y: 0.13285735175255386d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3167814205723307d, y: 0.3733332312420766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897783729040467d, y: 0.9763346786470504d), new NpgsqlTypes.NpgsqlPoint(x: 0.585229997424138d, y: 0.5158257147755286d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8235099503809448d, y: 0.540120288223034d), new NpgsqlTypes.NpgsqlPoint(x: 0.353538839402575d, y: 0.028361810608764637d), new NpgsqlTypes.NpgsqlPoint(x: 0.4436607341619693d, y: 0.48580646777226855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3621720297512274d, y: 0.5540318490075533d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144009964525991d, y: 0.9760643193274938d), new NpgsqlTypes.NpgsqlPoint(x: 0.43968465579512517d, y: 0.8755358260417113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713422481901792d, y: 0.28857674203966244d), new NpgsqlTypes.NpgsqlPoint(x: 0.2960180122516862d, y: 0.3384842759114062d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741105925458351d, y: 0.2718229178615845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10231241700744209d, y: 0.17663420861109058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289352532855513d, y: 0.08551369283262189d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659410114881898d, y: 0.05673389378332172d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30288711286339787d, y: 0.41263718849517794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9881079231701148d, y: 0.9208212203046829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934229950635637d, y: 0.3298511787836492d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6036241657345914d, y: 0.38936497762480493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9156352076094021d, y: 0.8745380553110932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7929712025511854d, y: 0.12319813967891124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07419304075391286d, y: 0.9826049983725664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601974777221253d, y: 0.2778246078325395d), new NpgsqlTypes.NpgsqlPoint(x: 0.05057147072741275d, y: 0.22796072668816358d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8909399720318842d, y: 0.809322184663515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6850775376860126d, y: 0.2990154733975189d), new NpgsqlTypes.NpgsqlPoint(x: 0.47861729620538196d, y: 0.28933389843585355d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.042118822074180384d, y: 0.3707460639227025d), new NpgsqlTypes.NpgsqlPoint(x: 0.004620353365443752d, y: 0.06937018251637928d), new NpgsqlTypes.NpgsqlPoint(x: 0.26168188729387565d, y: 0.3811074638436315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8452504989096735d, y: 0.10954684337665543d), new NpgsqlTypes.NpgsqlPoint(x: 0.2787144992574734d, y: 0.9110455443378344d), new NpgsqlTypes.NpgsqlPoint(x: 0.007076144453082689d, y: 0.5653704561965425d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3463345114723323d, y: 0.787884722016925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391646467566395d, y: 0.7826909791218649d), new NpgsqlTypes.NpgsqlPoint(x: 0.0941460627829106d, y: 0.015493130701384805d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7522529255602807d, y: 0.844175895472608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031454631499066d, y: 0.7436851767189976d), new NpgsqlTypes.NpgsqlPoint(x: 0.38221100187690027d, y: 0.8380424542299003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6253014575097438d, y: 0.27902940863058323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326239883452396d, y: 0.09769624893773232d), new NpgsqlTypes.NpgsqlPoint(x: 0.986703531793479d, y: 0.23333510858091722d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9243108133031376d, y: 0.9911195360350951d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893014299942102d, y: 0.8630670139569753d), new NpgsqlTypes.NpgsqlPoint(x: 0.012332853544874012d, y: 0.4380738936278511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12196684967671412d, y: 0.4118638734255552d), new NpgsqlTypes.NpgsqlPoint(x: 0.40853801008795254d, y: 0.9018203502536096d), new NpgsqlTypes.NpgsqlPoint(x: 0.41922011722853014d, y: 0.5402478564165872d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37506468593697617d, y: 0.24764197260503173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672110330976901d, y: 0.6368790320023187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5262940957869596d, y: 0.9540741887522425d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46708049443480104d, y: 0.09680422625757579d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722138755277582d, y: 0.4347856566027254d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204149923152606d, y: 0.3708235435039572d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021089385940326277d, y: 0.4450026908144281d), new NpgsqlTypes.NpgsqlPoint(x: 0.040608081337817126d, y: 0.5592103914488445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359222134185395d, y: 0.5956465995907753d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49729999758766585d, y: 0.3119457561863318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673844355957798d, y: 0.5740423948182293d), new NpgsqlTypes.NpgsqlPoint(x: 0.17940500637705492d, y: 0.9645782731942499d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35805597019308366d, y: 0.3503096058852134d), new NpgsqlTypes.NpgsqlPoint(x: 0.015048906061809308d, y: 0.25163980857288415d), new NpgsqlTypes.NpgsqlPoint(x: 0.315101053781914d, y: 0.15180817785839706d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1626889985542893d, y: 0.892826786729911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445928022310496d, y: 0.8731366242482408d), new NpgsqlTypes.NpgsqlPoint(x: 0.49787060109777825d, y: 0.2190873093064255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33547071799751405d, y: 0.8591383508084737d), new NpgsqlTypes.NpgsqlPoint(x: 0.32580179915810714d, y: 0.13885524650871428d), new NpgsqlTypes.NpgsqlPoint(x: 0.6671356850095503d, y: 0.4433860520488456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7512351602742418d, y: 0.3916002223935434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7560039011389202d, y: 0.1986706970377845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3886232008827042d, y: 0.8414124447027838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31992899396838115d, y: 0.9974961698863658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515232413539572d, y: 0.881467063751379d), new NpgsqlTypes.NpgsqlPoint(x: 0.15477143225573564d, y: 0.2453027199040645d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4122918632065412d, y: 0.1693163044074577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4234479373629607d, y: 0.9831060742493556d), new NpgsqlTypes.NpgsqlPoint(x: 0.3372388048866667d, y: 0.1636335253921849d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7542086259338076d, y: 0.6185303421722954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728242118656827d, y: 0.6552663641848937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660660223498764d, y: 0.8349519811909729d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32625742031971616d, y: 0.46363758564297586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3761772187992142d, y: 0.8663973344540488d), new NpgsqlTypes.NpgsqlPoint(x: 0.6931887016765076d, y: 0.25128160289114077d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703807232771917d, y: 0.7690658317082602d), new NpgsqlTypes.NpgsqlPoint(x: 0.23480054155558738d, y: 0.746394175602135d), new NpgsqlTypes.NpgsqlPoint(x: 0.20216808911252193d, y: 0.2856778703186791d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9442875236616113d, y: 0.7052706430167182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060669546796679d, y: 0.3989587978730692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966409838690746d, y: 0.44955268016349925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6699782808624044d, y: 0.3601957688427385d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503508154320195d, y: 0.054061718279920234d), new NpgsqlTypes.NpgsqlPoint(x: 0.36229749622577834d, y: 0.3290577471525491d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7394627338330721d, y: 0.8041982896593135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428095869811896d, y: 0.14465463035034787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045658215343206d, y: 0.7751334884437923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5511342076188684d, y: 0.22963486281612278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5411743778656865d, y: 0.22102315895600244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935075458534878d, y: 0.3177431569415834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7554227836643439d, y: 0.7945951481615912d), new NpgsqlTypes.NpgsqlPoint(x: 0.11657260087721755d, y: 0.28511433668901853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707285803217164d, y: 0.07459235741365977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3438397874823017d, y: 0.21050949492965254d), new NpgsqlTypes.NpgsqlPoint(x: 0.04994632655375242d, y: 0.7073985472704353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572829678345832d, y: 0.81097547150133d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3806891764995165d, y: 0.1506000880171695d), new NpgsqlTypes.NpgsqlPoint(x: 0.07581692706346854d, y: 0.6047913884850953d), new NpgsqlTypes.NpgsqlPoint(x: 0.24500077047556545d, y: 0.922250589536351d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25472401985630155d, y: 0.6202688980652508d), new NpgsqlTypes.NpgsqlPoint(x: 0.295615703045054d, y: 0.4400315859203979d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754974565053868d, y: 0.10514377667599084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09334270182411819d, y: 0.7213379980969318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528726705616153d, y: 0.6332585241183417d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868601669046052d, y: 0.9613730252106866d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21338869643389147d, y: 0.9576890964182979d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655235118724437d, y: 0.6750996809861949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402089027390848d, y: 0.32793812901683217d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46226310849514074d, y: 0.17995728125853416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6975591403358168d, y: 0.7791008852505429d), new NpgsqlTypes.NpgsqlPoint(x: 0.05067727994946902d, y: 0.2855776380201457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9477358352963123d, y: 0.0519503296493119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8076363096242977d, y: 0.2018830866777539d), new NpgsqlTypes.NpgsqlPoint(x: 0.12147224792389222d, y: 0.9897403900564925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5966736940187714d, y: 0.9653333289537576d), new NpgsqlTypes.NpgsqlPoint(x: 0.35567081071071527d, y: 0.6635017239977582d), new NpgsqlTypes.NpgsqlPoint(x: 0.08580081811717755d, y: 0.3956360042222622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9959667198647351d, y: 0.8995304233628654d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179321778769061d, y: 0.19728906498526944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855081260575329d, y: 0.9309476399990935d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2960519369721647d, y: 0.9404160199743894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3617393007719216d, y: 0.1263621939729146d), new NpgsqlTypes.NpgsqlPoint(x: 0.434193709086374d, y: 0.9403531723684024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03408698193643478d, y: 0.4239201671814876d), new NpgsqlTypes.NpgsqlPoint(x: 0.008666721113038012d, y: 0.7124089771684442d), new NpgsqlTypes.NpgsqlPoint(x: 0.018776939425240724d, y: 0.40649452743947756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.928813719815977d, y: 0.7230525807851457d), new NpgsqlTypes.NpgsqlPoint(x: 0.3620661677644683d, y: 0.0018122832649468679d), new NpgsqlTypes.NpgsqlPoint(x: 0.6316029285326995d, y: 0.34819692069467767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8804617126905975d, y: 0.21265700234354878d), new NpgsqlTypes.NpgsqlPoint(x: 0.016408992198365113d, y: 0.40658595107827666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8759958601436223d, y: 0.2922968025670605d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8502425692989278d, y: 0.008011921567833036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386002616376772d, y: 0.16071298983380988d), new NpgsqlTypes.NpgsqlPoint(x: 0.11281880643096331d, y: 0.030637395660475297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4160507862005173d, y: 0.15702331286789883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987286574536602d, y: 0.12416501114891698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623311339591859d, y: 0.9788875180059283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5669361174527985d, y: 0.6142734747035331d), new NpgsqlTypes.NpgsqlPoint(x: 0.19064126745718257d, y: 0.8427205915893461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902446677549334d, y: 0.4278366066297401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6121121679905095d, y: 0.969426889729889d), new NpgsqlTypes.NpgsqlPoint(x: 0.45888321184185954d, y: 0.5252244829959318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911521927863709d, y: 0.0992164858202994d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33439630350346516d, y: 0.8065870993070453d), new NpgsqlTypes.NpgsqlPoint(x: 0.12782778624279167d, y: 0.02298165637469085d), new NpgsqlTypes.NpgsqlPoint(x: 0.36186731567747765d, y: 0.750614878971885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840169670311225d, y: 0.6358129280132077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782085877330065d, y: 0.011660914067772143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745839920420298d, y: 0.5412747653546222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.778453619586218d, y: 0.825492719286133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477772695959376d, y: 0.8757147498575935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656169610254639d, y: 0.5591661050727573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8231503016358064d, y: 0.07636920043921891d), new NpgsqlTypes.NpgsqlPoint(x: 0.8949238026430064d, y: 0.5555464840708296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859353509344479d, y: 0.13594499621015277d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6549167452468508d, y: 0.21769053884191614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411166096034285d, y: 0.21884801778808038d), new NpgsqlTypes.NpgsqlPoint(x: 0.3917165940530495d, y: 0.40124133380186044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.314238306301443d, y: 0.37598632773772844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550735068835866d, y: 0.8561894340971304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635437157789695d, y: 0.5766911048789145d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6695448818305646d, y: 0.1682729784362582d), new NpgsqlTypes.NpgsqlPoint(x: 0.7101664673715596d, y: 0.8857086297809814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8291448598895957d, y: 0.8955411400322946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6946384084024672d, y: 0.04325017022799704d), new NpgsqlTypes.NpgsqlPoint(x: 0.817806733815215d, y: 0.9138163923273955d), new NpgsqlTypes.NpgsqlPoint(x: 0.07003869707960564d, y: 0.5209474715780045d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4112800874017196d, y: 0.25860469286619736d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423924229837117d, y: 0.7688792746334286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069665783491165d, y: 0.2286763003370269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8179763962144431d, y: 0.7851666114978866d), new NpgsqlTypes.NpgsqlPoint(x: 0.219277426512955d, y: 0.29824050260885693d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171091243373726d, y: 0.07827021609813956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146917905331934d, y: 0.8497523244913769d), new NpgsqlTypes.NpgsqlPoint(x: 0.682196280331384d, y: 0.22840928948423445d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920212947771539d, y: 0.9446763073348114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26524844835542083d, y: 0.5920136765602036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935137910789296d, y: 0.027592971411127265d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085808097213829d, y: 0.46220944576364076d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2745402308590582d, y: 0.48274632171733445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7561429561377906d, y: 0.9391390887081636d), new NpgsqlTypes.NpgsqlPoint(x: 0.10659017363558265d, y: 0.4974437905788711d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47123950939250225d, y: 0.9098007505402395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398683255535048d, y: 0.09853955671858139d), new NpgsqlTypes.NpgsqlPoint(x: 0.045443524605116914d, y: 0.7850645088655607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1509495682181594d, y: 0.7078927670757098d), new NpgsqlTypes.NpgsqlPoint(x: 0.36187842666564696d, y: 0.5081592802893566d), new NpgsqlTypes.NpgsqlPoint(x: 0.7186765080034873d, y: 0.8451234978204797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03671544179241759d, y: 0.12195444411030898d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263612809426831d, y: 0.09973971333755183d), new NpgsqlTypes.NpgsqlPoint(x: 0.10121955993919785d, y: 0.5394765676467513d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43318459347255966d, y: 0.5850951003079425d), new NpgsqlTypes.NpgsqlPoint(x: 0.42477313228367675d, y: 0.30555707513696484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5912094194994055d, y: 0.6572869597413863d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19225916279573807d, y: 0.8396633304097816d), new NpgsqlTypes.NpgsqlPoint(x: 0.505516225055308d, y: 0.5463927829491589d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015082217703206d, y: 0.038449093561607306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.538531390038741d, y: 0.5247617051341795d), new NpgsqlTypes.NpgsqlPoint(x: 0.33565874971149834d, y: 0.37446087302363806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832683661572846d, y: 0.5764757700857838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0006599790471252254d, y: 0.016127468282817636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353197785625134d, y: 0.7707450285295404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6829783660350929d, y: 0.28690441680492695d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2945105104454888d, y: 0.08159136513502929d), new NpgsqlTypes.NpgsqlPoint(x: 0.591283527090741d, y: 0.30644763409266496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8953578571710359d, y: 0.05828384770024686d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589526551391205d, y: 0.6176258942363715d), new NpgsqlTypes.NpgsqlPoint(x: 0.17872326316816756d, y: 0.22603596800611703d), new NpgsqlTypes.NpgsqlPoint(x: 0.06290495050195632d, y: 0.3117761736832195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9472588005838823d, y: 0.18266334750636537d), new NpgsqlTypes.NpgsqlPoint(x: 0.46767053180555784d, y: 0.358000045264252d), new NpgsqlTypes.NpgsqlPoint(x: 0.18430973816721985d, y: 0.5678227295188469d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5013334020825104d, y: 0.46880260541680285d), new NpgsqlTypes.NpgsqlPoint(x: 0.04568383291297984d, y: 0.08782591210427837d), new NpgsqlTypes.NpgsqlPoint(x: 0.20717866254402018d, y: 0.7793960044793571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45172643927952993d, y: 0.1842825641472633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885610736488133d, y: 0.3253756291235991d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622877115374261d, y: 0.6225893886582424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23318900570893408d, y: 0.033816342936741406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801775408967011d, y: 0.8803775987477627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960517300652542d, y: 0.07755556243265371d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9120849886185215d, y: 0.7979054315924461d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723330292481577d, y: 0.2979465105413158d), new NpgsqlTypes.NpgsqlPoint(x: 0.20637234873933608d, y: 0.854114301173473d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6752211345121956d, y: 0.34783204513667165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615164902729446d, y: 0.5380686574400938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914827020460359d, y: 0.8474026128448021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8794682277679772d, y: 0.7875978020728537d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525854878953646d, y: 0.451411386679723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404867492951834d, y: 0.4274932609356463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05223063494027713d, y: 0.4369872360788004d), new NpgsqlTypes.NpgsqlPoint(x: 0.059932307753956304d, y: 0.5824722730085242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4849197613020325d, y: 0.3353044039759191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9769947027840048d, y: 0.32214682641429193d), new NpgsqlTypes.NpgsqlPoint(x: 0.37178765637599487d, y: 0.36702593844174547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4937810682288535d, y: 0.7899883609617009d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9948146890248782d, y: 0.5977502147369878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2482432200152458d, y: 0.11449237290340464d), new NpgsqlTypes.NpgsqlPoint(x: 0.13446251855124025d, y: 0.3915245911892383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4227086850201417d, y: 0.41112790292847723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7711011731489248d, y: 0.729845671953092d), new NpgsqlTypes.NpgsqlPoint(x: 0.48998384966369235d, y: 0.36757208676759656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6594566520329597d, y: 0.1344300078497257d), new NpgsqlTypes.NpgsqlPoint(x: 0.015241447370658245d, y: 0.8320973017034295d), new NpgsqlTypes.NpgsqlPoint(x: 0.39611595430505997d, y: 0.9244768904347722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8314381349694313d, y: 0.49883131996579866d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394261964708846d, y: 0.08032208945731345d), new NpgsqlTypes.NpgsqlPoint(x: 0.16780317045331428d, y: 0.3211888292150411d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07498931108411977d, y: 0.8252914451229669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495040419420684d, y: 0.7377070692225696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417371313316104d, y: 0.633838532966845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014026699144430443d, y: 0.1274248277734361d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188004569617293d, y: 0.4854406394201576d), new NpgsqlTypes.NpgsqlPoint(x: 0.1324321208461231d, y: 0.663143125458903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12138029422624619d, y: 0.8762896426705993d), new NpgsqlTypes.NpgsqlPoint(x: 0.09218562209968773d, y: 0.5921092652567438d), new NpgsqlTypes.NpgsqlPoint(x: 0.12304890335476149d, y: 0.5488464372594566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8005943009051553d, y: 0.16210066447660043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260360102248019d, y: 0.08924634218334215d), new NpgsqlTypes.NpgsqlPoint(x: 0.0965952724816882d, y: 0.9029455640773806d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536698734468108d, y: 0.9767964302473555d), new NpgsqlTypes.NpgsqlPoint(x: 0.48580525452211376d, y: 0.09815965943383465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626480382616469d, y: 0.5812930453927737d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6011890328871655d, y: 0.14216138800809686d), new NpgsqlTypes.NpgsqlPoint(x: 0.36124792406910355d, y: 0.15436078330473468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646716190022699d, y: 0.4351148077226925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522269221344397d, y: 0.27350003728548933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124902105437567d, y: 0.5609561810495886d), new NpgsqlTypes.NpgsqlPoint(x: 0.838964111333405d, y: 0.5593514049931199d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7342416049302259d, y: 0.21153302005341146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9362183232766187d, y: 0.6459302658190246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476157306591953d, y: 0.6914986082861613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16443161365428394d, y: 0.25156352110120705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659142974164028d, y: 0.8173119349962852d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323521130005944d, y: 0.7651537540594885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5950160606291774d, y: 0.22084645465778463d), new NpgsqlTypes.NpgsqlPoint(x: 0.988329585054953d, y: 0.2944785527917003d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198019755963935d, y: 0.46860873953126303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7479059296423354d, y: 0.3773519396977282d), new NpgsqlTypes.NpgsqlPoint(x: 0.08200304866215302d, y: 0.19424350498993082d), new NpgsqlTypes.NpgsqlPoint(x: 0.366373371441418d, y: 0.1845448329289684d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.796692070573439d, y: 0.33741203770187367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536837403238269d, y: 0.8311290873797201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413505552719615d, y: 0.06459274465742859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2301924923265396d, y: 0.8345945019158307d), new NpgsqlTypes.NpgsqlPoint(x: 0.36750265778439706d, y: 0.8416117939773973d), new NpgsqlTypes.NpgsqlPoint(x: 0.25468346420156607d, y: 0.8047892646913596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44479033926927936d, y: 0.8450292331913711d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644592374568818d, y: 0.6143244180326917d), new NpgsqlTypes.NpgsqlPoint(x: 0.49308013764351877d, y: 0.5567369800741906d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19814525895046387d, y: 0.9907849811089381d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987802890006286d, y: 0.025370866942183712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502993076409777d, y: 0.31544333575245176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3601150130699855d, y: 0.8595436334502713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934572306941037d, y: 0.19323365319055952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315655619048921d, y: 0.6473564229662754d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.315131440285652d, y: 0.16690977034122978d), new NpgsqlTypes.NpgsqlPoint(x: 0.12494351461517905d, y: 0.22783580524711322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9855089203197025d, y: 0.9781527966105997d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9756446580258424d, y: 0.9434376035400878d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520988744683936d, y: 0.44129575672404786d), new NpgsqlTypes.NpgsqlPoint(x: 0.965028410734416d, y: 0.3294308012732272d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9354094441010169d, y: 0.4148500974271063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144772141661117d, y: 0.6390784752649283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719635595630326d, y: 0.8866515729355482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052286191206308286d, y: 0.11195346956896712d), new NpgsqlTypes.NpgsqlPoint(x: 0.17169191755575508d, y: 0.05118311587395441d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973537686806137d, y: 0.6366633252007418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24630221603997682d, y: 0.3634209810127639d), new NpgsqlTypes.NpgsqlPoint(x: 0.38815104646851173d, y: 0.2894842794652863d), new NpgsqlTypes.NpgsqlPoint(x: 0.19755117707776038d, y: 0.3930879618861429d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34010435226788194d, y: 0.9713370179201735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877254634103794d, y: 0.9596420728573335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422847285463014d, y: 0.6480577539855d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43065340169312083d, y: 0.3238655886027695d), new NpgsqlTypes.NpgsqlPoint(x: 0.2440890667639264d, y: 0.20219749921600383d), new NpgsqlTypes.NpgsqlPoint(x: 0.3834247524657691d, y: 0.18509705796930875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20669815174836403d, y: 0.7539836246771818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433182973499066d, y: 0.7808250473513136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038679518663313d, y: 0.8681302173234746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20218654491322097d, y: 0.2863110762472324d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625385719643835d, y: 0.448293477973729d), new NpgsqlTypes.NpgsqlPoint(x: 0.32230798286922757d, y: 0.2950469608372227d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107995486273632d, y: 0.8831419656759446d), new NpgsqlTypes.NpgsqlPoint(x: 0.0112492415376092d, y: 0.8456812302832123d), new NpgsqlTypes.NpgsqlPoint(x: 0.32578955983170177d, y: 0.7181471477988738d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39402999579006115d, y: 0.04553866098126502d), new NpgsqlTypes.NpgsqlPoint(x: 0.35124134359469616d, y: 0.497063389649246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958602403681474d, y: 0.054564844280521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9893709203433685d, y: 0.206859577451327d), new NpgsqlTypes.NpgsqlPoint(x: 0.15584612836072131d, y: 0.9243154185735786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3973972447148091d, y: 0.6290150234915994d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46203457873956366d, y: 0.6032960564040548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638971152045699d, y: 0.46465280911667506d), new NpgsqlTypes.NpgsqlPoint(x: 0.47034414421484694d, y: 0.08429195691718194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13569748232121215d, y: 0.5042187731902483d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520733773167007d, y: 0.5390147049559852d), new NpgsqlTypes.NpgsqlPoint(x: 0.809086202085171d, y: 0.1548361542879979d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.76169056726302d, y: 0.06883387414894648d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725512053328145d, y: 0.37084958306672966d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774282944819911d, y: 0.72522552597897d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.663065659518477d, y: 0.8581869100394106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454489212672269d, y: 0.9287753268435023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329303562672223d, y: 0.07614175668085688d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11616977998464828d, y: 0.16014678858686449d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004720369929005d, y: 0.5943976708612346d), new NpgsqlTypes.NpgsqlPoint(x: 0.06106998226329852d, y: 0.15666829691140538d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5716480868621441d, y: 0.9460389540589148d), new NpgsqlTypes.NpgsqlPoint(x: 0.04891130806555943d, y: 0.6483631338858152d), new NpgsqlTypes.NpgsqlPoint(x: 0.47133459328314076d, y: 0.6802886619330986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37349118914937895d, y: 0.32125171714154266d), new NpgsqlTypes.NpgsqlPoint(x: 0.26752734980366766d, y: 0.0478047238718583d), new NpgsqlTypes.NpgsqlPoint(x: 0.16488063633639782d, y: 0.5821775189815769d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5194960785241274d, y: 0.9638213234255265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2014213002433054d, y: 0.5524317531609821d), new NpgsqlTypes.NpgsqlPoint(x: 0.4801337368561319d, y: 0.9077963692662048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45024365413009393d, y: 0.4043982947263157d), new NpgsqlTypes.NpgsqlPoint(x: 0.02391129214172283d, y: 0.06567301637114897d), new NpgsqlTypes.NpgsqlPoint(x: 0.06870839096385162d, y: 0.6727808179090409d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7407085999553763d, y: 0.36689119783494195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5061263048070636d, y: 0.3689812866553128d), new NpgsqlTypes.NpgsqlPoint(x: 0.1831106298085794d, y: 0.11436138556434716d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5007000750003082d, y: 0.13765241503443804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961715216516571d, y: 0.4087325799393262d), new NpgsqlTypes.NpgsqlPoint(x: 0.45084064636520504d, y: 0.3874615590775353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14654599772628196d, y: 0.7338072952096584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9596244376694018d, y: 0.5917614376605145d), new NpgsqlTypes.NpgsqlPoint(x: 0.16572746458650622d, y: 0.4038671709508864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27087921418727545d, y: 0.8521634410487806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3818512274100768d, y: 0.3280878307347971d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587005478888033d, y: 0.315699127758601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20083991710892268d, y: 0.393169778820062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158392032257518d, y: 0.5407005407449321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504395646445958d, y: 0.03603871080991694d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6577247661259048d, y: 0.5359462814336172d), new NpgsqlTypes.NpgsqlPoint(x: 0.23168454867609334d, y: 0.9295517907110712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8876747285596202d, y: 0.2812166714510168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30047980284045217d, y: 0.895225310585354d), new NpgsqlTypes.NpgsqlPoint(x: 0.35007621221008245d, y: 0.15403915906463095d), new NpgsqlTypes.NpgsqlPoint(x: 0.1853292929143895d, y: 0.03554025585285403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5648655171110207d, y: 0.5556269405596772d), new NpgsqlTypes.NpgsqlPoint(x: 0.16475640382726686d, y: 0.6858088307534277d), new NpgsqlTypes.NpgsqlPoint(x: 0.4153496607165682d, y: 0.35273174361419024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9045765369318352d, y: 0.2900083768399392d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910657036035826d, y: 0.7516997708848575d), new NpgsqlTypes.NpgsqlPoint(x: 0.682319856693366d, y: 0.647094845553968d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9607635778754875d, y: 0.0024295629770342275d), new NpgsqlTypes.NpgsqlPoint(x: 0.11876825217774489d, y: 0.9890171703405204d), new NpgsqlTypes.NpgsqlPoint(x: 0.18772132078317916d, y: 0.9412125066157377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7794229588728969d, y: 0.592683112164033d), new NpgsqlTypes.NpgsqlPoint(x: 0.32855996699338685d, y: 0.3150911123912832d), new NpgsqlTypes.NpgsqlPoint(x: 0.018427269192738627d, y: 0.0015074456482835341d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9215237560845774d, y: 0.11382368032445322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019270769160409d, y: 0.03705318829724513d), new NpgsqlTypes.NpgsqlPoint(x: 0.7339513647949651d, y: 0.0811805249095815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4487955607377989d, y: 0.1332180187804215d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615781726705358d, y: 0.3620464874260517d), new NpgsqlTypes.NpgsqlPoint(x: 0.555375878206294d, y: 0.5072475407834198d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47899392392460116d, y: 0.5482619544738015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425005923628212d, y: 0.13173647817554202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6342374168277877d, y: 0.6155006988448241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20398262236469034d, y: 0.7760640958964469d), new NpgsqlTypes.NpgsqlPoint(x: 0.30988036075853886d, y: 0.11862020458455957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838079885920909d, y: 0.7290869138582579d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003665907218970532d, y: 0.08947966869607482d), new NpgsqlTypes.NpgsqlPoint(x: 0.11317069788000012d, y: 0.083742801769505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8340894978790465d, y: 0.09444462957276611d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1765341821376304d, y: 0.9153506435282127d), new NpgsqlTypes.NpgsqlPoint(x: 0.8697851503258605d, y: 0.5818286433252613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063007739140749d, y: 0.3322909419314525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24657005669057452d, y: 0.28450685020973376d), new NpgsqlTypes.NpgsqlPoint(x: 0.251849822174796d, y: 0.9015123599572626d), new NpgsqlTypes.NpgsqlPoint(x: 0.734378878352483d, y: 0.11161205693657683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9148948943938736d, y: 0.463282800569792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9734810313012027d, y: 0.12725370758785637d), new NpgsqlTypes.NpgsqlPoint(x: 0.837090697395435d, y: 0.9854977100188881d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4665501004868319d, y: 0.5244403207282985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973667538982072d, y: 0.2622112704608527d), new NpgsqlTypes.NpgsqlPoint(x: 0.8869715987484024d, y: 0.5389217274407242d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6040852923766775d, y: 0.2695717297402479d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941015610960354d, y: 0.7441227139276145d), new NpgsqlTypes.NpgsqlPoint(x: 0.2008751298242616d, y: 0.7782637730177502d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722762172401609d, y: 0.24198641211334493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608315219651211d, y: 0.10540314209035906d), new NpgsqlTypes.NpgsqlPoint(x: 0.26671781597393396d, y: 0.24771682030457998d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7669921916702295d, y: 0.30842858461850586d), new NpgsqlTypes.NpgsqlPoint(x: 0.5275893746668193d, y: 0.9531819807195442d), new NpgsqlTypes.NpgsqlPoint(x: 0.3083480481599319d, y: 0.07512101734229859d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6493797803000507d, y: 0.6444513391342357d), new NpgsqlTypes.NpgsqlPoint(x: 0.04393112440450997d, y: 0.030635278930045806d), new NpgsqlTypes.NpgsqlPoint(x: 0.26063046378194477d, y: 0.7569315290393366d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9065318011840456d, y: 0.7101960849275142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7877577267027107d, y: 0.5943430632388206d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553830250017957d, y: 0.6505712710896963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8835780910478792d, y: 0.12275129162721576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507270315034235d, y: 0.7943045626635448d), new NpgsqlTypes.NpgsqlPoint(x: 0.0413605327699762d, y: 0.4367926659026842d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11252383177168324d, y: 0.7913026894085343d), new NpgsqlTypes.NpgsqlPoint(x: 0.3183694548104651d, y: 0.7850483736750302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948450195568297d, y: 0.5616450903862815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5312500845025674d, y: 0.46974272926759597d), new NpgsqlTypes.NpgsqlPoint(x: 0.3289976630574649d, y: 0.4979559826241582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029337399114824d, y: 0.732224695682466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.947180399346601d, y: 0.4117328576968776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833094651748692d, y: 0.9160570113019963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4532877793111241d, y: 0.06703288175348487d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25593128349703964d, y: 0.28792037424062467d), new NpgsqlTypes.NpgsqlPoint(x: 0.18511834382620873d, y: 0.9435277678531511d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468109609669581d, y: 0.9573066957306879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29330960021690844d, y: 0.42782414924804724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7305154407126917d, y: 0.9454849072480963d), new NpgsqlTypes.NpgsqlPoint(x: 0.20426787846666017d, y: 0.7368076075081077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9600263853019089d, y: 0.9433769664095328d), new NpgsqlTypes.NpgsqlPoint(x: 0.47506434242468065d, y: 0.6510709480304174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9656433982647868d, y: 0.6143712785707562d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8420045622485792d, y: 0.7102241670566487d), new NpgsqlTypes.NpgsqlPoint(x: 0.21979506522067693d, y: 0.22386054869970495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659491574790854d, y: 0.914839553576556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13941358029558104d, y: 0.9846001103522645d), new NpgsqlTypes.NpgsqlPoint(x: 0.19505754810598464d, y: 0.8854915955779766d), new NpgsqlTypes.NpgsqlPoint(x: 0.260837212412117d, y: 0.6285989179736549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6292336579101904d, y: 0.07999953045972907d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734438068329302d, y: 0.14807517793719693d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826139677939523d, y: 0.3996117509835806d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17895274838983355d, y: 0.7012295950231272d), new NpgsqlTypes.NpgsqlPoint(x: 0.9312426118066467d, y: 0.8863623969535792d), new NpgsqlTypes.NpgsqlPoint(x: 0.14210844902511233d, y: 0.4267830277566017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44952166901794355d, y: 0.488328338796403d), new NpgsqlTypes.NpgsqlPoint(x: 0.08072933918453584d, y: 0.46722619870288484d), new NpgsqlTypes.NpgsqlPoint(x: 0.7432769845936068d, y: 0.38339883187454205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2842078111770123d, y: 0.9206511960867799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098772039222191d, y: 0.1921796151580093d), new NpgsqlTypes.NpgsqlPoint(x: 0.11093700746746427d, y: 0.7552060914037149d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9391165103577837d, y: 0.9073462437563187d), new NpgsqlTypes.NpgsqlPoint(x: 0.41819331630348433d, y: 0.29119911109849506d), new NpgsqlTypes.NpgsqlPoint(x: 0.10343410975998846d, y: 0.9869052631990678d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06442301493025604d, y: 0.25307203344249485d), new NpgsqlTypes.NpgsqlPoint(x: 0.8627223997062918d, y: 0.37293608255934274d), new NpgsqlTypes.NpgsqlPoint(x: 0.49275661503049173d, y: 0.9921186269932508d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04733126328083448d, y: 0.9713665981772781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708391660694256d, y: 0.6213138048883889d), new NpgsqlTypes.NpgsqlPoint(x: 0.20817202204560004d, y: 0.7106913686288795d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2633596364606642d, y: 0.90016334258307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545445990157386d, y: 0.2689726172842699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637722123289433d, y: 0.5676494333597384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9050469018891224d, y: 0.8981661016460554d), new NpgsqlTypes.NpgsqlPoint(x: 0.2556536738705727d, y: 0.6706907459265206d), new NpgsqlTypes.NpgsqlPoint(x: 0.2609984746528139d, y: 0.7982068632100866d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13283820196964335d, y: 0.2617170006980032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191969207862931d, y: 0.29197864848311506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818448731175805d, y: 0.7011861096608929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9682607487894089d, y: 0.9844537412012188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9711564716796496d, y: 0.10283240641205404d), new NpgsqlTypes.NpgsqlPoint(x: 0.277348631140212d, y: 0.508473215917862d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7877229248664712d, y: 0.7878305451823586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3203498004400711d, y: 0.7499602932993312d), new NpgsqlTypes.NpgsqlPoint(x: 0.08353248673089464d, y: 0.9670320661159266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.840860945663089d, y: 0.8708359031461679d), new NpgsqlTypes.NpgsqlPoint(x: 0.10427236036910215d, y: 0.7526740556095427d), new NpgsqlTypes.NpgsqlPoint(x: 0.039268636358203546d, y: 0.6347919368797692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109354179693155d, y: 0.3243785578438453d), new NpgsqlTypes.NpgsqlPoint(x: 0.06890613964159653d, y: 0.8054654606754622d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958124608883447d, y: 0.10409407159503514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3483830933118621d, y: 0.8494192296702721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770212195178932d, y: 0.8334941714137646d), new NpgsqlTypes.NpgsqlPoint(x: 0.281637286290226d, y: 0.6616359031800996d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7802831068146077d, y: 0.7455821542911356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9674080771083828d, y: 0.3034172152228558d), new NpgsqlTypes.NpgsqlPoint(x: 0.2152227152073516d, y: 0.2703517697221248d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7502311497799862d, y: 0.2906395648707696d), new NpgsqlTypes.NpgsqlPoint(x: 0.006665786578615163d, y: 0.6046823553286642d), new NpgsqlTypes.NpgsqlPoint(x: 0.10945196641761412d, y: 0.14474809635748287d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7454232384042971d, y: 0.6362782554109468d), new NpgsqlTypes.NpgsqlPoint(x: 0.22734345612696816d, y: 0.4906492419280877d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275698457017954d, y: 0.6688599174504071d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6432461948316343d, y: 0.8544926050968092d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541910769650484d, y: 0.24667444754644363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332419420433853d, y: 0.34684242915053654d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6912480922208947d, y: 0.1633570121165513d), new NpgsqlTypes.NpgsqlPoint(x: 0.1421578897462008d, y: 0.8232458948117383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5120308237334373d, y: 0.6910616622332256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049142146931079767d, y: 0.7329452399828409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682454840120399d, y: 0.06417835200290534d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498164819375421d, y: 0.027724316237442093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2830400872625696d, y: 0.6041550373637824d), new NpgsqlTypes.NpgsqlPoint(x: 0.15508994741771842d, y: 0.8226117871287356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799212143289216d, y: 0.9244043055725848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05452681170214524d, y: 0.04045989155068441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735716879299077d, y: 0.1469500394579396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8290614863591914d, y: 0.1594643911885245d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05795894261056611d, y: 0.5699625945812604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5620978279842953d, y: 0.2603606255162162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4118504597103685d, y: 0.923619263052378d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9559548733152932d, y: 0.7202429123093324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896497073866273d, y: 0.803039072954934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5014973307188241d, y: 0.8170143613973647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4662070980066808d, y: 0.33273663057823966d), new NpgsqlTypes.NpgsqlPoint(x: 0.35430249472376174d, y: 0.3595318024613213d), new NpgsqlTypes.NpgsqlPoint(x: 0.39972687667115625d, y: 0.344336907359018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09423431446448527d, y: 0.23560247929155842d), new NpgsqlTypes.NpgsqlPoint(x: 0.3687831228404487d, y: 0.5246552731859822d), new NpgsqlTypes.NpgsqlPoint(x: 0.9188950114150168d, y: 0.23777232315780272d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37839858009237626d, y: 0.6964159230737897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397834585104096d, y: 0.22060502435259288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168043722008721d, y: 0.056206028129779706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9455084900413036d, y: 0.24201013526361537d), new NpgsqlTypes.NpgsqlPoint(x: 0.2856905393156598d, y: 0.9961866589332966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9584442403357388d, y: 0.9803522090615587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.248542945200257d, y: 0.08416861643579598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346719492827751d, y: 0.7491799775040399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6895570771447235d, y: 0.18606084281493185d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9182799362398667d, y: 0.3614787622477861d), new NpgsqlTypes.NpgsqlPoint(x: 0.010201572346223542d, y: 0.5306661298472838d), new NpgsqlTypes.NpgsqlPoint(x: 0.17543258734735756d, y: 0.8902295777762588d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7447090075779752d, y: 0.7953812456230268d), new NpgsqlTypes.NpgsqlPoint(x: 0.15811756309311809d, y: 0.07289510263420962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4125222102719087d, y: 0.7699824246187936d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.356040890621406d, y: 0.408615415240565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6498576307173694d, y: 0.7522347632704773d), new NpgsqlTypes.NpgsqlPoint(x: 0.13120182430358074d, y: 0.9864124498044708d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.549586142874207d, y: 0.17615392376213068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605969614110941d, y: 0.3574936992500085d), new NpgsqlTypes.NpgsqlPoint(x: 0.39416167096412513d, y: 0.16908115968998327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09933212540803837d, y: 0.18351245910979141d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846748931731081d, y: 0.8755922910295708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385473548245965d, y: 0.9478188190844683d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21335655854239444d, y: 0.2687540309412597d), new NpgsqlTypes.NpgsqlPoint(x: 0.44327852575147475d, y: 0.9974080312515192d), new NpgsqlTypes.NpgsqlPoint(x: 0.35873573065814024d, y: 0.589812102027962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9902378144211194d, y: 0.8050550229722265d), new NpgsqlTypes.NpgsqlPoint(x: 0.4827814055118549d, y: 0.6402315969259852d), new NpgsqlTypes.NpgsqlPoint(x: 0.11611629870442874d, y: 0.2709591826008211d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6975057335448042d, y: 0.4562545964342134d), new NpgsqlTypes.NpgsqlPoint(x: 0.45938974235393026d, y: 0.07326362181135815d), new NpgsqlTypes.NpgsqlPoint(x: 0.742097712691681d, y: 0.22735046674393067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6438036438324874d, y: 0.8135642862535057d), new NpgsqlTypes.NpgsqlPoint(x: 0.22431450511989937d, y: 0.18030221842182903d), new NpgsqlTypes.NpgsqlPoint(x: 0.20872578059360758d, y: 0.7855207618101112d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4019487036019561d, y: 0.08357682368908004d), new NpgsqlTypes.NpgsqlPoint(x: 0.3745023456236163d, y: 0.42152948796768774d), new NpgsqlTypes.NpgsqlPoint(x: 0.008197290633585985d, y: 0.7979623259170879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3936939418109613d, y: 0.5258842226295253d), new NpgsqlTypes.NpgsqlPoint(x: 0.6791081477211407d, y: 0.49633254316569364d), new NpgsqlTypes.NpgsqlPoint(x: 0.4617801362048418d, y: 0.2516562531541938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.996461594828404d, y: 0.9538245412711065d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209096729171754d, y: 0.9550198766983083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6794254599667731d, y: 0.6525418496613226d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36091831250202544d, y: 0.7478407435140451d), new NpgsqlTypes.NpgsqlPoint(x: 0.49273305539237444d, y: 0.9671933022463709d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732106941282945d, y: 0.36970950981202044d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5503093771629044d, y: 0.24723999057047852d), new NpgsqlTypes.NpgsqlPoint(x: 0.770582346741672d, y: 0.27573234168268534d), new NpgsqlTypes.NpgsqlPoint(x: 0.2461677736193958d, y: 0.7017523883784875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7736532240625776d, y: 0.07705021482860464d), new NpgsqlTypes.NpgsqlPoint(x: 0.32854940090640306d, y: 0.8927789244747663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151800048264128d, y: 0.26307118886652336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9812084193970438d, y: 0.7516490260431147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5761724710745592d, y: 0.3879280919091209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366300213378488d, y: 0.051859998613478786d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9750552462296296d, y: 0.409928499113821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992363050962505d, y: 0.7446603348383608d), new NpgsqlTypes.NpgsqlPoint(x: 0.332628126807364d, y: 0.258464230391397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6531997990529227d, y: 0.488664236190792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925865242252262d, y: 0.8193145646064866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4812491712480623d, y: 0.316231207938906d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3959610187221543d, y: 0.42885325917404615d), new NpgsqlTypes.NpgsqlPoint(x: 0.11625243284155617d, y: 0.06445292879556364d), new NpgsqlTypes.NpgsqlPoint(x: 0.42999142633546794d, y: 0.24132876558617478d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3580557937774439d, y: 0.3655486843191359d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588397101403995d, y: 0.1365906103647655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9515203649614972d, y: 0.6124477000263409d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06702166931221087d, y: 0.717804840191214d), new NpgsqlTypes.NpgsqlPoint(x: 0.44390448844300046d, y: 0.4646825756746117d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390698812546361d, y: 0.7470716949441777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5946278048237263d, y: 0.037080872229602324d), new NpgsqlTypes.NpgsqlPoint(x: 0.044255800033601855d, y: 0.9084035062700865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055655498770993d, y: 0.0709639412105566d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03705430592761416d, y: 0.08891974705766936d), new NpgsqlTypes.NpgsqlPoint(x: 0.4867263979051146d, y: 0.19867068496018037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6185822546490938d, y: 0.3794333634927055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4030192795265506d, y: 0.7263222054037095d), new NpgsqlTypes.NpgsqlPoint(x: 0.31949489910787d, y: 0.031694264245522685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136888193685507d, y: 0.18304681332447215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15064134655185768d, y: 0.5395360388984904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528848717262759d, y: 0.4149302814621716d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109524828686653d, y: 0.07584927750793691d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23031145121800467d, y: 0.5459784296057869d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168641481810398d, y: 0.24734840244362777d), new NpgsqlTypes.NpgsqlPoint(x: 0.12112868500530627d, y: 0.21377558580805467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21994443607547265d, y: 0.4901417685126843d), new NpgsqlTypes.NpgsqlPoint(x: 0.16527513298273477d, y: 0.3668738849253126d), new NpgsqlTypes.NpgsqlPoint(x: 0.020194908775194476d, y: 0.6389104327629878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6948019588101894d, y: 0.06593542452632317d), new NpgsqlTypes.NpgsqlPoint(x: 0.41493997639756564d, y: 0.5397161562364532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192524402736579d, y: 0.20183205642057878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32553853766938357d, y: 0.045978499235228676d), new NpgsqlTypes.NpgsqlPoint(x: 0.4386160511981261d, y: 0.3226262608717927d), new NpgsqlTypes.NpgsqlPoint(x: 0.4513161430088003d, y: 0.7932811748418355d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23684508040609242d, y: 0.9302073908154062d), new NpgsqlTypes.NpgsqlPoint(x: 0.35133749649585566d, y: 0.9607258294690315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4343559800075688d, y: 0.3564728269961629d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8426554730393665d, y: 0.5855586123813771d), new NpgsqlTypes.NpgsqlPoint(x: 0.636657355370563d, y: 0.4833146560692094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004997180982792d, y: 0.6675288662423704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11896416412062938d, y: 0.7379157772103847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8987243537687614d, y: 0.007167993821493357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851075800154965d, y: 0.3091541302938986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05852059640219476d, y: 0.48773501017901333d), new NpgsqlTypes.NpgsqlPoint(x: 0.12115562115849177d, y: 0.4784948809363897d), new NpgsqlTypes.NpgsqlPoint(x: 0.48201323110678473d, y: 0.6229650042646806d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06935954908516395d, y: 0.5552463047499855d), new NpgsqlTypes.NpgsqlPoint(x: 0.13776617043285377d, y: 0.9658182112502464d), new NpgsqlTypes.NpgsqlPoint(x: 0.037231636613225705d, y: 0.3354293476552538d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33024479976989174d, y: 0.03446716618319068d), new NpgsqlTypes.NpgsqlPoint(x: 0.8352149845304249d, y: 0.47718483744029094d), new NpgsqlTypes.NpgsqlPoint(x: 0.05960396564271242d, y: 0.037070891499138225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37839102624473064d, y: 0.612974490095322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8239749530896332d, y: 0.8626839153393374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120941048384207d, y: 0.8324099095727396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1887039918231176d, y: 0.9522067540633297d), new NpgsqlTypes.NpgsqlPoint(x: 0.44372672199565666d, y: 0.6652872886331697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240730532500956d, y: 0.8795130521534907d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002290459072458506d, y: 0.43074474967905385d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138467005535707d, y: 0.030156517476601197d), new NpgsqlTypes.NpgsqlPoint(x: 0.01100520343114575d, y: 0.7026292854805668d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34905752408852997d, y: 0.5925603078680717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2695524314310167d, y: 0.5196400026961907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653258022855781d, y: 0.562895653548306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12583576728441936d, y: 0.15524088465323704d), new NpgsqlTypes.NpgsqlPoint(x: 0.667329318573455d, y: 0.33601602705667366d), new NpgsqlTypes.NpgsqlPoint(x: 0.2305107007746513d, y: 0.06153837525784078d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7961616090805663d, y: 0.12161105004638073d), new NpgsqlTypes.NpgsqlPoint(x: 0.332573080993557d, y: 0.6542789396833142d), new NpgsqlTypes.NpgsqlPoint(x: 0.19331632111167396d, y: 0.264343978790193d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4234752040858677d, y: 0.1649908520438269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7393141921997678d, y: 0.17456553347377668d), new NpgsqlTypes.NpgsqlPoint(x: 0.2128711411977362d, y: 0.4825138982823639d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9691960088511574d, y: 0.8994874676753554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9950078724255108d, y: 0.31749056818708743d), new NpgsqlTypes.NpgsqlPoint(x: 0.45147403208550496d, y: 0.037349000806271127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21987037870628057d, y: 0.16221598408821736d), new NpgsqlTypes.NpgsqlPoint(x: 0.724911143079491d, y: 0.5385146247524614d), new NpgsqlTypes.NpgsqlPoint(x: 0.3890842722381639d, y: 0.3820952835573054d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19126810333983468d, y: 0.8946563175806838d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485474636359713d, y: 0.858757442071125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852219323096225d, y: 0.9378463877568195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833804418785811d, y: 0.6372216556513105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9863046248083039d, y: 0.39368381778395833d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555487324874274d, y: 0.5522085862727129d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44490163451817977d, y: 0.979089613084461d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335484731777226d, y: 0.7944753343261093d), new NpgsqlTypes.NpgsqlPoint(x: 0.805975830573667d, y: 0.648096338143337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9286903933122735d, y: 0.024760972701791895d), new NpgsqlTypes.NpgsqlPoint(x: 0.4901569438278409d, y: 0.9284389672346488d), new NpgsqlTypes.NpgsqlPoint(x: 0.1935350990596395d, y: 0.5003673280495662d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3992219705179566d, y: 0.731830961665914d), new NpgsqlTypes.NpgsqlPoint(x: 0.1850130943617645d, y: 0.9106739559221867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474056582641868d, y: 0.9313774242087938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4283328289141827d, y: 0.588814048781196d), new NpgsqlTypes.NpgsqlPoint(x: 0.15323873284018186d, y: 0.09245495103131507d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339164275643516d, y: 0.4930222725765956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5175711711913418d, y: 0.5631975942182476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753964085557505d, y: 0.5590051022996659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441104506791171d, y: 0.1460904203380201d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20497392438575812d, y: 0.9297914324190333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654311697850524d, y: 0.4339746650503208d), new NpgsqlTypes.NpgsqlPoint(x: 0.371164602626445d, y: 0.402659997945102d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5765994217691793d, y: 0.8489305999187642d), new NpgsqlTypes.NpgsqlPoint(x: 0.8360149122425632d, y: 0.07880024754262582d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570714285213112d, y: 0.6050851740261413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43030176421674604d, y: 0.18931792397927716d), new NpgsqlTypes.NpgsqlPoint(x: 0.2920823376956472d, y: 0.28789030756343836d), new NpgsqlTypes.NpgsqlPoint(x: 0.19331990850325897d, y: 0.9345484238407817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1919762656710733d, y: 0.6398825832933575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617274559952006d, y: 0.3236165606339765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200133371074702d, y: 0.03535049900670817d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3142193770677051d, y: 0.6157235318745146d), new NpgsqlTypes.NpgsqlPoint(x: 0.030108049890839483d, y: 0.3053027695880999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922279810860872d, y: 0.8392255370487093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9459775800601947d, y: 0.18863274115241035d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372146332729824d, y: 0.32039915050598644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164280180454754d, y: 0.595130888178469d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.977783819342718d, y: 0.5825183566979113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324584124707929d, y: 0.053010590522728274d), new NpgsqlTypes.NpgsqlPoint(x: 0.2243311053924355d, y: 0.8706940299062105d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4056892819755481d, y: 0.08335747457294318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708657599855577d, y: 0.08799896847622879d), new NpgsqlTypes.NpgsqlPoint(x: 0.8224367511041665d, y: 0.5590090795223729d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19950244390479854d, y: 0.947785712524087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891669993181908d, y: 0.33487070928060403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9309137681949283d, y: 0.5433175938603251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21179187086020312d, y: 0.6542370089397486d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345980863398243d, y: 0.6417281764146607d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322947209501524d, y: 0.7497262727776632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382412543609449d, y: 0.958787475216569d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371758503821322d, y: 0.9218423099861941d), new NpgsqlTypes.NpgsqlPoint(x: 0.33185315119887737d, y: 0.4229165374703996d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8897801831829117d, y: 0.9342519363052753d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746404334213348d, y: 0.34245587626872576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723279914737239d, y: 0.520089292411215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7892123647480107d, y: 0.7235335774637334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617785859227372d, y: 0.7059427349658159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9014638918594935d, y: 0.9689019489954461d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9644566507718435d, y: 0.42969488197192207d), new NpgsqlTypes.NpgsqlPoint(x: 0.14907033053490204d, y: 0.6436149295978361d), new NpgsqlTypes.NpgsqlPoint(x: 0.29534100744890346d, y: 0.1322840989779881d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9932016579813706d, y: 0.9637607847476001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2490148786477665d, y: 0.8407306853392325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8286277702437425d, y: 0.5606157199186421d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28191786300322663d, y: 0.8157908076366353d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024612992252028842d, y: 0.38723923893399415d), new NpgsqlTypes.NpgsqlPoint(x: 0.276423988845931d, y: 0.9593198697476392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5229588254952561d, y: 0.9133394040887322d), new NpgsqlTypes.NpgsqlPoint(x: 0.20255042744561325d, y: 0.06825819787143417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5518703398994804d, y: 0.6193360451521435d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7962722740078738d, y: 0.2825185253873146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960124458903255d, y: 0.42561428248643596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559387673007861d, y: 0.9237612333979666d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4372203033200288d, y: 0.31227868024911154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7977691694088878d, y: 0.1609909938076417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5120698885170012d, y: 0.47741920674228644d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7059848081561986d, y: 0.47782418991345876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414146587599427d, y: 0.5933220629201092d), new NpgsqlTypes.NpgsqlPoint(x: 0.673891077672324d, y: 0.4611080127681171d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3556697464649531d, y: 0.9898464131737558d), new NpgsqlTypes.NpgsqlPoint(x: 0.12424644069843349d, y: 0.23203434747184826d), new NpgsqlTypes.NpgsqlPoint(x: 0.20567829311377483d, y: 0.3597326578835012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.743363414018121d, y: 0.5084758295716222d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566890536371381d, y: 0.26840957828190315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801864471270729d, y: 0.5737106044295155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8832450439061708d, y: 0.45043437523843577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500035334657643d, y: 0.032207795826377894d), new NpgsqlTypes.NpgsqlPoint(x: 0.1964298511470033d, y: 0.33038943299786505d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5967567224050768d, y: 0.5084884862827266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3702507214740729d, y: 0.9331819111565798d), new NpgsqlTypes.NpgsqlPoint(x: 0.5316740033640032d, y: 0.7889753933789702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4842123350107328d, y: 0.7269883255978802d), new NpgsqlTypes.NpgsqlPoint(x: 0.19012748836037408d, y: 0.4532044431015019d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694135671626589d, y: 0.46732767607020653d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517315347131738d, y: 0.797818620205731d), new NpgsqlTypes.NpgsqlPoint(x: 0.27215788485291625d, y: 0.8969474429565254d), new NpgsqlTypes.NpgsqlPoint(x: 0.4767502555938533d, y: 0.23256682165866283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20864213460883896d, y: 0.2557906897819777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451568858082077d, y: 0.6956223446211282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3777367861082136d, y: 0.7749449621794647d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8388664500075165d, y: 0.6485854573382704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817651402466043d, y: 0.9652687834788926d), new NpgsqlTypes.NpgsqlPoint(x: 0.30445972188857484d, y: 0.9918203790733894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.715043272686356d, y: 0.6953875039029487d), new NpgsqlTypes.NpgsqlPoint(x: 0.09111466861119599d, y: 0.7958039284411665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9566217449974566d, y: 0.10069691616449372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.347386968157563d, y: 0.13357799983383145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7883622281739406d, y: 0.8097559048679238d), new NpgsqlTypes.NpgsqlPoint(x: 0.1626417782289511d, y: 0.7450445672050584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5848828566788343d, y: 0.47006378194464793d), new NpgsqlTypes.NpgsqlPoint(x: 0.28911652378999386d, y: 0.5446792675080306d), new NpgsqlTypes.NpgsqlPoint(x: 0.760613842861568d, y: 0.8891816624641611d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9070932533863048d, y: 0.2546627651667567d), new NpgsqlTypes.NpgsqlPoint(x: 0.12297410142532728d, y: 0.7599766099050588d), new NpgsqlTypes.NpgsqlPoint(x: 0.40324265467849985d, y: 0.14375511459913026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21538221159261406d, y: 0.6107816935522418d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181150266204917d, y: 0.9328642061334119d), new NpgsqlTypes.NpgsqlPoint(x: 0.6232989061793122d, y: 0.04561316369335178d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06837608603977241d, y: 0.5373965647863503d), new NpgsqlTypes.NpgsqlPoint(x: 0.047439797617243484d, y: 0.7377949675049122d), new NpgsqlTypes.NpgsqlPoint(x: 0.692784468153167d, y: 0.9886285533490091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8999263114826958d, y: 0.7330502050851867d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964365783358219d, y: 0.4481501122364858d), new NpgsqlTypes.NpgsqlPoint(x: 0.3935647728959777d, y: 0.02939919294004678d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)), 
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
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8502425692989278d, y: 0.008011921567833036d), new NpgsqlTypes.NpgsqlPoint(x: 0.3386002616376772d, y: 0.16071298983380988d), new NpgsqlTypes.NpgsqlPoint(x: 0.11281880643096331d, y: 0.030637395660475297d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4160507862005173d, y: 0.15702331286789883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987286574536602d, y: 0.12416501114891698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623311339591859d, y: 0.9788875180059283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5669361174527985d, y: 0.6142734747035331d), new NpgsqlTypes.NpgsqlPoint(x: 0.19064126745718257d, y: 0.8427205915893461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902446677549334d, y: 0.4278366066297401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6121121679905095d, y: 0.969426889729889d), new NpgsqlTypes.NpgsqlPoint(x: 0.45888321184185954d, y: 0.5252244829959318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911521927863709d, y: 0.0992164858202994d)),
}));
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4112800874017196d, y: 0.25860469286619736d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423924229837117d, y: 0.7688792746334286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069665783491165d, y: 0.2286763003370269d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8179763962144431d, y: 0.7851666114978866d), new NpgsqlTypes.NpgsqlPoint(x: 0.219277426512955d, y: 0.29824050260885693d), new NpgsqlTypes.NpgsqlPoint(x: 0.9171091243373726d, y: 0.07827021609813956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6146917905331934d, y: 0.8497523244913769d), new NpgsqlTypes.NpgsqlPoint(x: 0.682196280331384d, y: 0.22840928948423445d), new NpgsqlTypes.NpgsqlPoint(x: 0.5920212947771539d, y: 0.9446763073348114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26524844835542083d, y: 0.5920136765602036d), new NpgsqlTypes.NpgsqlPoint(x: 0.6935137910789296d, y: 0.027592971411127265d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085808097213829d, y: 0.46220944576364076d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536698734468108d, y: 0.9767964302473555d), new NpgsqlTypes.NpgsqlPoint(x: 0.48580525452211376d, y: 0.09815965943383465d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626480382616469d, y: 0.5812930453927737d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6011890328871655d, y: 0.14216138800809686d), new NpgsqlTypes.NpgsqlPoint(x: 0.36124792406910355d, y: 0.15436078330473468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2646716190022699d, y: 0.4351148077226925d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522269221344397d, y: 0.27350003728548933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124902105437567d, y: 0.5609561810495886d), new NpgsqlTypes.NpgsqlPoint(x: 0.838964111333405d, y: 0.5593514049931199d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
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
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 62, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 53, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 33, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 41, 142))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
FROM public.binary_npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI), typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

