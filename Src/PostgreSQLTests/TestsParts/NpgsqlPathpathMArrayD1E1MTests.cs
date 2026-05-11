

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
    internal partial interface INpgsqlPathMArraypathMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMArrayD1 : INpgsqlPathMArraypathMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMArrayD1E1M[] _testData = new NpgsqlPathpathMArrayD1E1M[]
        {
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.683973354699118d, y: 0.907519758867214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534047512157076d, y: 0.8859917814730482d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465760660901839d, y: 0.3410370722176347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5223622917078482d, y: 0.5092578191902655d), new NpgsqlTypes.NpgsqlPoint(x: 0.11525365877819416d, y: 0.8623451250513517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013185982968686d, y: 0.24240923378310353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28539392263979313d, y: 0.5594639123116879d), new NpgsqlTypes.NpgsqlPoint(x: 0.44891232816762994d, y: 0.13868380672861935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5179243504620451d, y: 0.4708784455676259d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43423443994425537d, y: 0.9462609437967415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296370691964131d, y: 0.31496466010976665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756740838624873d, y: 0.2841956383406383d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8407124591958579d, y: 0.5710390094750861d), new NpgsqlTypes.NpgsqlPoint(x: 0.29229839628144116d, y: 0.49607451317340745d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205666477329624d, y: 0.8141138472799837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5754841100609599d, y: 0.33389445329500267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280418563831381d, y: 0.2688851154320533d), new NpgsqlTypes.NpgsqlPoint(x: 0.677941324503151d, y: 0.4499797910423653d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7666702714082881d, y: 0.7383655859643294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451288372548161d, y: 0.9101816882446981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434710514921748d, y: 0.6681653592850276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7949032462549166d, y: 0.3412063582916123d), new NpgsqlTypes.NpgsqlPoint(x: 0.548795541784013d, y: 0.66676557534974d), new NpgsqlTypes.NpgsqlPoint(x: 0.2993831263390031d, y: 0.23716040789460247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20388267459045972d, y: 0.9559723649419842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801300508657798d, y: 0.7343673055609511d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511044522226282d, y: 0.3280189238429442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15407226095983617d, y: 0.9620840513092337d), new NpgsqlTypes.NpgsqlPoint(x: 0.08154340346875055d, y: 0.2251503979800924d), new NpgsqlTypes.NpgsqlPoint(x: 0.0004785556025196369d, y: 0.4534945826297573d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24746909310930043d, y: 0.02516209743551212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278811551552726d, y: 0.012356918872418854d), new NpgsqlTypes.NpgsqlPoint(x: 0.004508224311535636d, y: 0.8854002131181146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13884676855758293d, y: 0.5270929431260949d), new NpgsqlTypes.NpgsqlPoint(x: 0.32298184901588456d, y: 0.008292851368573939d), new NpgsqlTypes.NpgsqlPoint(x: 0.8240643887433637d, y: 0.9393502956582558d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854061928874353d, y: 0.19464587252029297d), new NpgsqlTypes.NpgsqlPoint(x: 0.025563118471348734d, y: 0.667631753583743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6652940207877341d, y: 0.3823489464388369d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.873653960107387d, y: 0.3365200015332148d), new NpgsqlTypes.NpgsqlPoint(x: 0.10863486515840404d, y: 0.2588215315811523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3337665208743803d, y: 0.38590313525052167d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6095793302305486d, y: 0.30180788780860923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528511615605355d, y: 0.18535529692164876d), new NpgsqlTypes.NpgsqlPoint(x: 0.2373535438611163d, y: 0.03324023667278719d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9108197650724066d, y: 0.8828800360214284d), new NpgsqlTypes.NpgsqlPoint(x: 0.842666702738168d, y: 0.11526838237392334d), new NpgsqlTypes.NpgsqlPoint(x: 0.4923332898594549d, y: 0.7330931733820446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07733676681691093d, y: 0.7533611626485998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4690273268118593d, y: 0.7558134382898772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905695209823693d, y: 0.1968777593212263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9845202018073155d, y: 0.7508966435026032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6340439034243984d, y: 0.0588069329184463d), new NpgsqlTypes.NpgsqlPoint(x: 0.3053006935436091d, y: 0.23720694794884656d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164793177130025d, y: 0.0011688271705710962d), new NpgsqlTypes.NpgsqlPoint(x: 0.04987602119767687d, y: 0.9200386313186062d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493878996048797d, y: 0.9054606693768923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.524072012331065d, y: 0.5949454000207938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8129048772802502d, y: 0.8832915786935955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9305813497595986d, y: 0.028345351502312544d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5379416000323003d, y: 0.03743183173521625d), new NpgsqlTypes.NpgsqlPoint(x: 0.129983743079775d, y: 0.12493769631479068d), new NpgsqlTypes.NpgsqlPoint(x: 0.43941445418878067d, y: 0.10111852211840522d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018423318109726416d, y: 0.45811628557906225d), new NpgsqlTypes.NpgsqlPoint(x: 0.08779316155420291d, y: 0.22216791633249477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585940271714846d, y: 0.9797523414579566d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5280029370999003d, y: 0.2084678092629032d), new NpgsqlTypes.NpgsqlPoint(x: 0.020337850500298682d, y: 0.26096800250203434d), new NpgsqlTypes.NpgsqlPoint(x: 0.31426569802290927d, y: 0.22243390899314552d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13280862471367638d, y: 0.7603793071379129d), new NpgsqlTypes.NpgsqlPoint(x: 0.9133075359479509d, y: 0.07249868167821016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630626400326772d, y: 0.3358866393529417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4857911518593705d, y: 0.7602463402301177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593982252625137d, y: 0.70386982481364d), new NpgsqlTypes.NpgsqlPoint(x: 0.25293631278332074d, y: 0.05542725257284653d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2967270541509115d, y: 0.3736197513068892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299594533198438d, y: 0.36743646481343384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089697123528708d, y: 0.0038252357952867078d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2754739763728409d, y: 0.6859031193000517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903959226714518d, y: 0.8604018887209605d), new NpgsqlTypes.NpgsqlPoint(x: 0.33954729987602017d, y: 0.010815960232457789d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10662735929114187d, y: 0.2864025387188027d), new NpgsqlTypes.NpgsqlPoint(x: 0.40985132270115987d, y: 0.7079584592807004d), new NpgsqlTypes.NpgsqlPoint(x: 0.261529646774717d, y: 0.878306645133796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6672615070932945d, y: 0.8658533918769744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734838023020625d, y: 0.6529989890962459d), new NpgsqlTypes.NpgsqlPoint(x: 0.5447469251214783d, y: 0.24486704932270154d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768082857054809d, y: 0.795610766432894d), new NpgsqlTypes.NpgsqlPoint(x: 0.3361645539565442d, y: 0.5671836497470336d), new NpgsqlTypes.NpgsqlPoint(x: 0.1778143912538248d, y: 0.14629759135138953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04305316917123625d, y: 0.6983426283369804d), new NpgsqlTypes.NpgsqlPoint(x: 0.09460123332208203d, y: 0.6226777226720434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429194554639549d, y: 0.7185982098887077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7690211438805974d, y: 0.5125811497147642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742114261920277d, y: 0.6828970474854263d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566011459507783d, y: 0.5014140376800764d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987838244820218d, y: 0.7497176545325889d), new NpgsqlTypes.NpgsqlPoint(x: 0.751970606433843d, y: 0.6222689380602041d), new NpgsqlTypes.NpgsqlPoint(x: 0.49622396596084295d, y: 0.39784965693458607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38332908573702196d, y: 0.8582507432225118d), new NpgsqlTypes.NpgsqlPoint(x: 0.846997406434384d, y: 0.8008575104026199d), new NpgsqlTypes.NpgsqlPoint(x: 0.38065719704365986d, y: 0.5961555609810062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31837567954679225d, y: 0.04647026226293682d), new NpgsqlTypes.NpgsqlPoint(x: 0.27331253908232056d, y: 0.38556122737410714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5440203291595103d, y: 0.3404159520307347d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48456148594847115d, y: 0.694315050919947d), new NpgsqlTypes.NpgsqlPoint(x: 0.931039868230846d, y: 0.04304823298918381d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315994808915374d, y: 0.8617826554918395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26146738595912444d, y: 0.26796992711420664d), new NpgsqlTypes.NpgsqlPoint(x: 0.42995467638715845d, y: 0.2403086118784965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968905763597015d, y: 0.8153931458990054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8091367188508346d, y: 0.22340277537894038d), new NpgsqlTypes.NpgsqlPoint(x: 0.666959547422711d, y: 0.8266805766117769d), new NpgsqlTypes.NpgsqlPoint(x: 0.34480191631411905d, y: 0.13234144381388724d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.706621812231373d, y: 0.5526130748491505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3633390536354859d, y: 0.5549576220641111d), new NpgsqlTypes.NpgsqlPoint(x: 0.4596725126317497d, y: 0.40128845403986313d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.789598403867893d, y: 0.19089862645821198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413154192159243d, y: 0.0025202763425838937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508793547466855d, y: 0.9337776971763735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7671617246600522d, y: 0.6996200559368446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584018699510618d, y: 0.5982724964282101d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563465713668008d, y: 0.6776698113846275d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12122177461044548d, y: 0.4711128260758084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159988358265057d, y: 0.9915405385751735d), new NpgsqlTypes.NpgsqlPoint(x: 0.26570704703260783d, y: 0.06280960296123983d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3635137226135483d, y: 0.9414122986881677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438243233127944d, y: 0.58595331323338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072963998292574d, y: 0.8150436209783044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43494316637934416d, y: 0.6448833990850984d), new NpgsqlTypes.NpgsqlPoint(x: 0.42050712017142666d, y: 0.5768913242538485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559832882371098d, y: 0.9300447146959826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768582670415046d, y: 0.050535359787835854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369217354281486d, y: 0.4594187114842899d), new NpgsqlTypes.NpgsqlPoint(x: 0.77503152723777d, y: 0.5873131752724362d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7483861065778598d, y: 0.6802808963175784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2619647325576727d, y: 0.9644494438161487d), new NpgsqlTypes.NpgsqlPoint(x: 0.2551472144393817d, y: 0.6249567459534908d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38867238381796154d, y: 0.5742954578285012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521297850443721d, y: 0.4520537078089537d), new NpgsqlTypes.NpgsqlPoint(x: 0.384129808968928d, y: 0.6648401704019746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6424135755130528d, y: 0.6976921392444134d), new NpgsqlTypes.NpgsqlPoint(x: 0.18279660556902666d, y: 0.3041649966014701d), new NpgsqlTypes.NpgsqlPoint(x: 0.43128193940629933d, y: 0.5821089385337769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18650063029969877d, y: 0.4975888882763627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966364609267565d, y: 0.7573420857491892d), new NpgsqlTypes.NpgsqlPoint(x: 0.4922362888423666d, y: 0.4579507371687239d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9641025903526066d, y: 0.3349780330848562d), new NpgsqlTypes.NpgsqlPoint(x: 0.10459636805589112d, y: 0.16542565666399733d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656685882333555d, y: 0.7213967790960977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791750323422466d, y: 0.0794720774271338d), new NpgsqlTypes.NpgsqlPoint(x: 0.36475129708706133d, y: 0.029936650910570073d), new NpgsqlTypes.NpgsqlPoint(x: 0.15366705182637141d, y: 0.13356686370647608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04222094874079296d, y: 0.8353434804127498d), new NpgsqlTypes.NpgsqlPoint(x: 0.38634872816737587d, y: 0.11838389287273188d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402081044504734d, y: 0.35830543421805816d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6071565865309414d, y: 0.8335172398315932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059560422265104d, y: 0.01806094475327813d), new NpgsqlTypes.NpgsqlPoint(x: 0.39243320690177197d, y: 0.5874324831542659d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9728271050090802d, y: 0.2142811279315d), new NpgsqlTypes.NpgsqlPoint(x: 0.739764004802845d, y: 0.056513644557673826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722206493925848d, y: 0.38098284904226276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047777631773690765d, y: 0.5909942518695283d), new NpgsqlTypes.NpgsqlPoint(x: 0.4079839287690853d, y: 0.42586669795251764d), new NpgsqlTypes.NpgsqlPoint(x: 0.15568180033758705d, y: 0.5532855600383472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38280519746745056d, y: 0.12442852424990636d), new NpgsqlTypes.NpgsqlPoint(x: 0.21837442774014326d, y: 0.08477560827462194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7459969689771879d, y: 0.5430799084332043d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6487576447236376d, y: 0.3265861150315639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994638471198113d, y: 0.32428300712734104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5979239714529471d, y: 0.3747939020417972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9598177154866576d, y: 0.6211551212041628d), new NpgsqlTypes.NpgsqlPoint(x: 0.026513524734105176d, y: 0.8696344175335555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8510531652767696d, y: 0.4304911687101969d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5869159996233934d, y: 0.27941136987206516d), new NpgsqlTypes.NpgsqlPoint(x: 0.745738837043457d, y: 0.9043411176731331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190088023725443d, y: 0.6489601592708573d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15039138960660714d, y: 0.003254650094973166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8157497400401604d, y: 0.2790237285048417d), new NpgsqlTypes.NpgsqlPoint(x: 0.2547930492055678d, y: 0.9778354834241239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6744398477619714d, y: 0.3139914766110433d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626365185312565d, y: 0.7505654333766223d), new NpgsqlTypes.NpgsqlPoint(x: 0.3241014315033992d, y: 0.9412021937692087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5557668363728565d, y: 0.5590748518017135d), new NpgsqlTypes.NpgsqlPoint(x: 0.05026004506404602d, y: 0.158345726007601d), new NpgsqlTypes.NpgsqlPoint(x: 0.17611403204196452d, y: 0.46068269368661174d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5940432308306958d, y: 0.1955391684735026d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722192558605748d, y: 0.07798494971244363d), new NpgsqlTypes.NpgsqlPoint(x: 0.6488639713191356d, y: 0.011722924221756803d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23056338948538668d, y: 0.41147955918429957d), new NpgsqlTypes.NpgsqlPoint(x: 0.15020688783096336d, y: 0.4646747730577485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194167943523651d, y: 0.8038719782290797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09880897143208822d, y: 0.918210737195404d), new NpgsqlTypes.NpgsqlPoint(x: 0.41842891635119384d, y: 0.66574501974618d), new NpgsqlTypes.NpgsqlPoint(x: 0.198344580473219d, y: 0.2666967346285186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46093029997498347d, y: 0.6746622167114171d), new NpgsqlTypes.NpgsqlPoint(x: 0.6332833035609906d, y: 0.8787565851193363d), new NpgsqlTypes.NpgsqlPoint(x: 0.4679485160449163d, y: 0.13957815374604576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1166597516913973d, y: 0.5721566821164915d), new NpgsqlTypes.NpgsqlPoint(x: 0.904415441395992d, y: 0.6236178804146989d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243317029662359d, y: 0.3518551941535808d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3922077447629003d, y: 0.6117376701328587d), new NpgsqlTypes.NpgsqlPoint(x: 0.4184874302013104d, y: 0.965124106189047d), new NpgsqlTypes.NpgsqlPoint(x: 0.39089692167366075d, y: 0.28745817013751584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14664198168376807d, y: 0.4275683242816162d), new NpgsqlTypes.NpgsqlPoint(x: 0.07547548050200781d, y: 0.7303727440519321d), new NpgsqlTypes.NpgsqlPoint(x: 0.009966446193839351d, y: 0.2867883994460725d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7559642876481054d, y: 0.5994166712950766d), new NpgsqlTypes.NpgsqlPoint(x: 0.019650766688141585d, y: 0.08895537482526494d), new NpgsqlTypes.NpgsqlPoint(x: 0.013133117809001504d, y: 0.779051221384772d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44173514016257265d, y: 0.7509332224918722d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015293995957277d, y: 0.44570961756628336d), new NpgsqlTypes.NpgsqlPoint(x: 0.2835241592088744d, y: 0.02906146925449493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5293676992259405d, y: 0.3672764922746907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176344510030161d, y: 0.10978853287040169d), new NpgsqlTypes.NpgsqlPoint(x: 0.29507434389454135d, y: 0.64695313699088d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7138528745496038d, y: 0.5324428923446487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9839926630087908d, y: 0.5630630752914738d), new NpgsqlTypes.NpgsqlPoint(x: 0.031090605906323066d, y: 0.4483787803705658d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9759561545059093d, y: 0.8818552246584077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639367339854814d, y: 0.6548867454673845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157880023425616d, y: 0.6012084593798338d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25462969135130464d, y: 0.9644870540449442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8998351534044402d, y: 0.1578009616658228d), new NpgsqlTypes.NpgsqlPoint(x: 0.35058212856307835d, y: 0.8672140377962971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6781121912993006d, y: 0.324028222206739d), new NpgsqlTypes.NpgsqlPoint(x: 0.13876586944949543d, y: 0.3398958085218724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398578819568971d, y: 0.6117148130919569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4288333239707848d, y: 0.33501581155228066d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673048612105307d, y: 0.04005666724318979d), new NpgsqlTypes.NpgsqlPoint(x: 0.669053473216146d, y: 0.15767504652126052d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2195466064122068d, y: 0.8069648117883955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515452197488106d, y: 0.7491810989936657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4574805020137135d, y: 0.3638078861087223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6936588539983242d, y: 0.26574703302818614d), new NpgsqlTypes.NpgsqlPoint(x: 0.31217340829568885d, y: 0.19284051067271057d), new NpgsqlTypes.NpgsqlPoint(x: 0.43042474464314695d, y: 0.702494319312634d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664473756351981d, y: 0.4137541652692851d), new NpgsqlTypes.NpgsqlPoint(x: 0.22514203609726946d, y: 0.8280686265653256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407593581399844d, y: 0.8502274395363266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7108889304550228d, y: 0.32676073712392995d), new NpgsqlTypes.NpgsqlPoint(x: 0.2615239447439628d, y: 0.10705013884633485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7834778336108927d, y: 0.5649797422747875d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5738047222192837d, y: 0.3693637051154416d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172480101010237d, y: 0.28899984539897405d), new NpgsqlTypes.NpgsqlPoint(x: 0.80290643642376d, y: 0.11438077876262498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8001823951100987d, y: 0.42907265204137734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195163748369241d, y: 0.2983266384107417d), new NpgsqlTypes.NpgsqlPoint(x: 0.11057279947251586d, y: 0.38304497555917283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39489325912359363d, y: 0.3861893724763884d), new NpgsqlTypes.NpgsqlPoint(x: 0.035892460244085655d, y: 0.10319783810524896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624974084307767d, y: 0.7823632803007239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3086752961284792d, y: 0.7115078525799721d), new NpgsqlTypes.NpgsqlPoint(x: 0.3449807764440894d, y: 0.26149424596293336d), new NpgsqlTypes.NpgsqlPoint(x: 0.858529165580077d, y: 0.8319271626707474d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14379564019423519d, y: 0.3480788482097734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5816293725900079d, y: 0.11725975225923224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6778089731935549d, y: 0.7716923711749097d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.625180374895058d, y: 0.7048249565989471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766038131728017d, y: 0.6116861457593665d), new NpgsqlTypes.NpgsqlPoint(x: 0.08337568222930547d, y: 0.24189192811827787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.760404497990057d, y: 0.19637537807882188d), new NpgsqlTypes.NpgsqlPoint(x: 0.07183783978759428d, y: 0.920646124892427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480993192979025d, y: 0.4673695938499043d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47025949621433505d, y: 0.09952584873347903d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747761357394146d, y: 0.34086198066271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875771622170437d, y: 0.8350654482970586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5923314692055566d, y: 0.10615497348807934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326896452780397d, y: 0.7069992557103915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062895360846415d, y: 0.049012505677012985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4816928505834508d, y: 0.26624869726165257d), new NpgsqlTypes.NpgsqlPoint(x: 0.1954808578000885d, y: 0.4143941188436603d), new NpgsqlTypes.NpgsqlPoint(x: 0.295378279340374d, y: 0.24870562666270446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906550225615785d, y: 0.13268819713111202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561527787167598d, y: 0.05391876941083029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873569603986429d, y: 0.18295321272030562d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2607452637817923d, y: 0.765976476123534d), new NpgsqlTypes.NpgsqlPoint(x: 0.04666529306220801d, y: 0.31223120864176634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9090453564296974d, y: 0.032474763160609155d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879413466570883d, y: 0.9641068392031387d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372906968823453d, y: 0.001052004299081144d), new NpgsqlTypes.NpgsqlPoint(x: 0.739824024564934d, y: 0.4185453773040999d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17631927589733865d, y: 0.9038985493100692d), new NpgsqlTypes.NpgsqlPoint(x: 0.16796921395510678d, y: 0.9149678761932118d), new NpgsqlTypes.NpgsqlPoint(x: 0.4359110725463555d, y: 0.8909784758339373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2726313103120742d, y: 0.1309254915397916d), new NpgsqlTypes.NpgsqlPoint(x: 0.022353462263537294d, y: 0.24158002878312368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710313378753617d, y: 0.19236841281186245d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8222632391918657d, y: 0.1585945094598814d), new NpgsqlTypes.NpgsqlPoint(x: 0.05130362112471687d, y: 0.27739357138737775d), new NpgsqlTypes.NpgsqlPoint(x: 0.1655425452493816d, y: 0.5374380624905958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11888299754358422d, y: 0.396495114000712d), new NpgsqlTypes.NpgsqlPoint(x: 0.1477388820988078d, y: 0.8060327211460032d), new NpgsqlTypes.NpgsqlPoint(x: 0.09432375933039139d, y: 0.154309869971329d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4452889631305944d, y: 0.5393151969528927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7501973621196958d, y: 0.750530406981709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379607356307623d, y: 0.9197127738989879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37857115887551984d, y: 0.06588920029453194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8536170365103627d, y: 0.2793502590326561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661687182208027d, y: 0.9280220076939091d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3460226613348536d, y: 0.9683848185851531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405721297892232d, y: 0.3842505231773221d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281255815448916d, y: 0.13574748655440594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40579474288500184d, y: 0.6013970528539128d), new NpgsqlTypes.NpgsqlPoint(x: 0.570973384466188d, y: 0.9304708819783369d), new NpgsqlTypes.NpgsqlPoint(x: 0.1762411930664084d, y: 0.5288745534490432d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27868168150573736d, y: 0.6960994240951177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8146277740141933d, y: 0.8636402781628126d), new NpgsqlTypes.NpgsqlPoint(x: 0.17209105440390704d, y: 0.2104858820370885d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7240421164210252d, y: 0.31175669260371897d), new NpgsqlTypes.NpgsqlPoint(x: 0.4860218573136298d, y: 0.3998106943529056d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797744428198894d, y: 0.7798213887470747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10603097555761698d, y: 0.5074709627604214d), new NpgsqlTypes.NpgsqlPoint(x: 0.048714589494355365d, y: 0.9847685313967204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493985555077374d, y: 0.7746535707154596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9060432134637685d, y: 0.41699293443455576d), new NpgsqlTypes.NpgsqlPoint(x: 0.10643002537308388d, y: 0.5775350835560071d), new NpgsqlTypes.NpgsqlPoint(x: 0.16192785798396436d, y: 0.6487819414526653d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.708350567497143d, y: 0.5257218027626787d), new NpgsqlTypes.NpgsqlPoint(x: 0.49857478737414096d, y: 0.48150484771867286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9112772141021162d, y: 0.6076182158532334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22028104682289384d, y: 0.5256703376905928d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437878399549636d, y: 0.8598621253566678d), new NpgsqlTypes.NpgsqlPoint(x: 0.2753661068896819d, y: 0.6616438806195408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4792020084426938d, y: 0.941010848792791d), new NpgsqlTypes.NpgsqlPoint(x: 0.2629928702167227d, y: 0.182767620476036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9482219605828702d, y: 0.021914988843359184d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5719128564955126d, y: 0.7542463558499554d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848747073824144d, y: 0.07444580651027799d), new NpgsqlTypes.NpgsqlPoint(x: 0.35418491297393573d, y: 0.3419087791799389d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6847036494240779d, y: 0.8153485460162728d), new NpgsqlTypes.NpgsqlPoint(x: 0.967861887700181d, y: 0.5656946756440581d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271122722427213d, y: 0.166764382185003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7323483131031447d, y: 0.45382460975087213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851986385294418d, y: 0.23464836654637167d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898977423481316d, y: 0.44425871686086704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6507370095958761d, y: 0.9909755688150236d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127723134754947d, y: 0.6544754777400656d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090178955683931d, y: 0.6769067605260655d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2724122761656147d, y: 0.3566245488522827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198263133751102d, y: 0.5235913939186007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8848689812321938d, y: 0.7406151570552096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31268224011566526d, y: 0.6247287139034446d), new NpgsqlTypes.NpgsqlPoint(x: 0.3027240055649254d, y: 0.878027342681508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992555446435294d, y: 0.08828617800869154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4965740106219223d, y: 0.8165928962930129d), new NpgsqlTypes.NpgsqlPoint(x: 0.42914475183513756d, y: 0.0952479682844728d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373807089770173d, y: 0.6252126027545111d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9033477196230039d, y: 0.9763572788158399d), new NpgsqlTypes.NpgsqlPoint(x: 0.7125357800596142d, y: 0.6110071836729412d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182643780627382d, y: 0.41884314316160753d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33411348555461884d, y: 0.5858573784402976d), new NpgsqlTypes.NpgsqlPoint(x: 0.1222052134044761d, y: 0.7100369105185155d), new NpgsqlTypes.NpgsqlPoint(x: 0.23897061313776913d, y: 0.6878029434340573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9356197363634432d, y: 0.3032065556885911d), new NpgsqlTypes.NpgsqlPoint(x: 0.3007247127183893d, y: 0.6425256150262526d), new NpgsqlTypes.NpgsqlPoint(x: 0.28280657094460837d, y: 0.7350333654466662d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048470560939010365d, y: 0.9322963520327723d), new NpgsqlTypes.NpgsqlPoint(x: 0.532022959011428d, y: 0.8104879582911402d), new NpgsqlTypes.NpgsqlPoint(x: 0.05642839116123699d, y: 0.9110336066344196d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13613856327776575d, y: 0.11616485183601222d), new NpgsqlTypes.NpgsqlPoint(x: 0.44129768654346335d, y: 0.48350777563759795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557981250251746d, y: 0.7968453694794537d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2672952521977968d, y: 0.7069170968709498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8038870922541993d, y: 0.695998994881164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9900456057355977d, y: 0.7342899794936653d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48419098767688074d, y: 0.06222935888662562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5965909195026272d, y: 0.7418062233871752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039903506615665d, y: 0.6011767725081026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1766353960789765d, y: 0.630344708584447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334097692531389d, y: 0.7141403139247242d), new NpgsqlTypes.NpgsqlPoint(x: 0.778541222167618d, y: 0.5950838369082098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9724148776205546d, y: 0.09877844233438737d), new NpgsqlTypes.NpgsqlPoint(x: 0.33936739851819175d, y: 0.09698752917954079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592078333146365d, y: 0.3844738291963421d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8253030301677234d, y: 0.29320274535220336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348822619912886d, y: 0.5003558790040399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703251662576546d, y: 0.09549362029476349d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3627329916072023d, y: 0.0760540190738902d), new NpgsqlTypes.NpgsqlPoint(x: 0.2769805586024927d, y: 0.31437873905282576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7531992172489782d, y: 0.8514303618975066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769254975598776d, y: 0.9419951107415597d), new NpgsqlTypes.NpgsqlPoint(x: 0.2475520767421353d, y: 0.8385480512364573d), new NpgsqlTypes.NpgsqlPoint(x: 0.897039802769359d, y: 0.6371621882060429d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5559077418700569d, y: 0.34296935695518704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618779787491336d, y: 0.40935112505893456d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894739652630396d, y: 0.35952331096173495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6741497340252377d, y: 0.2917014253584226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688225981240776d, y: 0.7610626280242438d), new NpgsqlTypes.NpgsqlPoint(x: 0.28768971531832477d, y: 0.36842287114175554d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8392484817583256d, y: 0.32577320926094244d), new NpgsqlTypes.NpgsqlPoint(x: 0.34490250478285034d, y: 0.048921514614719164d), new NpgsqlTypes.NpgsqlPoint(x: 0.1380895050156432d, y: 0.5827262863883252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712100229506603d, y: 0.3928183694844286d), new NpgsqlTypes.NpgsqlPoint(x: 0.984769074424603d, y: 0.547965579752903d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897741600439065d, y: 0.40888239289022676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.955463198676399d, y: 0.44988563339271415d), new NpgsqlTypes.NpgsqlPoint(x: 0.62353153606605d, y: 0.8403554970566781d), new NpgsqlTypes.NpgsqlPoint(x: 0.651176885676408d, y: 0.8260144932862521d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168353623684449d, y: 0.6807997608484638d), new NpgsqlTypes.NpgsqlPoint(x: 0.43802724311616015d, y: 0.34246048219702674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7474243510863194d, y: 0.40437699072691724d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35502717711623044d, y: 0.23180140857297848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325224114611905d, y: 0.903519982131738d), new NpgsqlTypes.NpgsqlPoint(x: 0.05236097186328903d, y: 0.6533629908534928d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7766684784514298d, y: 0.5612730707905683d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260505070817914d, y: 0.4646955542439195d), new NpgsqlTypes.NpgsqlPoint(x: 0.3831920762273061d, y: 0.9364427119935512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537695372841834d, y: 0.8772035336163967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6618270012111455d, y: 0.9803952672152512d), new NpgsqlTypes.NpgsqlPoint(x: 0.48579338436772224d, y: 0.40942255025849084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21433349435071514d, y: 0.4663715600128616d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052636903099159d, y: 0.6764153206503418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8834616675115495d, y: 0.5289236352215464d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40410327900875975d, y: 0.24910201584602154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7950747372384857d, y: 0.20135457764554032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7338913839637069d, y: 0.4888832868235562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42050606398293344d, y: 0.42884823058259014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9512337594547753d, y: 0.47776229235325973d), new NpgsqlTypes.NpgsqlPoint(x: 0.7266726844670106d, y: 0.48484585766762145d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39694232899082404d, y: 0.04729646305957336d), new NpgsqlTypes.NpgsqlPoint(x: 0.35573752850941565d, y: 0.1127108766021816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7546549396987876d, y: 0.6071424589782956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2670267276816233d, y: 0.789386785779539d), new NpgsqlTypes.NpgsqlPoint(x: 0.16518089859780305d, y: 0.34709736983071826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644596813348345d, y: 0.5942202034751616d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15457686336319054d, y: 0.935955005517383d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070751894111453d, y: 0.4167901576332498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277341543045676d, y: 0.02242626759693145d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2314711145296574d, y: 0.4470875427648804d), new NpgsqlTypes.NpgsqlPoint(x: 0.17966273580945735d, y: 0.9668134617389487d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750796380023195d, y: 0.6659335375731443d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2413869885922597d, y: 0.15562228685504287d), new NpgsqlTypes.NpgsqlPoint(x: 0.42015174374378683d, y: 0.8455540611449816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844983083876353d, y: 0.5107624583980548d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15217519188420203d, y: 0.5515006122368038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313263800247705d, y: 0.49898805842817306d), new NpgsqlTypes.NpgsqlPoint(x: 0.20438199858017148d, y: 0.02361264065974389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.376053989314316d, y: 0.3508123189648015d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068107350457682d, y: 0.8583843527528673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451039887136905d, y: 0.7815355755297455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6032408184247415d, y: 0.8602040731547052d), new NpgsqlTypes.NpgsqlPoint(x: 0.1419878125952847d, y: 0.8013445046632295d), new NpgsqlTypes.NpgsqlPoint(x: 0.2403975487843586d, y: 0.8263248362443617d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6453804896709079d, y: 0.5300331704001434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8912312360707001d, y: 0.8128168192857548d), new NpgsqlTypes.NpgsqlPoint(x: 0.050285005685116735d, y: 0.36761802181936787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2739224827468839d, y: 0.812536191981838d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693769183069125d, y: 0.5068072188078913d), new NpgsqlTypes.NpgsqlPoint(x: 0.2673447074229366d, y: 0.8697705134247946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8394991402493376d, y: 0.6973318012061339d), new NpgsqlTypes.NpgsqlPoint(x: 0.628440413870732d, y: 0.5659583211902893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597350673015225d, y: 0.8937748580126096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8279871847987127d, y: 0.31633879284068833d), new NpgsqlTypes.NpgsqlPoint(x: 0.13120664022212292d, y: 0.8551284397788058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6430864289144426d, y: 0.9393157932162608d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11748050219171335d, y: 0.4532656429038493d), new NpgsqlTypes.NpgsqlPoint(x: 0.677587298680032d, y: 0.40967469733044126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988787024538223d, y: 0.4545363991714242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31189362862124315d, y: 0.9968544655038193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198123358047748d, y: 0.15525752493359657d), new NpgsqlTypes.NpgsqlPoint(x: 0.05271920171689892d, y: 0.7165158275126636d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6578171871417761d, y: 0.2847537315946427d), new NpgsqlTypes.NpgsqlPoint(x: 0.0821908519256267d, y: 0.7186172097599611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7226056435581051d, y: 0.1726520002658548d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9131696487371347d, y: 0.8745160250146186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351385912702258d, y: 0.48529396680253345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5918036714246081d, y: 0.19285551228371112d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26384284079792375d, y: 0.20914619650661892d), new NpgsqlTypes.NpgsqlPoint(x: 0.003670693696413263d, y: 0.7391672924715416d), new NpgsqlTypes.NpgsqlPoint(x: 0.16244285491510868d, y: 0.4193929551735919d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35751079787882956d, y: 0.6317149861677132d), new NpgsqlTypes.NpgsqlPoint(x: 0.47427582321936723d, y: 0.9383610378242947d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880807320340284d, y: 0.3830684118492571d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25538871509478334d, y: 0.6615680797792985d), new NpgsqlTypes.NpgsqlPoint(x: 0.11721550304032202d, y: 0.197678514394813d), new NpgsqlTypes.NpgsqlPoint(x: 0.882728805897706d, y: 0.4224353046545517d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722497387733283d, y: 0.6951985067046682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5858839277325065d, y: 0.8583694597295224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319584054177146d, y: 0.3525335781126996d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3673308396094368d, y: 0.7798989741031934d), new NpgsqlTypes.NpgsqlPoint(x: 0.3562093895605838d, y: 0.3708905703415869d), new NpgsqlTypes.NpgsqlPoint(x: 0.06174693223392458d, y: 0.44569848485932595d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.953371787527057d, y: 0.7246273421792285d), new NpgsqlTypes.NpgsqlPoint(x: 0.05092042506377514d, y: 0.0743916709125434d), new NpgsqlTypes.NpgsqlPoint(x: 0.229403907964025d, y: 0.3786093176568621d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2505269483717567d, y: 0.1956419482765418d), new NpgsqlTypes.NpgsqlPoint(x: 0.44762102622761923d, y: 0.06995438986812363d), new NpgsqlTypes.NpgsqlPoint(x: 0.14714334195564183d, y: 0.43323700800399345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5846420678551414d, y: 0.41818318517795783d), new NpgsqlTypes.NpgsqlPoint(x: 0.8308664869705016d, y: 0.4144108975310168d), new NpgsqlTypes.NpgsqlPoint(x: 0.6027440150101604d, y: 0.7048135409517757d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7690924451777932d, y: 0.0035057676210498157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7400492622327373d, y: 0.5587976922089721d), new NpgsqlTypes.NpgsqlPoint(x: 0.4960414700497032d, y: 0.05159950044517947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6082659372755704d, y: 0.935861461049576d), new NpgsqlTypes.NpgsqlPoint(x: 0.954566614248322d, y: 0.6502863273061752d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077877849554117d, y: 0.7267434065441943d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6420672982913304d, y: 0.5814759344287279d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170716495849317d, y: 0.054172562867138674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8685816357072256d, y: 0.8598378985736456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6830733740868558d, y: 0.38738532275461013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053277947907536d, y: 0.700524252503185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4893552822037651d, y: 0.020200609885505316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28575540556554746d, y: 0.01769308984544604d), new NpgsqlTypes.NpgsqlPoint(x: 0.13712559528721768d, y: 0.2628155655960883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3291441453901116d, y: 0.5979506237754139d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07451957462749004d, y: 0.8451068943413048d), new NpgsqlTypes.NpgsqlPoint(x: 0.1486860845769732d, y: 0.012140790752620756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875800292822821d, y: 0.9431772932960578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3693508620325566d, y: 0.3471273750763586d), new NpgsqlTypes.NpgsqlPoint(x: 0.769147211649933d, y: 0.7861890735139123d), new NpgsqlTypes.NpgsqlPoint(x: 0.660355337322394d, y: 0.29825689347061246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4457366244482355d, y: 0.05415654746976639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5048815838218214d, y: 0.3042660284169211d), new NpgsqlTypes.NpgsqlPoint(x: 0.14070274268839422d, y: 0.40462999181429204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07692370711955465d, y: 0.5157314155568039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336693576312145d, y: 0.6149573941408321d), new NpgsqlTypes.NpgsqlPoint(x: 0.777065632118626d, y: 0.2993598256010549d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4039537466391365d, y: 0.9622530502151259d), new NpgsqlTypes.NpgsqlPoint(x: 0.14125661963694613d, y: 0.7900031906388005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9094384207424402d, y: 0.8251855063294988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6914258251319305d, y: 0.6470038409049848d), new NpgsqlTypes.NpgsqlPoint(x: 0.33749215147780753d, y: 0.5355860617222905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8350053814465924d, y: 0.46436750934777005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9398907079313041d, y: 0.22248785230576418d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844662638765417d, y: 0.893496668044828d), new NpgsqlTypes.NpgsqlPoint(x: 0.057565732092362154d, y: 0.006732763664520802d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979548867626415d, y: 0.44125702996274696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098782887953695d, y: 0.06172632214656815d), new NpgsqlTypes.NpgsqlPoint(x: 0.4012432876881957d, y: 0.21327593182881333d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5074862594786747d, y: 0.5330110242349757d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543072525289384d, y: 0.19189912888999783d), new NpgsqlTypes.NpgsqlPoint(x: 0.27842453707410864d, y: 0.7234884999584426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8772970422521668d, y: 0.18902384766653957d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402380967902749d, y: 0.5530572499519641d), new NpgsqlTypes.NpgsqlPoint(x: 0.2170077643441949d, y: 0.45666335034020866d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3503655065015817d, y: 0.7568253131059463d), new NpgsqlTypes.NpgsqlPoint(x: 0.4762780258162135d, y: 0.826776378773674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469115918472119d, y: 0.2189704662433396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19609468691918497d, y: 0.6646477775289579d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230644284061818d, y: 0.13215956196308842d), new NpgsqlTypes.NpgsqlPoint(x: 0.6680840077451308d, y: 0.30773644546648404d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7064107292098951d, y: 0.4022971422123848d), new NpgsqlTypes.NpgsqlPoint(x: 0.13950627904356583d, y: 0.9157081015458767d), new NpgsqlTypes.NpgsqlPoint(x: 0.38482407652251405d, y: 0.5491819465028458d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2933029274920783d, y: 0.43315861859228166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911520546846738d, y: 0.6059388286461126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9370813122070556d, y: 0.28085435616042953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6615768319560223d, y: 0.7226886688894076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408042348957519d, y: 0.7536377156392059d), new NpgsqlTypes.NpgsqlPoint(x: 0.8070682194752369d, y: 0.1901186331607787d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038771030383369376d, y: 0.765166485143472d), new NpgsqlTypes.NpgsqlPoint(x: 0.42333077625968785d, y: 0.3628692302721167d), new NpgsqlTypes.NpgsqlPoint(x: 0.10397959387185518d, y: 0.8786383771765087d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8379190997205928d, y: 0.06724931824031499d), new NpgsqlTypes.NpgsqlPoint(x: 0.4087218560391672d, y: 0.3861474618776207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019801808111809d, y: 0.2737217592967299d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5521146085906473d, y: 0.5690697205406724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3055992526934661d, y: 0.6918721475086067d), new NpgsqlTypes.NpgsqlPoint(x: 0.03290029019059415d, y: 0.1452027281851389d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8040807900969749d, y: 0.22161948197260195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394608485830567d, y: 0.2935735570444651d), new NpgsqlTypes.NpgsqlPoint(x: 0.3432473479837955d, y: 0.4578341977056426d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1688841872174861d, y: 0.4373648226829313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992858383557887d, y: 0.3002335597743223d), new NpgsqlTypes.NpgsqlPoint(x: 0.09821640207831395d, y: 0.7907514337531627d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6745909849721112d, y: 0.9600764941777777d), new NpgsqlTypes.NpgsqlPoint(x: 0.546463098421724d, y: 0.9584279093881686d), new NpgsqlTypes.NpgsqlPoint(x: 0.06389967419667364d, y: 0.17268267126129855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8279757108352238d, y: 0.6159521001888006d), new NpgsqlTypes.NpgsqlPoint(x: 0.78680337296074d, y: 0.4381144739412758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437973385524522d, y: 0.20236670800093925d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48751302009957587d, y: 0.27878673596643455d), new NpgsqlTypes.NpgsqlPoint(x: 0.3477844584647205d, y: 0.9232699597597945d), new NpgsqlTypes.NpgsqlPoint(x: 0.3834619176123838d, y: 0.5026269499851347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8220364918327187d, y: 0.929091038001028d), new NpgsqlTypes.NpgsqlPoint(x: 0.1802263106243639d, y: 0.8843018504556878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066535350803097d, y: 0.5314461492196016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7994905148942575d, y: 0.45447917982378494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8044018944207337d, y: 0.6190807412074999d), new NpgsqlTypes.NpgsqlPoint(x: 0.9832078506193399d, y: 0.613101043322728d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6123410751178521d, y: 0.844871266703617d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186696736645501d, y: 0.43490453108029536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4741848097142377d, y: 0.3998384576285934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04498439136327825d, y: 0.16798801772151228d), new NpgsqlTypes.NpgsqlPoint(x: 0.27674452042031294d, y: 0.18955694529183775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368179981858656d, y: 0.36136104279452763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8031637697197243d, y: 0.04070871504021778d), new NpgsqlTypes.NpgsqlPoint(x: 0.12971769704107483d, y: 0.8921370894267525d), new NpgsqlTypes.NpgsqlPoint(x: 0.46915577302412736d, y: 0.37570630896562973d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8679000471971365d, y: 0.3752214274868446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5705726854739201d, y: 0.2047828363788664d), new NpgsqlTypes.NpgsqlPoint(x: 0.07259914304169723d, y: 0.1463834756502972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039395231169345d, y: 0.8073423692189922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304494032727687d, y: 0.26060552145878446d), new NpgsqlTypes.NpgsqlPoint(x: 0.43377640816735163d, y: 0.5068410761445274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3606950727288235d, y: 0.24077589779336772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975380756864774d, y: 0.7103076145700395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066052957427249d, y: 0.7326998197442903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3092141815355165d, y: 0.29068139967119866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4829840626693829d, y: 0.7796213339409968d), new NpgsqlTypes.NpgsqlPoint(x: 0.2275556902119813d, y: 0.8457382159825745d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805754229230944d, y: 0.6932245365526816d), new NpgsqlTypes.NpgsqlPoint(x: 0.13339608553482163d, y: 0.8536343561439109d), new NpgsqlTypes.NpgsqlPoint(x: 0.04506508324986913d, y: 0.4287928792547032d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5494987233768156d, y: 0.8794494360869182d), new NpgsqlTypes.NpgsqlPoint(x: 0.36722837501037164d, y: 0.6817470658576182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2481774715503643d, y: 0.5808376286760758d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9091984038872732d, y: 0.08513256688815485d), new NpgsqlTypes.NpgsqlPoint(x: 0.11596149142518186d, y: 0.2602075017188621d), new NpgsqlTypes.NpgsqlPoint(x: 0.4706235881203059d, y: 0.9154943583164361d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7049084580139481d, y: 0.28758522151243127d), new NpgsqlTypes.NpgsqlPoint(x: 0.09738619974202922d, y: 0.8347917758221317d), new NpgsqlTypes.NpgsqlPoint(x: 0.41044146031787676d, y: 0.11492497623267484d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9959500392395331d, y: 0.6192061077702927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159247067272104d, y: 0.7797049912020492d), new NpgsqlTypes.NpgsqlPoint(x: 0.05457843588080791d, y: 0.8362904939128784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24169947161701866d, y: 0.463839694639666d), new NpgsqlTypes.NpgsqlPoint(x: 0.22911702617296448d, y: 0.26567596047867725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664020431975215d, y: 0.5197437930153648d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3588522707815557d, y: 0.7854673142338588d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807551162488995d, y: 0.9487599507665644d), new NpgsqlTypes.NpgsqlPoint(x: 0.48232464392235475d, y: 0.37614638635614395d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011043966819065498d, y: 0.8330344495709182d), new NpgsqlTypes.NpgsqlPoint(x: 0.21603003586641878d, y: 0.6814900487969764d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873115125579276d, y: 0.20384759657959628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5398444804740714d, y: 0.4917555192685392d), new NpgsqlTypes.NpgsqlPoint(x: 0.30074057926941145d, y: 0.9592548878590615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8106112523694281d, y: 0.35941525132344454d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9256417244215859d, y: 0.15953218947210457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488419792657168d, y: 0.8116983403636193d), new NpgsqlTypes.NpgsqlPoint(x: 0.4472714487315963d, y: 0.45499673823037357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8613321040576034d, y: 0.895971638550119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9438696671373913d, y: 0.7276473423452815d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708179727425102d, y: 0.15367677209891895d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5958973938219817d, y: 0.34236101806353125d), new NpgsqlTypes.NpgsqlPoint(x: 0.688792634705578d, y: 0.6663584031007695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714494833113995d, y: 0.6459659367985723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08449787344078663d, y: 0.5201215348469186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683195487271047d, y: 0.8844820568451929d), new NpgsqlTypes.NpgsqlPoint(x: 0.4219848480448549d, y: 0.4258026191359323d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24612996902522966d, y: 0.16316493349320815d), new NpgsqlTypes.NpgsqlPoint(x: 0.13761850245986507d, y: 0.3745583591071988d), new NpgsqlTypes.NpgsqlPoint(x: 0.250440319491237d, y: 0.2300105182181874d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4102818657183519d, y: 0.8941828875416279d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152400208116016d, y: 0.7940886855084195d), new NpgsqlTypes.NpgsqlPoint(x: 0.46238924685115546d, y: 0.24810507715524233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03687127658506095d, y: 0.9778728411942955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6137346721201586d, y: 0.5624960138540943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5950047020889659d, y: 0.04938802617578941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9464323780922992d, y: 0.8919490988733672d), new NpgsqlTypes.NpgsqlPoint(x: 0.4505338204093724d, y: 0.03580833739400402d), new NpgsqlTypes.NpgsqlPoint(x: 0.09398090613351551d, y: 0.29993993287353005d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29880098624385343d, y: 0.10586048732130582d), new NpgsqlTypes.NpgsqlPoint(x: 0.42917547268122125d, y: 0.6249129637783128d), new NpgsqlTypes.NpgsqlPoint(x: 0.3550433457208263d, y: 0.5872421046508999d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04981459857715531d, y: 0.5084425419960409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280082055010036d, y: 0.4973797164979079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7645822632041719d, y: 0.9128382262362709d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10979171433845614d, y: 0.7919034948938413d), new NpgsqlTypes.NpgsqlPoint(x: 0.2235638688450231d, y: 0.29216786492783564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005964839315822d, y: 0.7146864326094248d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48603115958164d, y: 0.8408938388619561d), new NpgsqlTypes.NpgsqlPoint(x: 0.20587577552514236d, y: 0.7391859909403056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7105703691608416d, y: 0.5699733516387845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5058122097965285d, y: 0.344352799353558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5579929255877043d, y: 0.6121986264674569d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690603009269529d, y: 0.06937637078236081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20043698713489422d, y: 0.24734787464148222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6733978073951356d, y: 0.2086419364913833d), new NpgsqlTypes.NpgsqlPoint(x: 0.32374489466037026d, y: 0.5217515499155913d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6049967515125982d, y: 0.273120104452784d), new NpgsqlTypes.NpgsqlPoint(x: 0.16383492713796743d, y: 0.18236833320950685d), new NpgsqlTypes.NpgsqlPoint(x: 0.200954637862248d, y: 0.14108924349543328d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14818405172644566d, y: 0.5141580707974496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4846531262373156d, y: 0.5284753370726986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4595025196557112d, y: 0.36112350856478403d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.263287887506065d, y: 0.08508149817942856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368011892189583d, y: 0.07558317103500989d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584614906546981d, y: 0.0868263121458227d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11288764328086986d, y: 0.8709297244322766d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888821751823513d, y: 0.18904726869192223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263505237140818d, y: 0.3197741099321786d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3279043567062979d, y: 0.18642835976800487d), new NpgsqlTypes.NpgsqlPoint(x: 0.10901865776361819d, y: 0.792927053554167d), new NpgsqlTypes.NpgsqlPoint(x: 0.40008753489103344d, y: 0.2980071671066342d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2503030015072598d, y: 0.6901090569262552d), new NpgsqlTypes.NpgsqlPoint(x: 0.08248128977777625d, y: 0.4263734164135845d), new NpgsqlTypes.NpgsqlPoint(x: 0.32847892646024035d, y: 0.37929631383393436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12929683031571382d, y: 0.2033168017102609d), new NpgsqlTypes.NpgsqlPoint(x: 0.3382680988193073d, y: 0.7531665613099019d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686864584811818d, y: 0.6605300926480494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8654154588696196d, y: 0.6785924448227213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231976090299729d, y: 0.10935164628530603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374051727415162d, y: 0.2677914385380228d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.021951247557620568d, y: 0.5146628037809674d), new NpgsqlTypes.NpgsqlPoint(x: 0.7960101781078549d, y: 0.47081557223974757d), new NpgsqlTypes.NpgsqlPoint(x: 0.4799091806649286d, y: 0.44900636285789697d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5681081923598347d, y: 0.4435937263056934d), new NpgsqlTypes.NpgsqlPoint(x: 0.18517352366334605d, y: 0.48318104500072045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151464358943011d, y: 0.11463568674138813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09024975320866191d, y: 0.478224778963401d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464027927889089d, y: 0.4081813823703364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2733763087011354d, y: 0.36728719059120496d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36357242867814765d, y: 0.21636690889901478d), new NpgsqlTypes.NpgsqlPoint(x: 0.23993855235632033d, y: 0.45139427765146123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573165641324481d, y: 0.6911680222683616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6729262077749935d, y: 0.8086552459037898d), new NpgsqlTypes.NpgsqlPoint(x: 0.9119107082896355d, y: 0.39594855227239234d), new NpgsqlTypes.NpgsqlPoint(x: 0.43558085659362666d, y: 0.11755640980390814d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2694845644899161d, y: 0.899906141948292d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176158158602495d, y: 0.30395835148610817d), new NpgsqlTypes.NpgsqlPoint(x: 0.16653488512025705d, y: 0.26524532788069577d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39798812536965733d, y: 0.6047334550967276d), new NpgsqlTypes.NpgsqlPoint(x: 0.41929010345252193d, y: 0.13150396377101836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237304275690512d, y: 0.38039953743936195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7803568703453551d, y: 0.7745604107344382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7866899889682258d, y: 0.8059530015111809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440388213839967d, y: 0.4903909055464041d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27389794855002314d, y: 0.19244603997249543d), new NpgsqlTypes.NpgsqlPoint(x: 0.3098774350915299d, y: 0.778820660156057d), new NpgsqlTypes.NpgsqlPoint(x: 0.029650654942242394d, y: 0.9609952087847631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11487734435031416d, y: 0.718146550874478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574341249610818d, y: 0.2089758443011559d), new NpgsqlTypes.NpgsqlPoint(x: 0.22382097052772976d, y: 0.5395976042760415d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 178,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49723950286228935d, y: 0.15319148814180772d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890561263055113d, y: 0.4716598723459624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910587082813392d, y: 0.5967672245937958d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3973286219484955d, y: 0.5317817917085582d), new NpgsqlTypes.NpgsqlPoint(x: 0.20942829070360802d, y: 0.5114625332985078d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200844734059462d, y: 0.3886798467768132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.622194145516003d, y: 0.42448015920723203d), new NpgsqlTypes.NpgsqlPoint(x: 0.042378320123888646d, y: 0.00729376835283202d), new NpgsqlTypes.NpgsqlPoint(x: 0.227843984056741d, y: 0.0938138117195837d)),
},
    ModelInner = new NpgsqlPathpathMArrayD11MI
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15734905037437197d, y: 0.10863377062692414d), new NpgsqlTypes.NpgsqlPoint(x: 0.45012281155498135d, y: 0.6746216666641235d), new NpgsqlTypes.NpgsqlPoint(x: 0.44967311639613505d, y: 0.8198483775984657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1550812827690523d, y: 0.9652229394195219d), new NpgsqlTypes.NpgsqlPoint(x: 0.008852706280422007d, y: 0.9021320135561236d), new NpgsqlTypes.NpgsqlPoint(x: 0.783851703161908d, y: 0.45138318054782867d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7206399756754013d, y: 0.9893840747787473d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849972494880838d, y: 0.29706702389266615d), new NpgsqlTypes.NpgsqlPoint(x: 0.15833747035673507d, y: 0.03262539073635795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2590840999826802d, y: 0.37378783350823575d), new NpgsqlTypes.NpgsqlPoint(x: 0.7018735334195589d, y: 0.9278756704619806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5095656289723931d, y: 0.6399198917995416d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36919596863149495d, y: 0.46917027092169916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020023855863659d, y: 0.39742227461167223d), new NpgsqlTypes.NpgsqlPoint(x: 0.1844351421230146d, y: 0.1913407403891807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5674837734179152d, y: 0.17694347959395818d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621504975740668d, y: 0.16399904939573595d), new NpgsqlTypes.NpgsqlPoint(x: 0.06691872330569315d, y: 0.8993260691164956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0022807454545423766d, y: 0.16268973595702718d), new NpgsqlTypes.NpgsqlPoint(x: 0.18514982060513585d, y: 0.3322964462125979d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110974430104471d, y: 0.04480275433508396d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3824667054959905d, y: 0.6009925840731022d), new NpgsqlTypes.NpgsqlPoint(x: 0.33364947807641787d, y: 0.11721700105197097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197237479294887d, y: 0.3856877866799633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19065747937819588d, y: 0.5702679838976545d), new NpgsqlTypes.NpgsqlPoint(x: 0.15978673516493336d, y: 0.3417713315876092d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417284034161013d, y: 0.6199855202479975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9732196604299874d, y: 0.8407477707685925d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574319400346445d, y: 0.5299078233619172d), new NpgsqlTypes.NpgsqlPoint(x: 0.939864325117645d, y: 0.9080689078941473d)),
},
},
            new NpgsqlPathpathMArrayD1E1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0634790413156533d, y: 0.4956597861301484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141741498093456d, y: 0.9662607049817383d), new NpgsqlTypes.NpgsqlPoint(x: 0.508242798789391d, y: 0.7861805569622241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12845389997107526d, y: 0.7257734510659839d), new NpgsqlTypes.NpgsqlPoint(x: 0.029143758766616013d, y: 0.5748537081595116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009373760360375d, y: 0.36384253697688496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6313500993978778d, y: 0.5301660395855617d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925538528222741d, y: 0.6578166748292686d), new NpgsqlTypes.NpgsqlPoint(x: 0.27232664524706596d, y: 0.9942229212058875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10976157873808157d, y: 0.17000199453620413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026748694451143d, y: 0.24131890887703478d), new NpgsqlTypes.NpgsqlPoint(x: 0.7026581723559423d, y: 0.08739535667202436d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd11mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
INSERT INTO public.npgsqlpathpathmarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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

                changedRows =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)), 
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
                methodParametrName: "npgsqlpathpathmarrayd11mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd11mi_id
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
    npgsqlpathpathmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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

                    nullable =  ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3635137226135483d, y: 0.9414122986881677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438243233127944d, y: 0.58595331323338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072963998292574d, y: 0.8150436209783044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43494316637934416d, y: 0.6448833990850984d), new NpgsqlTypes.NpgsqlPoint(x: 0.42050712017142666d, y: 0.5768913242538485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559832882371098d, y: 0.9300447146959826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6768582670415046d, y: 0.050535359787835854d), new NpgsqlTypes.NpgsqlPoint(x: 0.6369217354281486d, y: 0.4594187114842899d), new NpgsqlTypes.NpgsqlPoint(x: 0.77503152723777d, y: 0.5873131752724362d)),
}));
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

                    nullable = await ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9641025903526066d, y: 0.3349780330848562d), new NpgsqlTypes.NpgsqlPoint(x: 0.10459636805589112d, y: 0.16542565666399733d), new NpgsqlTypes.NpgsqlPoint(x: 0.41656685882333555d, y: 0.7213967790960977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8791750323422466d, y: 0.0794720774271338d), new NpgsqlTypes.NpgsqlPoint(x: 0.36475129708706133d, y: 0.029936650910570073d), new NpgsqlTypes.NpgsqlPoint(x: 0.15366705182637141d, y: 0.13356686370647608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04222094874079296d, y: 0.8353434804127498d), new NpgsqlTypes.NpgsqlPoint(x: 0.38634872816737587d, y: 0.11838389287273188d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402081044504734d, y: 0.35830543421805816d)),
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

                    nullable = await ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmarrayd11mi_id
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
    npgsqlpathpathmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                methodParametrName: "npgsqlpathpathmarrayd11mi_id", 
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
                nullable =  ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44173514016257265d, y: 0.7509332224918722d), new NpgsqlTypes.NpgsqlPoint(x: 0.5015293995957277d, y: 0.44570961756628336d), new NpgsqlTypes.NpgsqlPoint(x: 0.2835241592088744d, y: 0.02906146925449493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5293676992259405d, y: 0.3672764922746907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8176344510030161d, y: 0.10978853287040169d), new NpgsqlTypes.NpgsqlPoint(x: 0.29507434389454135d, y: 0.64695313699088d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7138528745496038d, y: 0.5324428923446487d), new NpgsqlTypes.NpgsqlPoint(x: 0.9839926630087908d, y: 0.5630630752914738d), new NpgsqlTypes.NpgsqlPoint(x: 0.031090605906323066d, y: 0.4483787803705658d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9759561545059093d, y: 0.8818552246584077d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639367339854814d, y: 0.6548867454673845d), new NpgsqlTypes.NpgsqlPoint(x: 0.9157880023425616d, y: 0.6012084593798338d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2195466064122068d, y: 0.8069648117883955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8515452197488106d, y: 0.7491810989936657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4574805020137135d, y: 0.3638078861087223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6936588539983242d, y: 0.26574703302818614d), new NpgsqlTypes.NpgsqlPoint(x: 0.31217340829568885d, y: 0.19284051067271057d), new NpgsqlTypes.NpgsqlPoint(x: 0.43042474464314695d, y: 0.702494319312634d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9664473756351981d, y: 0.4137541652692851d), new NpgsqlTypes.NpgsqlPoint(x: 0.22514203609726946d, y: 0.8280686265653256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407593581399844d, y: 0.8502274395363266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7108889304550228d, y: 0.32676073712392995d), new NpgsqlTypes.NpgsqlPoint(x: 0.2615239447439628d, y: 0.10705013884633485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7834778336108927d, y: 0.5649797422747875d)),
}));
                nullable = await ((INpgsqlPathMArraypathMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47025949621433505d, y: 0.09952584873347903d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747761357394146d, y: 0.34086198066271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875771622170437d, y: 0.8350654482970586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5923314692055566d, y: 0.10615497348807934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326896452780397d, y: 0.7069992557103915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6062895360846415d, y: 0.049012505677012985d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4816928505834508d, y: 0.26624869726165257d), new NpgsqlTypes.NpgsqlPoint(x: 0.1954808578000885d, y: 0.4143941188436603d), new NpgsqlTypes.NpgsqlPoint(x: 0.295378279340374d, y: 0.24870562666270446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.906550225615785d, y: 0.13268819713111202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561527787167598d, y: 0.05391876941083029d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873569603986429d, y: 0.18295321272030562d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M), typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmarrayd11mi mi ON mi.id = m.npgsqlpathpathmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M), typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmarrayd11mi mi ON mi.id = m.npgsqlpathpathmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M), typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 155;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 118;
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmarrayd11mi mi ON mi.id = m.npgsqlpathpathmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M), typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 169, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 169, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 108, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
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
FROM public.npgsqlpathpathmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmarrayd11mi mi ON mi.id = m.npgsqlpathpathmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 108, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 22, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((INpgsqlPathMArraypathMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPathpathMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                NpgsqlPathpathMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
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
FROM public.binary_npgsqlpathpathmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmarrayd11mi mi ON mi.id = m.npgsqlpathpathmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models =  ((INpgsqlPathMArraypathMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA), typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
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
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
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
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA), typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
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
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmarrayd11mi
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
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MI), typeof(NpgsqlPathpathMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models1 = new List<NpgsqlPathpathMArrayD11MI>();
                var models2 = new List<NpgsqlPathpathMArrayD11MI>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD11MI>();
                var models2 = new List<NpgsqlPathpathMArrayD11MI>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA), typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                await ((INpgsqlPathMArraypathMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMArrayD11MIWA>();
                var models2 = new List<NpgsqlPathpathMArrayD11MIWA>();
                ((INpgsqlPathMArraypathMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

