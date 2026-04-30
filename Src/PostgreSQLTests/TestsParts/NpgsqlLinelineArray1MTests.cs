

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
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.25300932470450943d, b: 0.190028105646585d, c: 0.8125013706715659d),
new NpgsqlTypes.NpgsqlLine(a: 0.4146196067764376d, b: 0.4405470254351893d, c: 0.30868014609698224d),
new NpgsqlTypes.NpgsqlLine(a: 0.6283110869377915d, b: 0.673404543057193d, c: 0.371601673409807d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9849144212323603d, b: 0.6365495765807164d, c: 0.6364927535507776d),
new NpgsqlTypes.NpgsqlLine(a: 0.7228991426572384d, b: 0.6945706917363786d, c: 0.8286143812914968d),
new NpgsqlTypes.NpgsqlLine(a: 0.41196545221401126d, b: 0.6763604146880736d, c: 0.33306732642977377d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6712191986335011d, b: 0.759949261234576d, c: 0.5043174089062065d),
new NpgsqlTypes.NpgsqlLine(a: 0.06573238462570485d, b: 0.7560380627356165d, c: 0.28359986938616333d),
new NpgsqlTypes.NpgsqlLine(a: 0.9966224697392466d, b: 0.34421993313836974d, c: 0.585517167590587d),
new NpgsqlTypes.NpgsqlLine(a: 0.4284381660474166d, b: 0.6502077847903646d, c: 0.3165049139278313d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.47936025007696914d, b: 0.1284808973770193d, c: 0.12994435547185312d),
new NpgsqlTypes.NpgsqlLine(a: 0.9027302519342392d, b: 0.23384122170392274d, c: 0.948581432202971d),
new NpgsqlTypes.NpgsqlLine(a: 0.8103421334080331d, b: 0.45570904541882373d, c: 0.43617255677120015d),
new NpgsqlTypes.NpgsqlLine(a: 0.6674953882200529d, b: 0.9819281457342149d, c: 0.6695066220450319d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2975486556774206d, b: 0.8208174379158324d, c: 0.6313035192653217d),
new NpgsqlTypes.NpgsqlLine(a: 0.585472556918548d, b: 0.14870007116105566d, c: 0.671883519479139d),
new NpgsqlTypes.NpgsqlLine(a: 0.4595565036628626d, b: 0.6643597271752095d, c: 0.8282948582799833d),
new NpgsqlTypes.NpgsqlLine(a: 0.19221154517666283d, b: 0.9065252583341096d, c: 0.9258003718347231d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2479664914742754d, b: 0.29058872590930895d, c: 0.12816815263882708d),
new NpgsqlTypes.NpgsqlLine(a: 0.9024465739790665d, b: 0.6826219620348125d, c: 0.4064762129348448d),
new NpgsqlTypes.NpgsqlLine(a: 0.026819812412459565d, b: 0.16571158540737374d, c: 0.9355852358724619d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8405953028369418d, b: 0.9863737999884233d, c: 0.07506327530933277d),
new NpgsqlTypes.NpgsqlLine(a: 0.8656829524094669d, b: 0.14244345582797702d, c: 0.3959265986930135d),
new NpgsqlTypes.NpgsqlLine(a: 0.9677228721886518d, b: 0.6041540520319866d, c: 0.6068512810093551d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9464864705757119d, b: 0.24251237643691048d, c: 0.8073896894484295d),
new NpgsqlTypes.NpgsqlLine(a: 0.8882061815545341d, b: 0.49922891432210015d, c: 0.5968259638190657d),
new NpgsqlTypes.NpgsqlLine(a: 0.3399515702991428d, b: 0.7083181299186132d, c: 0.3346693244221901d),
new NpgsqlTypes.NpgsqlLine(a: 0.15461066626402964d, b: 0.7926960023720305d, c: 0.48802640345368187d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8195790330005003d, b: 0.9052291250853239d, c: 0.5201185777146399d),
new NpgsqlTypes.NpgsqlLine(a: 0.1306199725692876d, b: 0.3677067401320161d, c: 0.2903648553025394d),
new NpgsqlTypes.NpgsqlLine(a: 0.3155112074554277d, b: 0.4207838102289917d, c: 0.5281616629877299d),
new NpgsqlTypes.NpgsqlLine(a: 0.9106933664086083d, b: 0.20471972979487174d, c: 0.9521815499915366d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2733054738899545d, b: 0.2754963987845138d, c: 0.4296154270382846d),
new NpgsqlTypes.NpgsqlLine(a: 0.946581899904277d, b: 0.3967276740288541d, c: 0.631464217587841d),
new NpgsqlTypes.NpgsqlLine(a: 0.9209820533313099d, b: 0.8570632413972962d, c: 0.4105221128149442d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4838084368937715d, b: 0.9199366694108211d, c: 0.7792796390752952d),
new NpgsqlTypes.NpgsqlLine(a: 0.5989454614997765d, b: 0.8048794453360517d, c: 0.4624559937821723d),
new NpgsqlTypes.NpgsqlLine(a: 0.3968386103178335d, b: 0.9430216579846672d, c: 0.9217541359525621d),
new NpgsqlTypes.NpgsqlLine(a: 0.418921191912505d, b: 0.3531333480921779d, c: 0.2578431181871197d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.014130001232553924d, b: 0.14082256494200984d, c: 0.23686975487995499d),
new NpgsqlTypes.NpgsqlLine(a: 0.700251399644931d, b: 0.8419878141373699d, c: 0.7000032610355367d),
new NpgsqlTypes.NpgsqlLine(a: 0.24881673530533832d, b: 0.030593338203068754d, c: 0.48062417128272195d),
new NpgsqlTypes.NpgsqlLine(a: 0.053027698635765064d, b: 0.885462452417157d, c: 0.8697319318930106d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1705585855922106d, b: 0.6412846071996356d, c: 0.8372522818170284d),
new NpgsqlTypes.NpgsqlLine(a: 0.5771347197738488d, b: 0.5076414962615866d, c: 0.36155901285597725d),
new NpgsqlTypes.NpgsqlLine(a: 0.4754858743366889d, b: 0.1590023929988541d, c: 0.8104388187737865d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20624402164888678d, b: 0.2349941911841571d, c: 0.26227770748685886d),
new NpgsqlTypes.NpgsqlLine(a: 0.12444257928575331d, b: 0.7354241917692651d, c: 0.9505264524870697d),
new NpgsqlTypes.NpgsqlLine(a: 0.7327976790517008d, b: 0.8982677624746562d, c: 0.9380695030005415d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8977829373384376d, b: 0.3151629293849084d, c: 0.413187655880074d),
new NpgsqlTypes.NpgsqlLine(a: 0.12408286944019531d, b: 0.38823146539561193d, c: 0.7253997518411144d),
new NpgsqlTypes.NpgsqlLine(a: 0.07110831927515071d, b: 0.7566104724613614d, c: 0.8240836009715372d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5308322858296735d, b: 0.2108184242811597d, c: 0.40089331178719245d),
new NpgsqlTypes.NpgsqlLine(a: 0.5054070364431732d, b: 0.4361990831381173d, c: 0.7835009204841332d),
new NpgsqlTypes.NpgsqlLine(a: 0.5377211455344552d, b: 0.86844534784455d, c: 0.3649723466710596d),
new NpgsqlTypes.NpgsqlLine(a: 0.7035063866285353d, b: 0.15763210264575322d, c: 0.8071181074589404d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6151001597689516d, b: 0.1957059675136108d, c: 0.5425371965156324d),
new NpgsqlTypes.NpgsqlLine(a: 0.7384982930975821d, b: 0.3234280237784882d, c: 0.24101915133632956d),
new NpgsqlTypes.NpgsqlLine(a: 0.5188498903302063d, b: 0.9518547353816352d, c: 0.7467185636655667d),
new NpgsqlTypes.NpgsqlLine(a: 0.05794497599932524d, b: 0.792567940113807d, c: 0.7834672454850358d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11824989635627081d, b: 0.991033099614866d, c: 0.6003488937188707d),
new NpgsqlTypes.NpgsqlLine(a: 0.055343822736721116d, b: 0.07899505002516982d, c: 0.9916719280520627d),
new NpgsqlTypes.NpgsqlLine(a: 0.7534817863268412d, b: 0.0064727942248750114d, c: 0.5174531306354225d),
new NpgsqlTypes.NpgsqlLine(a: 0.20746698733215607d, b: 0.541993517401067d, c: 0.8284439442002024d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2965248590271319d, b: 0.5830117408785647d, c: 0.41257693200055934d),
new NpgsqlTypes.NpgsqlLine(a: 0.3836193313947043d, b: 0.6155895643394108d, c: 0.7675946191450531d),
new NpgsqlTypes.NpgsqlLine(a: 0.9446310705022064d, b: 0.42467701426996973d, c: 0.5236210656854005d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35321219406517046d, b: 0.8948676538003765d, c: 0.5756578157100323d),
new NpgsqlTypes.NpgsqlLine(a: 0.685940581169017d, b: 0.6414645101712896d, c: 0.8502879574006447d),
new NpgsqlTypes.NpgsqlLine(a: 0.22389699632462357d, b: 0.035403134438245165d, c: 0.615430205724071d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6386304102375252d, b: 0.22067112316395676d, c: 0.9722964469595284d),
new NpgsqlTypes.NpgsqlLine(a: 0.724432334343928d, b: 0.6063566494197984d, c: 0.31244436299514966d),
new NpgsqlTypes.NpgsqlLine(a: 0.29807040619647096d, b: 0.7392362365138491d, c: 0.9731774310162623d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43261914152969394d, b: 0.41238673652580426d, c: 0.22862586866058443d),
new NpgsqlTypes.NpgsqlLine(a: 0.43046214231018187d, b: 0.23030960595984873d, c: 0.6899172877878342d),
new NpgsqlTypes.NpgsqlLine(a: 0.513061078058066d, b: 0.08587918215682921d, c: 0.24609741419866615d),
new NpgsqlTypes.NpgsqlLine(a: 0.2519388954256788d, b: 0.8163300701077788d, c: 0.5513786460722543d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3708268270710732d, b: 0.10867444287271244d, c: 0.8855311491424018d),
new NpgsqlTypes.NpgsqlLine(a: 0.9395299520566862d, b: 0.342217497476511d, c: 0.8504936482645393d),
new NpgsqlTypes.NpgsqlLine(a: 0.08387949077102108d, b: 0.7958555438151709d, c: 0.8813771788115432d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3982046470266989d, b: 0.5802977846957086d, c: 0.029991626044410524d),
new NpgsqlTypes.NpgsqlLine(a: 0.25040996398199067d, b: 0.6701941872034978d, c: 0.14529751461237184d),
new NpgsqlTypes.NpgsqlLine(a: 0.2825485725138618d, b: 0.5173579364356733d, c: 0.09956874494980994d),
new NpgsqlTypes.NpgsqlLine(a: 0.0030129838355694716d, b: 0.6356950859521452d, c: 0.22650017496314645d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7837282902709956d, b: 0.47484605996541185d, c: 0.8798005377195309d),
new NpgsqlTypes.NpgsqlLine(a: 0.5085923246367753d, b: 0.14031876683507516d, c: 0.28474631622284174d),
new NpgsqlTypes.NpgsqlLine(a: 0.192157902306491d, b: 0.5346510357108888d, c: 0.2979299774145395d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22635613965505397d, b: 0.9332481506974474d, c: 0.21281626051030622d),
new NpgsqlTypes.NpgsqlLine(a: 0.2809971408297751d, b: 0.8754368599409625d, c: 0.34156490896472014d),
new NpgsqlTypes.NpgsqlLine(a: 0.6027188099164175d, b: 0.11334613208559552d, c: 0.5843234374881209d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.42047541050476767d, b: 0.5377188584577364d, c: 0.13725398453939075d),
new NpgsqlTypes.NpgsqlLine(a: 0.7432868195799239d, b: 0.15941068412560933d, c: 0.0746474471016636d),
new NpgsqlTypes.NpgsqlLine(a: 0.5864235078651072d, b: 0.11713594504712677d, c: 0.42883140851942037d),
new NpgsqlTypes.NpgsqlLine(a: 0.19192354859941263d, b: 0.5807877659328177d, c: 0.18845188956294778d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.38625337894851564d, b: 0.5032301402905205d, c: 0.27862244126741387d),
new NpgsqlTypes.NpgsqlLine(a: 0.9807667139739134d, b: 0.28634774755181625d, c: 0.13736677524931906d),
new NpgsqlTypes.NpgsqlLine(a: 0.18226362505345461d, b: 0.41695671740327656d, c: 0.9664623395127298d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6473378935937143d, b: 0.4421007561721022d, c: 0.8956157257437993d),
new NpgsqlTypes.NpgsqlLine(a: 0.3253734410568897d, b: 0.9909281218790518d, c: 0.631705870373119d),
new NpgsqlTypes.NpgsqlLine(a: 0.4735203836227171d, b: 0.9011241435289099d, c: 0.6061164568567429d),
new NpgsqlTypes.NpgsqlLine(a: 0.2578773399034062d, b: 0.21161970923196316d, c: 0.9788059666130194d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7451751656101993d, b: 0.15481934087125093d, c: 0.715462921741109d),
new NpgsqlTypes.NpgsqlLine(a: 0.7378354335763064d, b: 0.36315984763911247d, c: 0.31599675284188244d),
new NpgsqlTypes.NpgsqlLine(a: 0.5159479526036926d, b: 0.02828615160707426d, c: 0.6544155746980039d),
new NpgsqlTypes.NpgsqlLine(a: 0.14411129629177655d, b: 0.652343409598465d, c: 0.8814741406490008d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5153541423947761d, b: 0.40941854924448373d, c: 0.3387144086697925d),
new NpgsqlTypes.NpgsqlLine(a: 0.40235515278113876d, b: 0.9266099104693422d, c: 0.10079380357133572d),
new NpgsqlTypes.NpgsqlLine(a: 0.732230430595184d, b: 0.039534670319072096d, c: 0.4857642532118963d),
new NpgsqlTypes.NpgsqlLine(a: 0.8760626535249598d, b: 0.6366583400207786d, c: 0.8119999206874612d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10165203660724431d, b: 0.1955323660391649d, c: 0.04400668308549638d),
new NpgsqlTypes.NpgsqlLine(a: 0.12582222457621328d, b: 0.12977088823923122d, c: 0.9440094024496564d),
new NpgsqlTypes.NpgsqlLine(a: 0.4390502356488296d, b: 0.36174483366406207d, c: 0.9629324755859638d),
new NpgsqlTypes.NpgsqlLine(a: 0.45392013515829566d, b: 0.6446107998783206d, c: 0.6050697855055351d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666801631285862d, b: 0.05951403151675494d, c: 0.39365299434389545d),
new NpgsqlTypes.NpgsqlLine(a: 0.38785028566836754d, b: 0.7566211312157222d, c: 0.24920820365543694d),
new NpgsqlTypes.NpgsqlLine(a: 0.49848873844185126d, b: 0.13897722995783712d, c: 0.3285931647889264d),
new NpgsqlTypes.NpgsqlLine(a: 0.025922337273069695d, b: 0.9091980573329902d, c: 0.6274670447256967d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09544110639351955d, b: 0.6246765781522107d, c: 0.9021229798000592d),
new NpgsqlTypes.NpgsqlLine(a: 0.4087168872065301d, b: 0.2860581355683506d, c: 0.752046053309658d),
new NpgsqlTypes.NpgsqlLine(a: 0.42916764271128216d, b: 0.10810806854566057d, c: 0.6376233918815016d),
new NpgsqlTypes.NpgsqlLine(a: 0.5846075066788937d, b: 0.8879616535554347d, c: 0.35145912771235854d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.22779682638385712d, b: 0.2800979286102918d, c: 0.6706691007906104d),
new NpgsqlTypes.NpgsqlLine(a: 0.6407412796435088d, b: 0.9961777654796149d, c: 0.37682927798231636d),
new NpgsqlTypes.NpgsqlLine(a: 0.7148944801971849d, b: 0.28220514335335745d, c: 0.27044076014484697d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9601186240952542d, b: 0.5609558712248469d, c: 0.8700735761145116d),
new NpgsqlTypes.NpgsqlLine(a: 0.7096731731256501d, b: 0.9726129832477248d, c: 0.001159794623419752d),
new NpgsqlTypes.NpgsqlLine(a: 0.03548008083756793d, b: 0.5324754878128277d, c: 0.07123676989005123d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.23946064852823468d, b: 0.7111265882918903d, c: 0.5784619276332436d),
new NpgsqlTypes.NpgsqlLine(a: 0.2503279987318847d, b: 0.4685291773193254d, c: 0.18796015676196298d),
new NpgsqlTypes.NpgsqlLine(a: 0.8590931040478611d, b: 0.002384623417145959d, c: 0.313540601591073d),
new NpgsqlTypes.NpgsqlLine(a: 0.5891353278432362d, b: 0.7077243067127376d, c: 0.17987377402778604d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.12153401452511436d, b: 0.388588758977769d, c: 0.8500617745548419d),
new NpgsqlTypes.NpgsqlLine(a: 0.7877998326532469d, b: 0.15886300603064873d, c: 0.5816005714622761d),
new NpgsqlTypes.NpgsqlLine(a: 0.7001165475732426d, b: 0.3322930751807537d, c: 0.9081728387591315d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7690865489871458d, b: 0.8708393414039376d, c: 0.1515472545845996d),
new NpgsqlTypes.NpgsqlLine(a: 0.6061491523808065d, b: 0.886067592552198d, c: 0.06169742775991549d),
new NpgsqlTypes.NpgsqlLine(a: 0.6467989768287619d, b: 0.41226802673804375d, c: 0.4075057693242108d),
new NpgsqlTypes.NpgsqlLine(a: 0.9271612925267856d, b: 0.23994726146732204d, c: 0.7416391902046818d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3349628026063043d, b: 0.3747820888405722d, c: 0.08312868809702234d),
new NpgsqlTypes.NpgsqlLine(a: 0.1511390302869703d, b: 0.7107614465127272d, c: 0.40640490405395213d),
new NpgsqlTypes.NpgsqlLine(a: 0.028987182002509715d, b: 0.9864647555566695d, c: 0.6982854198225095d),
new NpgsqlTypes.NpgsqlLine(a: 0.7044059283288228d, b: 0.3106804833879352d, c: 0.6432266711380611d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8541620496450275d, b: 0.6045017072169772d, c: 0.7386235493386607d),
new NpgsqlTypes.NpgsqlLine(a: 0.2965261752077202d, b: 0.8468847023873819d, c: 0.9885211329470686d),
new NpgsqlTypes.NpgsqlLine(a: 0.7683210776485547d, b: 0.9090333820113138d, c: 0.06353680016270524d),
new NpgsqlTypes.NpgsqlLine(a: 0.7214334261455719d, b: 0.578491224431624d, c: 0.5169112783916933d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7299452401205323d, b: 0.39395901720616877d, c: 0.12762289705239482d),
new NpgsqlTypes.NpgsqlLine(a: 0.20917844922669404d, b: 0.5324818144137737d, c: 0.6031084156551484d),
new NpgsqlTypes.NpgsqlLine(a: 0.33301081089340434d, b: 0.9737695748735633d, c: 0.6662815206341551d),
new NpgsqlTypes.NpgsqlLine(a: 0.36773017973026734d, b: 0.144009096747155d, c: 0.10819964069437749d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4575456054110586d, b: 0.015615133442189122d, c: 0.4250374874921474d),
new NpgsqlTypes.NpgsqlLine(a: 0.6861624176141379d, b: 0.7250596318434542d, c: 0.9581364309103058d),
new NpgsqlTypes.NpgsqlLine(a: 0.39842600034390263d, b: 0.04070339099624709d, c: 0.07838579911925336d),
new NpgsqlTypes.NpgsqlLine(a: 0.2768474740981798d, b: 0.6995745138781917d, c: 0.019744131458566683d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1903597532274216d, b: 0.9837852798054024d, c: 0.7718743075997642d),
new NpgsqlTypes.NpgsqlLine(a: 0.26277104558936426d, b: 0.892312175934273d, c: 0.23035927405982826d),
new NpgsqlTypes.NpgsqlLine(a: 0.03783217410019335d, b: 0.2804972311637629d, c: 0.3563966515718756d),
new NpgsqlTypes.NpgsqlLine(a: 0.2881088473201515d, b: 0.424654049481906d, c: 0.777645681135021d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.16471051528684622d, b: 0.013123858357187324d, c: 0.7508111663740181d),
new NpgsqlTypes.NpgsqlLine(a: 0.5712548403450756d, b: 0.24529152974421553d, c: 0.48033729127315283d),
new NpgsqlTypes.NpgsqlLine(a: 0.18279277559285922d, b: 0.3551779963493672d, c: 0.5227335802565372d),
new NpgsqlTypes.NpgsqlLine(a: 0.06434130046469189d, b: 0.7559076455047948d, c: 0.45308739191665337d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.013518497271785224d, b: 0.09724353701784971d, c: 0.47471507078862685d),
new NpgsqlTypes.NpgsqlLine(a: 0.8043300520087505d, b: 0.5529821915980268d, c: 0.14904909822417545d),
new NpgsqlTypes.NpgsqlLine(a: 0.42055222797812086d, b: 0.501814782575442d, c: 0.5407886573581661d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43386439509678243d, b: 0.16957857290384792d, c: 0.4420000307560923d),
new NpgsqlTypes.NpgsqlLine(a: 0.5165294692446717d, b: 0.7123729060850452d, c: 0.607366571000827d),
new NpgsqlTypes.NpgsqlLine(a: 0.3327545749777103d, b: 0.8471739673405804d, c: 0.8035676186705402d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.162311578683082d, b: 0.8162014303036651d, c: 0.8836700974105157d),
new NpgsqlTypes.NpgsqlLine(a: 0.4882659870530739d, b: 0.8866471217062075d, c: 0.42794795248405615d),
new NpgsqlTypes.NpgsqlLine(a: 0.9802464089016739d, b: 0.9042407894287118d, c: 0.5362340628714716d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.868999850302803d, b: 0.42571985822529224d, c: 0.11358016003426008d),
new NpgsqlTypes.NpgsqlLine(a: 0.9423400086198487d, b: 0.49413447531512844d, c: 0.7441562843678816d),
new NpgsqlTypes.NpgsqlLine(a: 0.6624564654988445d, b: 0.24648509057999823d, c: 0.7712979209542286d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2941363444421201d, b: 0.638215818788352d, c: 0.39751737986107927d),
new NpgsqlTypes.NpgsqlLine(a: 0.7901428320781623d, b: 0.3038404693898943d, c: 0.32358935313258097d),
new NpgsqlTypes.NpgsqlLine(a: 0.3448034283289919d, b: 0.9472674131615944d, c: 0.452142327323812d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7634473398000988d, b: 0.37014904087674483d, c: 0.47920668652906706d),
new NpgsqlTypes.NpgsqlLine(a: 0.8536944806727707d, b: 0.802635050330933d, c: 0.7971596868907045d),
new NpgsqlTypes.NpgsqlLine(a: 0.9400888957429689d, b: 0.2869958621366949d, c: 0.5558684826106439d),
new NpgsqlTypes.NpgsqlLine(a: 0.5154867178278343d, b: 0.08200623092460935d, c: 0.9914611644956577d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2527071117592662d, b: 0.6151268978422038d, c: 0.2987895951608389d),
new NpgsqlTypes.NpgsqlLine(a: 0.8939924703159899d, b: 0.19076432689645229d, c: 0.5831342920634821d),
new NpgsqlTypes.NpgsqlLine(a: 0.8690569245696392d, b: 0.7055788028086143d, c: 0.14305731892423001d),
new NpgsqlTypes.NpgsqlLine(a: 0.680584544521102d, b: 0.061648036218754365d, c: 0.11210258231089743d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7638694266362464d, b: 0.20710677015954904d, c: 0.009182954942191013d),
new NpgsqlTypes.NpgsqlLine(a: 0.6639718466133737d, b: 0.5171871989737835d, c: 0.7717353226857677d),
new NpgsqlTypes.NpgsqlLine(a: 0.5595101289270581d, b: 0.18345468089778483d, c: 0.6379841535484295d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1966931166120791d, b: 0.43506062178166904d, c: 0.5458087544929331d),
new NpgsqlTypes.NpgsqlLine(a: 0.34957207782735344d, b: 0.7525637832771357d, c: 0.337904251672444d),
new NpgsqlTypes.NpgsqlLine(a: 0.4533112231160621d, b: 0.042255488811310804d, c: 0.16180021845592663d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5127700901353149d, b: 0.9406999170746395d, c: 0.5323575180295426d),
new NpgsqlTypes.NpgsqlLine(a: 0.49329381909385595d, b: 0.6335736675510183d, c: 0.9762752559821415d),
new NpgsqlTypes.NpgsqlLine(a: 0.005354606432810827d, b: 0.43086958982824275d, c: 0.24047790310157258d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4849729282900813d, b: 0.8222870476632974d, c: 0.9831917363852034d),
new NpgsqlTypes.NpgsqlLine(a: 0.4716820163413017d, b: 0.7231589845892271d, c: 0.6583304395303567d),
new NpgsqlTypes.NpgsqlLine(a: 0.7599580754261528d, b: 0.7912976064232783d, c: 0.2292966068767387d),
new NpgsqlTypes.NpgsqlLine(a: 0.6446542239430226d, b: 0.873070539601631d, c: 0.661416169445673d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.37854449093985276d, b: 0.40022733370575725d, c: 0.6506815480923416d),
new NpgsqlTypes.NpgsqlLine(a: 0.6231873177123627d, b: 0.028832492233176743d, c: 0.8526524710753309d),
new NpgsqlTypes.NpgsqlLine(a: 0.45315282957671665d, b: 0.5253999972887963d, c: 0.9232877683396804d),
new NpgsqlTypes.NpgsqlLine(a: 0.1700876319808995d, b: 0.9460891612823834d, c: 0.3837224535088275d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8496845459067847d, b: 0.5749005087976101d, c: 0.8691285234673544d),
new NpgsqlTypes.NpgsqlLine(a: 0.5336379961532003d, b: 0.5875712322277654d, c: 0.41460947609242904d),
new NpgsqlTypes.NpgsqlLine(a: 0.1638942964024398d, b: 0.37164606373759046d, c: 0.37721803573902735d),
new NpgsqlTypes.NpgsqlLine(a: 0.36141258146144917d, b: 0.33612736416806976d, c: 0.06695184660244957d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.33223363718599586d, b: 0.200478291879436d, c: 0.017696989391701723d),
new NpgsqlTypes.NpgsqlLine(a: 0.9364273638061719d, b: 0.04944531667961127d, c: 0.621141583343829d),
new NpgsqlTypes.NpgsqlLine(a: 0.18638013618489924d, b: 0.4599794230706652d, c: 0.6712847507525013d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.025484481307926354d, b: 0.6562539043729514d, c: 0.7312630900984914d),
new NpgsqlTypes.NpgsqlLine(a: 0.3735149175101685d, b: 0.9384099763738908d, c: 0.2151132406175409d),
new NpgsqlTypes.NpgsqlLine(a: 0.8192276428969647d, b: 0.4754170224766928d, c: 0.3202443267102867d),
new NpgsqlTypes.NpgsqlLine(a: 0.05087162631102082d, b: 0.8701691821556985d, c: 0.9068907870032047d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7695465532627966d, b: 0.5763869332411705d, c: 0.19226573387066204d),
new NpgsqlTypes.NpgsqlLine(a: 0.05928170663355736d, b: 0.5353448398192903d, c: 0.3593471166292548d),
new NpgsqlTypes.NpgsqlLine(a: 0.1885182073874222d, b: 0.2332858012209783d, c: 0.024483396786990186d),
new NpgsqlTypes.NpgsqlLine(a: 0.6845839399238803d, b: 0.5746202714326315d, c: 0.7082668843048118d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8408369268438567d, b: 0.09870740453267446d, c: 0.4487692769985101d),
new NpgsqlTypes.NpgsqlLine(a: 0.860438587286698d, b: 0.6238996689915556d, c: 0.6116166059052749d),
new NpgsqlTypes.NpgsqlLine(a: 0.5521486485425312d, b: 0.8535162758881266d, c: 0.45306987305959456d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7670079150411865d, b: 0.02927642075064063d, c: 0.45358638459027834d),
new NpgsqlTypes.NpgsqlLine(a: 0.9484212452917333d, b: 0.3961605563421301d, c: 0.328109296872927d),
new NpgsqlTypes.NpgsqlLine(a: 0.709429938985681d, b: 0.6978766494170743d, c: 0.6167337789453397d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15124980748829542d, b: 0.10913927310026506d, c: 0.8475350362891858d),
new NpgsqlTypes.NpgsqlLine(a: 0.522998217034003d, b: 0.1918238448606514d, c: 0.9762684754250749d),
new NpgsqlTypes.NpgsqlLine(a: 0.09143537992476836d, b: 0.895089667994135d, c: 0.06183314480565605d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4520738209711106d, b: 0.43821979426482527d, c: 0.2314155691621569d),
new NpgsqlTypes.NpgsqlLine(a: 0.49322603532047804d, b: 0.35505079865346123d, c: 0.4791058431785281d),
new NpgsqlTypes.NpgsqlLine(a: 0.059338605611264805d, b: 0.8227039868419623d, c: 0.30748603361633864d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8131817799393711d, b: 0.7835034297994148d, c: 0.526882358547226d),
new NpgsqlTypes.NpgsqlLine(a: 0.8176835065950376d, b: 0.7730135637271766d, c: 0.0746999381185024d),
new NpgsqlTypes.NpgsqlLine(a: 0.30822279080878356d, b: 0.6085326387323303d, c: 0.9832114786392127d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.28520801691185826d, b: 0.4246080050770866d, c: 0.31495032242541754d),
new NpgsqlTypes.NpgsqlLine(a: 0.4375574110610684d, b: 0.2569706402914621d, c: 0.9671114721652961d),
new NpgsqlTypes.NpgsqlLine(a: 0.14171994487743056d, b: 0.9746347404214205d, c: 0.02973113952649442d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7440781914568552d, b: 0.8857455909814197d, c: 0.5074433095934056d),
new NpgsqlTypes.NpgsqlLine(a: 0.9999859065256728d, b: 0.550464331879703d, c: 0.1263589950313454d),
new NpgsqlTypes.NpgsqlLine(a: 0.9915408234529013d, b: 0.10246056870098874d, c: 0.48200656338941206d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4838084368937715d, b: 0.9199366694108211d, c: 0.7792796390752952d),
new NpgsqlTypes.NpgsqlLine(a: 0.5989454614997765d, b: 0.8048794453360517d, c: 0.4624559937821723d),
new NpgsqlTypes.NpgsqlLine(a: 0.3968386103178335d, b: 0.9430216579846672d, c: 0.9217541359525621d),
new NpgsqlTypes.NpgsqlLine(a: 0.418921191912505d, b: 0.3531333480921779d, c: 0.2578431181871197d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.20624402164888678d, b: 0.2349941911841571d, c: 0.26227770748685886d),
new NpgsqlTypes.NpgsqlLine(a: 0.12444257928575331d, b: 0.7354241917692651d, c: 0.9505264524870697d),
new NpgsqlTypes.NpgsqlLine(a: 0.7327976790517008d, b: 0.8982677624746562d, c: 0.9380695030005415d),
}));
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6386304102375252d, b: 0.22067112316395676d, c: 0.9722964469595284d),
new NpgsqlTypes.NpgsqlLine(a: 0.724432334343928d, b: 0.6063566494197984d, c: 0.31244436299514966d),
new NpgsqlTypes.NpgsqlLine(a: 0.29807040619647096d, b: 0.7392362365138491d, c: 0.9731774310162623d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3708268270710732d, b: 0.10867444287271244d, c: 0.8855311491424018d),
new NpgsqlTypes.NpgsqlLine(a: 0.9395299520566862d, b: 0.342217497476511d, c: 0.8504936482645393d),
new NpgsqlTypes.NpgsqlLine(a: 0.08387949077102108d, b: 0.7958555438151709d, c: 0.8813771788115432d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 66;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 105, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 84, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 102, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 87, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 112, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 17, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 113, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 102, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
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
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], false);NpgsqlLinelineArray1M.AssertModel(models[1],_testData[14], false);NpgsqlLinelineArray1M.AssertModel(models[2],_testData[15], false);NpgsqlLinelineArray1M.AssertModel(models[3],_testData[16], false);NpgsqlLinelineArray1M.AssertModel(models[4],_testData[17], false);NpgsqlLinelineArray1M.AssertModel(models[5],_testData[18], false);NpgsqlLinelineArray1M.AssertModel(models[6],_testData[19], false);NpgsqlLinelineArray1M.AssertModel(models[7],_testData[20], false);NpgsqlLinelineArray1M.AssertModel(models[8],_testData[21], false);NpgsqlLinelineArray1M.AssertModel(models[9],_testData[22], false);NpgsqlLinelineArray1M.AssertModel(models[10],_testData[23], false);NpgsqlLinelineArray1M.AssertModel(models[11],_testData[24], false);NpgsqlLinelineArray1M.AssertModel(models[12],_testData[25], false);NpgsqlLinelineArray1M.AssertModel(models[13],_testData[26], false);NpgsqlLinelineArray1M.AssertModel(models[14],_testData[27], false);NpgsqlLinelineArray1M.AssertModel(models[15],_testData[28], false);NpgsqlLinelineArray1M.AssertModel(models[16],_testData[29], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 6; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 10; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlLinelineArray1M),
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

