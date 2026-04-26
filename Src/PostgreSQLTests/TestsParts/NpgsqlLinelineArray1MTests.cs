

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3322944591117851d, b: 0.7539266976705091d, c: 0.4409654179260807d),
new NpgsqlTypes.NpgsqlLine(a: 0.07368211506783873d, b: 0.8971825677915621d, c: 0.8084843587613566d),
new NpgsqlTypes.NpgsqlLine(a: 0.46363569593670373d, b: 0.6067094802559195d, c: 0.008866411934452922d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1876676583633169d, b: 0.13052859118214366d, c: 0.45146086376226213d),
new NpgsqlTypes.NpgsqlLine(a: 0.32829429495396345d, b: 0.782918609764023d, c: 0.6385038974064269d),
new NpgsqlTypes.NpgsqlLine(a: 0.6664963908642473d, b: 0.33936104297548975d, c: 0.8361870979345528d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8186960221061003d, b: 0.6582561370466846d, c: 0.9596472719822262d),
new NpgsqlTypes.NpgsqlLine(a: 0.9632229561365503d, b: 0.28813382856473d, c: 0.23206088459908158d),
new NpgsqlTypes.NpgsqlLine(a: 0.33556317062110463d, b: 0.14313153937667222d, c: 0.8987696404858866d),
new NpgsqlTypes.NpgsqlLine(a: 0.65035937156573d, b: 0.5022145701186185d, c: 0.41266962394316287d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7799226240677382d, b: 0.8544360012544622d, c: 0.4998027985004724d),
new NpgsqlTypes.NpgsqlLine(a: 0.7231896374522447d, b: 0.07780896126967829d, c: 0.7339984667177185d),
new NpgsqlTypes.NpgsqlLine(a: 0.13881492671364037d, b: 0.32695090862737497d, c: 0.45703039231525266d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46252833451435216d, b: 0.09112670590995864d, c: 0.16667626049610285d),
new NpgsqlTypes.NpgsqlLine(a: 0.2696480846988678d, b: 0.9981395649583126d, c: 0.025482779887713414d),
new NpgsqlTypes.NpgsqlLine(a: 0.760082819975719d, b: 0.3610685492927104d, c: 0.9511045099740362d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3702404982690053d, b: 0.5715728611516536d, c: 0.10969854952620284d),
new NpgsqlTypes.NpgsqlLine(a: 0.5792417136925058d, b: 0.46296325100412195d, c: 0.6918343604241519d),
new NpgsqlTypes.NpgsqlLine(a: 0.5451079413129363d, b: 0.3999548628073948d, c: 0.045515941646172564d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12620294192446513d, b: 0.4587772048411025d, c: 0.3145746219240537d),
new NpgsqlTypes.NpgsqlLine(a: 0.9914086254953884d, b: 0.8062028840859706d, c: 0.8082520678112184d),
new NpgsqlTypes.NpgsqlLine(a: 0.8881220937920331d, b: 0.7460500374567599d, c: 0.8157476970121748d),
new NpgsqlTypes.NpgsqlLine(a: 0.6198680134172344d, b: 0.6853573158807909d, c: 0.6833255304571043d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5339121215932692d, b: 0.14219702024289493d, c: 0.7560325007676297d),
new NpgsqlTypes.NpgsqlLine(a: 0.9398693087436453d, b: 0.9439996138692827d, c: 0.3776009868507342d),
new NpgsqlTypes.NpgsqlLine(a: 0.7919580112876103d, b: 0.8842899556837263d, c: 0.27224566113142057d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8779884784002131d, b: 0.7333588852656597d, c: 0.9074003063576196d),
new NpgsqlTypes.NpgsqlLine(a: 0.4006510536437522d, b: 0.2251000115568662d, c: 0.7059687390968042d),
new NpgsqlTypes.NpgsqlLine(a: 0.9053049499136627d, b: 0.6741762498324637d, c: 0.16518003455572994d),
new NpgsqlTypes.NpgsqlLine(a: 0.5110213916017355d, b: 0.8109906580163063d, c: 0.0781721146818608d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40693673183138945d, b: 0.5507489387721164d, c: 0.516993697879588d),
new NpgsqlTypes.NpgsqlLine(a: 0.42320204364197445d, b: 0.9030599609050395d, c: 0.4682379742012508d),
new NpgsqlTypes.NpgsqlLine(a: 0.24897368844976808d, b: 0.23391949787484556d, c: 0.5961473688662137d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7411187115687704d, b: 0.5301449868695544d, c: 0.405317784801312d),
new NpgsqlTypes.NpgsqlLine(a: 0.5886244165059616d, b: 0.07471312969115729d, c: 0.8012438483990786d),
new NpgsqlTypes.NpgsqlLine(a: 0.613206346513417d, b: 0.9853065187391009d, c: 0.9390120990112014d),
new NpgsqlTypes.NpgsqlLine(a: 0.9199933146119025d, b: 0.49465991950697674d, c: 0.26264153143009306d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9172645476874312d, b: 0.1265718083347943d, c: 0.14255002208872858d),
new NpgsqlTypes.NpgsqlLine(a: 0.9786863383091055d, b: 0.22587094365568383d, c: 0.5756895497875085d),
new NpgsqlTypes.NpgsqlLine(a: 0.45831815683343313d, b: 0.33861250315971836d, c: 0.06204575074756036d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5258267801525661d, b: 0.5060305433501399d, c: 0.4130156951672401d),
new NpgsqlTypes.NpgsqlLine(a: 0.21275111936802327d, b: 0.5136849227261764d, c: 0.5150776828865012d),
new NpgsqlTypes.NpgsqlLine(a: 0.8218995543943078d, b: 0.3284426587529089d, c: 0.9072358151058112d),
new NpgsqlTypes.NpgsqlLine(a: 0.7915998222942283d, b: 0.8609728781869614d, c: 0.9197123448199989d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9141568434133602d, b: 0.9741911328212004d, c: 0.14707131854571465d),
new NpgsqlTypes.NpgsqlLine(a: 0.9174126857112254d, b: 0.16560760918655504d, c: 0.20959558536479006d),
new NpgsqlTypes.NpgsqlLine(a: 0.12853702616292972d, b: 0.316375376325273d, c: 0.5647372043962983d),
new NpgsqlTypes.NpgsqlLine(a: 0.3657445510098959d, b: 0.12193613660188896d, c: 0.6591263517762267d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33387274067771966d, b: 0.25646353534228417d, c: 0.7568691507412332d),
new NpgsqlTypes.NpgsqlLine(a: 0.9391064805283429d, b: 0.4496582516672789d, c: 0.5546462940993716d),
new NpgsqlTypes.NpgsqlLine(a: 0.6200619396953089d, b: 0.0024805321450348528d, c: 0.6882160611592212d),
new NpgsqlTypes.NpgsqlLine(a: 0.7278657232549832d, b: 0.5851038275370422d, c: 0.08503563934401681d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.32640904103448576d, b: 0.6146258995513508d, c: 0.8959470658924553d),
new NpgsqlTypes.NpgsqlLine(a: 0.43942986604863576d, b: 0.20198361476832938d, c: 0.08918007725165922d),
new NpgsqlTypes.NpgsqlLine(a: 0.362112887352515d, b: 0.5073993752444573d, c: 0.5608374918328386d),
new NpgsqlTypes.NpgsqlLine(a: 0.08890362271300978d, b: 0.36978725668374235d, c: 0.5094743167337039d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5685718318806668d, b: 0.6514288915796582d, c: 0.9650078593978202d),
new NpgsqlTypes.NpgsqlLine(a: 0.9691354919774698d, b: 0.744019959355153d, c: 0.08559632332302469d),
new NpgsqlTypes.NpgsqlLine(a: 0.9322577289868452d, b: 0.7875340312199555d, c: 0.8198793023735589d),
new NpgsqlTypes.NpgsqlLine(a: 0.2754631145840173d, b: 0.03367109317292083d, c: 0.4687624999399427d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26643494286933056d, b: 0.7185584062467373d, c: 0.6057859429343528d),
new NpgsqlTypes.NpgsqlLine(a: 0.08962187715262326d, b: 0.9718285587336293d, c: 0.7590755861928469d),
new NpgsqlTypes.NpgsqlLine(a: 0.2788808972120972d, b: 0.8249471201155655d, c: 0.6865588710549769d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4396812158790867d, b: 0.12422413723074788d, c: 0.2746636177959727d),
new NpgsqlTypes.NpgsqlLine(a: 0.9816448888764031d, b: 0.6045741820771934d, c: 0.19687467823771d),
new NpgsqlTypes.NpgsqlLine(a: 0.4718215184122456d, b: 0.8560592907114869d, c: 0.20080676689168053d),
new NpgsqlTypes.NpgsqlLine(a: 0.03740027227438214d, b: 0.5100011641493095d, c: 0.9902529342135493d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.03771271887766248d, b: 0.9935326111739363d, c: 0.2520255694992247d),
new NpgsqlTypes.NpgsqlLine(a: 0.22588986884604667d, b: 0.3568001209807877d, c: 0.45572208988303153d),
new NpgsqlTypes.NpgsqlLine(a: 0.7463749791301734d, b: 0.952921635120058d, c: 0.6894582150052359d),
new NpgsqlTypes.NpgsqlLine(a: 0.19586712937447104d, b: 0.2533062981591634d, c: 0.45679431139501503d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9569272641004067d, b: 0.5363904549952764d, c: 0.740027977390762d),
new NpgsqlTypes.NpgsqlLine(a: 0.11100790006000893d, b: 0.9506711440873438d, c: 0.03642543132272369d),
new NpgsqlTypes.NpgsqlLine(a: 0.3485193341219477d, b: 0.04061103879223149d, c: 0.45282943675216314d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4840698994379439d, b: 0.4791296780594393d, c: 0.6054753219536385d),
new NpgsqlTypes.NpgsqlLine(a: 0.5339408599652941d, b: 0.6294851620000889d, c: 0.039321570537478645d),
new NpgsqlTypes.NpgsqlLine(a: 0.1346333478965066d, b: 0.28544699262390494d, c: 0.23230297745529138d),
new NpgsqlTypes.NpgsqlLine(a: 0.8611845131120149d, b: 0.9489783590201448d, c: 0.48973593311006225d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2821732487722356d, b: 0.27490638931688527d, c: 0.08034459208847189d),
new NpgsqlTypes.NpgsqlLine(a: 0.9752749711163542d, b: 0.07583513606548531d, c: 0.9234928865010488d),
new NpgsqlTypes.NpgsqlLine(a: 0.12712236911605168d, b: 0.6054466847593608d, c: 0.17987611372576062d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15924737026028535d, b: 0.610810242058416d, c: 0.047564035363183654d),
new NpgsqlTypes.NpgsqlLine(a: 0.7835704592191169d, b: 0.41316771450893697d, c: 0.05576325433331675d),
new NpgsqlTypes.NpgsqlLine(a: 0.4667730045361669d, b: 0.6484459339722798d, c: 0.28852652804734036d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6898854654422867d, b: 0.6614981685987237d, c: 0.8168008410700277d),
new NpgsqlTypes.NpgsqlLine(a: 0.9610345992993377d, b: 0.6868618454761212d, c: 0.9229519825010596d),
new NpgsqlTypes.NpgsqlLine(a: 0.3927324734262332d, b: 0.19459198597934868d, c: 0.9041256328401165d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8824171486145446d, b: 0.8593282157176876d, c: 0.0031019720775455895d),
new NpgsqlTypes.NpgsqlLine(a: 0.42501875462671046d, b: 0.3055562799901991d, c: 0.863697136216471d),
new NpgsqlTypes.NpgsqlLine(a: 0.08890877224547356d, b: 0.35426322408324296d, c: 0.35199628541284744d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06787018110232257d, b: 0.517832229213823d, c: 0.016575966132609143d),
new NpgsqlTypes.NpgsqlLine(a: 0.34064968933983497d, b: 0.0736120595432791d, c: 0.9436569541063086d),
new NpgsqlTypes.NpgsqlLine(a: 0.7161846781143746d, b: 0.5250962543863624d, c: 0.052476756359248755d),
new NpgsqlTypes.NpgsqlLine(a: 0.2816982086488975d, b: 0.8367867261556318d, c: 0.6658315294767196d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5937419612167778d, b: 0.31078922558449307d, c: 0.3333255381482262d),
new NpgsqlTypes.NpgsqlLine(a: 0.1053252334187097d, b: 0.7728609100381276d, c: 0.16554032989030576d),
new NpgsqlTypes.NpgsqlLine(a: 0.7869970583876891d, b: 0.40249174989016745d, c: 0.2137420370704588d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11894288387586582d, b: 0.47404995988104603d, c: 0.5943511222286739d),
new NpgsqlTypes.NpgsqlLine(a: 0.5512144219843503d, b: 0.6475621496083337d, c: 0.9326525070628255d),
new NpgsqlTypes.NpgsqlLine(a: 0.11830248877611993d, b: 0.3092945302480671d, c: 0.34084307908334643d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6195003049681101d, b: 0.5303448107084036d, c: 0.19083892828893345d),
new NpgsqlTypes.NpgsqlLine(a: 0.0453733705315823d, b: 0.619821443090492d, c: 0.49675225358222974d),
new NpgsqlTypes.NpgsqlLine(a: 0.1828549881054674d, b: 4.809866606458879E-05d, c: 0.9398648778547661d),
new NpgsqlTypes.NpgsqlLine(a: 0.6426768264548707d, b: 0.3430453963070057d, c: 0.1987358514440013d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2521987192878654d, b: 0.8147621787255886d, c: 0.6737454992999647d),
new NpgsqlTypes.NpgsqlLine(a: 0.47869001600567584d, b: 0.28742881373883644d, c: 0.521642444156669d),
new NpgsqlTypes.NpgsqlLine(a: 0.875381164924445d, b: 0.010443178142555798d, c: 0.972664397961333d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44468049361172834d, b: 0.41357642373998005d, c: 0.9119966044491046d),
new NpgsqlTypes.NpgsqlLine(a: 0.16463228697761145d, b: 0.9594978069248687d, c: 0.5749292668678682d),
new NpgsqlTypes.NpgsqlLine(a: 0.40156935036150465d, b: 0.6023743616715378d, c: 0.4966370736981296d),
new NpgsqlTypes.NpgsqlLine(a: 0.11486144385019981d, b: 0.2570893965031118d, c: 0.12305439368226434d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7486352742543062d, b: 0.19003476752254678d, c: 0.504062767559317d),
new NpgsqlTypes.NpgsqlLine(a: 0.9290340257911988d, b: 0.8683991282484376d, c: 0.834832786443788d),
new NpgsqlTypes.NpgsqlLine(a: 0.053798937631319044d, b: 0.2787793690453395d, c: 0.39626090077925735d),
new NpgsqlTypes.NpgsqlLine(a: 0.3171178047001245d, b: 0.3279536528718464d, c: 0.43037505222950134d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8742123767412201d, b: 0.7454449461640429d, c: 0.34176138880748586d),
new NpgsqlTypes.NpgsqlLine(a: 0.4955146324209546d, b: 0.1662841942862907d, c: 0.7863149132958562d),
new NpgsqlTypes.NpgsqlLine(a: 0.4259539751603606d, b: 0.40300317142531006d, c: 0.9578971818693816d),
new NpgsqlTypes.NpgsqlLine(a: 0.32184499278491174d, b: 0.3045993445020103d, c: 0.14675445822272803d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.24075324381296714d, b: 0.7453994587995089d, c: 0.9013114211823863d),
new NpgsqlTypes.NpgsqlLine(a: 0.3652091619401062d, b: 0.7264369326421285d, c: 0.40026697005721146d),
new NpgsqlTypes.NpgsqlLine(a: 0.3263579245689735d, b: 0.24428644388200338d, c: 0.9779815532818864d),
new NpgsqlTypes.NpgsqlLine(a: 0.4855102699624938d, b: 0.3570162991776038d, c: 0.7764671258292722d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06360928098359597d, b: 0.668074866353519d, c: 0.21712875651799257d),
new NpgsqlTypes.NpgsqlLine(a: 0.28137000599280815d, b: 0.3165425190811708d, c: 0.28101585765015935d),
new NpgsqlTypes.NpgsqlLine(a: 0.8266783866155902d, b: 0.6099510666867435d, c: 0.8531747901298298d),
new NpgsqlTypes.NpgsqlLine(a: 0.10632208554400102d, b: 0.7707692450105008d, c: 0.45641856792543456d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2915983437751124d, b: 0.38929846133674084d, c: 0.33088497585258214d),
new NpgsqlTypes.NpgsqlLine(a: 0.9462733321243834d, b: 0.799663743984983d, c: 0.02422555019636785d),
new NpgsqlTypes.NpgsqlLine(a: 0.17763612158603992d, b: 0.5486924711844021d, c: 0.8314917385060339d),
new NpgsqlTypes.NpgsqlLine(a: 0.004466238897971597d, b: 0.8955432112038512d, c: 0.580955470356308d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2831083372872616d, b: 0.3761974819498304d, c: 0.047291161666033865d),
new NpgsqlTypes.NpgsqlLine(a: 0.6928537423344224d, b: 0.6231966996872502d, c: 0.26282989703993964d),
new NpgsqlTypes.NpgsqlLine(a: 0.4064610336915785d, b: 0.40279829024425395d, c: 0.9248658292901885d),
new NpgsqlTypes.NpgsqlLine(a: 0.8790808170847327d, b: 0.7674535249144522d, c: 0.3480562606657668d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5845938641434265d, b: 0.7880390741030004d, c: 0.18398925444429748d),
new NpgsqlTypes.NpgsqlLine(a: 0.3088003615493964d, b: 0.8670253202827508d, c: 0.5472431950495096d),
new NpgsqlTypes.NpgsqlLine(a: 0.37010785374213295d, b: 0.6422472317076691d, c: 0.21791256831771932d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7576276158626449d, b: 0.06440378549825565d, c: 0.23261592403802445d),
new NpgsqlTypes.NpgsqlLine(a: 0.010799682519600506d, b: 0.19991425169084365d, c: 0.7926250428703169d),
new NpgsqlTypes.NpgsqlLine(a: 0.6873349057257594d, b: 0.3077083875133175d, c: 0.4011164366883265d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.274057549011658d, b: 0.6765492312889002d, c: 0.22821932688759983d),
new NpgsqlTypes.NpgsqlLine(a: 0.7519958867938824d, b: 0.5220294934266224d, c: 0.4683614035334128d),
new NpgsqlTypes.NpgsqlLine(a: 0.897254105819813d, b: 0.30888114682126167d, c: 0.8197475429456442d),
new NpgsqlTypes.NpgsqlLine(a: 0.3877993554477315d, b: 0.8621301658753625d, c: 0.12933783450196756d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7324759262122564d, b: 0.9448226934443881d, c: 0.071761406116708d),
new NpgsqlTypes.NpgsqlLine(a: 0.4441061543818434d, b: 0.23763712069908527d, c: 0.35784678010905213d),
new NpgsqlTypes.NpgsqlLine(a: 0.7983772119686993d, b: 0.817626641485655d, c: 0.0016704239969909107d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4093931813677626d, b: 0.22844905856197406d, c: 0.18426717586094465d),
new NpgsqlTypes.NpgsqlLine(a: 0.007127047518669105d, b: 0.24996840933736297d, c: 0.7787523243280563d),
new NpgsqlTypes.NpgsqlLine(a: 0.9717934198875047d, b: 0.8877245279282036d, c: 0.7930869494771148d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3023952785096202d, b: 0.8555208623024741d, c: 0.9965035280974702d),
new NpgsqlTypes.NpgsqlLine(a: 0.892773202915513d, b: 0.7939776275712718d, c: 0.1998303503510479d),
new NpgsqlTypes.NpgsqlLine(a: 0.10997558976415422d, b: 0.20130027775025716d, c: 0.6263061126885605d),
new NpgsqlTypes.NpgsqlLine(a: 0.5746691338813272d, b: 0.772794862901342d, c: 0.22769780302386533d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.023247511086371464d, b: 0.007271519793043635d, c: 0.6110393239242567d),
new NpgsqlTypes.NpgsqlLine(a: 0.20016525415119502d, b: 0.7470365513405113d, c: 0.2626394838551257d),
new NpgsqlTypes.NpgsqlLine(a: 0.42524071896677884d, b: 0.10335803848410441d, c: 0.19445382356770247d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.061038540904272076d, b: 0.7168681784477504d, c: 0.7625638815635334d),
new NpgsqlTypes.NpgsqlLine(a: 0.1206154703905834d, b: 0.739604897613623d, c: 0.1475324466861908d),
new NpgsqlTypes.NpgsqlLine(a: 0.8403230372207487d, b: 0.9603401763407577d, c: 0.9402506296536041d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18513817460506243d, b: 0.5813442292518449d, c: 0.6409313559617078d),
new NpgsqlTypes.NpgsqlLine(a: 0.7744786336853299d, b: 0.7568522879577092d, c: 0.35217046714216793d),
new NpgsqlTypes.NpgsqlLine(a: 0.13492161728939667d, b: 0.015570209472063556d, c: 0.7892596364671869d),
new NpgsqlTypes.NpgsqlLine(a: 0.3180662634067771d, b: 0.9529845877522648d, c: 0.6867467173479135d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6941230149187188d, b: 0.6632103106814548d, c: 0.5443472610277665d),
new NpgsqlTypes.NpgsqlLine(a: 0.5424952262054562d, b: 0.12370905677710908d, c: 0.3260795519566638d),
new NpgsqlTypes.NpgsqlLine(a: 0.5263420873265069d, b: 0.9887667899790801d, c: 0.865499892367578d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10317186335636197d, b: 0.31164528669145d, c: 0.6165826994317185d),
new NpgsqlTypes.NpgsqlLine(a: 0.47066370873170027d, b: 0.00461715845403099d, c: 0.09030981568357233d),
new NpgsqlTypes.NpgsqlLine(a: 0.6588368950192189d, b: 0.2850116994329531d, c: 0.15716103089926314d),
new NpgsqlTypes.NpgsqlLine(a: 0.09190457751245984d, b: 0.14181362539123032d, c: 0.8846590309728231d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.40891659887596765d, b: 0.5131539627808425d, c: 0.6550593194117625d),
new NpgsqlTypes.NpgsqlLine(a: 0.24326424395655155d, b: 0.4377036440779385d, c: 0.3068132516295945d),
new NpgsqlTypes.NpgsqlLine(a: 0.7690976798932875d, b: 0.254162168978705d, c: 0.5248492139623214d),
new NpgsqlTypes.NpgsqlLine(a: 0.7712646529211225d, b: 0.5125520921763342d, c: 0.6090651255077288d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.007846149701128402d, b: 0.8016907281499581d, c: 0.8777521252396153d),
new NpgsqlTypes.NpgsqlLine(a: 0.8195477348714493d, b: 0.2813889942965645d, c: 0.3316770565184456d),
new NpgsqlTypes.NpgsqlLine(a: 0.9576763096452942d, b: 0.8816444769731597d, c: 0.5445150299784325d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9912106135312041d, b: 0.7603273562890804d, c: 0.7853352511915549d),
new NpgsqlTypes.NpgsqlLine(a: 0.34873298428592525d, b: 0.8925241972243256d, c: 0.2094537755035457d),
new NpgsqlTypes.NpgsqlLine(a: 0.16623074842172725d, b: 0.9203901895448098d, c: 0.1818238553088315d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5961357642383137d, b: 0.4968022364537009d, c: 0.6562185293573495d),
new NpgsqlTypes.NpgsqlLine(a: 0.7007229795034658d, b: 0.19793032066295413d, c: 0.898829959625248d),
new NpgsqlTypes.NpgsqlLine(a: 0.04372924217177232d, b: 0.9567843692424782d, c: 0.445898504253059d),
new NpgsqlTypes.NpgsqlLine(a: 0.8132070699821532d, b: 0.5817040658584637d, c: 0.7725077768742603d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.003952498173376062d, b: 0.523121736831529d, c: 0.6346264954644488d),
new NpgsqlTypes.NpgsqlLine(a: 0.5851347952628058d, b: 0.5475580037737305d, c: 0.06275327295916744d),
new NpgsqlTypes.NpgsqlLine(a: 0.16642949674029328d, b: 0.5121105598802986d, c: 0.577642247164822d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8264204684147359d, b: 0.5888068547363788d, c: 0.49018308877567096d),
new NpgsqlTypes.NpgsqlLine(a: 0.22680006816503617d, b: 0.22437232171882593d, c: 0.5947921137923824d),
new NpgsqlTypes.NpgsqlLine(a: 0.04254397126944254d, b: 0.5704919980884621d, c: 0.014329893017944406d),
new NpgsqlTypes.NpgsqlLine(a: 0.2855278702491796d, b: 0.1616720298140304d, c: 0.8829169371955667d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5757759343568757d, b: 0.3821481895860175d, c: 0.3879574802360731d),
new NpgsqlTypes.NpgsqlLine(a: 0.3741316791548528d, b: 0.24196570432947295d, c: 0.07487572890786742d),
new NpgsqlTypes.NpgsqlLine(a: 0.5759363445031084d, b: 0.5197334857812173d, c: 0.7417711192614012d),
new NpgsqlTypes.NpgsqlLine(a: 0.6714972491945999d, b: 0.35433353347743446d, c: 0.9827423147329807d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5654907496220469d, b: 0.6919747475979858d, c: 0.8963795103703633d),
new NpgsqlTypes.NpgsqlLine(a: 0.2446746865149222d, b: 0.7276134980322566d, c: 0.2690767971492003d),
new NpgsqlTypes.NpgsqlLine(a: 0.34015179654295125d, b: 0.8157516501927863d, c: 0.40074377281403084d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39013659921893995d, b: 0.9960702463111313d, c: 0.07167250521092539d),
new NpgsqlTypes.NpgsqlLine(a: 0.0721968123432487d, b: 0.23682313103679076d, c: 0.9590403069219745d),
new NpgsqlTypes.NpgsqlLine(a: 0.3697233592890974d, b: 0.033442825830390044d, c: 0.8927639029661422d),
new NpgsqlTypes.NpgsqlLine(a: 0.6200080002690214d, b: 0.14271196335459913d, c: 0.888610968782483d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08502892906319703d, b: 0.5490193735233685d, c: 0.067644937662249d),
new NpgsqlTypes.NpgsqlLine(a: 0.9524306533168114d, b: 0.09222933365825936d, c: 0.6594351484184465d),
new NpgsqlTypes.NpgsqlLine(a: 0.8476962301727549d, b: 0.03120689401614818d, c: 0.5733522834864987d),
new NpgsqlTypes.NpgsqlLine(a: 0.6753717838495492d, b: 0.6339361518889227d, c: 0.7972877619168982d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6025100176385589d, b: 0.19284564808916438d, c: 0.6015985631407473d),
new NpgsqlTypes.NpgsqlLine(a: 0.46588061299352734d, b: 0.6494786066675621d, c: 0.3735265534662233d),
new NpgsqlTypes.NpgsqlLine(a: 0.7125682799659124d, b: 0.8253895288063942d, c: 0.8087037458944674d),
new NpgsqlTypes.NpgsqlLine(a: 0.6204775833784675d, b: 0.6273780633588097d, c: 0.9639385212787964d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4642460631237928d, b: 0.8995201324093628d, c: 0.9015715911982033d),
new NpgsqlTypes.NpgsqlLine(a: 0.5917435382196156d, b: 0.9752484107456248d, c: 0.848480315870943d),
new NpgsqlTypes.NpgsqlLine(a: 0.053783314390640546d, b: 0.7899969364329509d, c: 0.04621844451389334d),
new NpgsqlTypes.NpgsqlLine(a: 0.8072014105695193d, b: 0.09297442194570849d, c: 0.4824579822423939d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43666708451974734d, b: 0.44272002259226007d, c: 0.22645877323057806d),
new NpgsqlTypes.NpgsqlLine(a: 0.30500388856298233d, b: 0.5037553881294338d, c: 0.09402440678664936d),
new NpgsqlTypes.NpgsqlLine(a: 0.21299975136627658d, b: 0.9635365575892385d, c: 0.4806573360376686d),
new NpgsqlTypes.NpgsqlLine(a: 0.1566892233382d, b: 0.9417595184665243d, c: 0.4266065091447906d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7187268633187164d, b: 0.1313694731245021d, c: 0.25748720515789103d),
new NpgsqlTypes.NpgsqlLine(a: 0.8979156895520606d, b: 0.26375770067638027d, c: 0.5774787323923358d),
new NpgsqlTypes.NpgsqlLine(a: 0.7539748300629086d, b: 0.7558560240123829d, c: 0.35036013105607366d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.009658523573148114d, b: 0.28094995587296623d, c: 0.3876603037228912d),
new NpgsqlTypes.NpgsqlLine(a: 0.8371038923401372d, b: 0.9467222465545653d, c: 0.7812049783396957d),
new NpgsqlTypes.NpgsqlLine(a: 0.942144179930908d, b: 0.2950528607069548d, c: 0.7749240481069433d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.39911680196512167d, b: 0.49149108154924404d, c: 0.3668328381869299d),
new NpgsqlTypes.NpgsqlLine(a: 0.02092097995095643d, b: 0.7401773479813744d, c: 0.7167658485401234d),
new NpgsqlTypes.NpgsqlLine(a: 0.2238339366901677d, b: 0.2928581199455107d, c: 0.5913851321411162d),
new NpgsqlTypes.NpgsqlLine(a: 0.059848086900432085d, b: 0.5495095426901793d, c: 0.14499455144145568d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9930009960566456d, b: 0.6644189788989352d, c: 0.5885290451028179d),
new NpgsqlTypes.NpgsqlLine(a: 0.4264611062344641d, b: 0.5183753510081849d, c: 0.6945920916125263d),
new NpgsqlTypes.NpgsqlLine(a: 0.7096585595079824d, b: 0.9961174494777797d, c: 0.3286463631257731d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.782726745818714d, b: 0.9097703669573031d, c: 0.5945788076091368d),
new NpgsqlTypes.NpgsqlLine(a: 0.9383991858312712d, b: 0.25621674492750357d, c: 0.9164659190304624d),
new NpgsqlTypes.NpgsqlLine(a: 0.365759813923041d, b: 0.3358944967655988d, c: 0.2900587093963396d),
new NpgsqlTypes.NpgsqlLine(a: 0.36466641235630004d, b: 0.08734209869869591d, c: 0.3662970154998769d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
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
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33387274067771966d, b: 0.25646353534228417d, c: 0.7568691507412332d),
new NpgsqlTypes.NpgsqlLine(a: 0.9391064805283429d, b: 0.4496582516672789d, c: 0.5546462940993716d),
new NpgsqlTypes.NpgsqlLine(a: 0.6200619396953089d, b: 0.0024805321450348528d, c: 0.6882160611592212d),
new NpgsqlTypes.NpgsqlLine(a: 0.7278657232549832d, b: 0.5851038275370422d, c: 0.08503563934401681d),
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4840698994379439d, b: 0.4791296780594393d, c: 0.6054753219536385d),
new NpgsqlTypes.NpgsqlLine(a: 0.5339408599652941d, b: 0.6294851620000889d, c: 0.039321570537478645d),
new NpgsqlTypes.NpgsqlLine(a: 0.1346333478965066d, b: 0.28544699262390494d, c: 0.23230297745529138d),
new NpgsqlTypes.NpgsqlLine(a: 0.8611845131120149d, b: 0.9489783590201448d, c: 0.48973593311006225d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06787018110232257d, b: 0.517832229213823d, c: 0.016575966132609143d),
new NpgsqlTypes.NpgsqlLine(a: 0.34064968933983497d, b: 0.0736120595432791d, c: 0.9436569541063086d),
new NpgsqlTypes.NpgsqlLine(a: 0.7161846781143746d, b: 0.5250962543863624d, c: 0.052476756359248755d),
new NpgsqlTypes.NpgsqlLine(a: 0.2816982086488975d, b: 0.8367867261556318d, c: 0.6658315294767196d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 147;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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

                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[29], false);
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

                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 81, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatchAsync(connection, 29, 123))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
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
                var models =  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelBatch(connection, 93, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray1M>(15);

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
                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

