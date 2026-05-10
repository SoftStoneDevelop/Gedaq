

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3446211671231305d,right: 0.8551800691761533d,bottom: 0.11487647035731796d,left: 0.36010279333033357d),
new NpgsqlTypes.NpgsqlBox(top: 0.6223708604841389d,right: 0.5552126984171732d,bottom: 0.4149494453121316d,left: 0.40770250646618456d),
new NpgsqlTypes.NpgsqlBox(top: 0.8631454625496827d,right: 0.7515917468479335d,bottom: 0.8462860292296177d,left: 0.3205722312239224d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.08177067557592566d,right: 0.6231833336664402d,bottom: 0.04432395509393938d,left: 0.01236999937139871d),
new NpgsqlTypes.NpgsqlBox(top: 0.9656937742508812d,right: 0.9058358022794276d,bottom: 0.41349892359670304d,left: 0.17025200634042614d),
new NpgsqlTypes.NpgsqlBox(top: 0.4446516432599237d,right: 0.022274769361037006d,bottom: 0.09003466744806199d,left: 0.004748496729972684d),
new NpgsqlTypes.NpgsqlBox(top: 0.680590528745702d,right: 0.6289650056648183d,bottom: 0.33149174820133565d,left: 0.5282268526227621d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6554385127247742d,right: 0.9553974185159968d,bottom: 0.33235457950151914d,left: 0.08754020538531038d),
new NpgsqlTypes.NpgsqlBox(top: 0.505613421694526d,right: 0.29559929536376417d,bottom: 0.01439990526526791d,left: 0.15789051870725523d),
new NpgsqlTypes.NpgsqlBox(top: 0.3592879844994138d,right: 0.5694825378941687d,bottom: 0.14965117295694552d,left: 0.4457209672703626d),
new NpgsqlTypes.NpgsqlBox(top: 0.996928101300523d,right: 0.851595059330304d,bottom: 0.690741551727143d,left: 0.1349832704856584d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.871675851528823d,right: 0.8002601142766269d,bottom: 0.8194872863621705d,left: 0.42325458892416223d),
new NpgsqlTypes.NpgsqlBox(top: 0.8703914347249401d,right: 0.4333639373376157d,bottom: 0.8075597765878891d,left: 0.17434252902946956d),
new NpgsqlTypes.NpgsqlBox(top: 0.3286371700777445d,right: 0.8385790600490289d,bottom: 0.14040773734161638d,left: 0.6675440017318425d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5261728541690883d,right: 0.8768910079674482d,bottom: 0.23820442727631452d,left: 0.8037099221687778d),
new NpgsqlTypes.NpgsqlBox(top: 0.9052874900395774d,right: 0.21501265423550342d,bottom: 0.4301158111909499d,left: 0.11987840798769789d),
new NpgsqlTypes.NpgsqlBox(top: 0.346276119220166d,right: 0.8957030979648285d,bottom: 0.2557331719664159d,left: 0.3752778056797823d),
new NpgsqlTypes.NpgsqlBox(top: 0.9980100245027105d,right: 0.7299837751503245d,bottom: 0.3826268120750973d,left: 0.18989212223187046d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9863450199895069d,right: 0.9425915398463627d,bottom: 0.02537770626189928d,left: 0.6982192611761966d),
new NpgsqlTypes.NpgsqlBox(top: 0.9297046212963302d,right: 0.6148903870508574d,bottom: 0.6391196021192647d,left: 0.08910782356273228d),
new NpgsqlTypes.NpgsqlBox(top: 0.7893709869661226d,right: 0.7202415453012392d,bottom: 0.7762047473231952d,left: 0.6813597819442863d),
new NpgsqlTypes.NpgsqlBox(top: 0.5799310705095326d,right: 0.7246814075964854d,bottom: 0.14237067125060265d,left: 0.10200565879991907d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7143992735588857d,right: 0.6672742772840964d,bottom: 0.28128575985849735d,left: 0.3086269746111956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9444237246490317d,right: 0.9595851885216875d,bottom: 0.9122898247589916d,left: 0.48944478189946283d),
new NpgsqlTypes.NpgsqlBox(top: 0.3418462941635062d,right: 0.8904852463588354d,bottom: 0.22773808201665247d,left: 0.17835911900926937d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8372172854373714d,right: 0.9514604977973702d,bottom: 0.6118295009893845d,left: 0.3648735545819376d),
new NpgsqlTypes.NpgsqlBox(top: 0.8672906137210401d,right: 0.9476589878999028d,bottom: 0.011748528442614536d,left: 0.7087687952150084d),
new NpgsqlTypes.NpgsqlBox(top: 0.6193696192379684d,right: 0.3819254635897782d,bottom: 0.3066116811498877d,left: 0.14514062187261567d),
new NpgsqlTypes.NpgsqlBox(top: 0.433865830229059d,right: 0.4284126382092238d,bottom: 0.03681426682254951d,left: 0.3126036972074969d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42052425079760125d,right: 0.8351244396094901d,bottom: 0.1466700751840353d,left: 0.3686645055891654d),
new NpgsqlTypes.NpgsqlBox(top: 0.6031702527897134d,right: 0.4747362746016238d,bottom: 0.21561055301262477d,left: 0.09076353717163543d),
new NpgsqlTypes.NpgsqlBox(top: 0.9944883607188248d,right: 0.8048615296755753d,bottom: 0.78303446815849d,left: 0.058461507041897565d),
new NpgsqlTypes.NpgsqlBox(top: 0.45102390648932533d,right: 0.8908619406907345d,bottom: 0.18917257500023277d,left: 0.7459680263960445d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9072673951511553d,right: 0.7916283809113212d,bottom: 0.017462317094588675d,left: 0.07955229661181773d),
new NpgsqlTypes.NpgsqlBox(top: 0.6505529998323913d,right: 0.6805937328819776d,bottom: 0.3034719453989324d,left: 0.2729607833896962d),
new NpgsqlTypes.NpgsqlBox(top: 0.4053313800345806d,right: 0.9698916311371589d,bottom: 0.34762319693446586d,left: 0.3564907234794389d),
new NpgsqlTypes.NpgsqlBox(top: 0.94500608742956d,right: 0.6456501431234368d,bottom: 0.38410528099236296d,left: 0.05075452430143046d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.691732509972447d,right: 0.3679076854815796d,bottom: 0.09074782022478867d,left: 0.17494658105522187d),
new NpgsqlTypes.NpgsqlBox(top: 0.9651013945328932d,right: 0.4475719097131243d,bottom: 0.5660135302387171d,left: 0.42695052944444145d),
new NpgsqlTypes.NpgsqlBox(top: 0.6516600514776749d,right: 0.05599674689330114d,bottom: 0.41931447644588216d,left: 0.02353707274425665d),
new NpgsqlTypes.NpgsqlBox(top: 0.8528189112122465d,right: 0.9962178336614322d,bottom: 0.6859906090984215d,left: 0.3961827424602873d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5829921468725912d,right: 0.6972197436413741d,bottom: 0.5139713016991634d,left: 0.16291691414439102d),
new NpgsqlTypes.NpgsqlBox(top: 0.9963518172576479d,right: 0.793396507590992d,bottom: 0.1758482826193738d,left: 0.09236591391029003d),
new NpgsqlTypes.NpgsqlBox(top: 0.772253132634675d,right: 0.09232401991084505d,bottom: 0.1833918066724467d,left: 0.027006486261172413d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.757990224566452d,right: 0.9514013830840523d,bottom: 0.645280899942832d,left: 0.40459602996794697d),
new NpgsqlTypes.NpgsqlBox(top: 0.7677276582998738d,right: 0.3667201245986672d,bottom: 0.6943042466296966d,left: 0.05082573380206101d),
new NpgsqlTypes.NpgsqlBox(top: 0.7420782129777851d,right: 0.529577803278093d,bottom: 0.041444036033933096d,left: 0.277345476102719d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7642571091540898d,right: 0.4520597842918126d,bottom: 0.09457155047859922d,left: 0.03524149589878667d),
new NpgsqlTypes.NpgsqlBox(top: 0.6691443263931859d,right: 0.7971070691452575d,bottom: 0.4442344353301356d,left: 0.011390656197844629d),
new NpgsqlTypes.NpgsqlBox(top: 0.9188939414684549d,right: 0.9646920686010723d,bottom: 0.12457058380552621d,left: 0.6660351357108573d),
new NpgsqlTypes.NpgsqlBox(top: 0.541776746434589d,right: 0.6102679602059619d,bottom: 0.4628778899775925d,left: 0.5450615529513427d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9897497876869941d,right: 0.507854716086435d,bottom: 0.3971328385118703d,left: 0.25094365293946297d),
new NpgsqlTypes.NpgsqlBox(top: 0.32097959483375005d,right: 0.84936358976159d,bottom: 0.22285348245946734d,left: 0.5125245108949348d),
new NpgsqlTypes.NpgsqlBox(top: 0.8441168293520068d,right: 0.7908847985722429d,bottom: 0.5931900468230797d,left: 0.6830446818763294d),
new NpgsqlTypes.NpgsqlBox(top: 0.4889306593097149d,right: 0.8071086598157435d,bottom: 0.05440938733014422d,left: 0.5272341706721518d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.47719372644141644d,right: 0.8504114792024524d,bottom: 0.07342012143923093d,left: 0.6759435840068968d),
new NpgsqlTypes.NpgsqlBox(top: 0.33954877558501717d,right: 0.3142840384223483d,bottom: 0.31676154772944254d,left: 0.18548595475043128d),
new NpgsqlTypes.NpgsqlBox(top: 0.09426493353113419d,right: 0.6260797821299187d,bottom: 0.035973710090854705d,left: 0.059743087307548404d),
new NpgsqlTypes.NpgsqlBox(top: 0.5017657235361784d,right: 0.6421213124707809d,bottom: 0.123196884335801d,left: 0.31905508554551887d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3359004633245749d,right: 0.45821969635184756d,bottom: 0.20207758518265195d,left: 0.2528745030709699d),
new NpgsqlTypes.NpgsqlBox(top: 0.7838717928396285d,right: 0.8969019373763834d,bottom: 0.7008193975176543d,left: 0.2752157919059388d),
new NpgsqlTypes.NpgsqlBox(top: 0.653657241914915d,right: 0.49531971154923005d,bottom: 0.6131017016557252d,left: 0.29189370818139115d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7988575687380243d,right: 0.5127872855430982d,bottom: 0.5543570128696886d,left: 0.14900438376006742d),
new NpgsqlTypes.NpgsqlBox(top: 0.7534746443504489d,right: 0.8686228162087128d,bottom: 0.46575750275972316d,left: 0.3623656158153563d),
new NpgsqlTypes.NpgsqlBox(top: 0.9099157515267354d,right: 0.827994199951409d,bottom: 0.14535494895324563d,left: 0.07888924579285395d),
new NpgsqlTypes.NpgsqlBox(top: 0.6446694090595921d,right: 0.246841201571952d,bottom: 0.36180149014874374d,left: 0.055304182994131534d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8640218526418637d,right: 0.9420699699461531d,bottom: 0.1802534591105227d,left: 0.20036159395893116d),
new NpgsqlTypes.NpgsqlBox(top: 0.7747573199074137d,right: 0.877048359338168d,bottom: 0.49846820742797815d,left: 0.11108066730401212d),
new NpgsqlTypes.NpgsqlBox(top: 0.9472719414947613d,right: 0.48930786615121047d,bottom: 0.8952243731445829d,left: 0.22017975655320954d),
new NpgsqlTypes.NpgsqlBox(top: 0.7710292249778089d,right: 0.7335350975045223d,bottom: 0.5619552549853878d,left: 0.298818234344836d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4400411284594111d,right: 0.9961000093756899d,bottom: 0.2992078631384353d,left: 0.9632973691404513d),
new NpgsqlTypes.NpgsqlBox(top: 0.37677532265903824d,right: 0.9784420724061739d,bottom: 0.2891165246439008d,left: 0.682898694681749d),
new NpgsqlTypes.NpgsqlBox(top: 0.35207969084827695d,right: 0.7966858676856527d,bottom: 0.04822005659089401d,left: 0.24950577802080987d),
new NpgsqlTypes.NpgsqlBox(top: 0.5723339250158824d,right: 0.9478609057640002d,bottom: 0.04505406878681095d,left: 0.09977721673822315d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8667376922524562d,right: 0.8460370184277702d,bottom: 0.5566908137214196d,left: 0.052781013096225404d),
new NpgsqlTypes.NpgsqlBox(top: 0.8083318083980422d,right: 0.9299375952174579d,bottom: 0.7130082005393981d,left: 0.04486196627402972d),
new NpgsqlTypes.NpgsqlBox(top: 0.9798477965513243d,right: 0.9470410683754646d,bottom: 0.9026825646221651d,left: 0.7284972337986892d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6487697263629262d,right: 0.32708943727804807d,bottom: 0.10118448032786753d,left: 0.12521237584791678d),
new NpgsqlTypes.NpgsqlBox(top: 0.3777427514174072d,right: 0.9648066431643058d,bottom: 0.22295995651452982d,left: 0.08807737731300347d),
new NpgsqlTypes.NpgsqlBox(top: 0.8189091436431214d,right: 0.9109222829660538d,bottom: 0.3884372962171535d,left: 0.6545662154603868d),
new NpgsqlTypes.NpgsqlBox(top: 0.5966273716584591d,right: 0.43123004978734314d,bottom: 0.12221420031495422d,left: 0.016415268737217437d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5412608219585793d,right: 0.8328225354967584d,bottom: 0.11915008588857046d,left: 0.42445411772575214d),
new NpgsqlTypes.NpgsqlBox(top: 0.7054852003298073d,right: 0.1990931508144721d,bottom: 0.10820438830426593d,left: 0.1442975211974339d),
new NpgsqlTypes.NpgsqlBox(top: 0.9987160437228091d,right: 0.6510520966555551d,bottom: 0.5888895931055041d,left: 0.16576717890484294d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8407647753474754d,right: 0.9744521659781339d,bottom: 0.4379801315576324d,left: 0.10409139710930815d),
new NpgsqlTypes.NpgsqlBox(top: 0.9002801650151602d,right: 0.09506396482177715d,bottom: 0.03543724770292267d,left: 0.05448130266797402d),
new NpgsqlTypes.NpgsqlBox(top: 0.8008112530048569d,right: 0.501398952644402d,bottom: 0.42964950217501585d,left: 0.15133752012377866d),
new NpgsqlTypes.NpgsqlBox(top: 0.9348174468808117d,right: 0.8401043092349463d,bottom: 0.19925243506490897d,left: 0.5789313448325849d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7672428356690655d,right: 0.7267059001264586d,bottom: 0.4178189682063207d,left: 0.5938141806302191d),
new NpgsqlTypes.NpgsqlBox(top: 0.9757777438546081d,right: 0.7124295418101719d,bottom: 0.24958953645043558d,left: 0.26019607682085366d),
new NpgsqlTypes.NpgsqlBox(top: 0.3263452328974039d,right: 0.7482584070747784d,bottom: 0.28288074710378885d,left: 0.0167775410153973d),
new NpgsqlTypes.NpgsqlBox(top: 0.7533274643029999d,right: 0.7698292675700898d,bottom: 0.16686533958970395d,left: 0.5637498928687315d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9926599641948693d,right: 0.6400717095566987d,bottom: 0.9312504163699218d,left: 0.10224926133697276d),
new NpgsqlTypes.NpgsqlBox(top: 0.5555282597944364d,right: 0.6953978734708498d,bottom: 0.4931631773085069d,left: 0.5900792831643509d),
new NpgsqlTypes.NpgsqlBox(top: 0.9445577435151976d,right: 0.9676388864242909d,bottom: 0.385628462583786d,left: 0.8318136041006827d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9825153996533323d,right: 0.43720564438678866d,bottom: 0.7047097828231301d,left: 0.06869803719739231d),
new NpgsqlTypes.NpgsqlBox(top: 0.23254103574202412d,right: 0.9104701226772516d,bottom: 0.08749644505579635d,left: 0.3945400154231291d),
new NpgsqlTypes.NpgsqlBox(top: 0.698428486210396d,right: 0.3524846849863159d,bottom: 0.3628228047287d,left: 0.281981231008391d),
new NpgsqlTypes.NpgsqlBox(top: 0.9358009702830994d,right: 0.7340456010090893d,bottom: 0.4823186823396648d,left: 0.37033583897839895d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9517418710080731d,right: 0.49812916935737805d,bottom: 0.849319878733953d,left: 0.3575828487786835d),
new NpgsqlTypes.NpgsqlBox(top: 0.9516426383676856d,right: 0.14476399186734712d,bottom: 0.3050003541719851d,left: 0.11569400803512309d),
new NpgsqlTypes.NpgsqlBox(top: 0.2702050771820077d,right: 0.7058802506207909d,bottom: 0.1753121869165014d,left: 0.27473642334242476d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.051247040103160835d,right: 0.6463130212228135d,bottom: 0.03389005788187094d,left: 0.020275246136021274d),
new NpgsqlTypes.NpgsqlBox(top: 0.8471777830334299d,right: 0.6203311111770773d,bottom: 0.37027602723528386d,left: 0.3894563844950657d),
new NpgsqlTypes.NpgsqlBox(top: 0.7689675941551013d,right: 0.9077596000664788d,bottom: 0.33230812834155044d,left: 0.7283665522974833d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.11720993602050889d,right: 0.29758245171428244d,bottom: 0.11253962224440384d,left: 0.02746696655678804d),
new NpgsqlTypes.NpgsqlBox(top: 0.9980922930586976d,right: 0.10191549473384587d,bottom: 0.6587207351245695d,left: 0.03205056728777578d),
new NpgsqlTypes.NpgsqlBox(top: 0.45299871965645555d,right: 0.5276190299349552d,bottom: 0.11276252973527356d,left: 0.4583832298904075d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.48436005204389054d,right: 0.3490575184009802d,bottom: 0.20479963009091728d,left: 0.16230951121738912d),
new NpgsqlTypes.NpgsqlBox(top: 0.8452306308069005d,right: 0.8334286469388497d,bottom: 0.6776851756722412d,left: 0.3049099051334969d),
new NpgsqlTypes.NpgsqlBox(top: 0.7526754010481919d,right: 0.14086677886246635d,bottom: 0.03225599349163877d,left: 0.0814547566255096d),
new NpgsqlTypes.NpgsqlBox(top: 0.27266334768705613d,right: 0.15553067746279126d,bottom: 0.2621904557167346d,left: 0.05679218692036103d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9715396826026973d,right: 0.2820574572497775d,bottom: 0.23088693049364217d,left: 0.05333425663821023d),
new NpgsqlTypes.NpgsqlBox(top: 0.725855951364766d,right: 0.4278349199047814d,bottom: 0.37144636893112626d,left: 0.38562868760560554d),
new NpgsqlTypes.NpgsqlBox(top: 0.7597442465647041d,right: 0.7481805768738944d,bottom: 0.1153892275218229d,left: 0.4218943469318799d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5361250091612233d,right: 0.3973830311633517d,bottom: 0.1739433851999097d,left: 0.313213214706095d),
new NpgsqlTypes.NpgsqlBox(top: 0.6617403441280167d,right: 0.2949584865993524d,bottom: 0.1348092518463554d,left: 0.24058917094003085d),
new NpgsqlTypes.NpgsqlBox(top: 0.7137219719572723d,right: 0.8858118848435068d,bottom: 0.5322236322463417d,left: 0.44932336115645033d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6417224539994838d,right: 0.5918148140928455d,bottom: 0.14125283319499382d,left: 0.3782688866182279d),
new NpgsqlTypes.NpgsqlBox(top: 0.7810898333623257d,right: 0.5254369900960009d,bottom: 0.573625037330512d,left: 0.08998489075024196d),
new NpgsqlTypes.NpgsqlBox(top: 0.7464998700798753d,right: 0.8035261772729215d,bottom: 0.1434984562237842d,left: 0.7898894517811276d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.38390078611737244d,right: 0.8182276540421366d,bottom: 0.1989651249636918d,left: 0.5383617727307227d),
new NpgsqlTypes.NpgsqlBox(top: 0.9001946969800237d,right: 0.5457810524032889d,bottom: 0.8660104794147719d,left: 0.42218764740123993d),
new NpgsqlTypes.NpgsqlBox(top: 0.4548635906723695d,right: 0.6009532452442347d,bottom: 0.2289455661284675d,left: 0.2851245783305262d),
new NpgsqlTypes.NpgsqlBox(top: 0.8251263870500934d,right: 0.5041533134934192d,bottom: 0.7744497310837279d,left: 0.45941180148304095d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.13706516631487453d,right: 0.8271480536886999d,bottom: 0.10591074045540039d,left: 0.32166815962405626d),
new NpgsqlTypes.NpgsqlBox(top: 0.7547223791458433d,right: 0.7357249204027433d,bottom: 0.08795029305699986d,left: 0.40742301105020373d),
new NpgsqlTypes.NpgsqlBox(top: 0.3309945523658392d,right: 0.7865712325699826d,bottom: 0.11276724751093237d,left: 0.3697686006130506d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10707069785894119d,right: 0.6223641923063707d,bottom: 0.0884714576386102d,left: 0.13554972222700523d),
new NpgsqlTypes.NpgsqlBox(top: 0.5352947634930566d,right: 0.989213362318636d,bottom: 0.15082048623796063d,left: 0.22552879623390587d),
new NpgsqlTypes.NpgsqlBox(top: 0.7308410096646831d,right: 0.9304602130774661d,bottom: 0.16919244452433524d,left: 0.6760477085236979d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4499239417850699d,right: 0.9504066287118176d,bottom: 0.3028980508903537d,left: 0.584976123339941d),
new NpgsqlTypes.NpgsqlBox(top: 0.8939610437618614d,right: 0.8690867391640044d,bottom: 0.03565300545595762d,left: 0.16663247701499062d),
new NpgsqlTypes.NpgsqlBox(top: 0.5719434267435552d,right: 0.8875575951859183d,bottom: 0.507196147507625d,left: 0.10579436961514976d),
new NpgsqlTypes.NpgsqlBox(top: 0.9993529438277778d,right: 0.7564630115548355d,bottom: 0.24948125295198376d,left: 0.5771972360532848d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8189579848295452d,right: 0.3968749128358642d,bottom: 0.7148779163439178d,left: 0.060834638832619525d),
new NpgsqlTypes.NpgsqlBox(top: 0.595512342279425d,right: 0.8697621966940975d,bottom: 0.4234837694579594d,left: 0.6696336794713506d),
new NpgsqlTypes.NpgsqlBox(top: 0.9128588052514591d,right: 0.6557617804146308d,bottom: 0.3899392972120841d,left: 0.5875883600425693d),
new NpgsqlTypes.NpgsqlBox(top: 0.7606907183393828d,right: 0.5353592533154702d,bottom: 0.10666766814390649d,left: 0.28291601374691044d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2857529373673725d,right: 0.9148133823295768d,bottom: 0.23251073465642857d,left: 0.09224447391117963d),
new NpgsqlTypes.NpgsqlBox(top: 0.3045130235830611d,right: 0.41740999200476436d,bottom: 0.13819607926563127d,left: 0.13737453462055438d),
new NpgsqlTypes.NpgsqlBox(top: 0.792819579640713d,right: 0.8296281265252349d,bottom: 0.5043674877735873d,left: 0.34223877765183885d),
new NpgsqlTypes.NpgsqlBox(top: 0.6552531728459973d,right: 0.8078745952968012d,bottom: 0.3386157426762766d,left: 0.7623631185851084d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8897148421641259d,right: 0.5658312818091148d,bottom: 0.5371445127200662d,left: 0.4885472348688029d),
new NpgsqlTypes.NpgsqlBox(top: 0.76295785957996d,right: 0.9415933134832427d,bottom: 0.44198481822053937d,left: 0.8168261553229028d),
new NpgsqlTypes.NpgsqlBox(top: 0.807851908086448d,right: 0.572766696812724d,bottom: 0.053359806491704576d,left: 0.19899108181287883d),
new NpgsqlTypes.NpgsqlBox(top: 0.8365089958326316d,right: 0.81429060421652d,bottom: 0.7656372945406761d,left: 0.21195417487431534d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9085689445639036d,right: 0.8015885810297597d,bottom: 0.10559169214466879d,left: 0.3055433014433553d),
new NpgsqlTypes.NpgsqlBox(top: 0.46981294441921484d,right: 0.46584581013865767d,bottom: 0.23911340714226292d,left: 0.3205959908556014d),
new NpgsqlTypes.NpgsqlBox(top: 0.8591377671738741d,right: 0.8647108956475978d,bottom: 0.20599548797387945d,left: 0.05656422488148238d),
new NpgsqlTypes.NpgsqlBox(top: 0.9597692600367563d,right: 0.7207553524654181d,bottom: 0.5286831582711305d,left: 0.12637254900768513d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.29535707865611294d,right: 0.4856968687205582d,bottom: 0.2627083363898246d,left: 0.38737614101197737d),
new NpgsqlTypes.NpgsqlBox(top: 0.8917819193091566d,right: 0.6958929058031839d,bottom: 0.4808399006598748d,left: 0.5334373715224263d),
new NpgsqlTypes.NpgsqlBox(top: 0.4250026215383862d,right: 0.5240373099322568d,bottom: 0.03187478191412707d,left: 0.3840882920018781d),
new NpgsqlTypes.NpgsqlBox(top: 0.5450737894092709d,right: 0.5611894992542309d,bottom: 0.519092200657766d,left: 0.36212391731513427d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8739269615403393d,right: 0.5534324292501389d,bottom: 0.3550142965154338d,left: 0.2930531911007155d),
new NpgsqlTypes.NpgsqlBox(top: 0.4410674810590226d,right: 0.36867028634942456d,bottom: 0.3573376670793359d,left: 0.09327038224358164d),
new NpgsqlTypes.NpgsqlBox(top: 0.6850390284505619d,right: 0.8760390969221281d,bottom: 0.6373080666040379d,left: 0.705874012267268d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7967202876620106d,right: 0.37843564326752155d,bottom: 0.42430547454388723d,left: 0.06460557566295733d),
new NpgsqlTypes.NpgsqlBox(top: 0.4603340013709667d,right: 0.5918450012673351d,bottom: 0.2203157677246247d,left: 0.11574774409370026d),
new NpgsqlTypes.NpgsqlBox(top: 0.8797406895804378d,right: 0.5374225361660152d,bottom: 0.6247055344452934d,left: 0.24342927384852486d),
new NpgsqlTypes.NpgsqlBox(top: 0.44330152795259015d,right: 0.6104010300429299d,bottom: 0.4053135593537597d,left: 0.20684740554141834d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4623693570933971d,right: 0.9739153670855248d,bottom: 0.28498325576661376d,left: 0.5123410302209271d),
new NpgsqlTypes.NpgsqlBox(top: 0.4823503269219248d,right: 0.5179480830274501d,bottom: 0.43012271480337483d,left: 0.17675246031975034d),
new NpgsqlTypes.NpgsqlBox(top: 0.7778853999992454d,right: 0.9075574708622884d,bottom: 0.22705165227000812d,left: 0.2617434241191521d),
new NpgsqlTypes.NpgsqlBox(top: 0.8876849959617972d,right: 0.7762570196089794d,bottom: 0.42091660351797666d,left: 0.48359235530134637d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8154923629048915d,right: 0.7978217965633563d,bottom: 0.7289965799119873d,left: 0.6857744431024844d),
new NpgsqlTypes.NpgsqlBox(top: 0.6652169172136686d,right: 0.9130585168186234d,bottom: 0.6384869982433053d,left: 0.8412145322367108d),
new NpgsqlTypes.NpgsqlBox(top: 0.980873670171829d,right: 0.9651434342411243d,bottom: 0.3097742078629594d,left: 0.6717540454551406d),
new NpgsqlTypes.NpgsqlBox(top: 0.7841839754329133d,right: 0.5631621985684151d,bottom: 0.4922266135784171d,left: 0.16338559879274572d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4771015452875421d,right: 0.9684475302299094d,bottom: 0.43620604812433783d,left: 0.08481077972268747d),
new NpgsqlTypes.NpgsqlBox(top: 0.5153534809890583d,right: 0.6721951368413318d,bottom: 0.48217214311857504d,left: 0.5921875448841151d),
new NpgsqlTypes.NpgsqlBox(top: 0.2076733562785471d,right: 0.9582468325745155d,bottom: 0.16292895131800655d,left: 0.8374180574660861d),
new NpgsqlTypes.NpgsqlBox(top: 0.4566517305812622d,right: 0.5335752302781459d,bottom: 0.1334102315770489d,left: 0.35076287815209084d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.21205363958079215d,right: 0.8319029399065838d,bottom: 0.10313770942825451d,left: 0.6425091144811408d),
new NpgsqlTypes.NpgsqlBox(top: 0.24613860004990307d,right: 0.8968448400662177d,bottom: 0.0418528008148612d,left: 0.0747868925253804d),
new NpgsqlTypes.NpgsqlBox(top: 0.47931091749425747d,right: 0.9220478724069933d,bottom: 0.3386580375443362d,left: 0.5599632061925233d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6715676184682663d,right: 0.8001943011922469d,bottom: 0.3464947989564987d,left: 0.324257593038629d),
new NpgsqlTypes.NpgsqlBox(top: 0.8931117912891331d,right: 0.5703567955418558d,bottom: 0.08921716840960559d,left: 0.1352531393862153d),
new NpgsqlTypes.NpgsqlBox(top: 0.44544607682188464d,right: 0.9028251950144429d,bottom: 0.04715030707807921d,left: 0.01652962903590649d),
new NpgsqlTypes.NpgsqlBox(top: 0.8950835888502138d,right: 0.6438176935865652d,bottom: 0.6181206089739977d,left: 0.3106353698890666d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.36239408139078455d,right: 0.7740488055534341d,bottom: 0.30991572629852937d,left: 0.07930273101419583d),
new NpgsqlTypes.NpgsqlBox(top: 0.8393224467826186d,right: 0.8543386012761418d,bottom: 0.12821827101485317d,left: 0.7608217088030337d),
new NpgsqlTypes.NpgsqlBox(top: 0.39822838763249624d,right: 0.32120042538215177d,bottom: 0.15325519856810166d,left: 0.17559152824494262d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9851078399096006d,right: 0.8777703875561537d,bottom: 0.015865825080452645d,left: 0.5155605584979039d),
new NpgsqlTypes.NpgsqlBox(top: 0.6101461380725907d,right: 0.9594978552632287d,bottom: 0.05220503709778335d,left: 0.4968196983061933d),
new NpgsqlTypes.NpgsqlBox(top: 0.7925259044648508d,right: 0.7416225204571671d,bottom: 0.4085648867617344d,left: 0.7326029536938874d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5191159259174473d,right: 0.881569394301687d,bottom: 0.5025147073940565d,left: 0.323824158584305d),
new NpgsqlTypes.NpgsqlBox(top: 0.6501580368391691d,right: 0.6687898684262836d,bottom: 0.29068779548535906d,left: 0.006825850648112253d),
new NpgsqlTypes.NpgsqlBox(top: 0.6805828315102663d,right: 0.6323493034988107d,bottom: 0.2422611888192957d,left: 0.480122330534669d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6164582773331952d,right: 0.9835138568082684d,bottom: 0.4716211153513572d,left: 0.8664164852580956d),
new NpgsqlTypes.NpgsqlBox(top: 0.543811653360207d,right: 0.7803444426917379d,bottom: 0.3192708819885859d,left: 0.5972691428316067d),
new NpgsqlTypes.NpgsqlBox(top: 0.8329012275043186d,right: 0.4548191650710811d,bottom: 0.3260968666829649d,left: 0.03525398484273956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9669526574416571d,right: 0.6299151926113614d,bottom: 0.8126457857038497d,left: 0.5179764264516419d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3034181294836671d,right: 0.35588934888679946d,bottom: 0.021197097132802933d,left: 0.10813440387943674d),
new NpgsqlTypes.NpgsqlBox(top: 0.9195482561008487d,right: 0.9549973434677328d,bottom: 0.5550677710042872d,left: 0.24564591325978413d),
new NpgsqlTypes.NpgsqlBox(top: 0.7167425181999734d,right: 0.9459045451575411d,bottom: 0.6258711057465127d,left: 0.8853699466900568d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8108581953999308d,right: 0.7232777745068303d,bottom: 0.6928527895512537d,left: 0.2973880339288839d),
new NpgsqlTypes.NpgsqlBox(top: 0.942645124082629d,right: 0.8745234220415979d,bottom: 0.016036674624301583d,left: 0.46897226223229527d),
new NpgsqlTypes.NpgsqlBox(top: 0.9704311418828473d,right: 0.40810910258132915d,bottom: 0.929524203728178d,left: 0.16582240465379283d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.08571571975152359d,right: 0.32827834126225697d,bottom: 0.06291672924314706d,left: 0.09738936169802082d),
new NpgsqlTypes.NpgsqlBox(top: 0.47376110665445215d,right: 0.3254386724999546d,bottom: 0.3543575864950784d,left: 0.15399906692161114d),
new NpgsqlTypes.NpgsqlBox(top: 0.9650521031181594d,right: 0.6531282021749002d,bottom: 0.25235812148767267d,left: 0.38001745598240033d),
new NpgsqlTypes.NpgsqlBox(top: 0.9595627618919845d,right: 0.6790811646761704d,bottom: 0.5549471077498371d,left: 0.0015426014937217625d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5023606842047513d,right: 0.7915374995307494d,bottom: 0.39455847350615647d,left: 0.5871413836519378d),
new NpgsqlTypes.NpgsqlBox(top: 0.9743496529620305d,right: 0.3257042452536354d,bottom: 0.8286378541041253d,left: 0.036710461712098685d),
new NpgsqlTypes.NpgsqlBox(top: 0.7974887568588892d,right: 0.6115783561102505d,bottom: 0.061852742075292455d,left: 0.42051602708080693d),
new NpgsqlTypes.NpgsqlBox(top: 0.2617944743578723d,right: 0.7817917899933476d,bottom: 0.1670731609360303d,left: 0.714153605604602d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9812309562825373d,right: 0.9172380586194349d,bottom: 0.3683039614020105d,left: 0.21933581853079975d),
new NpgsqlTypes.NpgsqlBox(top: 0.7010968560818842d,right: 0.7526782383739389d,bottom: 0.6624284037118642d,left: 0.28843830855986174d),
new NpgsqlTypes.NpgsqlBox(top: 0.734638173046138d,right: 0.7551649470812415d,bottom: 0.2907970044695656d,left: 0.5073535837257503d),
new NpgsqlTypes.NpgsqlBox(top: 0.4782546210765328d,right: 0.3558317295193488d,bottom: 0.251950389121267d,left: 0.029296932987811997d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5491279359014715d,right: 0.86228471400432d,bottom: 0.22077176113590913d,left: 0.651832761495654d),
new NpgsqlTypes.NpgsqlBox(top: 0.693770681811126d,right: 0.46432736889129844d,bottom: 0.39441063065752513d,left: 0.08760453076628383d),
new NpgsqlTypes.NpgsqlBox(top: 0.6954429503168097d,right: 0.703006467073721d,bottom: 0.27347337006488004d,left: 0.3571391342892217d),
new NpgsqlTypes.NpgsqlBox(top: 0.3972564769618604d,right: 0.47585969379967685d,bottom: 0.22745784841897732d,left: 0.0021130073843533825d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41464132119928265d,right: 0.9486083648234956d,bottom: 0.25781262219053835d,left: 0.07539115045874345d),
new NpgsqlTypes.NpgsqlBox(top: 0.6077034646490725d,right: 0.08257844934288117d,bottom: 0.5131924758244671d,left: 0.008478492089920575d),
new NpgsqlTypes.NpgsqlBox(top: 0.8344145339305502d,right: 0.9464926843977536d,bottom: 0.25670421841339996d,left: 0.49962481590452945d),
new NpgsqlTypes.NpgsqlBox(top: 0.826356988320637d,right: 0.9783247955924875d,bottom: 0.4735417286807637d,left: 0.6716532642740352d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9480835899197553d,right: 0.5528478206580467d,bottom: 0.15942317618971336d,left: 0.1414141256276511d),
new NpgsqlTypes.NpgsqlBox(top: 0.8912741304773537d,right: 0.40279690555120995d,bottom: 0.57524830611037d,left: 0.023211974502577948d),
new NpgsqlTypes.NpgsqlBox(top: 0.8478713447508007d,right: 0.8455816092817312d,bottom: 0.6422851016418081d,left: 0.07312337485468501d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6967111205227403d,right: 0.9594457350830224d,bottom: 0.5470405241809511d,left: 0.45096700426247827d),
new NpgsqlTypes.NpgsqlBox(top: 0.8542421606612373d,right: 0.547302618321654d,bottom: 0.25497285170158623d,left: 0.0966139414986319d),
new NpgsqlTypes.NpgsqlBox(top: 0.9811586109685033d,right: 0.47454678042783016d,bottom: 0.7271367727755724d,left: 0.40788466913759003d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9316796141828918d,right: 0.8785870701639776d,bottom: 0.41035747396650835d,left: 0.08553741433676376d),
new NpgsqlTypes.NpgsqlBox(top: 0.6305426787780541d,right: 0.6856497516748227d,bottom: 0.5494980060439821d,left: 0.03547740982621739d),
new NpgsqlTypes.NpgsqlBox(top: 0.7079166682830448d,right: 0.1236729344387173d,bottom: 0.20038084399966827d,left: 0.0953357244837495d),
new NpgsqlTypes.NpgsqlBox(top: 0.9296661727041853d,right: 0.7654927215384957d,bottom: 0.8700133184507891d,left: 0.15572469417542067d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3834084770609344d,right: 0.9370202285477941d,bottom: 0.1878187445405617d,left: 0.3165527687369797d),
new NpgsqlTypes.NpgsqlBox(top: 0.4707648220757723d,right: 0.8271039734910937d,bottom: 0.2898931755745061d,left: 0.5641090842090937d),
new NpgsqlTypes.NpgsqlBox(top: 0.4070351184772043d,right: 0.24828097510333957d,bottom: 0.1872079302699634d,left: 0.0014888492361020411d),
new NpgsqlTypes.NpgsqlBox(top: 0.5570669164882611d,right: 0.7690133017471502d,bottom: 0.03555209031567863d,left: 0.41921650297027035d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 161,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9087421813804618d,right: 0.3668775649993036d,bottom: 0.6462650116179737d,left: 0.027854847572909236d),
new NpgsqlTypes.NpgsqlBox(top: 0.5339198516364341d,right: 0.5687568183249465d,bottom: 0.08947502417709274d,left: 0.34643197016091176d),
new NpgsqlTypes.NpgsqlBox(top: 0.22822811349419625d,right: 0.343586642714816d,bottom: 0.19250508907658215d,left: 0.28032954637399055d),
new NpgsqlTypes.NpgsqlBox(top: 0.8698754490301585d,right: 0.986763723618749d,bottom: 0.08231662655801353d,left: 0.13863030363201356d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27841640851642835d,right: 0.5822547004514089d,bottom: 0.16155233751068598d,left: 0.46685906146760525d),
new NpgsqlTypes.NpgsqlBox(top: 0.27477191872114504d,right: 0.2888669515118898d,bottom: 0.11545083334028017d,left: 0.023611760990581265d),
new NpgsqlTypes.NpgsqlBox(top: 0.21107352121387568d,right: 0.7065207833579611d,bottom: 0.16659210441243355d,left: 0.07876223713902608d),
new NpgsqlTypes.NpgsqlBox(top: 0.45403780826534645d,right: 0.8068663080317191d,bottom: 0.050592274020206274d,left: 0.669426076832286d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7271436258253754d,right: 0.2929842122457067d,bottom: 0.3997932749696692d,left: 0.028155542150592905d),
new NpgsqlTypes.NpgsqlBox(top: 0.08500508385772565d,right: 0.9715894053601725d,bottom: 0.007388949102526854d,left: 0.07658896423870676d),
new NpgsqlTypes.NpgsqlBox(top: 0.8393248984645894d,right: 0.8121438628005334d,bottom: 0.11356239921156575d,left: 0.1187038303524286d),
new NpgsqlTypes.NpgsqlBox(top: 0.4258759592393784d,right: 0.6312299160930546d,bottom: 0.005719173220362528d,left: 0.4808138125333825d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6903617478663955d,right: 0.9823863837237905d,bottom: 0.3177030207083331d,left: 0.27581139091339524d),
new NpgsqlTypes.NpgsqlBox(top: 0.6855443654982509d,right: 0.8881678010624933d,bottom: 0.047065141906142194d,left: 0.6331215396007972d),
new NpgsqlTypes.NpgsqlBox(top: 0.3736435805160313d,right: 0.8707358105770844d,bottom: 0.19310919916504077d,left: 0.5661971336335139d),
new NpgsqlTypes.NpgsqlBox(top: 0.988731557433062d,right: 0.9962340551806274d,bottom: 0.6668283218212498d,left: 0.040792593609983996d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5372364027969584d,right: 0.8043067750903973d,bottom: 0.08081944320070888d,left: 0.33254836254122366d),
new NpgsqlTypes.NpgsqlBox(top: 0.6230057939128986d,right: 0.5911369360598222d,bottom: 0.38575418967834885d,left: 0.08198003292018397d),
new NpgsqlTypes.NpgsqlBox(top: 0.9246523661939837d,right: 0.579744665958689d,bottom: 0.4626063294804097d,left: 0.5420493460971084d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15828570796154628d,right: 0.7587820553174919d,bottom: 0.1278294862236119d,left: 0.4429244731447822d),
new NpgsqlTypes.NpgsqlBox(top: 0.6608708246505617d,right: 0.518867080719379d,bottom: 0.10499794824885766d,left: 0.02079877398552521d),
new NpgsqlTypes.NpgsqlBox(top: 0.6633500982428475d,right: 0.40747519178897895d,bottom: 0.471238865061539d,left: 0.3858307594920196d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9437220639705677d,right: 0.829571119424521d,bottom: 0.5400653197351681d,left: 0.24392308919183903d),
new NpgsqlTypes.NpgsqlBox(top: 0.7600844082366865d,right: 0.7102022425889332d,bottom: 0.7238212992050904d,left: 0.18825154074683592d),
new NpgsqlTypes.NpgsqlBox(top: 0.8030420888633897d,right: 0.7802014503301291d,bottom: 0.6490467699984159d,left: 0.2271564922441488d),
new NpgsqlTypes.NpgsqlBox(top: 0.6651016697187333d,right: 0.6066033452786801d,bottom: 0.27168877153376236d,left: 0.06505136751143437d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43829052664766777d,right: 0.9723556807652743d,bottom: 0.018320327523473123d,left: 0.0925947515924257d),
new NpgsqlTypes.NpgsqlBox(top: 0.37777138193675286d,right: 0.5665211214989212d,bottom: 0.28091901193214674d,left: 0.4849625091617974d),
new NpgsqlTypes.NpgsqlBox(top: 0.9322597056930695d,right: 0.8227361328025139d,bottom: 0.2144111244275464d,left: 0.28590452888301965d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8697001998279433d,right: 0.44465536061649125d,bottom: 0.008397199245022913d,left: 0.43513121568559143d),
new NpgsqlTypes.NpgsqlBox(top: 0.4120583619087115d,right: 0.9715735519856217d,bottom: 0.17279047216269117d,left: 0.3328251572643047d),
new NpgsqlTypes.NpgsqlBox(top: 0.2763104809913678d,right: 0.9806563765344337d,bottom: 0.22505794882901764d,left: 0.64239007378811d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1420002364436268d,right: 0.957441075057047d,bottom: 0.11576472784082181d,left: 0.5381644381617853d),
new NpgsqlTypes.NpgsqlBox(top: 0.7105669596153464d,right: 0.4920181843295576d,bottom: 0.16868777723358608d,left: 0.18658840668490517d),
new NpgsqlTypes.NpgsqlBox(top: 0.9607604524849188d,right: 0.6218808563634695d,bottom: 0.07599175563209593d,left: 0.006445917200959994d),
new NpgsqlTypes.NpgsqlBox(top: 0.8420315993927042d,right: 0.4892940336286712d,bottom: 0.00511083285250491d,left: 0.033939473844617596d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 187,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9325320319499154d,right: 0.4373071262393814d,bottom: 0.539996527766997d,left: 0.3714133522789763d),
new NpgsqlTypes.NpgsqlBox(top: 0.871630211319361d,right: 0.29606715200986156d,bottom: 0.7265032228938779d,left: 0.08507354884040119d),
new NpgsqlTypes.NpgsqlBox(top: 0.4899367286623604d,right: 0.9327472445160239d,bottom: 0.44983097801472116d,left: 0.7505007095604966d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8605801059069312d,right: 0.4721786334855338d,bottom: 0.62705097399082d,left: 0.017694798264670908d),
new NpgsqlTypes.NpgsqlBox(top: 0.5502184033203465d,right: 0.6127779369452653d,bottom: 0.24243432826739364d,left: 0.18160269975298948d),
new NpgsqlTypes.NpgsqlBox(top: 0.9120992975158803d,right: 0.9613081857384084d,bottom: 0.7385463071838195d,left: 0.4726389766971322d),
new NpgsqlTypes.NpgsqlBox(top: 0.924670056065554d,right: 0.9421070910056615d,bottom: 0.43779345006189985d,left: 0.08473669803625317d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33902891539346935d,right: 0.8180006053988466d,bottom: 0.1592141051791761d,left: 0.7101657550286938d),
new NpgsqlTypes.NpgsqlBox(top: 0.4355386776703395d,right: 0.594734885343181d,bottom: 0.12771245724943747d,left: 0.14794147078770914d),
new NpgsqlTypes.NpgsqlBox(top: 0.4188068637825978d,right: 0.8343749434982871d,bottom: 0.3925736247228119d,left: 0.5548116303318685d),
new NpgsqlTypes.NpgsqlBox(top: 0.7312293157060358d,right: 0.8851210123882313d,bottom: 0.21196487994908841d,left: 0.3830148426404104d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8967231487338184d,right: 0.478932711351195d,bottom: 0.28020302216018467d,left: 0.23875993044764776d),
new NpgsqlTypes.NpgsqlBox(top: 0.9601962064971208d,right: 0.6341310486459546d,bottom: 0.15145139395505425d,left: 0.2083455092612061d),
new NpgsqlTypes.NpgsqlBox(top: 0.9351093021450805d,right: 0.9276983165159434d,bottom: 0.13185399043713386d,left: 0.8216429181524292d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.82805345534431d,right: 0.6191232792082991d,bottom: 0.36906512853361495d,left: 0.6168291456297375d),
new NpgsqlTypes.NpgsqlBox(top: 0.8832906345797206d,right: 0.839118538810852d,bottom: 0.20887543068709424d,left: 0.3264780658847569d),
new NpgsqlTypes.NpgsqlBox(top: 0.6913903647592522d,right: 0.9327653282172734d,bottom: 0.6622484893718039d,left: 0.8901573567610532d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 198,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8927527425992766d,right: 0.8430998656635804d,bottom: 0.032353903063262246d,left: 0.24152712610385174d),
new NpgsqlTypes.NpgsqlBox(top: 0.797300981849242d,right: 0.9753250259795022d,bottom: 0.00030325106019912784d,left: 0.1606616676962781d),
new NpgsqlTypes.NpgsqlBox(top: 0.8845287052600628d,right: 0.2534521102816355d,bottom: 0.3302875667847873d,left: 0.17914522030589441d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6911041885064483d,right: 0.7518537815160915d,bottom: 0.37969426764770664d,left: 0.5061711488285568d),
new NpgsqlTypes.NpgsqlBox(top: 0.5980986560459455d,right: 0.1314311279509245d,bottom: 0.3383950484624898d,left: 0.06291020069893061d),
new NpgsqlTypes.NpgsqlBox(top: 0.9125320283142693d,right: 0.8250960761075639d,bottom: 0.49274071950625453d,left: 0.7413434210558194d),
new NpgsqlTypes.NpgsqlBox(top: 0.636832335166056d,right: 0.9524482749572911d,bottom: 0.20149268598748904d,left: 0.6142696232116945d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.691732509972447d,right: 0.3679076854815796d,bottom: 0.09074782022478867d,left: 0.17494658105522187d),
new NpgsqlTypes.NpgsqlBox(top: 0.9651013945328932d,right: 0.4475719097131243d,bottom: 0.5660135302387171d,left: 0.42695052944444145d),
new NpgsqlTypes.NpgsqlBox(top: 0.6516600514776749d,right: 0.05599674689330114d,bottom: 0.41931447644588216d,left: 0.02353707274425665d),
new NpgsqlTypes.NpgsqlBox(top: 0.8528189112122465d,right: 0.9962178336614322d,bottom: 0.6859906090984215d,left: 0.3961827424602873d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7642571091540898d,right: 0.4520597842918126d,bottom: 0.09457155047859922d,left: 0.03524149589878667d),
new NpgsqlTypes.NpgsqlBox(top: 0.6691443263931859d,right: 0.7971070691452575d,bottom: 0.4442344353301356d,left: 0.011390656197844629d),
new NpgsqlTypes.NpgsqlBox(top: 0.9188939414684549d,right: 0.9646920686010723d,bottom: 0.12457058380552621d,left: 0.6660351357108573d),
new NpgsqlTypes.NpgsqlBox(top: 0.541776746434589d,right: 0.6102679602059619d,bottom: 0.4628778899775925d,left: 0.5450615529513427d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4400411284594111d,right: 0.9961000093756899d,bottom: 0.2992078631384353d,left: 0.9632973691404513d),
new NpgsqlTypes.NpgsqlBox(top: 0.37677532265903824d,right: 0.9784420724061739d,bottom: 0.2891165246439008d,left: 0.682898694681749d),
new NpgsqlTypes.NpgsqlBox(top: 0.35207969084827695d,right: 0.7966858676856527d,bottom: 0.04822005659089401d,left: 0.24950577802080987d),
new NpgsqlTypes.NpgsqlBox(top: 0.5723339250158824d,right: 0.9478609057640002d,bottom: 0.04505406878681095d,left: 0.09977721673822315d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8407647753474754d,right: 0.9744521659781339d,bottom: 0.4379801315576324d,left: 0.10409139710930815d),
new NpgsqlTypes.NpgsqlBox(top: 0.9002801650151602d,right: 0.09506396482177715d,bottom: 0.03543724770292267d,left: 0.05448130266797402d),
new NpgsqlTypes.NpgsqlBox(top: 0.8008112530048569d,right: 0.501398952644402d,bottom: 0.42964950217501585d,left: 0.15133752012377866d),
new NpgsqlTypes.NpgsqlBox(top: 0.9348174468808117d,right: 0.8401043092349463d,bottom: 0.19925243506490897d,left: 0.5789313448325849d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9825153996533323d,right: 0.43720564438678866d,bottom: 0.7047097828231301d,left: 0.06869803719739231d),
new NpgsqlTypes.NpgsqlBox(top: 0.23254103574202412d,right: 0.9104701226772516d,bottom: 0.08749644505579635d,left: 0.3945400154231291d),
new NpgsqlTypes.NpgsqlBox(top: 0.698428486210396d,right: 0.3524846849863159d,bottom: 0.3628228047287d,left: 0.281981231008391d),
new NpgsqlTypes.NpgsqlBox(top: 0.9358009702830994d,right: 0.7340456010090893d,bottom: 0.4823186823396648d,left: 0.37033583897839895d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 187;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 187;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 143, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 156, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 96, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 171, query1, 47, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 156, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 121, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 52, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[32],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[30],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[30], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[31], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[32], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[33], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxarray1mi
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
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI), typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                await ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MI>();
                var models2 = new List<NpgsqlBoxboxArray1MI>();
                ((INpgsqlBoxArrayboxArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxArrayboxArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA), typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                await ((INpgsqlBoxArrayboxArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxArray1MIWA>();
                var models2 = new List<NpgsqlBoxboxArray1MIWA>();
                ((INpgsqlBoxArrayboxArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

