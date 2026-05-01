

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8520645213320824d, y: 0.4720894573518194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987543523963282d, y: 0.08474772957011478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8771971243621697d, y: 0.013868042991966534d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.67819999940806d, y: 0.01393697252289261d), new NpgsqlTypes.NpgsqlPoint(x: 0.24412866393066968d, y: 0.6034875443358988d), new NpgsqlTypes.NpgsqlPoint(x: 0.16927569425439593d, y: 0.13605350863052834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07268023840259485d, y: 0.7649516891750155d), new NpgsqlTypes.NpgsqlPoint(x: 0.17008833497154996d, y: 0.8592910626326975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827101496926734d, y: 0.2305475937212207d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5604942785605141d, y: 0.9649791263651084d), new NpgsqlTypes.NpgsqlPoint(x: 0.3722140008422522d, y: 0.7587099370796042d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919696041344468d, y: 0.5828646031514196d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6972752907001964d, y: 0.37547452210975985d), new NpgsqlTypes.NpgsqlPoint(x: 0.00355064951489914d, y: 0.7143228221974943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9098893557966388d, y: 0.6222142559934682d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7574364622017685d, y: 0.9303335112873589d), new NpgsqlTypes.NpgsqlPoint(x: 0.010641445390016768d, y: 0.5822999480935872d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880132570169822d, y: 0.8876646249287506d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.606222736677279d, y: 0.5560238341517915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9628467433214449d, y: 0.06733136819337959d), new NpgsqlTypes.NpgsqlPoint(x: 0.8067800216236105d, y: 0.17995709436988894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39742621030519687d, y: 0.0971514940062731d), new NpgsqlTypes.NpgsqlPoint(x: 0.35010516029666694d, y: 0.2246846695625343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544917771095086d, y: 0.006451464408683383d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06453591785659007d, y: 0.024314160514408933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813481988130569d, y: 0.4082768035700107d), new NpgsqlTypes.NpgsqlPoint(x: 0.31533826170631496d, y: 0.6264471081449715d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.446415128154777d, y: 0.922142269194504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2690609230846539d, y: 0.9271424110404399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002518374986415d, y: 0.7857623084290241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5345684498722093d, y: 0.4503608346067255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038739097277438d, y: 0.15021570203098966d), new NpgsqlTypes.NpgsqlPoint(x: 0.45822853876573444d, y: 0.9123357360182539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26928159463790435d, y: 0.6307560654977155d), new NpgsqlTypes.NpgsqlPoint(x: 0.1427583008220542d, y: 0.2025264353192776d), new NpgsqlTypes.NpgsqlPoint(x: 0.12812726114910833d, y: 0.7949508302368659d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07745842976991768d, y: 0.8220245441265654d), new NpgsqlTypes.NpgsqlPoint(x: 0.31222334615434655d, y: 0.03362645719287283d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318676806043042d, y: 0.3250100387540452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059821196867009596d, y: 0.8446801487107233d), new NpgsqlTypes.NpgsqlPoint(x: 0.2270420873748228d, y: 0.609911012985523d), new NpgsqlTypes.NpgsqlPoint(x: 0.41695428281145674d, y: 0.6283830021143474d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8698129763593649d, y: 0.42219849113095465d), new NpgsqlTypes.NpgsqlPoint(x: 0.24562637379113728d, y: 0.6030140718141379d), new NpgsqlTypes.NpgsqlPoint(x: 0.32376703532262396d, y: 0.8529614616966228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.529987881447774d, y: 0.5686823758580688d), new NpgsqlTypes.NpgsqlPoint(x: 0.38367473273457453d, y: 0.09290773121435691d), new NpgsqlTypes.NpgsqlPoint(x: 0.012888271200320323d, y: 0.9557961949024049d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2851502707179665d, y: 0.5883405728328028d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016775140581740677d, y: 0.3365721560477086d), new NpgsqlTypes.NpgsqlPoint(x: 0.350978871411991d, y: 0.2967564725082027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5721313997936023d, y: 0.5654421520566963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9354780091305742d, y: 0.9207779169063357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055131202159634d, y: 0.5678981098986777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5208961548531891d, y: 0.6817309008816445d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553638728641d, y: 0.24995561389060938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843479625996448d, y: 0.09240571780795259d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2065915698067643d, y: 0.4711971218313147d), new NpgsqlTypes.NpgsqlPoint(x: 0.13384650788361374d, y: 0.47343226369578106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322586909259855d, y: 0.09806877596224839d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5735366603900575d, y: 0.34823798998006994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6700482693475616d, y: 0.4915815174876018d), new NpgsqlTypes.NpgsqlPoint(x: 0.32826420400940504d, y: 0.4092050669011501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9394140328380448d, y: 0.523316514928854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446539974639601d, y: 0.6783714799701213d), new NpgsqlTypes.NpgsqlPoint(x: 0.11974052705282467d, y: 0.04597913771809259d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24776300159763232d, y: 0.4428182233989544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349243666429771d, y: 0.44636324586920495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178564992831377d, y: 0.5836302199876251d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8356778522844243d, y: 0.11108981144209451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6283852529397173d, y: 0.4046493857162171d), new NpgsqlTypes.NpgsqlPoint(x: 0.18702729231701376d, y: 0.41869274922140476d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30555605561169863d, y: 0.6501585772349201d), new NpgsqlTypes.NpgsqlPoint(x: 0.8051595277061638d, y: 0.6424766733743271d), new NpgsqlTypes.NpgsqlPoint(x: 0.06703733678026502d, y: 0.9647979239495772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4747435902865914d, y: 0.8136256009758394d), new NpgsqlTypes.NpgsqlPoint(x: 0.34990730829610406d, y: 0.5713282236547442d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231981043356838d, y: 0.054742058435869434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6279473679927455d, y: 0.499632036451201d), new NpgsqlTypes.NpgsqlPoint(x: 0.04225522816487193d, y: 0.768311471884411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5362417872322327d, y: 0.9452029098766369d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01864982584136421d, y: 0.9968879109397561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8002661708106491d, y: 0.7211364928478433d), new NpgsqlTypes.NpgsqlPoint(x: 0.0788013010300036d, y: 0.50882850658585d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3882317070074456d, y: 0.8036762488521204d), new NpgsqlTypes.NpgsqlPoint(x: 0.42572297854348606d, y: 0.2953115719063515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584798542967699d, y: 0.48136783248941284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6366245212026668d, y: 0.8310245182556332d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764058134561344d, y: 0.47777908370163213d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722453024571343d, y: 0.5700231168413654d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7647052335720531d, y: 0.5612398529620769d), new NpgsqlTypes.NpgsqlPoint(x: 0.8936603951341866d, y: 0.5684400679223689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6812278637730609d, y: 0.6940650059663868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47172584407875173d, y: 0.6593527932971314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201254242162897d, y: 0.22586041448728522d), new NpgsqlTypes.NpgsqlPoint(x: 0.06445121186825487d, y: 0.5188332972618613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3548283705006683d, y: 0.43699560081134203d), new NpgsqlTypes.NpgsqlPoint(x: 0.0470274197531535d, y: 0.07125559912504731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9873757559222418d, y: 0.2487236461932525d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010315255660444222d, y: 0.25019365233034063d), new NpgsqlTypes.NpgsqlPoint(x: 0.35707628481114906d, y: 0.8879640320880408d), new NpgsqlTypes.NpgsqlPoint(x: 0.24254953591426465d, y: 0.0320047028216075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6358959844182946d, y: 0.573288932655432d), new NpgsqlTypes.NpgsqlPoint(x: 0.2089932585400247d, y: 0.6769653055182685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7616694888380265d, y: 0.5080950105378512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2088898441829622d, y: 0.9784473645276459d), new NpgsqlTypes.NpgsqlPoint(x: 0.810750627855829d, y: 0.24182925884715978d), new NpgsqlTypes.NpgsqlPoint(x: 0.18164680790243637d, y: 0.2457816034467487d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40224411840388774d, y: 0.7825442982363713d), new NpgsqlTypes.NpgsqlPoint(x: 0.927065941683376d, y: 0.11967865623475427d), new NpgsqlTypes.NpgsqlPoint(x: 0.09562908039183826d, y: 0.1820314336055635d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12117600698467912d, y: 0.6499073331871564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6326374031710928d, y: 0.9555347718873448d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456775910042993d, y: 0.7229623283424136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5070939750366245d, y: 0.3267811225274101d), new NpgsqlTypes.NpgsqlPoint(x: 0.10871033715367384d, y: 0.6151789826806736d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230051465392214d, y: 0.16667612216037053d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007097497877379011d, y: 0.11746787901468392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673451205978797d, y: 0.7076022121191229d), new NpgsqlTypes.NpgsqlPoint(x: 0.3517531449259502d, y: 0.602523615372973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4945463505658778d, y: 0.9335271478398023d), new NpgsqlTypes.NpgsqlPoint(x: 0.09955824338854602d, y: 0.9342606968788995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9226567432603199d, y: 0.01691588179918091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.673106884877953d, y: 0.14948195201504422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818043234321632d, y: 0.19050736354850517d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432152767006896d, y: 0.9153057336997961d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6939028832210643d, y: 0.6709304074451856d), new NpgsqlTypes.NpgsqlPoint(x: 0.8398265392065036d, y: 0.8437364691389934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8061930333530971d, y: 0.7711737618803984d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02591694834580016d, y: 0.2867251260039497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226283720907348d, y: 0.1608458788048348d), new NpgsqlTypes.NpgsqlPoint(x: 0.38154424707985046d, y: 0.3250625973616541d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9844532953545632d, y: 0.7344740896076766d), new NpgsqlTypes.NpgsqlPoint(x: 0.784306017712844d, y: 0.01700199545283676d), new NpgsqlTypes.NpgsqlPoint(x: 0.35326750668379525d, y: 0.6577540975725686d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07344357573380589d, y: 0.7416975758685711d), new NpgsqlTypes.NpgsqlPoint(x: 0.518140510714189d, y: 0.3739523421821207d), new NpgsqlTypes.NpgsqlPoint(x: 0.07145883894383598d, y: 0.03580668448893076d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6385743750617588d, y: 0.0782954183273048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5268404955134525d, y: 0.8145726855874816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570694299255393d, y: 0.30775610629638395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13029665593305384d, y: 0.20187168569386849d), new NpgsqlTypes.NpgsqlPoint(x: 0.41677772264702273d, y: 0.37963283195953357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3590260749663954d, y: 0.9239874395752663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17238094035606666d, y: 0.8516403714512754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393053921311886d, y: 0.8789079945582214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9944407686327748d, y: 0.10305281813033929d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8145225178785646d, y: 0.6963215193431574d), new NpgsqlTypes.NpgsqlPoint(x: 0.48083682606179856d, y: 0.38115842731449734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9882422510904924d, y: 0.47592774871307875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6417849135155366d, y: 0.7194220676902428d), new NpgsqlTypes.NpgsqlPoint(x: 0.29996340560193957d, y: 0.559358006356325d), new NpgsqlTypes.NpgsqlPoint(x: 0.06635653193878022d, y: 0.207181814672889d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9757761430800292d, y: 0.9665419530946618d), new NpgsqlTypes.NpgsqlPoint(x: 0.009379311982900762d, y: 0.3150205051511257d), new NpgsqlTypes.NpgsqlPoint(x: 0.054792034088956054d, y: 0.18258181271495522d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901737032841109d, y: 0.8471593294343185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100036784341654d, y: 0.522765572685541d), new NpgsqlTypes.NpgsqlPoint(x: 0.313168775181465d, y: 0.4224994944044893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3814853531928952d, y: 0.14516511182540903d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719955582124116d, y: 0.9426242066842985d), new NpgsqlTypes.NpgsqlPoint(x: 0.1585600821504607d, y: 0.6945641739441739d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42276130777941545d, y: 0.3462101126821122d), new NpgsqlTypes.NpgsqlPoint(x: 0.0062763751595745765d, y: 0.5476734256279887d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992676074410012d, y: 0.970887726122123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852333555602305d, y: 0.04424995985074065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882079320158252d, y: 0.43343092491328716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252478564741531d, y: 0.6004926663492037d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12725433270023467d, y: 0.9350487229236204d), new NpgsqlTypes.NpgsqlPoint(x: 0.06286304109838747d, y: 0.9490555627821489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470029333754527d, y: 0.7107833049954481d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31473466815312456d, y: 0.015875497102184832d), new NpgsqlTypes.NpgsqlPoint(x: 0.1223927944042098d, y: 0.5955341797537377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319674189187061d, y: 0.6350035350373452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3384395746762493d, y: 0.5670198153624004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6471089689362938d, y: 0.6672995695730772d), new NpgsqlTypes.NpgsqlPoint(x: 0.2532947852512264d, y: 0.6037432846160589d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7228727149342159d, y: 0.6365016387862487d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192068514837565d, y: 0.8673817914040959d), new NpgsqlTypes.NpgsqlPoint(x: 0.07019314451709391d, y: 0.34763250364975495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5107250004566471d, y: 0.8228159907422948d), new NpgsqlTypes.NpgsqlPoint(x: 0.32681862282614205d, y: 0.17494430611343226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286442148373966d, y: 0.8679757231994893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5297182484648424d, y: 0.08169357699936342d), new NpgsqlTypes.NpgsqlPoint(x: 0.802892797765826d, y: 0.1858555964787606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623304739248931d, y: 0.13577851586756862d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7587398573056383d, y: 0.9148495351711786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3136542460401003d, y: 0.47026993963471575d), new NpgsqlTypes.NpgsqlPoint(x: 0.47190979550948386d, y: 0.9853906215295365d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6418203662318033d, y: 0.8760375022333174d), new NpgsqlTypes.NpgsqlPoint(x: 0.3515972907932011d, y: 0.959068109656613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610806621518228d, y: 0.45749291859152363d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27019967753319485d, y: 0.7525610263676322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777243477510819d, y: 0.6273338011901042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647757882981591d, y: 0.984294125697081d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8159736598882991d, y: 0.23357081139494773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9436979235597106d, y: 0.36813058632597107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175427570275812d, y: 0.7947610841859487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24316023919251695d, y: 0.897730160720296d), new NpgsqlTypes.NpgsqlPoint(x: 0.44095346530865953d, y: 0.5376407073847146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255355342954139d, y: 0.39566694770917143d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8281666000498565d, y: 0.035837182093082176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9547308942254017d, y: 0.5138525197379239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736014418455219d, y: 0.32570793037980783d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8104537084261899d, y: 0.9773827163411221d), new NpgsqlTypes.NpgsqlPoint(x: 0.23167186353780522d, y: 0.31327867439155255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384702977945349d, y: 0.8032158274446166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03911438766038977d, y: 0.6611564501562746d), new NpgsqlTypes.NpgsqlPoint(x: 0.3134536477874674d, y: 0.05404701289053959d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608947150193309d, y: 0.9106623835666292d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.567963497593003d, y: 0.10733955265630901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500067654476319d, y: 0.2669627620846602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9033556018053883d, y: 0.39127966157347904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9595184133740257d, y: 0.5027655970487002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2418186605080821d, y: 0.15513423922650682d), new NpgsqlTypes.NpgsqlPoint(x: 0.1948665657500369d, y: 0.5260445277266815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357904964173886d, y: 0.6882154134215613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4332086531323639d, y: 0.49196818829468225d), new NpgsqlTypes.NpgsqlPoint(x: 0.002208419736533962d, y: 0.5842357480233628d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786350605680545d, y: 0.02140525932236048d), new NpgsqlTypes.NpgsqlPoint(x: 0.40262832314172825d, y: 0.8522773699190974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843028642310149d, y: 0.035672086534962344d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9961514962974866d, y: 0.2154769478592835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3168586472167384d, y: 0.18280523526917913d), new NpgsqlTypes.NpgsqlPoint(x: 0.29520823859321255d, y: 0.14415503779312633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693541722402385d, y: 0.5607598215496928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277405249771898d, y: 0.5184009579820376d), new NpgsqlTypes.NpgsqlPoint(x: 0.89237027051829d, y: 0.25573972252498633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7906822005852757d, y: 0.5504935045613353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5121281929825072d, y: 0.06541967863708675d), new NpgsqlTypes.NpgsqlPoint(x: 0.4416520301947201d, y: 0.8871595426781738d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06026160284350379d, y: 0.6345478905277143d), new NpgsqlTypes.NpgsqlPoint(x: 0.17725233909547378d, y: 0.7423125979483436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8851483965475891d, y: 0.18042494124995268d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9107251887688584d, y: 0.7097184596148243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476722031340115d, y: 0.5934544359390966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9378564764825148d, y: 0.5931890870303912d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6700600396113718d, y: 0.06312317053976446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6531789322709379d, y: 0.697748811888848d), new NpgsqlTypes.NpgsqlPoint(x: 0.46265241497311094d, y: 0.9755204674708948d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5668233581501892d, y: 0.24703471976946223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702551811887593d, y: 0.0032329157295720723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384986006196055d, y: 0.47222461870398347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296347368253304d, y: 0.16006863930981596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6031476397181124d, y: 0.8964397447665632d), new NpgsqlTypes.NpgsqlPoint(x: 0.14282944622378924d, y: 0.12745226721327896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6318521672469529d, y: 0.07131044817781351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243557532343046d, y: 0.4014309681066607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889598536341619d, y: 0.8572947490426244d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21502328382918423d, y: 0.6505742841600745d), new NpgsqlTypes.NpgsqlPoint(x: 0.017550627044108924d, y: 0.8085125928103178d), new NpgsqlTypes.NpgsqlPoint(x: 0.014645823781999856d, y: 0.8776671457280472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11641235749062073d, y: 0.25201121020104067d), new NpgsqlTypes.NpgsqlPoint(x: 0.008747859585559015d, y: 0.3360855762186301d), new NpgsqlTypes.NpgsqlPoint(x: 0.34586642335283124d, y: 0.21485229562807828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13890918597807023d, y: 0.8854223708540356d), new NpgsqlTypes.NpgsqlPoint(x: 0.7542991769575723d, y: 0.8694640766850271d), new NpgsqlTypes.NpgsqlPoint(x: 0.318720651581491d, y: 0.09403239991535706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6187694164313773d, y: 0.4800280007131962d), new NpgsqlTypes.NpgsqlPoint(x: 0.22264026022968408d, y: 0.45428747485197696d), new NpgsqlTypes.NpgsqlPoint(x: 0.20292720266955144d, y: 0.7966405857232931d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6332260087480681d, y: 0.2931568795342855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731518014953941d, y: 0.03961748856939529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902352445253238d, y: 0.47820416383507935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897915933043081d, y: 0.9073029028567535d), new NpgsqlTypes.NpgsqlPoint(x: 0.04902690966074008d, y: 0.20619593704186856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747897042920148d, y: 0.46516648919026693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23338503877575567d, y: 0.7528920050938788d), new NpgsqlTypes.NpgsqlPoint(x: 0.91435893516466d, y: 0.08195214113729488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8563553606095936d, y: 0.31524664797646773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6555671069892052d, y: 0.4856786643872937d), new NpgsqlTypes.NpgsqlPoint(x: 0.39072477874344547d, y: 0.4065010424539618d), new NpgsqlTypes.NpgsqlPoint(x: 0.011674964167589952d, y: 0.9522335997333423d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8373867416589368d, y: 0.27197931665957087d), new NpgsqlTypes.NpgsqlPoint(x: 0.2170798884369356d, y: 0.2651252546013162d), new NpgsqlTypes.NpgsqlPoint(x: 0.4621772311789566d, y: 0.4935141510910924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.870234537311704d, y: 0.42723468291357036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9101066829084159d, y: 0.6114344425710525d), new NpgsqlTypes.NpgsqlPoint(x: 0.03562354818923652d, y: 0.22516275658238893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8706056240674163d, y: 0.5149734040805927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783665547026493d, y: 0.13889771503890713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5398899788636324d, y: 0.15488263343533415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31982518209174005d, y: 0.825430469463447d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314403518518834d, y: 0.4400444827545331d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880544934892676d, y: 0.4566259979260078d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788263076368439d, y: 0.2092586514879411d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298595736371887d, y: 0.6909999582455885d), new NpgsqlTypes.NpgsqlPoint(x: 0.21977690958491058d, y: 0.0851815738414402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738508539003018d, y: 0.6729663002141402d), new NpgsqlTypes.NpgsqlPoint(x: 0.11793250472888694d, y: 0.22742968932357954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339563873821966d, y: 0.6477509475282671d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28217419950309064d, y: 0.9361736190379198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466361626005573d, y: 0.4468549313882023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379359333097813d, y: 0.43409922942458035d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3227541302150365d, y: 0.2671259866861305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3354448418337139d, y: 0.17648299790934752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460542819163593d, y: 0.050245378957800124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33856002348311d, y: 0.7220604034851261d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312547925033207d, y: 0.4662720659598111d), new NpgsqlTypes.NpgsqlPoint(x: 0.33569008152656654d, y: 0.6477346339174034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28955696887751003d, y: 0.9721767093334572d), new NpgsqlTypes.NpgsqlPoint(x: 0.05464299992580912d, y: 0.27044098395916827d), new NpgsqlTypes.NpgsqlPoint(x: 0.06230699018577357d, y: 0.3036759748746697d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07744264297886883d, y: 0.3391538496696739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513484654101042d, y: 0.9667821562089342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556542598351409d, y: 0.8251517973296607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173501386581594d, y: 0.29584795164215494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236060258491107d, y: 0.4418177559332924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091096098636356d, y: 0.7223351471645566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5977063390783451d, y: 0.9924878600887358d), new NpgsqlTypes.NpgsqlPoint(x: 0.298961213254024d, y: 0.09495902989882721d), new NpgsqlTypes.NpgsqlPoint(x: 0.042050549508589d, y: 0.701910820636424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305022057704977d, y: 0.07118405126456673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827264845706609d, y: 0.7080053013279337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575881012476226d, y: 0.1423315045932635d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2960140862443209d, y: 0.28036756190830703d), new NpgsqlTypes.NpgsqlPoint(x: 0.03861954918048505d, y: 0.21342774046507973d), new NpgsqlTypes.NpgsqlPoint(x: 0.5811103810114673d, y: 0.7620246647900348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22115761579381754d, y: 0.016109219999463686d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039178390704181d, y: 0.8025693624344088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173357486397712d, y: 0.9378420796260601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4428258088792616d, y: 0.4830679482387996d), new NpgsqlTypes.NpgsqlPoint(x: 0.25224037462229d, y: 0.48289497741327314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868744482281947d, y: 0.4550015787317119d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44295273344044006d, y: 0.23596204965018175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000266052076989d, y: 0.7408434248331873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6985818210215535d, y: 0.3719512501090205d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.996982554097256d, y: 0.04445088393854624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726565345785572d, y: 0.8109740057647407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632907294962474d, y: 0.12091027077160654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8060236063085348d, y: 0.627213189673704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3901610723395905d, y: 0.3092340481672098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192370860973801d, y: 0.8593738132983173d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9934984493502462d, y: 0.803120831970462d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457077500338839d, y: 0.18739480770120553d), new NpgsqlTypes.NpgsqlPoint(x: 0.08367523520029008d, y: 0.24424148592728445d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5980041201695752d, y: 0.4177456975977868d), new NpgsqlTypes.NpgsqlPoint(x: 0.24102040637046596d, y: 0.9892218862013162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5178118029322984d, y: 0.8422135735972618d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2729341449889017d, y: 0.5233482805740216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038950578808235d, y: 0.8260631902299334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7560604191831486d, y: 0.9621010096626118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8878432787897427d, y: 0.2625014193130796d), new NpgsqlTypes.NpgsqlPoint(x: 0.00509258921692568d, y: 0.617818864120812d), new NpgsqlTypes.NpgsqlPoint(x: 0.21886763323429514d, y: 0.6596900079849094d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9735113426508495d, y: 0.7252119227812721d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581835631093379d, y: 0.13052142744313322d), new NpgsqlTypes.NpgsqlPoint(x: 0.33048847333777054d, y: 0.1831402304570443d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6179431001117611d, y: 0.6055227842833476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451219241259268d, y: 0.9200761575155669d), new NpgsqlTypes.NpgsqlPoint(x: 0.1350804829618779d, y: 0.6300986229571529d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7956821948405114d, y: 0.514491608678978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9990576160720472d, y: 0.20847176921567168d), new NpgsqlTypes.NpgsqlPoint(x: 0.15088733178873104d, y: 0.4401213633162723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3251371491840056d, y: 0.029805160492197613d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643000515656947d, y: 0.94732314081066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8552784909160633d, y: 0.13184160121741761d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.756585564191228d, y: 0.8790293898524402d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237279099897677d, y: 0.47479932019680493d), new NpgsqlTypes.NpgsqlPoint(x: 0.36959056216358643d, y: 0.527016241727291d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2497605356866529d, y: 0.14576401274948914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342160744077982d, y: 0.6885522958497194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8346334963660978d, y: 0.19246827295577718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6848066528567577d, y: 0.10890684972473963d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529133576020213d, y: 0.7280886716769832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922428074985372d, y: 0.6273090702809226d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40866950407304103d, y: 0.5380096110324749d), new NpgsqlTypes.NpgsqlPoint(x: 0.2736181670134147d, y: 0.440014752193266d), new NpgsqlTypes.NpgsqlPoint(x: 0.3816939002884385d, y: 0.4213485556494688d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059226915657675905d, y: 0.7985107506358411d), new NpgsqlTypes.NpgsqlPoint(x: 0.12427169339500677d, y: 0.4222325352354471d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781331960477586d, y: 0.6316337709164147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5189992005072346d, y: 0.9714637435463709d), new NpgsqlTypes.NpgsqlPoint(x: 0.14526640000709135d, y: 0.22491837120161884d), new NpgsqlTypes.NpgsqlPoint(x: 0.016567918177306518d, y: 0.6636509144858873d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.538878043022369d, y: 0.1876827443932878d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091402612344422d, y: 0.799029481511727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8839283952538977d, y: 0.40746436779592154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3774352760158116d, y: 0.39955489297529645d), new NpgsqlTypes.NpgsqlPoint(x: 0.4465080892912716d, y: 0.988629487865118d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323252575360341d, y: 0.21905587844068086d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8102563197580808d, y: 0.9766871454559264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7179778342660224d, y: 0.1693287604981758d), new NpgsqlTypes.NpgsqlPoint(x: 0.06610613769025442d, y: 0.8825305147550228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6912274649248874d, y: 0.4032236736054492d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073589145504112d, y: 0.6576166304337009d), new NpgsqlTypes.NpgsqlPoint(x: 0.04041602747649786d, y: 0.9328092351091021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271387688887907d, y: 0.3696542720162532d), new NpgsqlTypes.NpgsqlPoint(x: 0.23904967935597643d, y: 0.1375011432669313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744150599922868d, y: 0.6382444249269418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8181260905426355d, y: 0.191411089643156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9693934738895811d, y: 0.07877019760593906d), new NpgsqlTypes.NpgsqlPoint(x: 0.20658363144384484d, y: 0.5742301486568895d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8868241359576792d, y: 0.48954746190388887d), new NpgsqlTypes.NpgsqlPoint(x: 0.15053344733638174d, y: 0.9404128099616026d), new NpgsqlTypes.NpgsqlPoint(x: 0.964617342073301d, y: 0.012520900040136507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.68409296525938d, y: 0.9915625211901417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3906725170732649d, y: 0.15472738683640264d), new NpgsqlTypes.NpgsqlPoint(x: 0.618615929530979d, y: 0.4299399734860334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02410010306692234d, y: 0.3908286550930131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8227608137130987d, y: 0.6955471280146265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807129852238165d, y: 0.049304772955097276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4416137640603198d, y: 0.5587639298887206d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752208070631785d, y: 0.2682704790118371d), new NpgsqlTypes.NpgsqlPoint(x: 0.8493828163776458d, y: 0.6269376502855739d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6171768254207707d, y: 0.9990517413312139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8406909886950834d, y: 0.7320312764857417d), new NpgsqlTypes.NpgsqlPoint(x: 0.08034210033228206d, y: 0.17968995314136038d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43598446843352145d, y: 0.17345865216048295d), new NpgsqlTypes.NpgsqlPoint(x: 0.04509203982787624d, y: 0.515634591389748d), new NpgsqlTypes.NpgsqlPoint(x: 0.6344267330623202d, y: 0.7492325527157175d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4409312377602479d, y: 0.5679134192626917d), new NpgsqlTypes.NpgsqlPoint(x: 0.006064161020515102d, y: 0.6636099532006937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318995074699918d, y: 0.5762580679018406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9202680087023931d, y: 0.2526631192377571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589934294464339d, y: 0.20393236124852643d), new NpgsqlTypes.NpgsqlPoint(x: 0.06257883288209831d, y: 0.1970517267045685d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26541005455853284d, y: 0.25367797993976615d), new NpgsqlTypes.NpgsqlPoint(x: 0.46666220923560753d, y: 0.6844476984982818d), new NpgsqlTypes.NpgsqlPoint(x: 0.2515604054199958d, y: 0.9160834860555617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6666367285576043d, y: 0.18311002424836964d), new NpgsqlTypes.NpgsqlPoint(x: 0.31124000985112465d, y: 0.19672698195299343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9824650783336007d, y: 0.11587287050222106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21101215649895622d, y: 0.39843074603074347d), new NpgsqlTypes.NpgsqlPoint(x: 0.24003134602707343d, y: 0.9263992631075358d), new NpgsqlTypes.NpgsqlPoint(x: 0.6394696107678621d, y: 0.8967412460272777d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4393329836846487d, y: 0.7572200838034667d), new NpgsqlTypes.NpgsqlPoint(x: 0.8657868786305627d, y: 0.34457164544893293d), new NpgsqlTypes.NpgsqlPoint(x: 0.284810222427765d, y: 0.5314480546033681d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9979534248779017d, y: 0.845294844519985d), new NpgsqlTypes.NpgsqlPoint(x: 0.3280063876783198d, y: 0.8267372216511181d), new NpgsqlTypes.NpgsqlPoint(x: 0.17016673334574095d, y: 0.9892903578794408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049099448711880544d, y: 0.313932819688892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784280128728015d, y: 0.19936384024154785d), new NpgsqlTypes.NpgsqlPoint(x: 0.014395912671397615d, y: 0.795465024624511d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6905033463482788d, y: 0.49777815002680426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807263036010079d, y: 0.45652184371860294d), new NpgsqlTypes.NpgsqlPoint(x: 0.26790689049040795d, y: 0.8906978111167871d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4887322264790587d, y: 0.2242307791346091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7084588619116865d, y: 0.2207913827419773d), new NpgsqlTypes.NpgsqlPoint(x: 0.2675824865006572d, y: 0.7204788539361926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.629707460688625d, y: 0.5305911596473751d), new NpgsqlTypes.NpgsqlPoint(x: 0.4871072777744263d, y: 0.4723357401629348d), new NpgsqlTypes.NpgsqlPoint(x: 0.042781566495241896d, y: 0.2616226043553843d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37266285375444874d, y: 0.615005474404217d), new NpgsqlTypes.NpgsqlPoint(x: 0.29436571240103404d, y: 0.4796767379725321d), new NpgsqlTypes.NpgsqlPoint(x: 0.624146036925335d, y: 0.5640521040376136d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45051360141088104d, y: 0.058711965731543914d), new NpgsqlTypes.NpgsqlPoint(x: 0.039627413174846415d, y: 0.2787468135245448d), new NpgsqlTypes.NpgsqlPoint(x: 0.07215166494415337d, y: 0.5586976990311211d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43907455928695927d, y: 0.8618969797006973d), new NpgsqlTypes.NpgsqlPoint(x: 0.37032642583811504d, y: 0.6779477919857835d), new NpgsqlTypes.NpgsqlPoint(x: 0.21531811308925863d, y: 0.2846883950802136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3049608129703588d, y: 0.5106733027026864d), new NpgsqlTypes.NpgsqlPoint(x: 0.17496218841753897d, y: 0.3749343482321814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155268512831037d, y: 0.23457142904570716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5328596808842321d, y: 0.7068750645766065d), new NpgsqlTypes.NpgsqlPoint(x: 0.34374449723534073d, y: 0.06664835796076884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449945912989944d, y: 0.9191100310375527d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6392598803534384d, y: 0.6862845446672574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549022585693821d, y: 0.24732599080421636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2625778996452395d, y: 0.08179150291093584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05657139667593458d, y: 0.11916874255297505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7462193744268035d, y: 0.503849601136308d), new NpgsqlTypes.NpgsqlPoint(x: 0.33947331820677884d, y: 0.6022291530425892d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8157982948194304d, y: 0.9979563318024438d), new NpgsqlTypes.NpgsqlPoint(x: 0.562895190447669d, y: 0.6493026521834102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099514671785749d, y: 0.3876661698659376d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405331811004726d, y: 0.1778391893489205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8852617135718585d, y: 0.4293518063984415d), new NpgsqlTypes.NpgsqlPoint(x: 0.822841482799741d, y: 0.7145314141724278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.970365920715101d, y: 0.8286947603472689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7515775738746981d, y: 0.5682493868108704d), new NpgsqlTypes.NpgsqlPoint(x: 0.4192473719363833d, y: 0.06873372936024025d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6163240500107705d, y: 0.13145739535181844d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898942822036532d, y: 0.40910189622139514d), new NpgsqlTypes.NpgsqlPoint(x: 0.43975855486648185d, y: 0.40554697299156695d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9101826463746813d, y: 0.8151820960855551d), new NpgsqlTypes.NpgsqlPoint(x: 0.5852427771742049d, y: 0.13199776701763166d), new NpgsqlTypes.NpgsqlPoint(x: 0.13375304594098603d, y: 0.117907702112657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1272561110481285d, y: 0.696341269302112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976470738011136d, y: 0.06928449252490188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583029897343579d, y: 0.6425367152806841d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.920806362572582d, y: 0.923730549364672d), new NpgsqlTypes.NpgsqlPoint(x: 0.620070895275255d, y: 0.88045657363642d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213828267948966d, y: 0.07681339101152562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7228943692191854d, y: 0.2102081893749399d), new NpgsqlTypes.NpgsqlPoint(x: 0.748619019256347d, y: 0.36948374169025244d), new NpgsqlTypes.NpgsqlPoint(x: 0.986622052440911d, y: 0.5430936682819348d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9778855150200202d, y: 0.6070096080812803d), new NpgsqlTypes.NpgsqlPoint(x: 0.3076965731620789d, y: 0.5594070837271955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861775610068003d, y: 0.5044712341842273d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13465038563708942d, y: 0.06902819994385323d), new NpgsqlTypes.NpgsqlPoint(x: 0.24022719779699642d, y: 0.8316908642422951d), new NpgsqlTypes.NpgsqlPoint(x: 0.6897935301823378d, y: 0.4696958143276587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6345203245266356d, y: 0.9243191112818424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106763389470779d, y: 0.417659439104912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445824624219545d, y: 0.5255898778021401d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42080900260008014d, y: 0.9312767236071152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998672494878861d, y: 0.3747336331298663d), new NpgsqlTypes.NpgsqlPoint(x: 0.834636970474875d, y: 0.6744220921433529d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6360868024012198d, y: 0.14649528791364286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7940168915567895d, y: 0.55187369470513d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418175556153148d, y: 0.6137137630683223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46234080018589085d, y: 0.1442392679620178d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101492508413407d, y: 0.6397930790184942d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544719697942716d, y: 0.39427116661812633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6679373284400577d, y: 0.022563871818514603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4843960361831189d, y: 0.23012839460723566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335841592724434d, y: 0.4128295950356837d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5384735289382233d, y: 0.22719320011049549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499369099221219d, y: 0.4499303674337176d), new NpgsqlTypes.NpgsqlPoint(x: 0.30316232670480436d, y: 0.12567335484745312d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22579782355431766d, y: 0.25790422217707143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2834183393195041d, y: 0.2847179484665867d), new NpgsqlTypes.NpgsqlPoint(x: 0.464531079070051d, y: 0.28369090012070763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21349200475907915d, y: 0.45111122055568975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8380820845639403d, y: 0.12454808244039273d), new NpgsqlTypes.NpgsqlPoint(x: 0.6232084307517843d, y: 0.4211782223046485d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4455755204569599d, y: 0.020198439639181553d), new NpgsqlTypes.NpgsqlPoint(x: 0.24112915848659822d, y: 0.49798521928269845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455241927737217d, y: 0.852552949849624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6794792381185734d, y: 0.00487359130401388d), new NpgsqlTypes.NpgsqlPoint(x: 0.13515299111202916d, y: 0.399515713545586d), new NpgsqlTypes.NpgsqlPoint(x: 0.4074303630141023d, y: 0.026449905276449526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9177777941103963d, y: 0.43358007505003937d), new NpgsqlTypes.NpgsqlPoint(x: 0.649728709438133d, y: 0.2246637514637123d), new NpgsqlTypes.NpgsqlPoint(x: 0.22602319667857373d, y: 0.6779281077932167d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4611143185500516d, y: 0.7754338349350929d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378517063966255d, y: 0.29594067368983923d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665812845745097d, y: 0.3300036784997106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08067694984393359d, y: 0.9422219997876893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069810746547774d, y: 0.9584681850767888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712831605363743d, y: 0.27977681329654225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909810548752997d, y: 0.8703328852778229d), new NpgsqlTypes.NpgsqlPoint(x: 0.46229415278161956d, y: 0.8542296042214786d), new NpgsqlTypes.NpgsqlPoint(x: 0.29575246430814317d, y: 0.47006713751435003d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03194301650255904d, y: 0.6373721689133155d), new NpgsqlTypes.NpgsqlPoint(x: 0.21176098647986896d, y: 0.5568463492629646d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549979863039228d, y: 0.3156371873855782d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02350216264830518d, y: 0.6880357163657679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265574799333935d, y: 0.5641204172105501d), new NpgsqlTypes.NpgsqlPoint(x: 0.9410411053943847d, y: 0.3293657389087238d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3562333467135924d, y: 0.5310378029598734d), new NpgsqlTypes.NpgsqlPoint(x: 0.18110378395633575d, y: 0.6557730770549013d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454608137213658d, y: 0.7878648184723088d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10411524447874976d, y: 0.5333824764117141d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460348862145541d, y: 0.1654265102241842d), new NpgsqlTypes.NpgsqlPoint(x: 0.22937531020891566d, y: 0.4757495707799769d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07868040228977613d, y: 0.7727067277267452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9993213052376617d, y: 0.3051947018394472d), new NpgsqlTypes.NpgsqlPoint(x: 0.46244179069048597d, y: 0.3792416097508374d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5534519081286543d, y: 0.5765273720564235d), new NpgsqlTypes.NpgsqlPoint(x: 0.975218706997213d, y: 0.6342132571156022d), new NpgsqlTypes.NpgsqlPoint(x: 0.006289016067136166d, y: 0.858871556426576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.730959375892392d, y: 0.3068695936200787d), new NpgsqlTypes.NpgsqlPoint(x: 0.872280206841223d, y: 0.2776772418491432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922199631917345d, y: 0.7784129656818645d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2776297252498957d, y: 0.8970041218429011d), new NpgsqlTypes.NpgsqlPoint(x: 0.1248468394141028d, y: 0.2991781103234892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057002036034781d, y: 0.9254859726552896d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7239456531016955d, y: 0.6186135441638126d), new NpgsqlTypes.NpgsqlPoint(x: 0.04391482710741612d, y: 0.23600217705292925d), new NpgsqlTypes.NpgsqlPoint(x: 0.47850201122917846d, y: 0.24770469825218044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1831593187066891d, y: 0.7699295911456768d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388273541295713d, y: 0.8776864735136441d), new NpgsqlTypes.NpgsqlPoint(x: 0.1351137108330448d, y: 0.8981797655463766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6815050014478395d, y: 0.045834930704676036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725197325867975d, y: 0.5101993762840216d), new NpgsqlTypes.NpgsqlPoint(x: 0.7928131442624387d, y: 0.9264184204253736d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5566497007733097d, y: 0.29214414837791747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204140201598407d, y: 0.7987661464186544d), new NpgsqlTypes.NpgsqlPoint(x: 0.33949444340167356d, y: 0.571927734456215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8582290650139434d, y: 0.41385701461705393d), new NpgsqlTypes.NpgsqlPoint(x: 0.39063512322327376d, y: 0.7680380714685989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9250038930876257d, y: 0.40421077974371933d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3275827968585635d, y: 0.253165164106154d), new NpgsqlTypes.NpgsqlPoint(x: 0.605242181503053d, y: 0.8835425173380741d), new NpgsqlTypes.NpgsqlPoint(x: 0.01547775486588776d, y: 0.4543123786560612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34064962649670294d, y: 0.9294975132887064d), new NpgsqlTypes.NpgsqlPoint(x: 0.38072063544401435d, y: 0.4562728770644956d), new NpgsqlTypes.NpgsqlPoint(x: 0.12438044289198313d, y: 0.4673107110474636d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5561733288336185d, y: 0.09413078036854305d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350090019990071d, y: 0.955638581093569d), new NpgsqlTypes.NpgsqlPoint(x: 0.057058243769153916d, y: 0.7835912613662979d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43404436329960083d, y: 0.8893312440797161d), new NpgsqlTypes.NpgsqlPoint(x: 0.2319435342590369d, y: 0.8788875656859009d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974756420513057d, y: 0.6248645694086808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7068576498519142d, y: 0.9630902876247115d), new NpgsqlTypes.NpgsqlPoint(x: 0.22582371719293814d, y: 0.6644791317318545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9317886261072561d, y: 0.4001698166408406d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.658852529816625d, y: 0.3842847427477484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977565753740956d, y: 0.04197821784064659d), new NpgsqlTypes.NpgsqlPoint(x: 0.17001636480626392d, y: 0.3242745426692156d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28974709589959124d, y: 0.2730081487125552d), new NpgsqlTypes.NpgsqlPoint(x: 0.18103310412319396d, y: 0.6425959923992435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3511436390686108d, y: 0.44991437053885797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3668462453941379d, y: 0.15908069679403947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5259162244701094d, y: 0.10354313832719819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983860103476262d, y: 0.7422270207420208d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5819915150466726d, y: 0.05813028448185609d), new NpgsqlTypes.NpgsqlPoint(x: 0.13970753982685413d, y: 0.7737951762041927d), new NpgsqlTypes.NpgsqlPoint(x: 0.30408812989158907d, y: 0.1905478792120977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07164128790787694d, y: 0.3448707870800076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367284291261256d, y: 0.276822618407221d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975764774724178d, y: 0.7602684463478523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6295228301735226d, y: 0.3462844611036553d), new NpgsqlTypes.NpgsqlPoint(x: 0.474684583415407d, y: 0.38253508154953353d), new NpgsqlTypes.NpgsqlPoint(x: 0.05452895044667394d, y: 0.9570622946216566d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25812244095701575d, y: 0.08603064362004564d), new NpgsqlTypes.NpgsqlPoint(x: 0.9662316669697455d, y: 0.8476354244787354d), new NpgsqlTypes.NpgsqlPoint(x: 0.4438347522885686d, y: 0.03874919305641977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7847722648401321d, y: 0.5687443779169646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3499784336272733d, y: 0.06415073714703812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867858870393756d, y: 0.39332874338098356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6759835813593689d, y: 0.9598567977653613d), new NpgsqlTypes.NpgsqlPoint(x: 0.8447916450679852d, y: 0.23861552370168082d), new NpgsqlTypes.NpgsqlPoint(x: 0.06939153700184464d, y: 0.4712911773564652d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20289723271270654d, y: 0.5408725336272682d), new NpgsqlTypes.NpgsqlPoint(x: 0.1371172507629751d, y: 0.037501291977014795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155799810697044d, y: 0.09000561089373804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37849226573582206d, y: 0.7722097283132879d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731686085140965d, y: 0.23209555473220278d), new NpgsqlTypes.NpgsqlPoint(x: 0.25904839614567354d, y: 0.39621011495384373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8505765555374247d, y: 0.569206820565002d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663348892070899d, y: 0.8711366796250631d), new NpgsqlTypes.NpgsqlPoint(x: 0.097638569567147d, y: 0.1949389901554005d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5391357116847513d, y: 0.1361249241286001d), new NpgsqlTypes.NpgsqlPoint(x: 0.776574611221175d, y: 0.827071773589606d), new NpgsqlTypes.NpgsqlPoint(x: 0.389329045800215d, y: 0.9974395029409272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48385737096143744d, y: 0.915708286273829d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340092287416139d, y: 0.14496328190605234d), new NpgsqlTypes.NpgsqlPoint(x: 0.27481159251012155d, y: 0.8869658819640319d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7379814717138931d, y: 0.4277831305281201d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254346462512563d, y: 0.04847410643228345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7862094335424464d, y: 0.003577785668522515d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8517374454568192d, y: 0.4566416764277247d), new NpgsqlTypes.NpgsqlPoint(x: 0.4554271863406777d, y: 0.6939249017083172d), new NpgsqlTypes.NpgsqlPoint(x: 0.32419684558636974d, y: 0.1559571205908048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7334117599503513d, y: 0.11247656154979102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6197980925790973d, y: 0.040533246424504066d), new NpgsqlTypes.NpgsqlPoint(x: 0.4729164841382888d, y: 0.7808575170774354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6355819639890274d, y: 0.6025433622638228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206979600392424d, y: 0.6529080545663847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248771546551699d, y: 0.9368624639965766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8510544172004787d, y: 0.8536666032108512d), new NpgsqlTypes.NpgsqlPoint(x: 0.906752508081114d, y: 0.6292036509692935d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014383714201295916d, y: 0.20726348734166367d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3730799184856507d, y: 0.9260737596911206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667228098723693d, y: 0.9079391859504371d), new NpgsqlTypes.NpgsqlPoint(x: 0.21417034446327932d, y: 0.8287439191923394d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6120821399764026d, y: 0.05219563570093089d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073029006271289d, y: 0.08138189039203758d), new NpgsqlTypes.NpgsqlPoint(x: 0.9637039730942897d, y: 0.86007336196974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9638504456379701d, y: 0.8343384799455181d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389181438035587d, y: 0.7038956180498813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245027315997109d, y: 0.3564006355030964d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5220603415892172d, y: 0.9517532669399565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8271777020744202d, y: 0.01595183960449542d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915490519304922d, y: 0.7963501774329413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9716458524825693d, y: 0.2123929604904622d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579273489072061d, y: 0.02587276195013799d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290964237063551d, y: 0.0874255640595456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5940800192115133d, y: 0.6184381740664603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4298628957585151d, y: 0.5995887572685439d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513778561641179d, y: 0.9297757373089717d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3624337317921277d, y: 0.8818222225797019d), new NpgsqlTypes.NpgsqlPoint(x: 0.25940455162673837d, y: 0.8664437250923774d), new NpgsqlTypes.NpgsqlPoint(x: 0.3757397305823237d, y: 0.3986712833349938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5524227194213883d, y: 0.4754401607377696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8753802090067154d, y: 0.08505151816696077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152898631172264d, y: 0.22881433717621347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9245123458422765d, y: 0.5430515012879847d), new NpgsqlTypes.NpgsqlPoint(x: 0.13857315187692332d, y: 0.47113034971555856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323033436926345d, y: 0.19359062243481073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5309481373653361d, y: 0.142286166856204d), new NpgsqlTypes.NpgsqlPoint(x: 0.878359451987045d, y: 0.8005205192612753d), new NpgsqlTypes.NpgsqlPoint(x: 0.015094798433220702d, y: 0.8244921745742427d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1528778252096824d, y: 0.2109134334915792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872387820180047d, y: 0.9654039435597018d), new NpgsqlTypes.NpgsqlPoint(x: 0.4324152746108142d, y: 0.5695117816033888d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8279618640623799d, y: 0.45713941318021767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3639241373667047d, y: 0.49549779365096325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627948338750004d, y: 0.4967510452772421d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6520259726390606d, y: 0.4657739247678422d), new NpgsqlTypes.NpgsqlPoint(x: 0.2633082231188777d, y: 0.5921121511783899d), new NpgsqlTypes.NpgsqlPoint(x: 0.1351784495639089d, y: 0.42190460202433067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8797855501337979d, y: 0.3729528101581423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017298078226032d, y: 0.7736300272499569d), new NpgsqlTypes.NpgsqlPoint(x: 0.05119547782616829d, y: 0.7703237740768508d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40843532840455277d, y: 0.2780451905252991d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173935221365192d, y: 0.12202669348840756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7040359366169832d, y: 0.2238808624866524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18979988507908607d, y: 0.14782515549489983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7908250563889389d, y: 0.025586160707660843d), new NpgsqlTypes.NpgsqlPoint(x: 0.524011213394284d, y: 0.19746006019872497d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005187955643819686d, y: 0.27487995465415593d), new NpgsqlTypes.NpgsqlPoint(x: 0.16236866529741922d, y: 0.9212188642341707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6453255376446573d, y: 0.3583810522051375d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7490084744265213d, y: 0.6605345749471587d), new NpgsqlTypes.NpgsqlPoint(x: 0.004765428890245116d, y: 0.19553461193868915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068215052292014d, y: 0.18072715748292356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4472787823296418d, y: 0.9244633755327715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6916886348156556d, y: 0.23279366148612013d), new NpgsqlTypes.NpgsqlPoint(x: 0.1717203318764663d, y: 0.6997269218080021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013402143821965473d, y: 0.10746057001319309d), new NpgsqlTypes.NpgsqlPoint(x: 0.40024213130465824d, y: 0.08611449402994187d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619389118422981d, y: 0.9576820665974017d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5377214564467401d, y: 0.12158293302584344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7981544517921771d, y: 0.5476175289257956d), new NpgsqlTypes.NpgsqlPoint(x: 0.25259134565316876d, y: 0.35079691023753323d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21695188314128244d, y: 0.683121163747585d), new NpgsqlTypes.NpgsqlPoint(x: 0.2111902691841343d, y: 0.6143891837761166d), new NpgsqlTypes.NpgsqlPoint(x: 0.43728639583975715d, y: 0.8533825487064168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2969612942476606d, y: 0.9648180008520151d), new NpgsqlTypes.NpgsqlPoint(x: 0.25829461953704247d, y: 0.4320423356567773d), new NpgsqlTypes.NpgsqlPoint(x: 0.03625229101750327d, y: 0.012603086962159837d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12872079322752994d, y: 0.23343237337550438d), new NpgsqlTypes.NpgsqlPoint(x: 0.8057626059234033d, y: 0.7267090139686861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5720200473276628d, y: 0.06721959224328777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.538173300046122d, y: 0.25730821582544205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652684066310355d, y: 0.8179994972981747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6731914901136161d, y: 0.4796373158842969d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6042126675491217d, y: 0.3187758219113854d), new NpgsqlTypes.NpgsqlPoint(x: 0.5067786395912934d, y: 0.1578603774821754d), new NpgsqlTypes.NpgsqlPoint(x: 0.06554274625234302d, y: 0.22989732718995726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28311138217185483d, y: 0.09270522653739388d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963722314694097d, y: 0.05328572542025811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420739541190334d, y: 0.30996102468701325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24939451995138118d, y: 0.27604436320002057d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594437301119782d, y: 0.5393479893210983d), new NpgsqlTypes.NpgsqlPoint(x: 0.946380138391657d, y: 0.36673553938708836d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9993482853356751d, y: 0.03422834124474183d), new NpgsqlTypes.NpgsqlPoint(x: 0.14589618930832648d, y: 0.812487778890194d), new NpgsqlTypes.NpgsqlPoint(x: 0.009026324211610537d, y: 0.02968687220614563d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8883595683801866d, y: 0.9837595867282815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6744612973781049d, y: 0.8620797874349934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587731115839393d, y: 0.13603370785251878d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7639922678155544d, y: 0.6663440151313198d), new NpgsqlTypes.NpgsqlPoint(x: 0.14892148605016664d, y: 0.5010491060306732d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331548826707645d, y: 0.3385421869940677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38165937765978686d, y: 0.8501770176907115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853953028542066d, y: 0.9373689587712982d), new NpgsqlTypes.NpgsqlPoint(x: 0.526292400177636d, y: 0.7502186528932739d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21878550064471225d, y: 0.6318217023198778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8626745154796646d, y: 0.7493215267960881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3625602747996852d, y: 0.20708971098082618d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25227949869676203d, y: 0.48217630630164476d), new NpgsqlTypes.NpgsqlPoint(x: 0.24824488648158805d, y: 0.7866456505555087d), new NpgsqlTypes.NpgsqlPoint(x: 0.34477671905075646d, y: 0.9598484675176944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.493092880506253d, y: 0.20998449955057163d), new NpgsqlTypes.NpgsqlPoint(x: 0.90787967189196d, y: 0.39440890515032623d), new NpgsqlTypes.NpgsqlPoint(x: 0.087050750601664d, y: 0.10180279476010445d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2353069526184456d, y: 0.20624310824535308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061062921978987d, y: 0.5789019290619869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1125433906671981d, y: 0.540497526791373d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3509226121670561d, y: 0.9488006542159793d), new NpgsqlTypes.NpgsqlPoint(x: 0.055852943326008875d, y: 0.5184827012685226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989112365771034d, y: 0.4627237402285641d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3822036345738288d, y: 0.4836575451753943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196466957335863d, y: 0.5343721389312449d), new NpgsqlTypes.NpgsqlPoint(x: 0.3101808054964631d, y: 0.2948849732658908d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 189,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5974208524137986d, y: 0.9087613441334994d), new NpgsqlTypes.NpgsqlPoint(x: 0.42928302259637396d, y: 0.18989744358966953d), new NpgsqlTypes.NpgsqlPoint(x: 0.19493105170030445d, y: 0.32880035379476136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9165513174165247d, y: 0.23462406449128614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6921751376214637d, y: 0.5899697043605034d), new NpgsqlTypes.NpgsqlPoint(x: 0.24001056979370117d, y: 0.08959313576557737d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5974160895599173d, y: 0.4693070635082798d), new NpgsqlTypes.NpgsqlPoint(x: 0.13995630221244282d, y: 0.650875290446461d), new NpgsqlTypes.NpgsqlPoint(x: 0.017930534054563463d, y: 0.529900145675242d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6953973465710225d, y: 0.13343012056027004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248544485453965d, y: 0.2948953131343214d), new NpgsqlTypes.NpgsqlPoint(x: 0.0637779406145994d, y: 0.8119508531634225d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03344595023044372d, y: 0.6467276801000665d), new NpgsqlTypes.NpgsqlPoint(x: 0.2681182949012715d, y: 0.42286564861883646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6489099564815419d, y: 0.93031415986723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7308460133749477d, y: 0.31182751882800386d), new NpgsqlTypes.NpgsqlPoint(x: 0.09551869020796433d, y: 0.01780571426645783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712106542521768d, y: 0.5813136261239591d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4482056714875664d, y: 0.7373399863196324d), new NpgsqlTypes.NpgsqlPoint(x: 0.4289571661017605d, y: 0.7235645941221261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518140933088759d, y: 0.5819481782631295d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9838175843762369d, y: 0.7696694265077926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794777415051803d, y: 0.14611594693197727d), new NpgsqlTypes.NpgsqlPoint(x: 0.026233065464742134d, y: 0.02372704269857895d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6259575693496713d, y: 0.39874911222469156d), new NpgsqlTypes.NpgsqlPoint(x: 0.21805201034868749d, y: 0.577946686313055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6306892333799317d, y: 0.2158845457352493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6323067751115251d, y: 0.49388355503161185d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176570065907467d, y: 0.6277528356414687d), new NpgsqlTypes.NpgsqlPoint(x: 0.4716506980619388d, y: 0.5535647751820563d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 194,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45966355113279667d, y: 0.9947470050191773d), new NpgsqlTypes.NpgsqlPoint(x: 0.4617808812273134d, y: 0.8865525660911859d), new NpgsqlTypes.NpgsqlPoint(x: 0.15573411218920796d, y: 0.9581944741458526d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.798553333193651d, y: 0.6161104836060093d), new NpgsqlTypes.NpgsqlPoint(x: 0.05579345532229385d, y: 0.7411910255796236d), new NpgsqlTypes.NpgsqlPoint(x: 0.6227882976293728d, y: 0.16565254521019546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9103328166609159d, y: 0.10461821714528452d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175999010065477d, y: 0.8017665415025931d), new NpgsqlTypes.NpgsqlPoint(x: 0.48287616374979925d, y: 0.011950455835737395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.944946592491563d, y: 0.8762222303598245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047631410312238d, y: 0.9866984202654294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025733886800807d, y: 0.6660299093872107d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010315255660444222d, y: 0.25019365233034063d), new NpgsqlTypes.NpgsqlPoint(x: 0.35707628481114906d, y: 0.8879640320880408d), new NpgsqlTypes.NpgsqlPoint(x: 0.24254953591426465d, y: 0.0320047028216075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6358959844182946d, y: 0.573288932655432d), new NpgsqlTypes.NpgsqlPoint(x: 0.2089932585400247d, y: 0.6769653055182685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7616694888380265d, y: 0.5080950105378512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2088898441829622d, y: 0.9784473645276459d), new NpgsqlTypes.NpgsqlPoint(x: 0.810750627855829d, y: 0.24182925884715978d), new NpgsqlTypes.NpgsqlPoint(x: 0.18164680790243637d, y: 0.2457816034467487d)),
}));
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6385743750617588d, y: 0.0782954183273048d), new NpgsqlTypes.NpgsqlPoint(x: 0.5268404955134525d, y: 0.8145726855874816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570694299255393d, y: 0.30775610629638395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13029665593305384d, y: 0.20187168569386849d), new NpgsqlTypes.NpgsqlPoint(x: 0.41677772264702273d, y: 0.37963283195953357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3590260749663954d, y: 0.9239874395752663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17238094035606666d, y: 0.8516403714512754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3393053921311886d, y: 0.8789079945582214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9944407686327748d, y: 0.10305281813033929d)),
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6901737032841109d, y: 0.8471593294343185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100036784341654d, y: 0.522765572685541d), new NpgsqlTypes.NpgsqlPoint(x: 0.313168775181465d, y: 0.4224994944044893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3814853531928952d, y: 0.14516511182540903d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719955582124116d, y: 0.9426242066842985d), new NpgsqlTypes.NpgsqlPoint(x: 0.1585600821504607d, y: 0.6945641739441739d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42276130777941545d, y: 0.3462101126821122d), new NpgsqlTypes.NpgsqlPoint(x: 0.0062763751595745765d, y: 0.5476734256279887d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992676074410012d, y: 0.970887726122123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852333555602305d, y: 0.04424995985074065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882079320158252d, y: 0.43343092491328716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252478564741531d, y: 0.6004926663492037d)),
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.567963497593003d, y: 0.10733955265630901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2500067654476319d, y: 0.2669627620846602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9033556018053883d, y: 0.39127966157347904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9595184133740257d, y: 0.5027655970487002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2418186605080821d, y: 0.15513423922650682d), new NpgsqlTypes.NpgsqlPoint(x: 0.1948665657500369d, y: 0.5260445277266815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6357904964173886d, y: 0.6882154134215613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4332086531323639d, y: 0.49196818829468225d), new NpgsqlTypes.NpgsqlPoint(x: 0.002208419736533962d, y: 0.5842357480233628d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5668233581501892d, y: 0.24703471976946223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702551811887593d, y: 0.0032329157295720723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384986006196055d, y: 0.47222461870398347d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296347368253304d, y: 0.16006863930981596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6031476397181124d, y: 0.8964397447665632d), new NpgsqlTypes.NpgsqlPoint(x: 0.14282944622378924d, y: 0.12745226721327896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6318521672469529d, y: 0.07131044817781351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5243557532343046d, y: 0.4014309681066607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7889598536341619d, y: 0.8572947490426244d)),
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
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6332260087480681d, y: 0.2931568795342855d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731518014953941d, y: 0.03961748856939529d), new NpgsqlTypes.NpgsqlPoint(x: 0.8902352445253238d, y: 0.47820416383507935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6897915933043081d, y: 0.9073029028567535d), new NpgsqlTypes.NpgsqlPoint(x: 0.04902690966074008d, y: 0.20619593704186856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7747897042920148d, y: 0.46516648919026693d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23338503877575567d, y: 0.7528920050938788d), new NpgsqlTypes.NpgsqlPoint(x: 0.91435893516466d, y: 0.08195214113729488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8563553606095936d, y: 0.31524664797646773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6555671069892052d, y: 0.4856786643872937d), new NpgsqlTypes.NpgsqlPoint(x: 0.39072477874344547d, y: 0.4065010424539618d), new NpgsqlTypes.NpgsqlPoint(x: 0.011674964167589952d, y: 0.9522335997333423d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07744264297886883d, y: 0.3391538496696739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513484654101042d, y: 0.9667821562089342d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556542598351409d, y: 0.8251517973296607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5173501386581594d, y: 0.29584795164215494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236060258491107d, y: 0.4418177559332924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091096098636356d, y: 0.7223351471645566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5977063390783451d, y: 0.9924878600887358d), new NpgsqlTypes.NpgsqlPoint(x: 0.298961213254024d, y: 0.09495902989882721d), new NpgsqlTypes.NpgsqlPoint(x: 0.042050549508589d, y: 0.701910820636424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305022057704977d, y: 0.07118405126456673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827264845706609d, y: 0.7080053013279337d), new NpgsqlTypes.NpgsqlPoint(x: 0.9575881012476226d, y: 0.1423315045932635d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
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
                parametr2.Value = 189;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 36, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 36, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 155, query1, 129, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 169, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

